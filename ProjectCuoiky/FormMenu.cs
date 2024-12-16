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

namespace ProjectCuoiky
{
    public partial class FormMenu : Form
    {
        string connectionstring = @"Data Source=DESKTOP-CO09DFI\MSSQLSERVER01;Initial Catalog=Final;Integrated Security=True;TrustServerCertificate=True";
        SqlCommand cmd;
        SqlDataReader doc;
        string sql;
        int i = 0;
        SqlConnection con;
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionstring);
            hienthinhanvien();
            hienthisanpham();
        }
        private void hienthisanpham()
        {
            listView2.Items.Clear();
            listView2.View = View.Details;
            con.Open();
            sql = @"select * from Hanghoa";
            cmd = new SqlCommand(sql, con);
            doc = cmd.ExecuteReader();
            i = 0;
            while (doc.Read())
            {
                listView2.Items.Add(doc[0].ToString());
                listView2.Items[i].SubItems.Add(doc[1].ToString());
                listView2.Items[i].SubItems.Add(doc[2].ToString());
                listView2.Items[i].SubItems.Add(doc[3].ToString());
                listView2.Items[i].SubItems.Add(doc[4].ToString());
                i++;
            }
            con.Close();
        }
        private void hienthinhanvien()
        {
            listView1.Items.Clear();
            listView1.View = View.Details;
            con.Open();
            sql = @"select * from Nhanvien";
            cmd = new SqlCommand(sql, con);
            doc = cmd.ExecuteReader();
            i = 0;
            while (doc.Read())
            {
                listView1.Items.Add(doc[0].ToString());
                listView1.Items[i].SubItems.Add(doc[1].ToString());
                listView1.Items[i].SubItems.Add(doc[2].ToString());
                listView1.Items[i].SubItems.Add(doc[3].ToString());
                listView1.Items[i].SubItems.Add(doc[4].ToString());
                i++;
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDangNhap login = new FormDangNhap();
            this.Close();
            login.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonEditnv_Click(object sender, EventArgs e)
        {
            FormNhanvien nhanvien = new FormNhanvien();
            this.Close();
            nhanvien.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSanpham sanpham = new FormSanpham();
            sanpham.Show();
            this.Hide();
        }
    }
}
