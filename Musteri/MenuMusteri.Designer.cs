namespace EnvanterYönetimSistemi
{
    partial class MenuMusteri
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuMusteri));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_toplam = new System.Windows.Forms.Label();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_sepetEkle = new System.Windows.Forms.Button();
            this.txt_adet = new System.Windows.Forms.TextBox();
            this.cb_urun = new System.Windows.Forms.ComboBox();
            this.urunBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.envanterYonetimDataSet = new EnvanterYönetimSistemi.EnvanterYonetimDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UrunID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StokMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirimFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.urunTableAdapter = new EnvanterYönetimSistemi.EnvanterYonetimDataSetTableAdapters.UrunTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.envanterYonetimDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.lbl_toplam);
            this.panel1.Controls.Add(this.btn_hesapla);
            this.panel1.Controls.Add(this.btn_temizle);
            this.panel1.Controls.Add(this.btn_sepetEkle);
            this.panel1.Controls.Add(this.txt_adet);
            this.panel1.Controls.Add(this.cb_urun);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(21, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 407);
            this.panel1.TabIndex = 1;
            // 
            // lbl_toplam
            // 
            this.lbl_toplam.AutoSize = true;
            this.lbl_toplam.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_toplam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_toplam.Location = new System.Drawing.Point(702, 180);
            this.lbl_toplam.Name = "lbl_toplam";
            this.lbl_toplam.Size = new System.Drawing.Size(0, 16);
            this.lbl_toplam.TabIndex = 14;
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hesapla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_hesapla.Location = new System.Drawing.Point(867, 128);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(69, 25);
            this.btn_hesapla.TabIndex = 13;
            this.btn_hesapla.Text = "Hesapla";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click_1);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_temizle.Location = new System.Drawing.Point(694, 260);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(71, 30);
            this.btn_temizle.TabIndex = 12;
            this.btn_temizle.Text = "TEMİZLE";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_sepetEkle
            // 
            this.btn_sepetEkle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sepetEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_sepetEkle.Location = new System.Drawing.Point(659, 213);
            this.btn_sepetEkle.Name = "btn_sepetEkle";
            this.btn_sepetEkle.Size = new System.Drawing.Size(137, 30);
            this.btn_sepetEkle.TabIndex = 11;
            this.btn_sepetEkle.Text = "SEPETE EKLE";
            this.btn_sepetEkle.UseVisualStyleBackColor = true;
            this.btn_sepetEkle.Click += new System.EventHandler(this.btn_sepetEkle_Click);
            // 
            // txt_adet
            // 
            this.txt_adet.Location = new System.Drawing.Point(629, 133);
            this.txt_adet.Name = "txt_adet";
            this.txt_adet.Size = new System.Drawing.Size(207, 20);
            this.txt_adet.TabIndex = 9;
            // 
            // cb_urun
            // 
            this.cb_urun.DataSource = this.urunBindingSource1;
            this.cb_urun.DisplayMember = "UrunAd";
            this.cb_urun.FormattingEnabled = true;
            this.cb_urun.Location = new System.Drawing.Point(629, 93);
            this.cb_urun.Name = "cb_urun";
            this.cb_urun.Size = new System.Drawing.Size(207, 21);
            this.cb_urun.TabIndex = 8;
            // 
            // urunBindingSource1
            // 
            this.urunBindingSource1.DataMember = "Urun";
            this.urunBindingSource1.DataSource = this.envanterYonetimDataSet;
            // 
            // envanterYonetimDataSet
            // 
            this.envanterYonetimDataSet.DataSetName = "EnvanterYonetimDataSet";
            this.envanterYonetimDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(512, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Toplam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(512, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(513, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ürün";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(512, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sipariş Oluştur";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UrunID,
            this.UrunAd,
            this.StokMiktar,
            this.BirimFiyat});
            this.dataGridView1.DataSource = this.urunBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 367);
            this.dataGridView1.TabIndex = 0;
            // 
            // UrunID
            // 
            this.UrunID.DataPropertyName = "UrunID";
            this.UrunID.HeaderText = "Ürün ID";
            this.UrunID.Name = "UrunID";
            this.UrunID.ReadOnly = true;
            // 
            // UrunAd
            // 
            this.UrunAd.DataPropertyName = "UrunAd";
            this.UrunAd.HeaderText = "Ürünler";
            this.UrunAd.Name = "UrunAd";
            // 
            // StokMiktar
            // 
            this.StokMiktar.DataPropertyName = "StokMiktar";
            this.StokMiktar.HeaderText = "Stok";
            this.StokMiktar.Name = "StokMiktar";
            // 
            // BirimFiyat
            // 
            this.BirimFiyat.DataPropertyName = "BirimFiyat";
            this.BirimFiyat.HeaderText = "Fiyat";
            this.BirimFiyat.Name = "BirimFiyat";
            // 
            // urunBindingSource
            // 
            this.urunBindingSource.DataMember = "Urun";
            this.urunBindingSource.DataSource = this.envanterYonetimDataSet;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(870, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(801, 36);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // urunTableAdapter
            // 
            this.urunTableAdapter.ClearBeforeFill = true;
            // 
            // MenuMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1009, 545);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MenuMusteri";
            this.Text = "MenuMusteri";
            this.Load += new System.EventHandler(this.MenuMusteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.envanterYonetimDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private EnvanterYonetimDataSet envanterYonetimDataSet;
        private System.Windows.Forms.BindingSource urunBindingSource;
        private EnvanterYonetimDataSetTableAdapters.UrunTableAdapter urunTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_sepetEkle;
        private System.Windows.Forms.TextBox txt_adet;
        private System.Windows.Forms.ComboBox cb_urun;
        private System.Windows.Forms.BindingSource urunBindingSource1;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.Label lbl_toplam;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokMiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirimFiyat;
    }
}