namespace SimpleRSA
{
    partial class mainForm
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.siticoneLabel1 = new ns1.SiticoneLabel();
            this.txtxn = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.siticoneLabel5 = new ns1.SiticoneLabel();
            this.siticoneLabel4 = new ns1.SiticoneLabel();
            this.siticoneLabel3 = new ns1.SiticoneLabel();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.txttk = new System.Windows.Forms.TextBox();
            this.btnClose = new ns1.SiticoneButton();
            this.lblPublicKey = new ns1.SiticoneLabel();
            this.lblPlaintext = new ns1.SiticoneLabel();
            this.lblPrivate = new ns1.SiticoneLabel();
            this.richTextPublic = new System.Windows.Forms.RichTextBox();
            this.richTextPrivate = new System.Windows.Forms.RichTextBox();
            this.btnLoadPublic = new ns1.SiticoneButton();
            this.btnLoadPrivate = new ns1.SiticoneButton();
            this.btnEncrypt = new ns1.SiticoneButton();
            this.dragControl = new ns1.SiticoneDragControl(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.siticoneButton1 = new ns1.SiticoneButton();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.SlateGray;
            this.panelMain.Controls.Add(this.siticoneButton1);
            this.panelMain.Controls.Add(this.linkLabel1);
            this.panelMain.Controls.Add(this.siticoneLabel1);
            this.panelMain.Controls.Add(this.txtxn);
            this.panelMain.Controls.Add(this.txtemail);
            this.panelMain.Controls.Add(this.siticoneLabel5);
            this.panelMain.Controls.Add(this.siticoneLabel4);
            this.panelMain.Controls.Add(this.siticoneLabel3);
            this.panelMain.Controls.Add(this.txtmk);
            this.panelMain.Controls.Add(this.txttk);
            this.panelMain.Controls.Add(this.btnClose);
            this.panelMain.Controls.Add(this.lblPublicKey);
            this.panelMain.Controls.Add(this.lblPlaintext);
            this.panelMain.Controls.Add(this.lblPrivate);
            this.panelMain.Controls.Add(this.richTextPublic);
            this.panelMain.Controls.Add(this.richTextPrivate);
            this.panelMain.Controls.Add(this.btnLoadPublic);
            this.panelMain.Controls.Add(this.btnLoadPrivate);
            this.panelMain.Controls.Add(this.btnEncrypt);
            this.panelMain.Location = new System.Drawing.Point(2, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1088, 539);
            this.panelMain.TabIndex = 8;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Enabled = false;
            this.siticoneLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.ForeColor = System.Drawing.Color.White;
            this.siticoneLabel1.Location = new System.Drawing.Point(409, 404);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(99, 15);
            this.siticoneLabel1.TabIndex = 14;
            this.siticoneLabel1.Text = "Nhập lại mật khẩu";
            // 
            // txtxn
            // 
            this.txtxn.Location = new System.Drawing.Point(525, 404);
            this.txtxn.Name = "txtxn";
            this.txtxn.Size = new System.Drawing.Size(245, 20);
            this.txtxn.TabIndex = 10;
            this.txtxn.UseSystemPasswordChar = true;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(525, 319);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(245, 20);
            this.txtemail.TabIndex = 8;
            // 
            // siticoneLabel5
            // 
            this.siticoneLabel5.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel5.Enabled = false;
            this.siticoneLabel5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel5.ForeColor = System.Drawing.Color.White;
            this.siticoneLabel5.Location = new System.Drawing.Point(410, 362);
            this.siticoneLabel5.Name = "siticoneLabel5";
            this.siticoneLabel5.Size = new System.Drawing.Size(84, 15);
            this.siticoneLabel5.TabIndex = 11;
            this.siticoneLabel5.Text = "Nhập mật khẩu";
            // 
            // siticoneLabel4
            // 
            this.siticoneLabel4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel4.Enabled = false;
            this.siticoneLabel4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel4.ForeColor = System.Drawing.Color.White;
            this.siticoneLabel4.Location = new System.Drawing.Point(470, 235);
            this.siticoneLabel4.Name = "siticoneLabel4";
            this.siticoneLabel4.Size = new System.Drawing.Size(98, 15);
            this.siticoneLabel4.TabIndex = 10;
            this.siticoneLabel4.Text = "Đăng ký tài khoản";
            // 
            // siticoneLabel3
            // 
            this.siticoneLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel3.Enabled = false;
            this.siticoneLabel3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel3.ForeColor = System.Drawing.Color.White;
            this.siticoneLabel3.Location = new System.Drawing.Point(409, 319);
            this.siticoneLabel3.Name = "siticoneLabel3";
            this.siticoneLabel3.Size = new System.Drawing.Size(63, 15);
            this.siticoneLabel3.TabIndex = 9;
            this.siticoneLabel3.Text = "Nhập email";
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(525, 362);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(245, 20);
            this.txtmk.TabIndex = 9;
            this.txtmk.UseSystemPasswordChar = true;
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(525, 272);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(245, 20);
            this.txttk.TabIndex = 7;
            this.txttk.TextChanged += new System.EventHandler(this.txttk_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 15;
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoveredState.Parent = this.btnClose;
            this.btnClose.Location = new System.Drawing.Point(1054, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblPublicKey
            // 
            this.lblPublicKey.BackColor = System.Drawing.Color.Transparent;
            this.lblPublicKey.Enabled = false;
            this.lblPublicKey.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublicKey.ForeColor = System.Drawing.Color.White;
            this.lblPublicKey.Location = new System.Drawing.Point(558, 62);
            this.lblPublicKey.Name = "lblPublicKey";
            this.lblPublicKey.Size = new System.Drawing.Size(60, 15);
            this.lblPublicKey.TabIndex = 6;
            this.lblPublicKey.Text = "Public Key:";
            // 
            // lblPlaintext
            // 
            this.lblPlaintext.BackColor = System.Drawing.Color.Transparent;
            this.lblPlaintext.Enabled = false;
            this.lblPlaintext.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaintext.ForeColor = System.Drawing.Color.White;
            this.lblPlaintext.Location = new System.Drawing.Point(410, 277);
            this.lblPlaintext.Name = "lblPlaintext";
            this.lblPlaintext.Size = new System.Drawing.Size(84, 15);
            this.lblPlaintext.TabIndex = 6;
            this.lblPlaintext.Text = "Nhập tài khoản";
            // 
            // lblPrivate
            // 
            this.lblPrivate.BackColor = System.Drawing.Color.Transparent;
            this.lblPrivate.Enabled = false;
            this.lblPrivate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrivate.ForeColor = System.Drawing.Color.White;
            this.lblPrivate.Location = new System.Drawing.Point(10, 62);
            this.lblPrivate.Name = "lblPrivate";
            this.lblPrivate.Size = new System.Drawing.Size(64, 15);
            this.lblPrivate.TabIndex = 6;
            this.lblPrivate.Text = "Private Key:";
            // 
            // richTextPublic
            // 
            this.richTextPublic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.richTextPublic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextPublic.ForeColor = System.Drawing.Color.White;
            this.richTextPublic.Location = new System.Drawing.Point(558, 83);
            this.richTextPublic.Name = "richTextPublic";
            this.richTextPublic.Size = new System.Drawing.Size(518, 112);
            this.richTextPublic.TabIndex = 5;
            this.richTextPublic.Text = "";
            // 
            // richTextPrivate
            // 
            this.richTextPrivate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.richTextPrivate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextPrivate.ForeColor = System.Drawing.Color.White;
            this.richTextPrivate.Location = new System.Drawing.Point(10, 83);
            this.richTextPrivate.Name = "richTextPrivate";
            this.richTextPrivate.Size = new System.Drawing.Size(518, 112);
            this.richTextPrivate.TabIndex = 5;
            this.richTextPrivate.Text = "";
            // 
            // btnLoadPublic
            // 
            this.btnLoadPublic.CheckedState.Parent = this.btnLoadPublic;
            this.btnLoadPublic.CustomImages.Parent = this.btnLoadPublic;
            this.btnLoadPublic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(176)))), ((int)(((byte)(76)))));
            this.btnLoadPublic.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLoadPublic.ForeColor = System.Drawing.Color.White;
            this.btnLoadPublic.HoveredState.Parent = this.btnLoadPublic;
            this.btnLoadPublic.Location = new System.Drawing.Point(125, 8);
            this.btnLoadPublic.Name = "btnLoadPublic";
            this.btnLoadPublic.ShadowDecoration.Parent = this.btnLoadPublic;
            this.btnLoadPublic.Size = new System.Drawing.Size(109, 33);
            this.btnLoadPublic.TabIndex = 4;
            this.btnLoadPublic.Text = "Chọn Public Key";
            this.btnLoadPublic.Click += new System.EventHandler(this.btnLoadPublic_Click);
            // 
            // btnLoadPrivate
            // 
            this.btnLoadPrivate.CheckedState.Parent = this.btnLoadPrivate;
            this.btnLoadPrivate.CustomImages.Parent = this.btnLoadPrivate;
            this.btnLoadPrivate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(77)))), ((int)(((byte)(75)))));
            this.btnLoadPrivate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLoadPrivate.ForeColor = System.Drawing.Color.White;
            this.btnLoadPrivate.HoveredState.Parent = this.btnLoadPrivate;
            this.btnLoadPrivate.Location = new System.Drawing.Point(10, 8);
            this.btnLoadPrivate.Name = "btnLoadPrivate";
            this.btnLoadPrivate.ShadowDecoration.Parent = this.btnLoadPrivate;
            this.btnLoadPrivate.Size = new System.Drawing.Size(109, 33);
            this.btnLoadPrivate.TabIndex = 4;
            this.btnLoadPrivate.Text = "Chọn Private Key";
            this.btnLoadPrivate.Click += new System.EventHandler(this.btnLoadPrivate_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.CheckedState.Parent = this.btnEncrypt;
            this.btnEncrypt.CustomImages.Parent = this.btnEncrypt;
            this.btnEncrypt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEncrypt.ForeColor = System.Drawing.Color.White;
            this.btnEncrypt.HoveredState.Parent = this.btnEncrypt;
            this.btnEncrypt.Location = new System.Drawing.Point(409, 454);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.ShadowDecoration.Parent = this.btnEncrypt;
            this.btnEncrypt.Size = new System.Drawing.Size(95, 27);
            this.btnEncrypt.TabIndex = 0;
            this.btnEncrypt.Text = "Đăng ký";
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // dragControl
            // 
            this.dragControl.TargetControl = this.panelMain;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(807, 440);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(141, 13);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "ĐĂNG NHẬP TÀI KHOẢN ?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
            this.siticoneButton1.Location = new System.Drawing.Point(675, 454);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(95, 27);
            this.siticoneButton1.TabIndex = 16;
            this.siticoneButton1.Text = "Thoát";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 543);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private ns1.SiticoneButton btnClose;
        private ns1.SiticoneLabel lblPublicKey;
        private ns1.SiticoneLabel lblPlaintext;
        private ns1.SiticoneLabel lblPrivate;
        private System.Windows.Forms.RichTextBox richTextPublic;
        private System.Windows.Forms.RichTextBox richTextPrivate;
        private ns1.SiticoneButton btnLoadPublic;
        private ns1.SiticoneButton btnLoadPrivate;
        private ns1.SiticoneButton btnEncrypt;
        private ns1.SiticoneDragControl dragControl;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.TextBox txtmk;
        private ns1.SiticoneLabel siticoneLabel4;
        private ns1.SiticoneLabel siticoneLabel3;
        private ns1.SiticoneLabel siticoneLabel1;
        private System.Windows.Forms.TextBox txtxn;
        private System.Windows.Forms.TextBox txtemail;
        private ns1.SiticoneLabel siticoneLabel5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private ns1.SiticoneButton siticoneButton1;
    }
}

