namespace EnvanterYönetimSistemi.Calisan.Reports
{
    partial class StokReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokReportForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.rv_stok = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rv_stok);
            this.panel1.Location = new System.Drawing.Point(-6, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 546);
            this.panel1.TabIndex = 0;
            // 
            // rv_stok
            // 
            this.rv_stok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rv_stok.LocalReport.ReportEmbeddedResource = "EnvanterYönetimSistemi.Calisan.Reports.StokReport.rdlc";
            this.rv_stok.Location = new System.Drawing.Point(0, 0);
            this.rv_stok.Name = "rv_stok";
            this.rv_stok.ServerReport.BearerToken = null;
            this.rv_stok.Size = new System.Drawing.Size(821, 546);
            this.rv_stok.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(742, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // StokReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(808, 611);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "StokReportForm";
            this.Text = "StokReportForm";
            this.Load += new System.EventHandler(this.StokReportForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer rv_stok;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}