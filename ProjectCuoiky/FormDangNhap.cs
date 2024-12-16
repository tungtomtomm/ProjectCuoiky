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
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;

namespace ProjectCuoiky
{
    public partial class FormDangNhap : Form
    {
        
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
 
        }
        Modify modify = new Modify();
        private void buttonDangnhap_Click(object sender, EventArgs e)
        {
            string tendn = textBoxDangnhap.Text;
            string mk = textBoxMatkhau.Text;
            if(tendn.Trim() == "") 
                { MessageBox.Show("Vui lòng nhập tên đăng nhập"); }
            else if(mk.Trim() == "") 
                { MessageBox.Show("Vui lòng nhập Mật khẩu"); }
            else
            {
                string sql = @"select * from Dangnhap where tendangnhap = '"+tendn+"' and matkhau = '"+mk+"'";
                if (modify.account("select * from Dangnhap where tendangnhap = '" + tendn + "' and matkhau = '" + mk + "'").Count!= 0)
                {
                    MessageBox.Show("Đăng nhập thành công","Thông báo",
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                    FormMenu menu = new FormMenu();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tên Tài khoản hoặc mật khẩu không chính xác");
                }
            }
        }

        private void buttonDangky_Click(object sender, EventArgs e)
        {
            FormDangKy dangky = new FormDangKy();
            dangky.Show();
            this.Hide();
        }

        private void buttonCheat_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            this.Hide();
            menu.ShowDialog();
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            textBoxDangnhap.Text = "";
            textBoxMatkhau.Text = "";
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
