namespace EnvanterYönetimSistemi.Musteri
{
    partial class Siparislerim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Siparislerim));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_siparisler = new System.Windows.Forms.DataGridView();
            this.envanterYonetimDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.envanterYonetimDataSet = new EnvanterYönetimSistemi.EnvanterYonetimDataSet();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_siparisler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.envanterYonetimDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.envanterYonetimDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.dgv_siparisler);
            this.panel1.Location = new System.Drawing.Point(39, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 352);
            this.panel1.TabIndex = 1;
            // 
            // dgv_siparisler
            // 
            this.dgv_siparisler.AllowUserToOrderColumns = true;
            this.dgv_siparisler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_siparisler.AutoGenerateColumns = false;
            this.dgv_siparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_siparisler.DataSource = this.envanterYonetimDataSetBindingSource;
            this.dgv_siparisler.Location = new System.Drawing.Point(0, 0);
            this.dgv_siparisler.Name = "dgv_siparisler";
            this.dgv_siparisler.Size = new System.Drawing.Size(739, 352);
            this.dgv_siparisler.TabIndex = 0;
            // 
            // envanterYonetimDataSetBindingSource
            // 
            this.envanterYonetimDataSetBindingSource.DataSource = this.envanterYonetimDataSet;
            this.envanterYonetimDataSetBindingSource.Position = 0;
            // 
            // envanterYonetimDataSet
            // 
            this.envanterYonetimDataSet.DataSetName = "EnvanterYonetimDataSet";
            this.envanterYonetimDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(51, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "İptal Et";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Siparislerim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(832, 501);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Siparislerim";
            this.Text = "Siparislerim";
            this.Load += new System.EventHandler(this.Siparislerim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_siparisler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.envanterYonetimDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.envanterYonetimDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv_siparisler;
        private System.Windows.Forms.BindingSource envanterYonetimDataSetBindingSource;
        private EnvanterYonetimDataSet envanterYonetimDataSet;
    }
}