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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fatura));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_print = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_print)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 607);
            this.panel1.TabIndex = 0;
            // 
            // pic_print
            // 
            this.pic_print.Image = ((System.Drawing.Image)(resources.GetObject("pic_print.Image")));
            this.pic_print.Location = new System.Drawing.Point(526, 12);
            this.pic_print.Name = "pic_print";
            this.pic_print.Size = new System.Drawing.Size(46, 48);
            this.pic_print.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_print.TabIndex = 1;
            this.pic_print.TabStop = false;
            // 
            // Fatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 673);
            this.Controls.Add(this.pic_print);
            this.Controls.Add(this.panel1);
            this.Name = "Fatura";
            this.Text = "Fatura";
            ((System.ComponentModel.ISupportInitialize)(this.pic_print)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_print;
    }
}