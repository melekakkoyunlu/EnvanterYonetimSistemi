namespace EnvanterYönetimSistemi
{
    partial class MenuCalisan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuCalisan));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_menuTxt = new System.Windows.Forms.Label();
            this.btn_musteri = new System.Windows.Forms.Button();
            this.btn_fatura = new System.Windows.Forms.Button();
            this.btn_rapor = new System.Windows.Forms.Button();
            this.btn_urunYonetim = new System.Windows.Forms.Button();
            this.btn_tedarikciYonetim = new System.Windows.Forms.Button();
            this.btn_siparisYonetim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_menuTxt
            // 
            this.lbl_menuTxt.AutoSize = true;
            this.lbl_menuTxt.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_menuTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_menuTxt.Location = new System.Drawing.Point(78, 36);
            this.lbl_menuTxt.Name = "lbl_menuTxt";
            this.lbl_menuTxt.Size = new System.Drawing.Size(185, 36);
            this.lbl_menuTxt.TabIndex = 1;
            this.lbl_menuTxt.Text = "Hoş geldiniz";
            // 
            // btn_musteri
            // 
            this.btn_musteri.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_musteri.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_musteri.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_musteri.Location = new System.Drawing.Point(24, 105);
            this.btn_musteri.Name = "btn_musteri";
            this.btn_musteri.Size = new System.Drawing.Size(150, 135);
            this.btn_musteri.TabIndex = 2;
            this.btn_musteri.Text = "MÜŞTERİ EKLE";
            this.btn_musteri.UseVisualStyleBackColor = false;
            this.btn_musteri.Click += new System.EventHandler(this.btn_musteri_Click);
            // 
            // btn_fatura
            // 
            this.btn_fatura.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_fatura.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_fatura.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_fatura.Location = new System.Drawing.Point(220, 105);
            this.btn_fatura.Name = "btn_fatura";
            this.btn_fatura.Size = new System.Drawing.Size(150, 135);
            this.btn_fatura.TabIndex = 3;
            this.btn_fatura.Text = "FATURA OLUŞTUR";
            this.btn_fatura.UseVisualStyleBackColor = false;
            // 
            // btn_rapor
            // 
            this.btn_rapor.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_rapor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_rapor.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_rapor.Location = new System.Drawing.Point(416, 105);
            this.btn_rapor.Name = "btn_rapor";
            this.btn_rapor.Size = new System.Drawing.Size(150, 135);
            this.btn_rapor.TabIndex = 4;
            this.btn_rapor.Text = "RAPOR OLUŞTUR";
            this.btn_rapor.UseVisualStyleBackColor = false;
            // 
            // btn_urunYonetim
            // 
            this.btn_urunYonetim.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_urunYonetim.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_urunYonetim.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_urunYonetim.Location = new System.Drawing.Point(24, 268);
            this.btn_urunYonetim.Name = "btn_urunYonetim";
            this.btn_urunYonetim.Size = new System.Drawing.Size(150, 135);
            this.btn_urunYonetim.TabIndex = 5;
            this.btn_urunYonetim.Text = "ÜRÜN YÖNETİM";
            this.btn_urunYonetim.UseVisualStyleBackColor = false;
            this.btn_urunYonetim.Click += new System.EventHandler(this.btn_urunYonetim_Click);
            // 
            // btn_tedarikciYonetim
            // 
            this.btn_tedarikciYonetim.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_tedarikciYonetim.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_tedarikciYonetim.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_tedarikciYonetim.Location = new System.Drawing.Point(220, 268);
            this.btn_tedarikciYonetim.Name = "btn_tedarikciYonetim";
            this.btn_tedarikciYonetim.Size = new System.Drawing.Size(150, 135);
            this.btn_tedarikciYonetim.TabIndex = 6;
            this.btn_tedarikciYonetim.Text = "TEDARİKÇİ YÖNETİM";
            this.btn_tedarikciYonetim.UseVisualStyleBackColor = false;
            this.btn_tedarikciYonetim.Click += new System.EventHandler(this.btn_tedarikciYonetim_Click);
            // 
            // btn_siparisYonetim
            // 
            this.btn_siparisYonetim.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_siparisYonetim.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_siparisYonetim.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_siparisYonetim.Location = new System.Drawing.Point(416, 268);
            this.btn_siparisYonetim.Name = "btn_siparisYonetim";
            this.btn_siparisYonetim.Size = new System.Drawing.Size(150, 135);
            this.btn_siparisYonetim.TabIndex = 7;
            this.btn_siparisYonetim.Text = "SİPARİŞ YÖNETİM";
            this.btn_siparisYonetim.UseVisualStyleBackColor = false;
            this.btn_siparisYonetim.Click += new System.EventHandler(this.btn_siparisYonetim_Click);
            // 
            // MenuCalisan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(593, 450);
            this.Controls.Add(this.btn_siparisYonetim);
            this.Controls.Add(this.btn_tedarikciYonetim);
            this.Controls.Add(this.btn_urunYonetim);
            this.Controls.Add(this.btn_rapor);
            this.Controls.Add(this.btn_fatura);
            this.Controls.Add(this.btn_musteri);
            this.Controls.Add(this.lbl_menuTxt);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MenuCalisan";
            this.Text = "MenuCalisan";
            this.Load += new System.EventHandler(this.MenuCalisan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_menuTxt;
        private System.Windows.Forms.Button btn_musteri;
        private System.Windows.Forms.Button btn_fatura;
        private System.Windows.Forms.Button btn_rapor;
        private System.Windows.Forms.Button btn_urunYonetim;
        private System.Windows.Forms.Button btn_tedarikciYonetim;
        private System.Windows.Forms.Button btn_siparisYonetim;
    }
}