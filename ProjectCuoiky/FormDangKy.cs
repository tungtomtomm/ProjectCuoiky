using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjectCuoiky
{
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        public bool CheckAcc (string tendn)
        {
            return (Regex.IsMatch(tendn, "^[a-zA-z0-9]{6,}$"));
        }
        public bool CheckMK(string mk)
        {
            return (Regex.IsMatch(mk, @"^(?=.*[!@#$%^&*(),.?""{}|<>])[A-Za-z\d!@#$%^&*(),.?""{}|<>]{8,}$"));
        }
        public bool CheckSDT(string sdt)
        {
            return (Regex.IsMatch(sdt, "^[0-9]{10,}$"));
        }
        public bool CheckEmail (string email)
        {
            return (Regex.IsMatch(email, @"^[a-zA-z0-9_.]{3,24}@gmail.com(.vn|)$"));
        }
        Modify modify = new Modify();
        private void buttonDangky_Click(object sender, EventArgs e)
        {
            string tendn = textBoxtenDN.Text;
            string mk = textBoxMK.Text;
            string xnmk = textBoxXNMK.Text;
            string sdt = textBoxSDT.Text;
            string email = textBoxEmail.Text;
            if (!CheckAcc(tendn)) { MessageBox.Show("Vui lòng nhập Tên Đăng nhập đúng định dạng"); return; }
            if (!CheckMK(mk)) { MessageBox.Show("Vui lòng nhập Mật khẩu đúng định dạng"); return; }
            if (xnmk != mk) { MessageBox.Show("Vui lòng nhập lại Mật khẩu chính xác"); return; }
            if (!CheckSDT(sdt)) { MessageBox.Show("Vui lòng nhập SĐT đúng định dạng"); return; }
            if (!CheckEmail(email)) { MessageBox.Show("Vui lòng nhập Email đúng định dạng"); return; }
            
            if (modify.account("select * from Dangnhap where email = '"+email+"'").Count>0)
            {
                MessageBox.Show("Email này đã được đăng ký, vui lòng sử dụng Email khác");
            }
            try
            {
                string sql = "insert into Dangnhap values ('"+tendn+"', '"+mk+"', '"+sdt+"', '"+email+"')";
                modify.command(sql);
                DialogResult result = MessageBox.Show("Bạn có muốn đăng nhập luôn không","Đăng ký thành công" 
                    ,MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if(result == DialogResult.OK)
                {
                    FormMenu menu = new FormMenu();
                    this.Hide();
                    menu.ShowDialog();
                }
                if(result == DialogResult.Cancel)
                {
                    textBoxtenDN.Text = "";
                    textBoxEmail.Text = "";
                    textBoxSDT.Text = "";
                    textBoxXNMK.Text = "";
                    textBoxMK.Text = "";
                }  
            }
            catch
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng nhập Tên đăng nhập khác");
            }
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            textBoxtenDN.Text = "";
            textBoxEmail.Text = "";
            textBoxSDT.Text = "";
            textBoxXNMK.Text = "";
            textBoxMK.Text = "";
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            FormDangNhap login = new FormDangNhap();
            this.Close();
            login.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (modify.account("select * from Dangnhap where tendangnhap = '" + textBoxtenDN.Text + "'").Count > 0)
            {
                labelCheck.Text = "Tên đăng nhập này đã được sử dụng, vui lòng nhập lại";
                labelCheck.ForeColor = Color.Red;
            }
            else
            {
                labelCheck.Text = "Tên đăng nhập hợp lệ";
                labelCheck.ForeColor = Color.Blue;
            }
        }
    }
}
