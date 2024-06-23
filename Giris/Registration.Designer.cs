namespace EnvanterYönetimSistemi
{
    partial class Registration
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_register = new System.Windows.Forms.Button();
            this.list_rol = new System.Windows.Forms.ComboBox();
            this.txt_passwordRegister = new System.Windows.Forms.TextBox();
            this.txt_usernameRegister = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.btn_register);
            this.panel1.Controls.Add(this.list_rol);
            this.panel1.Controls.Add(this.txt_passwordRegister);
            this.panel1.Controls.Add(this.txt_usernameRegister);
            this.panel1.Location = new System.Drawing.Point(61, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 213);
            this.panel1.TabIndex = 0;
            // 
            // btn_register
            // 
            this.btn_register.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_register.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_register.Location = new System.Drawing.Point(134, 164);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(80, 25);
            this.btn_register.TabIndex = 4;
            this.btn_register.Text = "KAYDET";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // list_rol
            // 
            this.list_rol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.list_rol.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.list_rol.ForeColor = System.Drawing.Color.CadetBlue;
            this.list_rol.FormattingEnabled = true;
            this.list_rol.Items.AddRange(new object[] {
            "Müşteri",
            "Çalışan"});
            this.list_rol.Location = new System.Drawing.Point(75, 125);
            this.list_rol.Name = "list_rol";
            this.list_rol.Size = new System.Drawing.Size(200, 24);
            this.list_rol.TabIndex = 3;
            // 
            // txt_passwordRegister
            // 
            this.txt_passwordRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_passwordRegister.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_passwordRegister.ForeColor = System.Drawing.Color.CadetBlue;
            this.txt_passwordRegister.Location = new System.Drawing.Point(75, 85);
            this.txt_passwordRegister.Name = "txt_passwordRegister";
            this.txt_passwordRegister.Size = new System.Drawing.Size(200, 22);
            this.txt_passwordRegister.TabIndex = 2;
            this.txt_passwordRegister.Text = "Şifre";
            // 
            // txt_usernameRegister
            // 
            this.txt_usernameRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_usernameRegister.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_usernameRegister.ForeColor = System.Drawing.Color.CadetBlue;
            this.txt_usernameRegister.Location = new System.Drawing.Point(75, 44);
            this.txt_usernameRegister.Name = "txt_usernameRegister";
            this.txt_usernameRegister.Size = new System.Drawing.Size(200, 22);
            this.txt_usernameRegister.TabIndex = 1;
            this.txt_usernameRegister.Text = "Kullanıcı Adı";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(471, 281);
            this.Controls.Add(this.panel1);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_passwordRegister;
        private System.Windows.Forms.TextBox txt_usernameRegister;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.ComboBox list_rol;
    }
}