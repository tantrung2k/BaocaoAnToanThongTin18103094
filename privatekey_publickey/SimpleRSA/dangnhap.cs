using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace SimpleRSA
{
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }
        
        private string privatePem;
        private RSACryptoServiceProvider rsa;
        private void dangnhap_Load(object sender, EventArgs e)
        {
            rsa = new RSACryptoServiceProvider();
            rsa.ExportParameters(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=NGUYENHOANGTANT;Initial Catalog=HocSinh;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from dangnhap1 Where TaiKhoan = '" + txttk.Text + "' " , con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string tk = dr.GetValue(0).ToString();
                string mk = dr.GetValue(1).ToString();
                try
                {
                    rsa = RSAKeys.ImportPrivateKey(rsa, privatePem);
                    var encrydatedData = Convert.FromBase64String(mk);
                    var plainText = rsa.Decrypt(encrydatedData, false);
                    mk = Encoding.UTF8.GetString(plainText);

                
                     if (txttk.Text == tk && txtmk.Text == mk)
                {
                    thanhcong tc = new thanhcong();
                    tc.Show();
                    this.Hide();
                }
                
                else
                {
                    MessageBox.Show("Tài Khoản hoặc mật khẩu đã sai vui lòng kiểm tra lại ");
                }

                }
                catch
                {
                    MessageBox.Show("có lỗi trong quá trình đăng nhập", "HỆ THỐNG", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

               
            }    

            
               
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "Private Key .private|*.private";
                openFile.Title = "Vui lòng chọn Private key!";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    if (openFile.FileName != string.Empty)
                    {
                        using (StreamReader sr = new StreamReader(openFile.FileName))
                        {
                            privatePem = sr.ReadToEnd();
                            sr.Close();
                        }
                        richTextPrivate.Text = privatePem;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn đúng định dạng file", "HỆ THỐNG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("có lỗi trong quá trình tải Private Key!", "HỆ THỐNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn thoát ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
                Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainForm mn = new mainForm();
            mn.Show();
            this.Hide();
        }
    }
}
