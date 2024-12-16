using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCuoiky
{
    public partial class FormSanpham : Form
    {

        public FormSanpham()
        {
            InitializeComponent();

        }
        string connectionstring = @"Data Source=DESKTOP-CO09DFI\MSSQLSERVER01;Initial Catalog=Final;Integrated Security=True;TrustServerCertificate=True";
        SqlCommand cmd;
        SqlDataReader doc;
        string sql;
        int i = 0;
        SqlConnection con;

        private void FormSanpham_Load(object sender, EventArgs e)
        {
            
            con = new SqlConnection(connectionstring);
            hienthihanghoa();
        }
        private void cleartxt()
        {
            textBoxGia.Clear();
            textBoxTensp.Clear();
            textBoxMasp.Clear();
            textBoxDate.Clear();
            textBoxTimkiem.Clear();
            textBoxSolg.Text = "";
        }
        private void hienthihanghoa()
        {
            listView1.Items.Clear();
            listView1.View = View.Details;
            con.Open();
            sql = @"select * from Hanghoa";
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

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            hienthihanghoa();
        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Mã sản phẩm")
            {
                listView1.Items.Clear();
                listView1.View = View.Details;
                con.Open();
                sql = @"select * from Hanghoa where mahang like '%" + textBoxTimkiem.Text + @"%'";
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
            if (comboBox1.Text == "Tên sản phẩm")
            {
                listView1.Items.Clear();
                listView1.View = View.Details;
                con.Open();
                sql = @"select * from Hanghoa where tenhang like '%" + textBoxTimkiem.Text + @"%'";
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
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            textBoxMasp.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBoxTensp.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBoxGia.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBoxSolg.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBoxDate.Text = listView1.SelectedItems[0].SubItems[4].Text;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            string masp = textBoxMasp.Text;
            string tensp = textBoxTensp.Text;
            string gia = textBoxGia.Text;
            string soluong = textBoxSolg.Text;
            string date = textBoxDate.Text;
            con.Open();
            sql = @"insert into Hanghoa 
                values ('" + masp + @"',
                '" + tensp + @"', '" + gia + @"',
                '" + soluong + @"', '" + date + @"')";
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Thêm thành công");
            hienthihanghoa();
            cleartxt();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            string masp = textBoxMasp.Text;
            string tensp = textBoxTensp.Text;
            string gia = textBoxGia.Text;
            string soluong = textBoxSolg.Text;
            string date = textBoxDate.Text;
            con.Open();
            sql = @"update Hanghoa set
                    mahang = '" + masp + @"',
                    tenhang = '" + tensp + @"',
                    dongia = '" + gia + @"',
                    soluong = '" + soluong + @"',
                    ngaynhap = '" + date + @"'
                    where (mahang = '" + masp+ @"')";
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sửa thành công");
            hienthihanghoa();
            cleartxt();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            con.Open();
            sql = @"delete from Hanghoa where
                    mahang = '" + textBoxMasp.Text + @"'";
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Xóa thành công");
            hienthihanghoa();
            cleartxt();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
            this.Hide();
        }
    }
}
