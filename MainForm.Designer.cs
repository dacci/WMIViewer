namespace WMIViewer
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStripContainer toolStripContainer;
            System.Windows.Forms.StatusStrip statusStrip;
            System.Windows.Forms.TabPage browsePage;
            System.Windows.Forms.SplitContainer verticalSplitter;
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("dummy");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("ROOT", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.SplitContainer horizontalSplitter;
            System.Windows.Forms.ColumnHeader classNameColumn;
            System.Windows.Forms.ColumnHeader memberNameColumn;
            System.Windows.Forms.ColumnHeader memberTypeColumn;
            System.Windows.Forms.TabPage queryPage;
            this.messageLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.scopeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.scopeTree = new System.Windows.Forms.TreeView();
            this.queryMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyNameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classList = new System.Windows.Forms.ListView();
            this.memberList = new System.Windows.Forms.ListView();
            this.resultTable = new System.Windows.Forms.ListView();
            this.queryBox = new System.Windows.Forms.TextBox();
            toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            statusStrip = new System.Windows.Forms.StatusStrip();
            browsePage = new System.Windows.Forms.TabPage();
            verticalSplitter = new System.Windows.Forms.SplitContainer();
            horizontalSplitter = new System.Windows.Forms.SplitContainer();
            classNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            memberNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            memberTypeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            queryPage = new System.Windows.Forms.TabPage();
            toolStripContainer.BottomToolStripPanel.SuspendLayout();
            toolStripContainer.ContentPanel.SuspendLayout();
            toolStripContainer.SuspendLayout();
            statusStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            browsePage.SuspendLayout();
            verticalSplitter.Panel1.SuspendLayout();
            verticalSplitter.Panel2.SuspendLayout();
            verticalSplitter.SuspendLayout();
            this.queryMenu.SuspendLayout();
            horizontalSplitter.Panel1.SuspendLayout();
            horizontalSplitter.Panel2.SuspendLayout();
            horizontalSplitter.SuspendLayout();
            queryPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.BottomToolStripPanel
            // 
            toolStripContainer.BottomToolStripPanel.Controls.Add(statusStrip);
            // 
            // toolStripContainer.ContentPanel
            // 
            toolStripContainer.ContentPanel.Controls.Add(this.tabControl);
            toolStripContainer.ContentPanel.Size = new System.Drawing.Size(752, 440);
            toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            toolStripContainer.Location = new System.Drawing.Point(0, 0);
            toolStripContainer.Name = "toolStripContainer";
            toolStripContainer.Size = new System.Drawing.Size(752, 487);
            toolStripContainer.TabIndex = 0;
            toolStripContainer.Text = "toolStripContainer1";
            // 
            // statusStrip
            // 
            statusStrip.Dock = System.Windows.Forms.DockStyle.None;
            statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.messageLabel,
            this.scopeLabel});
            statusStrip.Location = new System.Drawing.Point(0, 0);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new System.Drawing.Size(752, 22);
            statusStrip.TabIndex = 0;
            // 
            // messageLabel
            // 
            this.messageLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.messageLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(387, 17);
            this.messageLabel.Spring = true;
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // scopeLabel
            // 
            this.scopeLabel.AutoSize = false;
            this.scopeLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.scopeLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.scopeLabel.Name = "scopeLabel";
            this.scopeLabel.Size = new System.Drawing.Size(350, 17);
            this.scopeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(browsePage);
            this.tabControl.Controls.Add(queryPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(752, 440);
            this.tabControl.TabIndex = 0;
            // 
            // browsePage
            // 
            browsePage.Controls.Add(verticalSplitter);
            browsePage.Location = new System.Drawing.Point(4, 22);
            browsePage.Name = "browsePage";
            browsePage.Padding = new System.Windows.Forms.Padding(3);
            browsePage.Size = new System.Drawing.Size(744, 414);
            browsePage.TabIndex = 0;
            browsePage.Text = "Browse";
            browsePage.UseVisualStyleBackColor = true;
            // 
            // verticalSplitter
            // 
            verticalSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            verticalSplitter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            verticalSplitter.Location = new System.Drawing.Point(3, 3);
            verticalSplitter.Name = "verticalSplitter";
            // 
            // verticalSplitter.Panel1
            // 
            verticalSplitter.Panel1.Controls.Add(this.scopeTree);
            // 
            // verticalSplitter.Panel2
            // 
            verticalSplitter.Panel2.Controls.Add(horizontalSplitter);
            verticalSplitter.Size = new System.Drawing.Size(738, 408);
            verticalSplitter.SplitterDistance = 150;
            verticalSplitter.TabIndex = 0;
            // 
            // scopeTree
            // 
            this.scopeTree.ContextMenuStrip = this.queryMenu;
            this.scopeTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scopeTree.HideSelection = false;
            this.scopeTree.Location = new System.Drawing.Point(0, 0);
            this.scopeTree.Name = "scopeTree";
            treeNode1.Name = "";
            treeNode1.Text = "dummy";
            treeNode2.Name = "";
            treeNode2.Text = "ROOT";
            this.scopeTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.scopeTree.Size = new System.Drawing.Size(150, 408);
            this.scopeTree.TabIndex = 0;
            this.scopeTree.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.scopeTree_BeforeExpand);
            this.scopeTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.scopeTree_AfterSelect);
            // 
            // queryMenu
            // 
            this.queryMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyNameMenuItem,
            this.queryMenuItem});
            this.queryMenu.Name = "queryMenu";
            this.queryMenu.Size = new System.Drawing.Size(143, 48);
            this.queryMenu.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.queryMenu_Closed);
            this.queryMenu.Opening += new System.ComponentModel.CancelEventHandler(this.queryMenu_Opening);
            // 
            // copyNameMenuItem
            // 
            this.copyNameMenuItem.Name = "copyNameMenuItem";
            this.copyNameMenuItem.Size = new System.Drawing.Size(142, 22);
            this.copyNameMenuItem.Text = "&Copy Name";
            this.copyNameMenuItem.Click += new System.EventHandler(this.copyNameMenuItem_Click);
            // 
            // queryMenuItem
            // 
            this.queryMenuItem.Name = "queryMenuItem";
            this.queryMenuItem.Size = new System.Drawing.Size(142, 22);
            this.queryMenuItem.Text = "&Query";
            this.queryMenuItem.Click += new System.EventHandler(this.queryMenuItem_Click);
            // 
            // horizontalSplitter
            // 
            horizontalSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            horizontalSplitter.Location = new System.Drawing.Point(0, 0);
            horizontalSplitter.Name = "horizontalSplitter";
            horizontalSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // horizontalSplitter.Panel1
            // 
            horizontalSplitter.Panel1.Controls.Add(this.classList);
            // 
            // horizontalSplitter.Panel2
            // 
            horizontalSplitter.Panel2.Controls.Add(this.memberList);
            horizontalSplitter.Size = new System.Drawing.Size(584, 408);
            horizontalSplitter.SplitterDistance = 254;
            horizontalSplitter.TabIndex = 0;
            // 
            // classList
            // 
            this.classList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            classNameColumn});
            this.classList.ContextMenuStrip = this.queryMenu;
            this.classList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classList.FullRowSelect = true;
            this.classList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.classList.HideSelection = false;
            this.classList.Location = new System.Drawing.Point(0, 0);
            this.classList.MultiSelect = false;
            this.classList.Name = "classList";
            this.classList.Size = new System.Drawing.Size(584, 254);
            this.classList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.classList.TabIndex = 0;
            this.classList.UseCompatibleStateImageBehavior = false;
            this.classList.View = System.Windows.Forms.View.Details;
            this.classList.ItemActivate += new System.EventHandler(this.classList_ItemActivate);
            // 
            // classNameColumn
            // 
            classNameColumn.Text = "Name";
            // 
            // memberList
            // 
            this.memberList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            memberNameColumn,
            memberTypeColumn});
            this.memberList.ContextMenuStrip = this.queryMenu;
            this.memberList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberList.FullRowSelect = true;
            this.memberList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.memberList.HideSelection = false;
            this.memberList.Location = new System.Drawing.Point(0, 0);
            this.memberList.Name = "memberList";
            this.memberList.Size = new System.Drawing.Size(584, 150);
            this.memberList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.memberList.TabIndex = 0;
            this.memberList.UseCompatibleStateImageBehavior = false;
            this.memberList.View = System.Windows.Forms.View.Details;
            // 
            // memberNameColumn
            // 
            memberNameColumn.Text = "Name";
            // 
            // memberTypeColumn
            // 
            memberTypeColumn.Text = "Type";
            // 
            // queryPage
            // 
            queryPage.Controls.Add(this.resultTable);
            queryPage.Controls.Add(this.queryBox);
            queryPage.Location = new System.Drawing.Point(4, 22);
            queryPage.Name = "queryPage";
            queryPage.Padding = new System.Windows.Forms.Padding(3);
            queryPage.Size = new System.Drawing.Size(744, 414);
            queryPage.TabIndex = 1;
            queryPage.Text = "Query";
            queryPage.UseVisualStyleBackColor = true;
            // 
            // resultTable
            // 
            this.resultTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultTable.FullRowSelect = true;
            this.resultTable.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.resultTable.HideSelection = false;
            this.resultTable.Location = new System.Drawing.Point(3, 22);
            this.resultTable.MultiSelect = false;
            this.resultTable.Name = "resultTable";
            this.resultTable.Size = new System.Drawing.Size(738, 389);
            this.resultTable.TabIndex = 5;
            this.resultTable.UseCompatibleStateImageBehavior = false;
            this.resultTable.View = System.Windows.Forms.View.Details;
            // 
            // queryBox
            // 
            this.queryBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.queryBox.HideSelection = false;
            this.queryBox.Location = new System.Drawing.Point(3, 3);
            this.queryBox.Name = "queryBox";
            this.queryBox.Size = new System.Drawing.Size(738, 19);
            this.queryBox.TabIndex = 1;
            this.queryBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.queryBox_KeyDown);
            this.queryBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.queryBox_KeyPress);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 487);
            this.Controls.Add(toolStripContainer);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "WMI Viewer";
            toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
            toolStripContainer.BottomToolStripPanel.PerformLayout();
            toolStripContainer.ContentPanel.ResumeLayout(false);
            toolStripContainer.ResumeLayout(false);
            toolStripContainer.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            browsePage.ResumeLayout(false);
            verticalSplitter.Panel1.ResumeLayout(false);
            verticalSplitter.Panel2.ResumeLayout(false);
            verticalSplitter.ResumeLayout(false);
            this.queryMenu.ResumeLayout(false);
            horizontalSplitter.Panel1.ResumeLayout(false);
            horizontalSplitter.Panel2.ResumeLayout(false);
            horizontalSplitter.ResumeLayout(false);
            queryPage.ResumeLayout(false);
            queryPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel messageLabel;
        private System.Windows.Forms.TreeView scopeTree;
        private System.Windows.Forms.ListView classList;
        private System.Windows.Forms.ListView memberList;
        private System.Windows.Forms.ListView resultTable;
        private System.Windows.Forms.TextBox queryBox;
        private System.Windows.Forms.ToolStripStatusLabel scopeLabel;
        private System.Windows.Forms.ContextMenuStrip queryMenu;
        private System.Windows.Forms.ToolStripMenuItem copyNameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryMenuItem;
        private System.Windows.Forms.TabControl tabControl;

    }
}

