namespace EnvanterYönetimSistemi
{
    partial class UrunYonetim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunYonetim));
            this.lbl_urunAd = new System.Windows.Forms.Label();
            this.lbl_urunStok = new System.Windows.Forms.Label();
            this.lbl_urunBirimFiyat = new System.Windows.Forms.Label();
            this.lbl_urunTedarikci = new System.Windows.Forms.Label();
            this.txt_urunAd = new System.Windows.Forms.TextBox();
            this.txt_urunStok = new System.Windows.Forms.TextBox();
            this.txt_urunBirimFiyat = new System.Windows.Forms.TextBox();
            this.cmb_tedarikciAd = new System.Windows.Forms.ComboBox();
            this.envanterYonetimDataSet = new EnvanterYönetimSistemi.EnvanterYonetimDataSet();
            this.tedarikciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.envanterYonetimDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.lbl_urun = new System.Windows.Forms.Label();
            this.tedarikciTableAdapter = new EnvanterYönetimSistemi.EnvanterYonetimDataSetTableAdapters.TedarikciTableAdapter();
            this.dgv_urunler = new System.Windows.Forms.DataGridView();
            this.UrunID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StokMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirimFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TedarikciID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunTableAdapter = new EnvanterYönetimSistemi.EnvanterYonetimDataSetTableAdapters.UrunTableAdapter();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.txt_arama = new System.Windows.Forms.TextBox();
            this.btn_ara = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.envanterYonetimDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedarikciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.envanterYonetimDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_urunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_urunAd
            // 
            this.lbl_urunAd.AutoSize = true;
            this.lbl_urunAd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_urunAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_urunAd.Location = new System.Drawing.Point(28, 25);
            this.lbl_urunAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_urunAd.Name = "lbl_urunAd";
            this.lbl_urunAd.Size = new System.Drawing.Size(98, 24);
            this.lbl_urunAd.TabIndex = 0;
            this.lbl_urunAd.Text = "Ürün Adı:";
            // 
            // lbl_urunStok
            // 
            this.lbl_urunStok.AutoSize = true;
            this.lbl_urunStok.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_urunStok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_urunStok.Location = new System.Drawing.Point(28, 74);
            this.lbl_urunStok.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_urunStok.Name = "lbl_urunStok";
            this.lbl_urunStok.Size = new System.Drawing.Size(130, 24);
            this.lbl_urunStok.TabIndex = 1;
            this.lbl_urunStok.Text = "Stok Miktarı:";
            // 
            // lbl_urunBirimFiyat
            // 
            this.lbl_urunBirimFiyat.AutoSize = true;
            this.lbl_urunBirimFiyat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_urunBirimFiyat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_urunBirimFiyat.Location = new System.Drawing.Point(28, 123);
            this.lbl_urunBirimFiyat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_urunBirimFiyat.Name = "lbl_urunBirimFiyat";
            this.lbl_urunBirimFiyat.Size = new System.Drawing.Size(123, 24);
            this.lbl_urunBirimFiyat.TabIndex = 2;
            this.lbl_urunBirimFiyat.Text = "Birim Fiyatı:";
            // 
            // lbl_urunTedarikci
            // 
            this.lbl_urunTedarikci.AutoSize = true;
            this.lbl_urunTedarikci.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_urunTedarikci.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_urunTedarikci.Location = new System.Drawing.Point(28, 172);
            this.lbl_urunTedarikci.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_urunTedarikci.Name = "lbl_urunTedarikci";
            this.lbl_urunTedarikci.Size = new System.Drawing.Size(138, 24);
            this.lbl_urunTedarikci.TabIndex = 3;
            this.lbl_urunTedarikci.Text = "Tedarikçi Adı:";
            // 
            // txt_urunAd
            // 
            this.txt_urunAd.Location = new System.Drawing.Point(224, 23);
            this.txt_urunAd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_urunAd.Name = "txt_urunAd";
            this.txt_urunAd.Size = new System.Drawing.Size(243, 22);
            this.txt_urunAd.TabIndex = 4;
            // 
            // txt_urunStok
            // 
            this.txt_urunStok.Location = new System.Drawing.Point(224, 75);
            this.txt_urunStok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_urunStok.Name = "txt_urunStok";
            this.txt_urunStok.Size = new System.Drawing.Size(243, 22);
            this.txt_urunStok.TabIndex = 5;
            // 
            // txt_urunBirimFiyat
            // 
            this.txt_urunBirimFiyat.Location = new System.Drawing.Point(224, 122);
            this.txt_urunBirimFiyat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_urunBirimFiyat.Name = "txt_urunBirimFiyat";
            this.txt_urunBirimFiyat.Size = new System.Drawing.Size(243, 22);
            this.txt_urunBirimFiyat.TabIndex = 6;
            // 
            // cmb_tedarikciAd
            // 
            this.cmb_tedarikciAd.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.envanterYonetimDataSet, "Tedarikci.TedarikciAd", true));
            this.cmb_tedarikciAd.DataSource = this.tedarikciBindingSource;
            this.cmb_tedarikciAd.FormattingEnabled = true;
            this.cmb_tedarikciAd.Location = new System.Drawing.Point(224, 170);
            this.cmb_tedarikciAd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_tedarikciAd.Name = "cmb_tedarikciAd";
            this.cmb_tedarikciAd.Size = new System.Drawing.Size(243, 24);
            this.cmb_tedarikciAd.TabIndex = 7;
            // 
            // envanterYonetimDataSet
            // 
            this.envanterYonetimDataSet.DataSetName = "EnvanterYonetimDataSet";
            this.envanterYonetimDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tedarikciBindingSource
            // 
            this.tedarikciBindingSource.DataMember = "Tedarikci";
            this.tedarikciBindingSource.DataSource = this.envanterYonetimDataSetBindingSource;
            // 
            // envanterYonetimDataSetBindingSource
            // 
            this.envanterYonetimDataSetBindingSource.DataSource = this.envanterYonetimDataSet;
            this.envanterYonetimDataSetBindingSource.Position = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1312, 37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ekle.Location = new System.Drawing.Point(239, 231);
            this.btn_ekle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(100, 28);
            this.btn_ekle.TabIndex = 9;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_temizle.Location = new System.Drawing.Point(347, 231);
            this.btn_temizle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(100, 28);
            this.btn_temizle.TabIndex = 10;
            this.btn_temizle.Text = "TEMİZLE";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // lbl_urun
            // 
            this.lbl_urun.AutoSize = true;
            this.lbl_urun.BackColor = System.Drawing.Color.CadetBlue;
            this.lbl_urun.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_urun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_urun.Location = new System.Drawing.Point(32, 37);
            this.lbl_urun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_urun.Name = "lbl_urun";
            this.lbl_urun.Size = new System.Drawing.Size(205, 46);
            this.lbl_urun.TabIndex = 11;
            this.lbl_urun.Text = "Ürün Ekle";
            // 
            // tedarikciTableAdapter
            // 
            this.tedarikciTableAdapter.ClearBeforeFill = true;
            // 
            // dgv_urunler
            // 
            this.dgv_urunler.AllowUserToOrderColumns = true;
            this.dgv_urunler.AutoGenerateColumns = false;
            this.dgv_urunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_urunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UrunID,
            this.UrunAd,
            this.StokMiktar,
            this.BirimFiyat,
            this.TedarikciID});
            this.dgv_urunler.DataSource = this.urunBindingSource;
            this.dgv_urunler.Location = new System.Drawing.Point(27, 75);
            this.dgv_urunler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_urunler.Name = "dgv_urunler";
            this.dgv_urunler.RowHeadersWidth = 51;
            this.dgv_urunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_urunler.Size = new System.Drawing.Size(676, 511);
            this.dgv_urunler.TabIndex = 12;
            // 
            // UrunID
            // 
            this.UrunID.DataPropertyName = "UrunID";
            this.UrunID.HeaderText = "UrunID";
            this.UrunID.MinimumWidth = 6;
            this.UrunID.Name = "UrunID";
            this.UrunID.ReadOnly = true;
            this.UrunID.Width = 125;
            // 
            // UrunAd
            // 
            this.UrunAd.DataPropertyName = "UrunAd";
            this.UrunAd.HeaderText = "UrunAd";
            this.UrunAd.MinimumWidth = 6;
            this.UrunAd.Name = "UrunAd";
            this.UrunAd.Width = 125;
            // 
            // StokMiktar
            // 
            this.StokMiktar.DataPropertyName = "StokMiktar";
            this.StokMiktar.HeaderText = "StokMiktar";
            this.StokMiktar.MinimumWidth = 6;
            this.StokMiktar.Name = "StokMiktar";
            this.StokMiktar.Width = 125;
            // 
            // BirimFiyat
            // 
            this.BirimFiyat.DataPropertyName = "BirimFiyat";
            this.BirimFiyat.HeaderText = "BirimFiyat";
            this.BirimFiyat.MinimumWidth = 6;
            this.BirimFiyat.Name = "BirimFiyat";
            this.BirimFiyat.Width = 125;
            // 
            // TedarikciID
            // 
            this.TedarikciID.DataPropertyName = "TedarikciID";
            this.TedarikciID.HeaderText = "TedarikciID";
            this.TedarikciID.MinimumWidth = 6;
            this.TedarikciID.Name = "TedarikciID";
            this.TedarikciID.Width = 125;
            // 
            // urunBindingSource
            // 
            this.urunBindingSource.DataMember = "Urun";
            this.urunBindingSource.DataSource = this.envanterYonetimDataSetBindingSource;
            // 
            // urunTableAdapter
            // 
            this.urunTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Guncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Guncelle.Location = new System.Drawing.Point(189, 601);
            this.btn_Guncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(127, 28);
            this.btn_Guncelle.TabIndex = 13;
            this.btn_Guncelle.Text = "GÜNCELLE";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Sil.Location = new System.Drawing.Point(436, 601);
            this.btn_Sil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(127, 28);
            this.btn_Sil.TabIndex = 14;
            this.btn_Sil.Text = "SİL";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // txt_arama
            // 
            this.txt_arama.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_arama.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_arama.HideSelection = false;
            this.txt_arama.Location = new System.Drawing.Point(27, 25);
            this.txt_arama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_arama.Name = "txt_arama";
            this.txt_arama.Size = new System.Drawing.Size(327, 30);
            this.txt_arama.TabIndex = 15;
            this.txt_arama.Text = "Bir kelime giriniz...";
            this.txt_arama.Enter += new System.EventHandler(this.txt_arama_Enter);
            this.txt_arama.Leave += new System.EventHandler(this.txt_arama_Leave);
            // 
            // btn_ara
            // 
            this.btn_ara.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ara.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ara.Location = new System.Drawing.Point(389, 25);
            this.btn_ara.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(100, 28);
            this.btn_ara.TabIndex = 16;
            this.btn_ara.Text = "ARA";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_temizle);
            this.panel1.Controls.Add(this.btn_ekle);
            this.panel1.Controls.Add(this.cmb_tedarikciAd);
            this.panel1.Controls.Add(this.txt_urunBirimFiyat);
            this.panel1.Controls.Add(this.txt_urunStok);
            this.panel1.Controls.Add(this.txt_urunAd);
            this.panel1.Controls.Add(this.lbl_urunTedarikci);
            this.panel1.Controls.Add(this.lbl_urunBirimFiyat);
            this.panel1.Controls.Add(this.lbl_urunStok);
            this.panel1.Controls.Add(this.lbl_urunAd);
            this.panel1.Location = new System.Drawing.Point(16, 123);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 283);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_ara);
            this.panel2.Controls.Add(this.txt_arama);
            this.panel2.Controls.Add(this.btn_Sil);
            this.panel2.Controls.Add(this.dgv_urunler);
            this.panel2.Controls.Add(this.btn_Guncelle);
            this.panel2.Location = new System.Drawing.Point(553, 123);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(773, 652);
            this.panel2.TabIndex = 18;
            // 
            // UrunYonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1392, 788);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_urun);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UrunYonetim";
            this.Text = "UrunYonetim";
            this.Load += new System.EventHandler(this.UrunYonetim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.envanterYonetimDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedarikciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.envanterYonetimDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_urunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_urunAd;
        private System.Windows.Forms.Label lbl_urunStok;
        private System.Windows.Forms.Label lbl_urunBirimFiyat;
        private System.Windows.Forms.Label lbl_urunTedarikci;
        private System.Windows.Forms.TextBox txt_urunAd;
        private System.Windows.Forms.TextBox txt_urunStok;
        private System.Windows.Forms.TextBox txt_urunBirimFiyat;
        private System.Windows.Forms.ComboBox cmb_tedarikciAd;
        private EnvanterYonetimDataSet envanterYonetimDataSet;
        private System.Windows.Forms.BindingSource envanterYonetimDataSetBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Label lbl_urun;
        private System.Windows.Forms.BindingSource tedarikciBindingSource;
        private EnvanterYonetimDataSetTableAdapters.TedarikciTableAdapter tedarikciTableAdapter;
        private System.Windows.Forms.DataGridView dgv_urunler;
        private System.Windows.Forms.BindingSource urunBindingSource;
        private EnvanterYonetimDataSetTableAdapters.UrunTableAdapter urunTableAdapter;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.TextBox txt_arama;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokMiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirimFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TedarikciID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}