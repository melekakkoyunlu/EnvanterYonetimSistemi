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
            this.rv_Musteri = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rv_Musteri
            // 
            this.rv_Musteri.AutoSize = true;
            this.rv_Musteri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rv_Musteri.LocalReport.ReportEmbeddedResource = "EnvanterYönetimSistemi.Calisan.Reports.MusteriReport.rdlc";
            this.rv_Musteri.Location = new System.Drawing.Point(0, 0);
            this.rv_Musteri.Name = "rv_Musteri";
            this.rv_Musteri.ServerReport.BearerToken = null;
            this.rv_Musteri.Size = new System.Drawing.Size(813, 558);
            this.rv_Musteri.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rv_Musteri);
            this.panel1.Location = new System.Drawing.Point(2, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 558);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(742, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MusteriReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(808, 611);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "MusteriReportForm";
            this.Text = "MusteriReportForm";
            this.Load += new System.EventHandler(this.MusteriReportForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_Musteri;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}