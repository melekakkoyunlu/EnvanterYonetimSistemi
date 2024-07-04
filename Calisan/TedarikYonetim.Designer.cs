namespace EnvanterYönetimSistemi.Calisan
{
    partial class TedarikYonetim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TedarikYonetim));
            this.lbl_tedarik = new System.Windows.Forms.Label();
            this.txt_iletisim = new System.Windows.Forms.TextBox();
            this.txt_tedarikciAd = new System.Windows.Forms.TextBox();
            this.lbl_tedarikInfo = new System.Windows.Forms.Label();
            this.lbl_tedarikAd = new System.Windows.Forms.Label();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_tedarik = new System.Windows.Forms.DataGridView();
            this.TedarikciID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TedarikciAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iletisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tedarikciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.envanterYonetimDataSet = new EnvanterYönetimSistemi.EnvanterYonetimDataSet();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_ara = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.txt_arama = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tedarikciTableAdapter = new EnvanterYönetimSistemi.EnvanterYonetimDataSetTableAdapters.TedarikciTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tedarik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedarikciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.envanterYonetimDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_tedarik
            // 
            this.lbl_tedarik.AutoSize = true;
            this.lbl_tedarik.BackColor = System.Drawing.Color.CadetBlue;
            this.lbl_tedarik.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tedarik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_tedarik.Location = new System.Drawing.Point(21, 25);
            this.lbl_tedarik.Name = "lbl_tedarik";
            this.lbl_tedarik.Size = new System.Drawing.Size(235, 37);
            this.lbl_tedarik.TabIndex = 12;
            this.lbl_tedarik.Text = "Tedarikçi Ekle";
            // 
            // txt_iletisim
            // 
            this.txt_iletisim.Location = new System.Drawing.Point(184, 91);
            this.txt_iletisim.Name = "txt_iletisim";
            this.txt_iletisim.Size = new System.Drawing.Size(179, 20);
            this.txt_iletisim.TabIndex = 17;
            // 
            // txt_tedarikciAd
            // 
            this.txt_tedarikciAd.Location = new System.Drawing.Point(184, 49);
            this.txt_tedarikciAd.Name = "txt_tedarikciAd";
            this.txt_tedarikciAd.Size = new System.Drawing.Size(179, 20);
            this.txt_tedarikciAd.TabIndex = 16;
            // 
            // lbl_tedarikInfo
            // 
            this.lbl_tedarikInfo.AutoSize = true;
            this.lbl_tedarikInfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tedarikInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_tedarikInfo.Location = new System.Drawing.Point(37, 90);
            this.lbl_tedarikInfo.Name = "lbl_tedarikInfo";
            this.lbl_tedarikInfo.Size = new System.Drawing.Size(68, 19);
            this.lbl_tedarikInfo.TabIndex = 14;
            this.lbl_tedarikInfo.Text = "İletişim:";
            // 
            // lbl_tedarikAd
            // 
            this.lbl_tedarikAd.AutoSize = true;
            this.lbl_tedarikAd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tedarikAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_tedarikAd.Location = new System.Drawing.Point(37, 50);
            this.lbl_tedarikAd.Name = "lbl_tedarikAd";
            this.lbl_tedarikAd.Size = new System.Drawing.Size(112, 19);
            this.lbl_tedarikAd.TabIndex = 13;
            this.lbl_tedarikAd.Text = "Tedarikçi Adı:";
            // 
            // btn_temizle
            // 
            this.btn_temizle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_temizle.Location = new System.Drawing.Point(276, 129);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(75, 23);
            this.btn_temizle.TabIndex = 19;
            this.btn_temizle.Text = "TEMİZLE";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ekle.Location = new System.Drawing.Point(195, 129);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 18;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_iletisim);
            this.panel1.Controls.Add(this.btn_temizle);
            this.panel1.Controls.Add(this.lbl_tedarikAd);
            this.panel1.Controls.Add(this.btn_ekle);
            this.panel1.Controls.Add(this.lbl_tedarikInfo);
            this.panel1.Controls.Add(this.txt_tedarikciAd);
            this.panel1.Location = new System.Drawing.Point(28, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 197);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgv_tedarik);
            this.panel2.Controls.Add(this.btn_Sil);
            this.panel2.Controls.Add(this.btn_ara);
            this.panel2.Controls.Add(this.btn_Guncelle);
            this.panel2.Controls.Add(this.txt_arama);
            this.panel2.Location = new System.Drawing.Point(463, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 492);
            this.panel2.TabIndex = 21;
            // 
            // dgv_tedarik
            // 
            this.dgv_tedarik.AutoGenerateColumns = false;
            this.dgv_tedarik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tedarik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TedarikciID,
            this.TedarikciAd,
            this.Iletisim});
            this.dgv_tedarik.DataSource = this.tedarikciBindingSource;
            this.dgv_tedarik.Location = new System.Drawing.Point(24, 90);
            this.dgv_tedarik.Name = "dgv_tedarik";
            this.dgv_tedarik.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tedarik.Size = new System.Drawing.Size(343, 378);
            this.dgv_tedarik.TabIndex = 25;
            // 
            // TedarikciID
            // 
            this.TedarikciID.DataPropertyName = "TedarikciID";
            this.TedarikciID.HeaderText = "TedarikciID";
            this.TedarikciID.Name = "TedarikciID";
            this.TedarikciID.ReadOnly = true;
            // 
            // TedarikciAd
            // 
            this.TedarikciAd.DataPropertyName = "TedarikciAd";
            this.TedarikciAd.HeaderText = "TedarikciAd";
            this.TedarikciAd.Name = "TedarikciAd";
            // 
            // Iletisim
            // 
            this.Iletisim.DataPropertyName = "Iletisim";
            this.Iletisim.HeaderText = "Iletisim";
            this.Iletisim.Name = "Iletisim";
            // 
            // tedarikciBindingSource
            // 
            this.tedarikciBindingSource.DataMember = "Tedarikci";
            this.tedarikciBindingSource.DataSource = this.envanterYonetimDataSet;
            // 
            // envanterYonetimDataSet
            // 
            this.envanterYonetimDataSet.DataSetName = "EnvanterYonetimDataSet";
            this.envanterYonetimDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Sil
            // 
            this.btn_Sil.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Sil.Location = new System.Drawing.Point(390, 153);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(95, 23);
            this.btn_Sil.TabIndex = 24;
            this.btn_Sil.Text = "SİL";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_ara
            // 
            this.btn_ara.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ara.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ara.Location = new System.Drawing.Point(302, 46);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(75, 23);
            this.btn_ara.TabIndex = 24;
            this.btn_ara.Text = "ARA";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Guncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Guncelle.Location = new System.Drawing.Point(390, 115);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(95, 23);
            this.btn_Guncelle.TabIndex = 23;
            this.btn_Guncelle.Text = "GÜNCELLE";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // txt_arama
            // 
            this.txt_arama.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_arama.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_arama.HideSelection = false;
            this.txt_arama.Location = new System.Drawing.Point(24, 43);
            this.txt_arama.Name = "txt_arama";
            this.txt_arama.Size = new System.Drawing.Size(246, 26);
            this.txt_arama.TabIndex = 23;
            this.txt_arama.Text = "Bir kelime giriniz...";
            this.txt_arama.Enter += new System.EventHandler(this.txt_arama_Enter);
            this.txt_arama.Leave += new System.EventHandler(this.txt_arama_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(929, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tedarikciTableAdapter
            // 
            this.tedarikciTableAdapter.ClearBeforeFill = true;
            // 
            // TedarikYonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1009, 590);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_tedarik);
            this.Name = "TedarikYonetim";
            this.Text = "TedarikYonetim";
            this.Load += new System.EventHandler(this.TedarikYonetim_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tedarik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedarikciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.envanterYonetimDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tedarik;
        private System.Windows.Forms.TextBox txt_iletisim;
        private System.Windows.Forms.TextBox txt_tedarikciAd;
        private System.Windows.Forms.Label lbl_tedarikInfo;
        private System.Windows.Forms.Label lbl_tedarikAd;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.TextBox txt_arama;
        private System.Windows.Forms.DataGridView dgv_tedarik;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Guncelle;
        private EnvanterYonetimDataSet envanterYonetimDataSet;
        private System.Windows.Forms.BindingSource tedarikciBindingSource;
        private EnvanterYonetimDataSetTableAdapters.TedarikciTableAdapter tedarikciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn TedarikciID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TedarikciAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iletisim;
    }
}