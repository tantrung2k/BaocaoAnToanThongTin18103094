namespace QuanLyDiemHS
{
    partial class DangKy
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
            this.textbox_TenTaiKhoan = new System.Windows.Forms.TextBox();
            this.textBox_MatKhau = new System.Windows.Forms.TextBox();
            this.textBox_XNMatKhau = new System.Windows.Forms.TextBox();
            this.button_DangKy = new System.Windows.Forms.Button();
            this.linkLabel_quaylai = new System.Windows.Forms.LinkLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // textbox_TenTaiKhoan
            // 
            this.textbox_TenTaiKhoan.Location = new System.Drawing.Point(167, 62);
            this.textbox_TenTaiKhoan.Name = "textbox_TenTaiKhoan";
            this.textbox_TenTaiKhoan.Size = new System.Drawing.Size(209, 20);
            this.textbox_TenTaiKhoan.TabIndex = 1;
            // 
            // textBox_MatKhau
            // 
            this.textBox_MatKhau.Location = new System.Drawing.Point(167, 179);
            this.textBox_MatKhau.Name = "textBox_MatKhau";
            this.textBox_MatKhau.Size = new System.Drawing.Size(209, 20);
            this.textBox_MatKhau.TabIndex = 3;
            this.textBox_MatKhau.UseSystemPasswordChar = true;
            // 
            // textBox_XNMatKhau
            // 
            this.textBox_XNMatKhau.Location = new System.Drawing.Point(167, 250);
            this.textBox_XNMatKhau.Name = "textBox_XNMatKhau";
            this.textBox_XNMatKhau.Size = new System.Drawing.Size(209, 20);
            this.textBox_XNMatKhau.TabIndex = 4;
            this.textBox_XNMatKhau.UseSystemPasswordChar = true;
            this.textBox_XNMatKhau.TextChanged += new System.EventHandler(this.textBox_XNMatKhau_TextChanged);
            // 
            // button_DangKy
            // 
            this.button_DangKy.Location = new System.Drawing.Point(16, 358);
            this.button_DangKy.Name = "button_DangKy";
            this.button_DangKy.Size = new System.Drawing.Size(123, 57);
            this.button_DangKy.TabIndex = 7;
            this.button_DangKy.Text = "Đăng ký";
            this.button_DangKy.UseVisualStyleBackColor = true;
            this.button_DangKy.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel_quaylai
            // 
            this.linkLabel_quaylai.AutoSize = true;
            this.linkLabel_quaylai.Location = new System.Drawing.Point(270, 321);
            this.linkLabel_quaylai.Name = "linkLabel_quaylai";
            this.linkLabel_quaylai.Size = new System.Drawing.Size(106, 13);
            this.linkLabel_quaylai.TabIndex = 8;
            this.linkLabel_quaylai.TabStop = true;
            this.linkLabel_quaylai.Text = "Quay lại đăng nhập?";
            this.linkLabel_quaylai.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_quaylai_LinkClicked);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 57);
            this.button1.TabIndex = 9;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Đăng Ký";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(167, 119);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(209, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Email";
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 490);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel_quaylai);
            this.Controls.Add(this.button_DangKy);
            this.Controls.Add(this.textBox_XNMatKhau);
            this.Controls.Add(this.textBox_MatKhau);
            this.Controls.Add(this.textbox_TenTaiKhoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DangKy";
            this.Text = "Đăng ký tài khoản";
            this.Load += new System.EventHandler(this.DangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbox_TenTaiKhoan;
        private System.Windows.Forms.TextBox textBox_MatKhau;
        private System.Windows.Forms.TextBox textBox_XNMatKhau;
        private System.Windows.Forms.Button button_DangKy;
        private System.Windows.Forms.LinkLabel linkLabel_quaylai;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
    }
}