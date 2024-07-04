namespace EnvanterYönetimSistemi.Calisan
{
    partial class SiparisYonetim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisYonetim));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.btn_onayla = new System.Windows.Forms.Button();
            this.dgv_gelenSiparis = new System.Windows.Forms.DataGridView();
            this.SiparisID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusteriID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiparisTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToplamTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiparisDurum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.envanterYonetimDataSet = new EnvanterYönetimSistemi.EnvanterYonetimDataSet();
            this.siparisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_aktif = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.siparisTableAdapter = new EnvanterYönetimSistemi.EnvanterYonetimDataSetTableAdapters.SiparisTableAdapter();
            this.siparisIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparisTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamTutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparisDurumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gelenSiparis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.envanterYonetimDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.btn_sil);
            this.panel2.Controls.Add(this.btn_iptal);
            this.panel2.Controls.Add(this.btn_onayla);
            this.panel2.Controls.Add(this.dgv_gelenSiparis);
            this.panel2.Location = new System.Drawing.Point(23, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(764, 534);
            this.panel2.TabIndex = 1;
            // 
            // btn_sil
            // 
            this.btn_sil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_sil.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_sil.Location = new System.Drawing.Point(617, 241);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(99, 41);
            this.btn_sil.TabIndex = 7;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // btn_iptal
            // 
            this.btn_iptal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_iptal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_iptal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_iptal.Location = new System.Drawing.Point(617, 173);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(99, 41);
            this.btn_iptal.TabIndex = 6;
            this.btn_iptal.Text = " İPTAL ET";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // btn_onayla
            // 
            this.btn_onayla.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_onayla.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_onayla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_onayla.Location = new System.Drawing.Point(617, 99);
            this.btn_onayla.Name = "btn_onayla";
            this.btn_onayla.Size = new System.Drawing.Size(99, 41);
            this.btn_onayla.TabIndex = 5;
            this.btn_onayla.Text = "ONAYLA";
            this.btn_onayla.UseVisualStyleBackColor = true;
            this.btn_onayla.Click += new System.EventHandler(this.btn_onayla_Click);
            // 
            // dgv_gelenSiparis
            // 
            this.dgv_gelenSiparis.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgv_gelenSiparis.AutoGenerateColumns = false;
            this.dgv_gelenSiparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_gelenSiparis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SiparisID,
            this.MusteriID,
            this.SiparisTarih,
            this.ToplamTutar,
            this.SiparisDurum,
            this.siparisIDDataGridViewTextBoxColumn,
            this.musteriIDDataGridViewTextBoxColumn,
            this.siparisTarihDataGridViewTextBoxColumn,
            this.toplamTutarDataGridViewTextBoxColumn,
            this.siparisDurumDataGridViewTextBoxColumn});
            this.dgv_gelenSiparis.DataSource = this.siparisBindingSource1;
            this.dgv_gelenSiparis.Location = new System.Drawing.Point(20, 18);
            this.dgv_gelenSiparis.Name = "dgv_gelenSiparis";
            this.dgv_gelenSiparis.Size = new System.Drawing.Size(543, 487);
            this.dgv_gelenSiparis.TabIndex = 0;
            // 
            // SiparisID
            // 
            this.SiparisID.DataPropertyName = "SiparisID";
            this.SiparisID.HeaderText = "SiparisID";
            this.SiparisID.Name = "SiparisID";
            this.SiparisID.ReadOnly = true;
            // 
            // MusteriID
            // 
            this.MusteriID.DataPropertyName = "MusteriID";
            this.MusteriID.HeaderText = "MusteriID";
            this.MusteriID.Name = "MusteriID";
            // 
            // SiparisTarih
            // 
            this.SiparisTarih.DataPropertyName = "SiparisTarih";
            this.SiparisTarih.HeaderText = "SiparisTarih";
            this.SiparisTarih.Name = "SiparisTarih";
            // 
            // ToplamTutar
            // 
            this.ToplamTutar.DataPropertyName = "ToplamTutar";
            this.ToplamTutar.HeaderText = "ToplamTutar";
            this.ToplamTutar.Name = "ToplamTutar";
            // 
            // SiparisDurum
            // 
            this.SiparisDurum.DataPropertyName = "SiparisDurum";
            this.SiparisDurum.HeaderText = "SiparisDurum";
            this.SiparisDurum.Name = "SiparisDurum";
            // 
            // siparisBindingSource1
            // 
            this.siparisBindingSource1.DataMember = "Siparis";
            this.siparisBindingSource1.DataSource = this.envanterYonetimDataSet;
            // 
            // envanterYonetimDataSet
            // 
            this.envanterYonetimDataSet.DataSetName = "EnvanterYonetimDataSet";
            this.envanterYonetimDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siparisBindingSource
            // 
            this.siparisBindingSource.DataMember = "Siparis";
            this.siparisBindingSource.DataSource = this.envanterYonetimDataSet;
            // 
            // lbl_aktif
            // 
            this.lbl_aktif.AutoSize = true;
            this.lbl_aktif.BackColor = System.Drawing.Color.CadetBlue;
            this.lbl_aktif.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_aktif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_aktif.Location = new System.Drawing.Point(46, 39);
            this.lbl_aktif.Name = "lbl_aktif";
            this.lbl_aktif.Size = new System.Drawing.Size(218, 32);
            this.lbl_aktif.TabIndex = 3;
            this.lbl_aktif.Text = "Aktif Siparişler:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(773, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // siparisTableAdapter
            // 
            this.siparisTableAdapter.ClearBeforeFill = true;
            // 
            // siparisIDDataGridViewTextBoxColumn
            // 
            this.siparisIDDataGridViewTextBoxColumn.DataPropertyName = "SiparisID";
            this.siparisIDDataGridViewTextBoxColumn.HeaderText = "SiparisID";
            this.siparisIDDataGridViewTextBoxColumn.Name = "siparisIDDataGridViewTextBoxColumn";
            this.siparisIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // musteriIDDataGridViewTextBoxColumn
            // 
            this.musteriIDDataGridViewTextBoxColumn.DataPropertyName = "MusteriID";
            this.musteriIDDataGridViewTextBoxColumn.HeaderText = "MusteriID";
            this.musteriIDDataGridViewTextBoxColumn.Name = "musteriIDDataGridViewTextBoxColumn";
            // 
            // siparisTarihDataGridViewTextBoxColumn
            // 
            this.siparisTarihDataGridViewTextBoxColumn.DataPropertyName = "SiparisTarih";
            this.siparisTarihDataGridViewTextBoxColumn.HeaderText = "SiparisTarih";
            this.siparisTarihDataGridViewTextBoxColumn.Name = "siparisTarihDataGridViewTextBoxColumn";
            // 
            // toplamTutarDataGridViewTextBoxColumn
            // 
            this.toplamTutarDataGridViewTextBoxColumn.DataPropertyName = "ToplamTutar";
            this.toplamTutarDataGridViewTextBoxColumn.HeaderText = "ToplamTutar";
            this.toplamTutarDataGridViewTextBoxColumn.Name = "toplamTutarDataGridViewTextBoxColumn";
            // 
            // siparisDurumDataGridViewTextBoxColumn
            // 
            this.siparisDurumDataGridViewTextBoxColumn.DataPropertyName = "SiparisDurum";
            this.siparisDurumDataGridViewTextBoxColumn.HeaderText = "SiparisDurum";
            this.siparisDurumDataGridViewTextBoxColumn.Name = "siparisDurumDataGridViewTextBoxColumn";
            // 
            // SiparisYonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(834, 707);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_aktif);
            this.Controls.Add(this.panel2);
            this.Name = "SiparisYonetim";
            this.Text = "SiparisYonetim";
            this.Load += new System.EventHandler(this.SiparisYonetim_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gelenSiparis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.envanterYonetimDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_aktif;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgv_gelenSiparis;
        private EnvanterYonetimDataSet envanterYonetimDataSet;
        private System.Windows.Forms.BindingSource siparisBindingSource;
        private EnvanterYonetimDataSetTableAdapters.SiparisTableAdapter siparisTableAdapter;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Button btn_onayla;
        private System.Windows.Forms.BindingSource siparisBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiparisID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusteriID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiparisTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToplamTutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiparisDurum;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamTutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisDurumDataGridViewTextBoxColumn;
    }
}