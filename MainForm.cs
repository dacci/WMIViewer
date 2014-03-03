using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Management;
using System.Windows.Forms;

namespace WMIViewer
{
    public partial class MainForm : Form
    {
        class ScopeCache
        {
            public bool expanded = false;
            public bool scanned = false;
            public readonly Dictionary<string, ObjectCache> classes = new Dictionary<string, ObjectCache>();
        }

        class ObjectCache
        {
            public bool scanned = false;
            public readonly Dictionary<string, string> members = new Dictionary<string, string>();
        }

        static string ToString(object data)
        {
            if (data == null)
                return "null";
            else
                return data.ToString();
        }

        public MainForm()
        {
            InitializeComponent();

            var rect = Screen.FromControl(this).WorkingArea;
            Size = new Size(rect.Width * 3 / 4, rect.Height * 3 / 4);

            scopeTree.Sorted = true;
            scopeTree.Nodes[0].Tag = new ScopeCache();

            classList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            memberList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void scopeTree_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            var node = e.Node;
            var cache = (ScopeCache)node.Tag;
            if (cache.expanded)
                return;

            try
            {
                Cursor = Cursors.WaitCursor;
                messageLabel.Text = "";
                scopeTree.BeginUpdate();
                node.Nodes.Clear();

                var scopes = new ManagementClass(node.FullPath, "__NAMESPACE", null);
                foreach (var scope in scopes.GetInstances())
                {
                    var name = (string)scope["Name"];
                    var child = node.Nodes.Add(name, name);
                    child.Nodes.Add("dummy");
                    child.Tag = new ScopeCache();
                }
            }
            catch (Exception ex)
            {
                messageLabel.Text = ex.Message;
            }
            finally
            {
                cache.expanded = true;
                scopeTree.EndUpdate();
                node.EnsureVisible();
                Cursor = Cursors.Default;
            }
        }

        private void scopeTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var node = e.Node;
            var cache = (ScopeCache)node.Tag;

            scopeLabel.Text = node.FullPath;

            try
            {
                Cursor = Cursors.WaitCursor;
                messageLabel.Text = "";

                memberList.BeginUpdate();
                memberList.Items.Clear();

                classList.BeginUpdate();
                classList.Items.Clear();

                if (cache.scanned)
                {
                    foreach (var name in cache.classes.Keys)
                        classList.Items.Add(name).Tag = cache.classes[name];
                }
                else
                {
                    var searcher = new ManagementObjectSearcher(node.FullPath, "SELECT * FROM meta_class", null);
                    foreach (var clazz in searcher.Get())
                    {
                        foreach (var qualifier in clazz.Qualifiers)
                        {
                            if (qualifier.Name == "dynamic" || qualifier.Name == "static")
                            {
                                string className = (string)clazz["__CLASS"];
                                var objectCache = new ObjectCache();

                                classList.Items.Add(className).Tag = objectCache;

                                cache.classes.Add(className, objectCache);
                                break;
                            }
                        }
                    }
                }

                if (classList.Items.Count > 0)
                    classList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                else
                    classList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch (Exception ex)
            {
                messageLabel.Text = ex.Message;
            }
            finally
            {
                cache.scanned = true;
                memberList.EndUpdate();
                classList.EndUpdate();
                Cursor = Cursors.Default;
            }
        }

        private void classList_ItemActivate(object sender, EventArgs e)
        {
            var item = classList.SelectedItems[0];
            var cache = (ObjectCache)item.Tag;

            try
            {
                Cursor = Cursors.WaitCursor;
                messageLabel.Text = "";

                memberList.BeginUpdate();
                memberList.Items.Clear();

                if (cache.scanned)
                {
                    foreach (var pair in cache.members)
                        memberList.Items.Add(pair.Key).SubItems.Add(pair.Value);
                }
                else
                {
                    var clazz = new ManagementClass(scopeTree.SelectedNode.FullPath, classList.SelectedItems[0].SubItems[0].Text, null);
                    foreach (var property in clazz.Properties)
                    {
                        var name = property.Name;
                        var type = property.Type.ToString();

                        cache.members.Add(name, type);
                        memberList.Items.Add(name).SubItems.Add(type);
                    }
                }

                if (memberList.Items.Count > 0)
                    memberList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                else
                    memberList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch (Exception ex)
            {
                messageLabel.Text = ex.Message;
            }
            finally
            {
                cache.scanned = true;
                memberList.EndUpdate();
                Cursor = Cursors.Default;
            }
        }

        private void queryBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;

            e.Handled = true;

            try
            {
                Cursor = Cursors.WaitCursor;
                messageLabel.Text = "";

                queryBox.Enabled = false;

                resultTable.BeginUpdate();
                resultTable.Clear();
                resultTable.Columns.Clear();

                var first = true;
                var searcher = new ManagementObjectSearcher(scopeLabel.Text, queryBox.Text);

                foreach (var result in searcher.Get())
                {
                    if (first)
                    {
                        first = false;

                        foreach (var property in result.Properties)
                            resultTable.Columns.Add(property.Name);
                    }

                    var item = new ListViewItem();
                    var firstProperty = true;
                    foreach (var property in result.Properties)
                    {
                        if (firstProperty)
                        {
                            firstProperty = false;
                            item.Text = ToString(property.Value);
                        }
                        else
                        {
                            item.SubItems.Add(ToString(property.Value));
                        }
                    }

                    resultTable.Items.Add(item);
                }

                resultTable.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch (ManagementException ex)
            {
                messageLabel.Text = ex.Message;
            }
            finally
            {
                resultTable.EndUpdate();

                queryBox.Enabled = true;
                queryBox.SelectAll();
                queryBox.Focus();

                Cursor = Cursors.Default;
            }
        }

        private void queryBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                e.Handled = true;
        }

        private void queryMenu_Opening(object sender, CancelEventArgs e)
        {
            if (queryMenu.SourceControl == scopeTree)
            {
                queryMenuItem.Enabled = false;
            }
            else if (queryMenu.SourceControl == classList)
            {
                queryMenu.Enabled = ((ListView)queryMenu.SourceControl).SelectedItems.Count == 1;
            }
            else if (queryMenu.SourceControl == memberList)
            {
                copyNameMenuItem.Enabled = ((ListView)queryMenu.SourceControl).SelectedItems.Count == 1;
            }
        }

        private void queryMenu_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            queryMenu.Enabled = true;
            copyNameMenuItem.Enabled = true;
            queryMenuItem.Enabled = true;
        }

        private void copyNameMenuItem_Click(object sender, EventArgs e)
        {
            if (queryMenu.SourceControl is TreeView)
            {
                Clipboard.SetText(((TreeView)queryMenu.SourceControl).SelectedNode.FullPath);
            }
            else if (queryMenu.SourceControl is ListView)
            {
                Clipboard.SetText(((ListView)queryMenu.SourceControl).SelectedItems[0].Text);
            }
        }

        private void queryMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab("queryPage");

            var source = (ListView)queryMenu.SourceControl;

            List<string> properties = new List<string>();
            if (source == memberList)
                foreach (ListViewItem item in memberList.SelectedItems)
                    properties.Add(item.Text);
            else
                properties.Add("*");

            queryBox.Text = string.Format("SELECT {0} FROM {1}", string.Join(", ", properties.ToArray()), classList.SelectedItems[0].Text);
            queryBox.Focus();
            queryBox_KeyDown(sender, new KeyEventArgs(Keys.Return));
        }
    }
}
