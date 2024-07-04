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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fatura));
            this.panelPrint = new System.Windows.Forms.Panel();
            this.dgv_urunler = new System.Windows.Forms.DataGridView();
            this.lbl_siparis = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_toplam = new System.Windows.Forms.Label();
            this.lbl_adres = new System.Windows.Forms.Label();
            this.lbl_info = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_header = new System.Windows.Forms.Label();
            this.pic_print = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panelPrint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_urunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_print)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrint
            // 
            this.panelPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelPrint.Controls.Add(this.dgv_urunler);
            this.panelPrint.Controls.Add(this.lbl_siparis);
            this.panelPrint.Controls.Add(this.label1);
            this.panelPrint.Controls.Add(this.label13);
            this.panelPrint.Controls.Add(this.lbl_toplam);
            this.panelPrint.Controls.Add(this.lbl_adres);
            this.panelPrint.Controls.Add(this.lbl_info);
            this.panelPrint.Controls.Add(this.lbl_name);
            this.panelPrint.Controls.Add(this.lbl_id);
            this.panelPrint.Controls.Add(this.lbl_date);
            this.panelPrint.Controls.Add(this.panel4);
            this.panelPrint.Controls.Add(this.label6);
            this.panelPrint.Controls.Add(this.label5);
            this.panelPrint.Controls.Add(this.label4);
            this.panelPrint.Controls.Add(this.panel3);
            this.panelPrint.Controls.Add(this.panel2);
            this.panelPrint.Controls.Add(this.label3);
            this.panelPrint.Controls.Add(this.label2);
            this.panelPrint.Controls.Add(this.lbl_header);
            this.panelPrint.Location = new System.Drawing.Point(0, 50);
            this.panelPrint.Name = "panelPrint";
            this.panelPrint.Size = new System.Drawing.Size(584, 623);
            this.panelPrint.TabIndex = 0;
            // 
            // dgv_urunler
            // 
            this.dgv_urunler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_urunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_urunler.Location = new System.Drawing.Point(26, 211);
            this.dgv_urunler.Name = "dgv_urunler";
            this.dgv_urunler.Size = new System.Drawing.Size(527, 302);
            this.dgv_urunler.TabIndex = 17;
            // 
            // lbl_siparis
            // 
            this.lbl_siparis.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_siparis.AutoSize = true;
            this.lbl_siparis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_siparis.Location = new System.Drawing.Point(474, 74);
            this.lbl_siparis.Name = "lbl_siparis";
            this.lbl_siparis.Size = new System.Drawing.Size(14, 16);
            this.lbl_siparis.TabIndex = 16;
            this.lbl_siparis.Text = "?";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(372, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Sipariş ID ";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(384, 571);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 16);
            this.label13.TabIndex = 14;
            this.label13.Text = "TOPLAM";
            // 
            // lbl_toplam
            // 
            this.lbl_toplam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_toplam.AutoSize = true;
            this.lbl_toplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_toplam.Location = new System.Drawing.Point(491, 571);
            this.lbl_toplam.Name = "lbl_toplam";
            this.lbl_toplam.Size = new System.Drawing.Size(14, 16);
            this.lbl_toplam.TabIndex = 13;
            this.lbl_toplam.Text = "?";
            // 
            // lbl_adres
            // 
            this.lbl_adres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_adres.AutoSize = true;
            this.lbl_adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_adres.Location = new System.Drawing.Point(23, 159);
            this.lbl_adres.Name = "lbl_adres";
            this.lbl_adres.Size = new System.Drawing.Size(14, 16);
            this.lbl_adres.TabIndex = 12;
            this.lbl_adres.Text = "?";
            // 
            // lbl_info
            // 
            this.lbl_info.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_info.Location = new System.Drawing.Point(23, 134);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(14, 16);
            this.lbl_info.TabIndex = 11;
            this.lbl_info.Text = "?";
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_name.Location = new System.Drawing.Point(23, 108);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(14, 16);
            this.lbl_name.TabIndex = 10;
            this.lbl_name.Text = "?";
            // 
            // lbl_id
            // 
            this.lbl_id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_id.Location = new System.Drawing.Point(474, 53);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(14, 16);
            this.lbl_id.TabIndex = 9;
            this.lbl_id.Text = "?";
            // 
            // lbl_date
            // 
            this.lbl_date.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_date.Location = new System.Drawing.Point(474, 37);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(14, 16);
            this.lbl_date.TabIndex = 8;
            this.lbl_date.Text = "?";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(12, 533);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(560, 2);
            this.panel4.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(23, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "777 7 777";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(372, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Müşteri ID ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(372, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tarih ";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(12, 188);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(560, 2);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(12, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 2);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(23, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "eys@gmail.com";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "EYS";
            // 
            // lbl_header
            // 
            this.lbl_header.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_header.Location = new System.Drawing.Point(12, 12);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(80, 25);
            this.lbl_header.TabIndex = 0;
            this.lbl_header.Text = "Fatura";
            // 
            // pic_print
            // 
            this.pic_print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_print.Image = ((System.Drawing.Image)(resources.GetObject("pic_print.Image")));
            this.pic_print.Location = new System.Drawing.Point(539, 12);
            this.pic_print.Name = "pic_print";
            this.pic_print.Size = new System.Drawing.Size(33, 32);
            this.pic_print.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_print.TabIndex = 1;
            this.pic_print.TabStop = false;
            this.pic_print.Click += new System.EventHandler(this.pic_print_Click);
            this.pic_print.MouseHover += new System.EventHandler(this.pic_print_MouseHover);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Fatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 673);
            this.Controls.Add(this.pic_print);
            this.Controls.Add(this.panelPrint);
            this.Name = "Fatura";
            this.Text = "Fatura";
            this.Load += new System.EventHandler(this.Fatura_Load);
            this.panelPrint.ResumeLayout(false);
            this.panelPrint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_urunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_print)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrint;
        private System.Windows.Forms.PictureBox pic_print;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Label lbl_adres;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_toplam;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label lbl_siparis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_urunler;
    }
}