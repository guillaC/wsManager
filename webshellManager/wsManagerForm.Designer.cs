namespace webshellManager
{
    partial class wsManagerForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wsManagerForm));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tssLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lvWebShells = new System.Windows.Forms.ListView();
            this.colURL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHostName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colReleaseName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colServerSoft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cMenuStripLV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.informationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.tsButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.ScreenshotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.cMenuStripLV.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 271);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(831, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "x servers";
            // 
            // tssLabel
            // 
            this.tssLabel.Name = "tssLabel";
            this.tssLabel.Size = new System.Drawing.Size(60, 17);
            this.tssLabel.Text = "0 server(s)";
            // 
            // lvWebShells
            // 
            this.lvWebShells.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvWebShells.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvWebShells.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colURL,
            this.colOS,
            this.colHostName,
            this.colReleaseName,
            this.colServerSoft});
            this.lvWebShells.ContextMenuStrip = this.cMenuStripLV;
            this.lvWebShells.FullRowSelect = true;
            this.lvWebShells.GridLines = true;
            this.lvWebShells.Location = new System.Drawing.Point(0, 24);
            this.lvWebShells.Name = "lvWebShells";
            this.lvWebShells.Size = new System.Drawing.Size(831, 247);
            this.lvWebShells.TabIndex = 1;
            this.lvWebShells.UseCompatibleStateImageBehavior = false;
            this.lvWebShells.View = System.Windows.Forms.View.Details;
            // 
            // colURL
            // 
            this.colURL.Text = "URL";
            this.colURL.Width = 295;
            // 
            // colOS
            // 
            this.colOS.Text = "OS";
            this.colOS.Width = 103;
            // 
            // colHostName
            // 
            this.colHostName.Text = "Hostname";
            this.colHostName.Width = 90;
            // 
            // colReleaseName
            // 
            this.colReleaseName.Text = "Release name";
            this.colReleaseName.Width = 136;
            // 
            // colServerSoft
            // 
            this.colServerSoft.Text = "Server Software";
            this.colServerSoft.Width = 135;
            // 
            // cMenuStripLV
            // 
            this.cMenuStripLV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationsToolStripMenuItem,
            this.fileManagerToolStripMenuItem,
            this.shellToolStripMenuItem,
            this.sQLExplorerToolStripMenuItem,
            this.ScreenshotToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteToolStripMenuItem});
            this.cMenuStripLV.Name = "cMenuStripLV";
            this.cMenuStripLV.Size = new System.Drawing.Size(153, 164);
            this.cMenuStripLV.Opening += new System.ComponentModel.CancelEventHandler(this.cMenuStripLV_Opening);
            // 
            // informationsToolStripMenuItem
            // 
            this.informationsToolStripMenuItem.Name = "informationsToolStripMenuItem";
            this.informationsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.informationsToolStripMenuItem.Text = "Information";
            this.informationsToolStripMenuItem.Click += new System.EventHandler(this.informationsToolStripMenuItem_Click);
            // 
            // fileManagerToolStripMenuItem
            // 
            this.fileManagerToolStripMenuItem.Name = "fileManagerToolStripMenuItem";
            this.fileManagerToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.fileManagerToolStripMenuItem.Text = "File Manager";
            this.fileManagerToolStripMenuItem.Click += new System.EventHandler(this.fileManagerToolStripMenuItem_Click);
            // 
            // shellToolStripMenuItem
            // 
            this.shellToolStripMenuItem.Name = "shellToolStripMenuItem";
            this.shellToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.shellToolStripMenuItem.Text = "Shell";
            this.shellToolStripMenuItem.Click += new System.EventHandler(this.shellToolStripMenuItem_Click);
            // 
            // sQLExplorerToolStripMenuItem
            // 
            this.sQLExplorerToolStripMenuItem.Name = "sQLExplorerToolStripMenuItem";
            this.sQLExplorerToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.sQLExplorerToolStripMenuItem.Text = "SQL Explorer";
            this.sQLExplorerToolStripMenuItem.Click += new System.EventHandler(this.sQLExplorerToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(139, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsButtonAdd,
            this.tsButtonSave,
            this.toolStripSeparator2,
            this.tsButtonAbout});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(831, 25);
            this.toolStrip.TabIndex = 3;
            // 
            // tsButtonAdd
            // 
            this.tsButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsButtonAdd.Image")));
            this.tsButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonAdd.Name = "tsButtonAdd";
            this.tsButtonAdd.Size = new System.Drawing.Size(33, 22);
            this.tsButtonAdd.Text = "Add";
            this.tsButtonAdd.Click += new System.EventHandler(this.tsButtonAdd_Click);
            // 
            // tsButtonSave
            // 
            this.tsButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("tsButtonSave.Image")));
            this.tsButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonSave.Name = "tsButtonSave";
            this.tsButtonSave.Size = new System.Drawing.Size(35, 22);
            this.tsButtonSave.Text = "Save";
            this.tsButtonSave.Click += new System.EventHandler(this.tsButtonSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsButtonAbout
            // 
            this.tsButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsButtonAbout.Image = ((System.Drawing.Image)(resources.GetObject("tsButtonAbout.Image")));
            this.tsButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonAbout.Name = "tsButtonAbout";
            this.tsButtonAbout.Size = new System.Drawing.Size(44, 22);
            this.tsButtonAbout.Text = "About";
            this.tsButtonAbout.Click += new System.EventHandler(this.tsButtonAbout_Click);
            // 
            // ScreenshotToolStripMenuItem
            // 
            this.ScreenshotToolStripMenuItem.Name = "ScreenshotToolStripMenuItem";
            this.ScreenshotToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ScreenshotToolStripMenuItem.Text = "Screenshot";
            this.ScreenshotToolStripMenuItem.Click += new System.EventHandler(this.ScreenshotToolStripMenuItem_Click);
            // 
            // wsManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 293);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.lvWebShells);
            this.Controls.Add(this.statusStrip);
            this.Name = "wsManagerForm";
            this.Text = "wsManager";
            this.Load += new System.EventHandler(this.wsManagerForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.cMenuStripLV.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tssLabel;
        private System.Windows.Forms.ListView lvWebShells;
        private System.Windows.Forms.ColumnHeader colURL;
        private System.Windows.Forms.ColumnHeader colOS;
        private System.Windows.Forms.ColumnHeader colHostName;
        private System.Windows.Forms.ContextMenuStrip cMenuStripLV;
        private System.Windows.Forms.ToolStripMenuItem informationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQLExplorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsButtonAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsButtonAbout;
        private System.Windows.Forms.ColumnHeader colReleaseName;
        private System.Windows.Forms.ColumnHeader colServerSoft;
        private System.Windows.Forms.ToolStripButton tsButtonSave;
        private System.Windows.Forms.ToolStripMenuItem ScreenshotToolStripMenuItem;
    }
}

