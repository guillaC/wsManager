namespace webshellManager
{
    partial class sqlForm
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
            this.btnGetDbsTbls = new System.Windows.Forms.Button();
            this.treeDB = new System.Windows.Forms.TreeView();
            this.lblDtb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.tbuname = new System.Windows.Forms.TextBox();
            this.tbBdd = new System.Windows.Forms.TextBox();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.lvSql = new System.Windows.Forms.ListView();
            this.tbSql = new System.Windows.Forms.TextBox();
            this.btnExecSql = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.sfdSql = new System.Windows.Forms.SaveFileDialog();
            this.cmsSQL = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSQL.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetDbsTbls
            // 
            this.btnGetDbsTbls.Location = new System.Drawing.Point(12, 65);
            this.btnGetDbsTbls.Name = "btnGetDbsTbls";
            this.btnGetDbsTbls.Size = new System.Drawing.Size(140, 23);
            this.btnGetDbsTbls.TabIndex = 30;
            this.btnGetDbsTbls.Text = "Get DBs && tables";
            this.btnGetDbsTbls.UseVisualStyleBackColor = true;
            this.btnGetDbsTbls.Click += new System.EventHandler(this.btnGetDbsTbls_Click);
            // 
            // treeDB
            // 
            this.treeDB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeDB.FullRowSelect = true;
            this.treeDB.Indent = 10;
            this.treeDB.Location = new System.Drawing.Point(12, 94);
            this.treeDB.Name = "treeDB";
            this.treeDB.Size = new System.Drawing.Size(140, 291);
            this.treeDB.TabIndex = 29;
            this.treeDB.DoubleClick += new System.EventHandler(this.treeDB_DoubleClick);
            // 
            // lblDtb
            // 
            this.lblDtb.AutoSize = true;
            this.lblDtb.Location = new System.Drawing.Point(477, 15);
            this.lblDtb.Name = "lblDtb";
            this.lblDtb.Size = new System.Drawing.Size(56, 13);
            this.lblDtb.TabIndex = 28;
            this.lblDtb.Text = "Database:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Password:";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(14, 15);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(32, 13);
            this.lblHost.TabIndex = 26;
            this.lblHost.Text = "Host:";
            // 
            // tbpass
            // 
            this.tbpass.Location = new System.Drawing.Point(371, 12);
            this.tbpass.Name = "tbpass";
            this.tbpass.Size = new System.Drawing.Size(100, 20);
            this.tbpass.TabIndex = 25;
            // 
            // tbuname
            // 
            this.tbuname.Location = new System.Drawing.Point(200, 12);
            this.tbuname.Name = "tbuname";
            this.tbuname.Size = new System.Drawing.Size(100, 20);
            this.tbuname.TabIndex = 24;
            this.tbuname.Text = "root";
            // 
            // tbBdd
            // 
            this.tbBdd.Location = new System.Drawing.Point(539, 12);
            this.tbBdd.Name = "tbBdd";
            this.tbBdd.Size = new System.Drawing.Size(100, 20);
            this.tbBdd.TabIndex = 23;
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(52, 12);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(100, 20);
            this.tbHost.TabIndex = 22;
            this.tbHost.Text = "127.0.0.1";
            // 
            // lvSql
            // 
            this.lvSql.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvSql.ContextMenuStrip = this.cmsSQL;
            this.lvSql.FullRowSelect = true;
            this.lvSql.GridLines = true;
            this.lvSql.Location = new System.Drawing.Point(161, 65);
            this.lvSql.Name = "lvSql";
            this.lvSql.Size = new System.Drawing.Size(478, 320);
            this.lvSql.TabIndex = 21;
            this.lvSql.UseCompatibleStateImageBehavior = false;
            this.lvSql.View = System.Windows.Forms.View.Details;
            // 
            // tbSql
            // 
            this.tbSql.Location = new System.Drawing.Point(14, 38);
            this.tbSql.Name = "tbSql";
            this.tbSql.Size = new System.Drawing.Size(544, 20);
            this.tbSql.TabIndex = 20;
            this.tbSql.Text = "select * from table";
            // 
            // btnExecSql
            // 
            this.btnExecSql.Location = new System.Drawing.Point(564, 36);
            this.btnExecSql.Name = "btnExecSql";
            this.btnExecSql.Size = new System.Drawing.Size(75, 23);
            this.btnExecSql.TabIndex = 19;
            this.btnExecSql.Text = "Execute";
            this.btnExecSql.UseVisualStyleBackColor = true;
            this.btnExecSql.Click += new System.EventHandler(this.btnExecSql_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(158, 15);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(36, 13);
            this.lblLogin.TabIndex = 31;
            this.lblLogin.Text = "Login:";
            // 
            // sfdSql
            // 
            this.sfdSql.DefaultExt = "html";
            this.sfdSql.Filter = "html|*.html";
            // 
            // cmsSQL
            // 
            this.cmsSQL.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem});
            this.cmsSQL.Name = "cmsSQL";
            this.cmsSQL.Size = new System.Drawing.Size(108, 26);
            this.cmsSQL.Opening += new System.ComponentModel.CancelEventHandler(this.cmsSQL_Opening);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // sqlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 397);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnGetDbsTbls);
            this.Controls.Add(this.treeDB);
            this.Controls.Add(this.lblDtb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHost);
            this.Controls.Add(this.tbpass);
            this.Controls.Add(this.tbuname);
            this.Controls.Add(this.tbBdd);
            this.Controls.Add(this.tbHost);
            this.Controls.Add(this.lvSql);
            this.Controls.Add(this.tbSql);
            this.Controls.Add(this.btnExecSql);
            this.Name = "sqlForm";
            this.Text = "sqlForm";
            this.cmsSQL.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetDbsTbls;
        private System.Windows.Forms.TreeView treeDB;
        private System.Windows.Forms.Label lblDtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.TextBox tbuname;
        private System.Windows.Forms.TextBox tbBdd;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.ListView lvSql;
        private System.Windows.Forms.TextBox tbSql;
        private System.Windows.Forms.Button btnExecSql;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.ContextMenuStrip cmsSQL;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog sfdSql;
    }
}