namespace webshellManager
{
    partial class informationsForm
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
            this.colItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvInformations
            // 
            this.lvInformations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvInformations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colItem,
            this.colValue});
            this.lvInformations.FullRowSelect = true;
            this.lvInformations.GridLines = true;
            this.lvInformations.Location = new System.Drawing.Point(12, 12);
            this.lvInformations.Name = "lvInformations";
            this.lvInformations.Size = new System.Drawing.Size(550, 381);
            this.lvInformations.TabIndex = 6;
            this.lvInformations.UseCompatibleStateImageBehavior = false;
            this.lvInformations.View = System.Windows.Forms.View.Details;
            // 
            // colItem
            // 
            this.colItem.Text = "Item";
            this.colItem.Width = 162;
            // 
            // colValue
            // 
            this.colValue.Text = "Value";
            this.colValue.Width = 350;
            // 
            // informationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 405);
            this.Controls.Add(this.lvInformations);
            this.Name = "informationsForm";
            this.Text = "informationsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvInformations;
        private System.Windows.Forms.ColumnHeader colItem;
        private System.Windows.Forms.ColumnHeader colValue;
    }
}