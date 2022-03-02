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
using System.Text.RegularExpressions;

namespace SimpleRSA
{

   
    public partial class mainForm : Form
    {

       public bool checkEmail(string em)
    {
        return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
    }
        public mainForm()
        {
            InitializeComponent();
        }
        private string privatePem;
        private string publicPem;
        private RSACryptoServiceProvider rsa;
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLoadPrivate_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "Private Key .private|*.private";
                openFile.Title = "Vui lòng chọn Private key!";
                if(openFile.ShowDialog() == DialogResult.OK)
                {
                    if(openFile.FileName != string.Empty)
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

        private void btnLoadPublic_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "Public Key .Public|*.Public";
                openFile.Title = "Vui lòng chọn Public key!";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    if (openFile.FileName != string.Empty)
                    {
                        using (StreamReader sr = new StreamReader(openFile.FileName))
                        {
                            publicPem = sr.ReadToEnd();
                            sr.Close();
                        }
                        richTextPublic.Text = publicPem;
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
                MessageBox.Show("có lỗi trong quá trình tải publickey Key!", "HỆ THỐNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text;

            if (!checkEmail(email))
            {
                MessageBox.Show("Vui lòng nhập đúng email");
                return;
            }
            else if (txtmk.Text != txtxn.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp, vui lòng nhập lại !");
                txtmk.ResetText();
                return;
            }

            rsa = RSAKeys.ImportPublicKey(rsa, publicPem);
                var inputData = Encoding.UTF8.GetBytes(txtmk.Text);
                var cipher = rsa.Encrypt(inputData, false);
                txtmk.Text = Convert.ToBase64String(cipher);

                SqlConnection con = new SqlConnection(@"Data Source=NGUYENHOANGTANT;Initial Catalog=HocSinh;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [HocSinh].[dbo].[dangnhap1]
            ([Taikhoan]
           ,[MatKhau]
            ,[Email])
            VALUES
           ('" + txttk.Text + "','" + txtmk.Text + "', '" + txtemail.Text + "')", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Đăng ký thành công");

            txttk.ResetText();
            txtemail.ResetText();
            txtmk.ResetText();
            txtxn.ResetText();

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            rsa = new RSACryptoServiceProvider();
            rsa.ExportParameters(true);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            
        }

        private void txttk_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dangnhap dn = new dangnhap();
            dn.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dangnhap dn = new dangnhap();
            dn.Show();
            this.Hide();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn thoát ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
                Application.Exit();
        }
    }
}
