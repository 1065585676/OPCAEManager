namespace CShapTest
{
    partial class LicenseManager
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
            this.licenseContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OKLicense = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // licenseContent
            // 
            this.licenseContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.licenseContent.Location = new System.Drawing.Point(47, 44);
            this.licenseContent.Name = "licenseContent";
            this.licenseContent.Size = new System.Drawing.Size(184, 23);
            this.licenseContent.TabIndex = 0;
            this.licenseContent.Text = "0ee0-0393-870e-28d9-68d7";
            this.licenseContent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter License :";
            // 
            // OKLicense
            // 
            this.OKLicense.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKLicense.Location = new System.Drawing.Point(92, 88);
            this.OKLicense.Name = "OKLicense";
            this.OKLicense.Size = new System.Drawing.Size(75, 23);
            this.OKLicense.TabIndex = 0;
            this.OKLicense.Text = "确定";
            this.OKLicense.UseVisualStyleBackColor = true;
            this.OKLicense.Click += new System.EventHandler(this.OKLicense_Click);
            // 
            // LicenseManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 155);
            this.Controls.Add(this.OKLicense);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.licenseContent);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LicenseManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LicenseManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox licenseContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OKLicense;
    }
}