using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using QuanLyDiemHS.dangkyTableAdapters;


namespace QuanLyDiemHS
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }



        string hash = "mahoamatkhaunenphaivietdai";

        public bool checkEmail(string em)
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;

            QueriesTableAdapter dk = new QueriesTableAdapter();
            if (dk.checkDangky(textbox_TenTaiKhoan.Text) == 1) 
            {
                MessageBox.Show("Tài khoản đã tồn tại !");
                textBox_MatKhau.ResetText();
                textBox_XNMatKhau.ResetText();    
                textbox_TenTaiKhoan.ResetText();
                return;
            }
            else if (!checkEmail(email))
            {
                MessageBox.Show("Vui lòng nhập đúng email");
                return;
            }
            else if (textBox_XNMatKhau.Text != textBox_MatKhau.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp, vui lòng nhập lại !");
                textBox_XNMatKhau.ResetText();
                return;
            }
            else if (textBox_XNMatKhau.Text == textBox_MatKhau.Text)
            {
             byte[] data = UTF8Encoding.UTF8.GetBytes(textBox_MatKhau.Text);
        using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
        {
            byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys,Mode = CipherMode.ECB,Padding = PaddingMode.PKCS7})
            {
                ICryptoTransform transform = tripDes.CreateEncryptor();
                byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                textBox_MatKhau.Text = Convert.ToBase64String(result, 0, result.Length);
            }
        }
                SqlConnection con = new SqlConnection(@"Data Source=NGUYENHOANGTANT;Initial Catalog=HocSinh;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [HocSinh].[dbo].[DangNhap]
           ([TaiKhoan]
           ,[MatKhau]
            ,[Email])
            VALUES
           ('" + textbox_TenTaiKhoan.Text + "','" + textBox_MatKhau.Text + "', '" + txtEmail.Text + "')", con);
                    
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Đăng ký thành công");
            }




        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel_quaylai_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.Show();
            this.Hide();
        }

        private void textBox_XNMatKhau_TextChanged(object sender, EventArgs e)
        {
            if(textBox_XNMatKhau.Text != textBox_MatKhau.Text)
            {
                textBox_XNMatKhau.Focus();
                errorProvider1.SetError(this.textBox_XNMatKhau,"Mật Khẩu nhập lại không khớp");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn thoát ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
                Application.Exit();
        }
    }
}
