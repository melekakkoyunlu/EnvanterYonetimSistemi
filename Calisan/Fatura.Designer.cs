namespace EnvanterYönetimSistemi.Calisan
{
    partial class Fatura
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_fatura = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_toplam = new System.Windows.Forms.Label();
            this.envanterYonetimDataSet = new EnvanterYönetimSistemi.EnvanterYonetimDataSet();
            this.envanterYonetimDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siparisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siparisTableAdapter = new EnvanterYönetimSistemi.EnvanterYonetimDataSetTableAdapters.SiparisTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.envanterYonetimDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.envanterYonetimDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "************************************************";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "************************************************";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(130, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "FATURA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_fatura
            // 
            this.dgv_fatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fatura.Location = new System.Drawing.Point(16, 92);
            this.dgv_fatura.Name = "dgv_fatura";
            this.dgv_fatura.Size = new System.Drawing.Size(342, 240);
            this.dgv_fatura.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(346, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "************************************************";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(346, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "************************************************";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(38, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "TOPLAM";
            // 
            // lbl_toplam
            // 
            this.lbl_toplam.AutoSize = true;
            this.lbl_toplam.BackColor = System.Drawing.Color.Transparent;
            this.lbl_toplam.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_toplam.ForeColor = System.Drawing.Color.Black;
            this.lbl_toplam.Location = new System.Drawing.Point(228, 367);
            this.lbl_toplam.Name = "lbl_toplam";
            this.lbl_toplam.Size = new System.Drawing.Size(0, 22);
            this.lbl_toplam.TabIndex = 7;
            // 
            // envanterYonetimDataSet
            // 
            this.envanterYonetimDataSet.DataSetName = "EnvanterYonetimDataSet";
            this.envanterYonetimDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // envanterYonetimDataSetBindingSource
            // 
            this.envanterYonetimDataSetBindingSource.DataSource = this.envanterYonetimDataSet;
            this.envanterYonetimDataSetBindingSource.Position = 0;
            // 
            // siparisBindingSource
            // 
            this.siparisBindingSource.DataMember = "Siparis";
            this.siparisBindingSource.DataSource = this.envanterYonetimDataSet;
            // 
            // siparisTableAdapter
            // 
            this.siparisTableAdapter.ClearBeforeFill = true;
            // 
            // Fatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 447);
            this.Controls.Add(this.lbl_toplam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_fatura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "Fatura";
            this.Text = "Fatura";
            this.Load += new System.EventHandler(this.Fatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.envanterYonetimDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.envanterYonetimDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_fatura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_toplam;
        private System.Windows.Forms.BindingSource envanterYonetimDataSetBindingSource;
        private EnvanterYonetimDataSet envanterYonetimDataSet;
        private System.Windows.Forms.BindingSource siparisBindingSource;
        private EnvanterYonetimDataSetTableAdapters.SiparisTableAdapter siparisTableAdapter;
    }
}