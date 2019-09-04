namespace webshellManager
{
    partial class fileInformationsForm
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
            this.lvInformations = new System.Windows.Forms.ListView();
            this.chItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvInformations
            // 
            this.lvInformations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvInformations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chItem,
            this.chValue});
            this.lvInformations.Location = new System.Drawing.Point(12, 12);
            this.lvInformations.Name = "lvInformations";
            this.lvInformations.Size = new System.Drawing.Size(302, 288);
            this.lvInformations.TabIndex = 2;
            this.lvInformations.UseCompatibleStateImageBehavior = false;
            this.lvInformations.View = System.Windows.Forms.View.Details;
            // 
            // chItem
            // 
            this.chItem.Text = "Item";
            this.chItem.Width = 100;
            // 
            // chValue
            // 
            this.chValue.Text = "Value";
            this.chValue.Width = 154;
            // 
            // fileInformationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 312);
            this.Controls.Add(this.lvInformations);
            this.Name = "fileInformationsForm";
            this.Text = "fileInformationsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvInformations;
        private System.Windows.Forms.ColumnHeader chItem;
        private System.Windows.Forms.ColumnHeader chValue;
    }
}