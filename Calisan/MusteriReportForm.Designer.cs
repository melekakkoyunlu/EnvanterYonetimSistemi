namespace EnvanterYönetimSistemi.Calisan
{
    partial class MusteriReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriReportForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rv_Musteri = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(852, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // rv_Musteri
            // 
            this.rv_Musteri.AutoSize = true;
            this.rv_Musteri.LocalReport.ReportEmbeddedResource = "EnvanterYönetimSistemi.Calisan.Reports.MusteriReport.rdlc";
            this.rv_Musteri.Location = new System.Drawing.Point(-2, 96);
            this.rv_Musteri.Name = "rv_Musteri";
            this.rv_Musteri.ServerReport.BearerToken = null;
            this.rv_Musteri.Size = new System.Drawing.Size(920, 740);
            this.rv_Musteri.TabIndex = 2;
            // 
            // MusteriReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(918, 839);
            this.Controls.Add(this.rv_Musteri);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MusteriReportForm";
            this.Text = "MusteriReportForm";
            this.Load += new System.EventHandler(this.MusteriReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.Reporting.WinForms.ReportViewer rv_Musteri;
    }
}