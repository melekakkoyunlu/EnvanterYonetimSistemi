namespace EnvanterYönetimSistemi.Giris
{
    partial class MusteriBilgiForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.txt_iletisim = new System.Windows.Forms.TextBox();
            this.txt_musteriAd = new System.Windows.Forms.TextBox();
            this.lbl_adres = new System.Windows.Forms.Label();
            this.lbl_iletisim = new System.Windows.Forms.Label();
            this.lbl_musteriAd = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.btn_kaydet);
            this.panel1.Controls.Add(this.txt_adres);
            this.panel1.Controls.Add(this.txt_iletisim);
            this.panel1.Controls.Add(this.txt_musteriAd);
            this.panel1.Controls.Add(this.lbl_adres);
            this.panel1.Controls.Add(this.lbl_iletisim);
            this.panel1.Controls.Add(this.lbl_musteriAd);
            this.panel1.Location = new System.Drawing.Point(30, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 309);
            this.panel1.TabIndex = 0;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Location = new System.Drawing.Point(196, 266);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 6;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // txt_adres
            // 
            this.txt_adres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_adres.Location = new System.Drawing.Point(149, 145);
            this.txt_adres.Multiline = true;
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(247, 102);
            this.txt_adres.TabIndex = 5;
            // 
            // txt_iletisim
            // 
            this.txt_iletisim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_iletisim.Location = new System.Drawing.Point(149, 90);
            this.txt_iletisim.Name = "txt_iletisim";
            this.txt_iletisim.Size = new System.Drawing.Size(247, 20);
            this.txt_iletisim.TabIndex = 4;
            // 
            // txt_musteriAd
            // 
            this.txt_musteriAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_musteriAd.Location = new System.Drawing.Point(149, 40);
            this.txt_musteriAd.Name = "txt_musteriAd";
            this.txt_musteriAd.Size = new System.Drawing.Size(247, 20);
            this.txt_musteriAd.TabIndex = 3;
            // 
            // lbl_adres
            // 
            this.lbl_adres.AutoSize = true;
            this.lbl_adres.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_adres.Location = new System.Drawing.Point(56, 146);
            this.lbl_adres.Name = "lbl_adres";
            this.lbl_adres.Size = new System.Drawing.Size(54, 19);
            this.lbl_adres.TabIndex = 2;
            this.lbl_adres.Text = "Adres";
            // 
            // lbl_iletisim
            // 
            this.lbl_iletisim.AutoSize = true;
            this.lbl_iletisim.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_iletisim.Location = new System.Drawing.Point(56, 91);
            this.lbl_iletisim.Name = "lbl_iletisim";
            this.lbl_iletisim.Size = new System.Drawing.Size(62, 19);
            this.lbl_iletisim.TabIndex = 1;
            this.lbl_iletisim.Text = "İletişim";
            // 
            // lbl_musteriAd
            // 
            this.lbl_musteriAd.AutoSize = true;
            this.lbl_musteriAd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_musteriAd.Location = new System.Drawing.Point(56, 41);
            this.lbl_musteriAd.Name = "lbl_musteriAd";
            this.lbl_musteriAd.Size = new System.Drawing.Size(30, 19);
            this.lbl_musteriAd.TabIndex = 0;
            this.lbl_musteriAd.Text = "Ad";
            // 
            // MusteriBilgiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(530, 383);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "MusteriBilgiForm";
            this.Text = "MusteriBilgiForm";
            this.Load += new System.EventHandler(this.MusteriBilgiForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_adres;
        private System.Windows.Forms.TextBox txt_iletisim;
        private System.Windows.Forms.TextBox txt_musteriAd;
        private System.Windows.Forms.Label lbl_adres;
        private System.Windows.Forms.Label lbl_iletisim;
        private System.Windows.Forms.Label lbl_musteriAd;
        private System.Windows.Forms.Button btn_kaydet;
    }
}