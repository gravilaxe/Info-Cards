namespace Assignment
{
    partial class InfoCardsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.cardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuItemDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView = new System.Windows.Forms.TreeView();
            this.contextMenuNode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuItemDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuCategory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuItemNewCard = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panelInfoCard = new System.Windows.Forms.Panel();
            this.contextMenuRoot = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuItemNewCardFromList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.contextMenuNode.SuspendLayout();
            this.contextMenuCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.contextMenuRoot.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.cardToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(496, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuItemExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mainMenuItemExit
            // 
            this.mainMenuItemExit.Name = "mainMenuItemExit";
            this.mainMenuItemExit.Size = new System.Drawing.Size(93, 22);
            this.mainMenuItemExit.Text = "Exit";
            this.mainMenuItemExit.Click += new System.EventHandler(this.mainMenuItemExit_Click);
            // 
            // cardToolStripMenuItem
            // 
            this.cardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuItemNew,
            this.mainMenuItemDisplay,
            this.mainMenuItemEdit,
            this.mainMenuItemDelete});
            this.cardToolStripMenuItem.Name = "cardToolStripMenuItem";
            this.cardToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.cardToolStripMenuItem.Text = "Card";
            this.cardToolStripMenuItem.Click += new System.EventHandler(this.cardToolStripMenuItem_Click);
            // 
            // mainMenuItemNew
            // 
            this.mainMenuItemNew.Name = "mainMenuItemNew";
            this.mainMenuItemNew.Size = new System.Drawing.Size(180, 22);
            this.mainMenuItemNew.Text = "New...";
            this.mainMenuItemNew.Click += new System.EventHandler(this.menuItemNewCardFromList);
            // 
            // mainMenuItemDisplay
            // 
            this.mainMenuItemDisplay.Name = "mainMenuItemDisplay";
            this.mainMenuItemDisplay.Size = new System.Drawing.Size(180, 22);
            this.mainMenuItemDisplay.Text = "Display";
            this.mainMenuItemDisplay.Click += new System.EventHandler(this.menuItemDisplay);
            // 
            // mainMenuItemEdit
            // 
            this.mainMenuItemEdit.Name = "mainMenuItemEdit";
            this.mainMenuItemEdit.Size = new System.Drawing.Size(180, 22);
            this.mainMenuItemEdit.Text = "Edit";
            this.mainMenuItemEdit.Click += new System.EventHandler(this.menuItemEdit);
            // 
            // mainMenuItemDelete
            // 
            this.mainMenuItemDelete.Name = "mainMenuItemDelete";
            this.mainMenuItemDelete.Size = new System.Drawing.Size(180, 22);
            this.mainMenuItemDelete.Text = "Delete";
            this.mainMenuItemDelete.Click += new System.EventHandler(this.menuItemDelete);
            // 
            // treeView
            // 
            this.treeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(184, 251);
            this.treeView.TabIndex = 1;
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            this.treeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseDoubleClick);
            // 
            // contextMenuNode
            // 
            this.contextMenuNode.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuNode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuItemDisplay,
            this.contextMenuItemEdit,
            this.contextMenuItemDelete});
            this.contextMenuNode.Name = "contextMenuNode";
            this.contextMenuNode.Size = new System.Drawing.Size(113, 70);
            // 
            // contextMenuItemDisplay
            // 
            this.contextMenuItemDisplay.Name = "contextMenuItemDisplay";
            this.contextMenuItemDisplay.Size = new System.Drawing.Size(112, 22);
            this.contextMenuItemDisplay.Text = "Display";
            this.contextMenuItemDisplay.Click += new System.EventHandler(this.menuItemDisplay);
            // 
            // contextMenuItemEdit
            // 
            this.contextMenuItemEdit.Name = "contextMenuItemEdit";
            this.contextMenuItemEdit.Size = new System.Drawing.Size(112, 22);
            this.contextMenuItemEdit.Text = "Edit";
            this.contextMenuItemEdit.Click += new System.EventHandler(this.menuItemEdit);
            // 
            // contextMenuItemDelete
            // 
            this.contextMenuItemDelete.Name = "contextMenuItemDelete";
            this.contextMenuItemDelete.Size = new System.Drawing.Size(112, 22);
            this.contextMenuItemDelete.Text = "Delete";
            this.contextMenuItemDelete.Click += new System.EventHandler(this.menuItemDelete);
            // 
            // contextMenuCategory
            // 
            this.contextMenuCategory.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuCategory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuItemNewCard});
            this.contextMenuCategory.Name = "contextMenuCategory";
            this.contextMenuCategory.Size = new System.Drawing.Size(127, 26);
            // 
            // contextMenuItemNewCard
            // 
            this.contextMenuItemNewCard.Name = "contextMenuItemNewCard";
            this.contextMenuItemNewCard.Size = new System.Drawing.Size(126, 22);
            this.contextMenuItemNewCard.Text = "New Card";
            this.contextMenuItemNewCard.Click += new System.EventHandler(this.contextMenuItemNewCard_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 24);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.treeView);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.panelInfoCard);
            this.splitContainer.Size = new System.Drawing.Size(496, 234);
            this.splitContainer.SplitterDistance = 182;
            this.splitContainer.SplitterWidth = 3;
            this.splitContainer.TabIndex = 2;
            // 
            // panelInfoCard
            // 
            this.panelInfoCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInfoCard.BackColor = System.Drawing.SystemColors.Control;
            this.panelInfoCard.Location = new System.Drawing.Point(2, 0);
            this.panelInfoCard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelInfoCard.Name = "panelInfoCard";
            this.panelInfoCard.Size = new System.Drawing.Size(300, 227);
            this.panelInfoCard.TabIndex = 0;
            // 
            // contextMenuRoot
            // 
            this.contextMenuRoot.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuRoot.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuItemNewCardFromList});
            this.contextMenuRoot.Name = "contextMenuRoot";
            this.contextMenuRoot.Size = new System.Drawing.Size(136, 26);
            // 
            // contextMenuItemNewCardFromList
            // 
            this.contextMenuItemNewCardFromList.Name = "contextMenuItemNewCardFromList";
            this.contextMenuItemNewCardFromList.Size = new System.Drawing.Size(135, 22);
            this.contextMenuItemNewCardFromList.Text = "New Card...";
            this.contextMenuItemNewCardFromList.Click += new System.EventHandler(this.menuItemNewCardFromList);
            // 
            // InfoCardsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 258);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InfoCardsForm";
            this.Text = "Info Tracker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuNode.ResumeLayout(false);
            this.contextMenuCategory.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.contextMenuRoot.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuItemExit;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ToolStripMenuItem cardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuItemDisplay;
        private System.Windows.Forms.ToolStripMenuItem mainMenuItemEdit;
        private System.Windows.Forms.ContextMenuStrip contextMenuNode;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItemDisplay;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItemDelete;
        private System.Windows.Forms.ContextMenuStrip contextMenuCategory;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItemNewCard;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel panelInfoCard;
        private System.Windows.Forms.ToolStripMenuItem mainMenuItemNew;
        private System.Windows.Forms.ToolStripMenuItem mainMenuItemDelete;
        private System.Windows.Forms.ContextMenuStrip contextMenuRoot;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItemNewCardFromList;
    }
}

