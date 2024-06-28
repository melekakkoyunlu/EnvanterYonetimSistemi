namespace EnvanterYönetimSistemi.Calisan
{
    partial class FaturaOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaturaOlustur));
            this.envanterYonetimDataSet1 = new EnvanterYönetimSistemi.EnvanterYonetimDataSet();
            this.dgv_fatura = new System.Windows.Forms.DataGridView();
            this.siparisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siparisTableAdapter = new EnvanterYönetimSistemi.EnvanterYonetimDataSetTableAdapters.SiparisTableAdapter();
            this.siparisIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparisTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamTutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparisDurumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_olustur = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.envanterYonetimDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // envanterYonetimDataSet1
            // 
            this.envanterYonetimDataSet1.DataSetName = "EnvanterYonetimDataSet";
            this.envanterYonetimDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgv_fatura
            // 
            this.dgv_fatura.AutoGenerateColumns = false;
            this.dgv_fatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fatura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.siparisIDDataGridViewTextBoxColumn,
            this.musteriIDDataGridViewTextBoxColumn,
            this.siparisTarihDataGridViewTextBoxColumn,
            this.toplamTutarDataGridViewTextBoxColumn,
            this.siparisDurumDataGridViewTextBoxColumn});
            this.dgv_fatura.DataSource = this.siparisBindingSource;
            this.dgv_fatura.Location = new System.Drawing.Point(58, 96);
            this.dgv_fatura.Name = "dgv_fatura";
            this.dgv_fatura.Size = new System.Drawing.Size(544, 281);
            this.dgv_fatura.TabIndex = 0;
            // 
            // siparisBindingSource
            // 
            this.siparisBindingSource.DataMember = "Siparis";
            this.siparisBindingSource.DataSource = this.envanterYonetimDataSet1;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(564, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_olustur
            // 
            this.btn_olustur.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_olustur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_olustur.Location = new System.Drawing.Point(258, 398);
            this.btn_olustur.Name = "btn_olustur";
            this.btn_olustur.Size = new System.Drawing.Size(168, 40);
            this.btn_olustur.TabIndex = 2;
            this.btn_olustur.Text = "FATURA OLUŞTUR";
            this.btn_olustur.UseVisualStyleBackColor = true;
            this.btn_olustur.Click += new System.EventHandler(this.btn_olustur_Click);
            // 
            // FaturaOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(643, 450);
            this.Controls.Add(this.btn_olustur);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgv_fatura);
            this.Name = "FaturaOlustur";
            this.Text = "FaturaOlustur";
            this.Load += new System.EventHandler(this.FaturaOlustur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.envanterYonetimDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EnvanterYonetimDataSet envanterYonetimDataSet1;
        private System.Windows.Forms.DataGridView dgv_fatura;
        private System.Windows.Forms.BindingSource siparisBindingSource;
        private EnvanterYonetimDataSetTableAdapters.SiparisTableAdapter siparisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamTutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisDurumDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_olustur;
    }
}