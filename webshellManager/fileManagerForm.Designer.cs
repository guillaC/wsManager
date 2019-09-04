namespace webshellManager
{
    partial class fileManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fileManagerForm));
            this.tbPath = new System.Windows.Forms.TextBox();
            this.lvExplorer = new System.Windows.Forms.ListView();
            this.cName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cLastMod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cPerms = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsFileManager = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRename = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiZIP = new System.Windows.Forms.ToolStripMenuItem();
            this.tss1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiDownload = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpload = new System.Windows.Forms.ToolStripMenuItem();
            this.tss2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiNDir = new System.Windows.Forms.ToolStripMenuItem();
            this.tss3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.imgListExplorer = new System.Windows.Forms.ImageList(this.components);
            this.btnOpn = new System.Windows.Forms.Button();
            this.sfdDownload = new System.Windows.Forms.SaveFileDialog();
            this.cmsFileManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPath
            // 
            this.tbPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPath.Location = new System.Drawing.Point(12, 12);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(540, 20);
            this.tbPath.TabIndex = 8;
            // 
            // lvExplorer
            // 
            this.lvExplorer.AllowColumnReorder = true;
            this.lvExplorer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvExplorer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cName,
            this.cSize,
            this.cLastMod,
            this.cPerms});
            this.lvExplorer.ContextMenuStrip = this.cmsFileManager;
            this.lvExplorer.FullRowSelect = true;
            this.lvExplorer.GridLines = true;
            this.lvExplorer.Location = new System.Drawing.Point(12, 39);
            this.lvExplorer.Name = "lvExplorer";
            this.lvExplorer.Size = new System.Drawing.Size(629, 348);
            this.lvExplorer.SmallImageList = this.imgListExplorer;
            this.lvExplorer.TabIndex = 7;
            this.lvExplorer.UseCompatibleStateImageBehavior = false;
            this.lvExplorer.View = System.Windows.Forms.View.Details;
            this.lvExplorer.DoubleClick += new System.EventHandler(this.lvExplorer_DoubleClick);
            // 
            // cName
            // 
            this.cName.Text = "Name";
            this.cName.Width = 271;
            // 
            // cSize
            // 
            this.cSize.Text = "Size";
            this.cSize.Width = 72;
            // 
            // cLastMod
            // 
            this.cLastMod.Text = "Modification Date";
            this.cLastMod.Width = 147;
            // 
            // cPerms
            // 
            this.cPerms.Text = "Permisions";
            this.cPerms.Width = 127;
            // 
            // cmsFileManager
            // 
            this.cmsFileManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRename,
            this.tsmiDelete,
            this.tsmiZIP,
            this.tss1,
            this.tsmiDownload,
            this.tsmiUpload,
            this.tss2,
            this.tsmiNDir,
            this.tss3,
            this.tsmiProperties});
            this.cmsFileManager.Name = "cmsFileManager";
            this.cmsFileManager.Size = new System.Drawing.Size(166, 176);
            this.cmsFileManager.Opening += new System.ComponentModel.CancelEventHandler(this.cmsFileManager_Opening);
            // 
            // tsmiRename
            // 
            this.tsmiRename.Name = "tsmiRename";
            this.tsmiRename.Size = new System.Drawing.Size(165, 22);
            this.tsmiRename.Text = "Rename";
            this.tsmiRename.Click += new System.EventHandler(this.tsmiRename_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(165, 22);
            this.tsmiDelete.Text = "Delete";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // tsmiZIP
            // 
            this.tsmiZIP.Name = "tsmiZIP";
            this.tsmiZIP.Size = new System.Drawing.Size(165, 22);
            this.tsmiZIP.Text = "Compress";
            this.tsmiZIP.Click += new System.EventHandler(this.tsmiZIP_Click);
            // 
            // tss1
            // 
            this.tss1.Name = "tss1";
            this.tss1.Size = new System.Drawing.Size(162, 6);
            // 
            // tsmiDownload
            // 
            this.tsmiDownload.Name = "tsmiDownload";
            this.tsmiDownload.Size = new System.Drawing.Size(165, 22);
            this.tsmiDownload.Text = "Download";
            this.tsmiDownload.Click += new System.EventHandler(this.tsmiDownload_Click);
            // 
            // tsmiUpload
            // 
            this.tsmiUpload.Name = "tsmiUpload";
            this.tsmiUpload.Size = new System.Drawing.Size(165, 22);
            this.tsmiUpload.Text = "Upload from URL";
            this.tsmiUpload.Click += new System.EventHandler(this.tsmiUpload_Click);
            // 
            // tss2
            // 
            this.tss2.Name = "tss2";
            this.tss2.Size = new System.Drawing.Size(162, 6);
            // 
            // tsmiNDir
            // 
            this.tsmiNDir.Name = "tsmiNDir";
            this.tsmiNDir.Size = new System.Drawing.Size(165, 22);
            this.tsmiNDir.Text = "New directory";
            this.tsmiNDir.Click += new System.EventHandler(this.tsmiNDir_Click);
            // 
            // tss3
            // 
            this.tss3.Name = "tss3";
            this.tss3.Size = new System.Drawing.Size(162, 6);
            // 
            // tsmiProperties
            // 
            this.tsmiProperties.Name = "tsmiProperties";
            this.tsmiProperties.Size = new System.Drawing.Size(165, 22);
            this.tsmiProperties.Text = "Properties";
            this.tsmiProperties.Click += new System.EventHandler(this.tsmiProperties_Click);
            // 
            // imgListExplorer
            // 
            this.imgListExplorer.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListExplorer.ImageStream")));
            this.imgListExplorer.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListExplorer.Images.SetKeyName(0, "folder");
            this.imgListExplorer.Images.SetKeyName(1, "file");
            this.imgListExplorer.Images.SetKeyName(2, "text");
            this.imgListExplorer.Images.SetKeyName(3, "image");
            // 
            // btnOpn
            // 
            this.btnOpn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpn.Location = new System.Drawing.Point(558, 10);
            this.btnOpn.Name = "btnOpn";
            this.btnOpn.Size = new System.Drawing.Size(82, 23);
            this.btnOpn.TabIndex = 9;
            this.btnOpn.Text = "Open";
            this.btnOpn.UseVisualStyleBackColor = true;
            this.btnOpn.Click += new System.EventHandler(this.button1_Click);
            // 
            // fileManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 400);
            this.Controls.Add(this.btnOpn);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.lvExplorer);
            this.Name = "fileManagerForm";
            this.Text = "fileManagerForm";
            this.Load += new System.EventHandler(this.fileManagerForm_Load);
            this.cmsFileManager.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.ListView lvExplorer;
        private System.Windows.Forms.ColumnHeader cName;
        private System.Windows.Forms.ColumnHeader cSize;
        private System.Windows.Forms.ColumnHeader cLastMod;
        private System.Windows.Forms.ColumnHeader cPerms;
        private System.Windows.Forms.Button btnOpn;
        private System.Windows.Forms.ImageList imgListExplorer;
        private System.Windows.Forms.ContextMenuStrip cmsFileManager;
        private System.Windows.Forms.ToolStripMenuItem tsmiRename;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiZIP;
        private System.Windows.Forms.ToolStripSeparator tss1;
        private System.Windows.Forms.ToolStripMenuItem tsmiDownload;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpload;
        private System.Windows.Forms.ToolStripSeparator tss2;
        private System.Windows.Forms.ToolStripMenuItem tsmiNDir;
        private System.Windows.Forms.ToolStripSeparator tss3;
        private System.Windows.Forms.ToolStripMenuItem tsmiProperties;
        private System.Windows.Forms.SaveFileDialog sfdDownload;
    }
}