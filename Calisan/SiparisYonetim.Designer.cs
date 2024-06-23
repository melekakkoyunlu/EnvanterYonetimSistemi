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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.siparisIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparisTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamTutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparisDurumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.envanterYonetimDataSet = new EnvanterYönetimSistemi.EnvanterYonetimDataSet();
            this.lbl_gelen = new System.Windows.Forms.Label();
            this.lbl_aktif = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.siparisTableAdapter = new EnvanterYönetimSistemi.EnvanterYonetimDataSetTableAdapters.SiparisTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.envanterYonetimDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(28, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 221);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(28, 370);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 313);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.siparisIDDataGridViewTextBoxColumn,
            this.musteriIDDataGridViewTextBoxColumn,
            this.siparisTarihDataGridViewTextBoxColumn,
            this.toplamTutarDataGridViewTextBoxColumn,
            this.siparisDurumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.siparisBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 273);
            this.dataGridView1.TabIndex = 0;
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
            // siparisBindingSource
            // 
            this.siparisBindingSource.DataMember = "Siparis";
            this.siparisBindingSource.DataSource = this.envanterYonetimDataSet;
            // 
            // envanterYonetimDataSet
            // 
            this.envanterYonetimDataSet.DataSetName = "EnvanterYonetimDataSet";
            this.envanterYonetimDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_gelen
            // 
            this.lbl_gelen.AutoSize = true;
            this.lbl_gelen.BackColor = System.Drawing.Color.CadetBlue;
            this.lbl_gelen.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_gelen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_gelen.Location = new System.Drawing.Point(32, 39);
            this.lbl_gelen.Name = "lbl_gelen";
            this.lbl_gelen.Size = new System.Drawing.Size(234, 32);
            this.lbl_gelen.TabIndex = 2;
            this.lbl_gelen.Text = "Gelen Siparişler:";
            // 
            // lbl_aktif
            // 
            this.lbl_aktif.AutoSize = true;
            this.lbl_aktif.BackColor = System.Drawing.Color.CadetBlue;
            this.lbl_aktif.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_aktif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_aktif.Location = new System.Drawing.Point(32, 321);
            this.lbl_aktif.Name = "lbl_aktif";
            this.lbl_aktif.Size = new System.Drawing.Size(218, 32);
            this.lbl_aktif.TabIndex = 3;
            this.lbl_aktif.Text = "Aktif Siparişler:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(686, 21);
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
            // SiparisYonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(776, 707);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_aktif);
            this.Controls.Add(this.lbl_gelen);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SiparisYonetim";
            this.Text = "SiparisYonetim";
            this.Load += new System.EventHandler(this.SiparisYonetim_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.envanterYonetimDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_gelen;
        private System.Windows.Forms.Label lbl_aktif;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private EnvanterYonetimDataSet envanterYonetimDataSet;
        private System.Windows.Forms.BindingSource siparisBindingSource;
        private EnvanterYonetimDataSetTableAdapters.SiparisTableAdapter siparisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamTutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisDurumDataGridViewTextBoxColumn;
    }
}