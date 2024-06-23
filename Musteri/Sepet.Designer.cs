namespace EnvanterYönetimSistemi.Musteri
{
    partial class Sepet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sepet));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_sepet = new System.Windows.Forms.DataGridView();
            this.urunAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_onayla = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sepet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.dgv_sepet);
            this.panel1.Location = new System.Drawing.Point(23, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 322);
            this.panel1.TabIndex = 0;
            // 
            // dgv_sepet
            // 
            this.dgv_sepet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sepet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunAd,
            this.adet,
            this.toplamFiyat});
            this.dgv_sepet.Location = new System.Drawing.Point(12, 17);
            this.dgv_sepet.Name = "dgv_sepet";
            this.dgv_sepet.Size = new System.Drawing.Size(340, 281);
            this.dgv_sepet.TabIndex = 0;
            // 
            // urunAd
            // 
            this.urunAd.HeaderText = "Ürün";
            this.urunAd.Name = "urunAd";
            // 
            // adet
            // 
            this.adet.HeaderText = "Adet";
            this.adet.Name = "adet";
            // 
            // toplamFiyat
            // 
            this.toplamFiyat.HeaderText = "Toplam";
            this.toplamFiyat.Name = "toplamFiyat";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_clear.Location = new System.Drawing.Point(253, 409);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(122, 32);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "SİL";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_onayla
            // 
            this.btn_onayla.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_onayla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_onayla.Location = new System.Drawing.Point(125, 409);
            this.btn_onayla.Name = "btn_onayla";
            this.btn_onayla.Size = new System.Drawing.Size(122, 32);
            this.btn_onayla.TabIndex = 3;
            this.btn_onayla.Text = "ONAYLA";
            this.btn_onayla.UseVisualStyleBackColor = true;
            this.btn_onayla.Click += new System.EventHandler(this.btn_onayla_Click);
            // 
            // Sepet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(416, 459);
            this.Controls.Add(this.btn_onayla);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.panel1);
            this.Name = "Sepet";
            this.Text = "Sepet";
            this.Load += new System.EventHandler(this.Sepet_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sepet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_onayla;
        private System.Windows.Forms.DataGridView dgv_sepet;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamFiyat;
    }
}