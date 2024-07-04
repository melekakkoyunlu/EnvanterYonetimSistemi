namespace EnvanterYönetimSistemi
{
    partial class MusteriEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriEkle));
            this.lbl_musteriAd = new System.Windows.Forms.Label();
            this.lbl_musteriInfo = new System.Windows.Forms.Label();
            this.lbl_musteriAdres = new System.Windows.Forms.Label();
            this.txt_musteriAd = new System.Windows.Forms.TextBox();
            this.txt_musteriInfo = new System.Windows.Forms.TextBox();
            this.txt_musteriAdres = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_musteriAd
            // 
            this.lbl_musteriAd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_musteriAd.AutoSize = true;
            this.lbl_musteriAd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_musteriAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_musteriAd.Location = new System.Drawing.Point(25, 32);
            this.lbl_musteriAd.Name = "lbl_musteriAd";
            this.lbl_musteriAd.Size = new System.Drawing.Size(166, 19);
            this.lbl_musteriAd.TabIndex = 0;
            this.lbl_musteriAd.Text = "Müşteri Adını Giriniz:";
            // 
            // lbl_musteriInfo
            // 
            this.lbl_musteriInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_musteriInfo.AutoSize = true;
            this.lbl_musteriInfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_musteriInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_musteriInfo.Location = new System.Drawing.Point(25, 99);
            this.lbl_musteriInfo.Name = "lbl_musteriInfo";
            this.lbl_musteriInfo.Size = new System.Drawing.Size(196, 19);
            this.lbl_musteriInfo.TabIndex = 1;
            this.lbl_musteriInfo.Text = "İletişim Bilgilerini Giriniz:";
            // 
            // lbl_musteriAdres
            // 
            this.lbl_musteriAdres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_musteriAdres.AutoSize = true;
            this.lbl_musteriAdres.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_musteriAdres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_musteriAdres.Location = new System.Drawing.Point(25, 159);
            this.lbl_musteriAdres.Name = "lbl_musteriAdres";
            this.lbl_musteriAdres.Size = new System.Drawing.Size(172, 19);
            this.lbl_musteriAdres.TabIndex = 2;
            this.lbl_musteriAdres.Text = "Müşteri Adres Giriniz:";
            // 
            // txt_musteriAd
            // 
            this.txt_musteriAd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_musteriAd.Location = new System.Drawing.Point(29, 63);
            this.txt_musteriAd.Name = "txt_musteriAd";
            this.txt_musteriAd.Size = new System.Drawing.Size(265, 20);
            this.txt_musteriAd.TabIndex = 3;
            this.txt_musteriAd.TextChanged += new System.EventHandler(this.txt_musteriAd_TextChanged);
            // 
            // txt_musteriInfo
            // 
            this.txt_musteriInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_musteriInfo.Location = new System.Drawing.Point(29, 121);
            this.txt_musteriInfo.Name = "txt_musteriInfo";
            this.txt_musteriInfo.Size = new System.Drawing.Size(265, 20);
            this.txt_musteriInfo.TabIndex = 4;
            // 
            // txt_musteriAdres
            // 
            this.txt_musteriAdres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_musteriAdres.Location = new System.Drawing.Point(29, 181);
            this.txt_musteriAdres.Multiline = true;
            this.txt_musteriAdres.Name = "txt_musteriAdres";
            this.txt_musteriAdres.Size = new System.Drawing.Size(265, 77);
            this.txt_musteriAdres.TabIndex = 5;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_ekle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ekle.Location = new System.Drawing.Point(29, 289);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(90, 30);
            this.btn_ekle.TabIndex = 6;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_temizle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_temizle.Location = new System.Drawing.Point(153, 289);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(90, 30);
            this.btn_temizle.TabIndex = 7;
            this.btn_temizle.Text = "TEMİZLE";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(333, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MusteriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(393, 352);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_musteriAdres);
            this.Controls.Add(this.txt_musteriInfo);
            this.Controls.Add(this.txt_musteriAd);
            this.Controls.Add(this.lbl_musteriAdres);
            this.Controls.Add(this.lbl_musteriInfo);
            this.Controls.Add(this.lbl_musteriAd);
            this.Name = "MusteriEkle";
            this.Text = "MusteriEkle";
            this.Load += new System.EventHandler(this.MusteriEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_musteriAd;
        private System.Windows.Forms.Label lbl_musteriInfo;
        private System.Windows.Forms.Label lbl_musteriAdres;
        private System.Windows.Forms.TextBox txt_musteriAd;
        private System.Windows.Forms.TextBox txt_musteriInfo;
        private System.Windows.Forms.TextBox txt_musteriAdres;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}