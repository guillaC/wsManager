namespace webshellManager
{
    partial class screenshotForm
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
            this.screen = new System.Windows.Forms.PictureBox();
            this.btnScrnShot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.screen)).BeginInit();
            this.SuspendLayout();
            // 
            // screen
            // 
            this.screen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.screen.Location = new System.Drawing.Point(13, 13);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(836, 523);
            this.screen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.screen.TabIndex = 0;
            this.screen.TabStop = false;
            // 
            // btnScrnShot
            // 
            this.btnScrnShot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScrnShot.Location = new System.Drawing.Point(696, 542);
            this.btnScrnShot.Name = "btnScrnShot";
            this.btnScrnShot.Size = new System.Drawing.Size(153, 23);
            this.btnScrnShot.TabIndex = 1;
            this.btnScrnShot.Text = "Screenshot";
            this.btnScrnShot.UseVisualStyleBackColor = true;
            this.btnScrnShot.Click += new System.EventHandler(this.btnScrnShot_Click);
            // 
            // screenshotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 577);
            this.Controls.Add(this.btnScrnShot);
            this.Controls.Add(this.screen);
            this.Name = "screenshotForm";
            this.Text = "screenshotForm";
            ((System.ComponentModel.ISupportInitialize)(this.screen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox screen;
        private System.Windows.Forms.Button btnScrnShot;
    }
}