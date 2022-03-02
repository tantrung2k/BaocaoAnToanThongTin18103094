using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;
using QuanLyDiemHS.laylaimatkhauTableAdapters;

namespace QuanLyDiemHS
{
    public partial class quenMK : Form
    {
        public quenMK()
        {
            InitializeComponent();
        }

        string hash = "mahoamatkhaunenphaivietdai";

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=NGUYENHOANGTANT;Initial Catalog=HocSinh;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from dangnhap where TaiKhoan = '" + txttk.Text + "' and Email = '"+txtemail.Text+"' ", con);
            QueriesTableAdapter laylai = new QueriesTableAdapter();
    if (laylai.laylaimk(txttk.Text, txtemail.Text) == 1)

    {
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            string mk = dr.GetValue(1).ToString();
            byte[] data = Convert.FromBase64String(mk);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
            byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
            {
                ICryptoTransform transform = tripDes.CreateDecryptor();
                byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                mk = UTF8Encoding.UTF8.GetString(result);
            }
             }
           

            MessageBox.Show("Tài Khoản : " + txttk.Text + " Mật khẩu : " + mk);
        }
    }
            else
            {
                MessageBox.Show("Tài Khoản hoặc Email đã sai vui lòng kiểm tra lại ");
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn thoát ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
                Application.Exit();
        }
    }
}
