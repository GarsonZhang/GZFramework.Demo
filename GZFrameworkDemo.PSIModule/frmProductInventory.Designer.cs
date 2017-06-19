namespace ClothingPSISQLite.PSIModule
{
    partial class frmProductInventory
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
            this.ucProductQty1 = new ClothingPSISQLite.PSIModule.ucControls.ucProductQty();
            this.SuspendLayout();
            // 
            // ucProductQty1
            // 
            this.ucProductQty1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucProductQty1.Location = new System.Drawing.Point(0, 0);
            this.ucProductQty1.Name = "ucProductQty1";
            this.ucProductQty1.Size = new System.Drawing.Size(844, 472);
            this.ucProductQty1.TabIndex = 0;
            // 
            // frmProductInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 472);
            this.Controls.Add(this.ucProductQty1);
            this.Name = "frmProductInventory";
            this.Text = "库存信息";
            this.ResumeLayout(false);

        }

        #endregion

        private ucControls.ucProductQty ucProductQty1;
    }
}