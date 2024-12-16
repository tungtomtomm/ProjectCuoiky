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
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjectCuoiky
{
    public partial class FormNhanvien : Form
    {
        string connectionstring = @"Data Source=DESKTOP-CO09DFI\MSSQLSERVER01;Initial Catalog=Final;Integrated Security=True;TrustServerCertificate=True";
        SqlCommand cmd;
        SqlDataReader doc;
        string sql;
        int i = 0;
        SqlConnection con;
        public FormNhanvien()
        {
            InitializeComponent();
        }
        private void cleartxt()
        {
            textBoxCoso.Clear();
            textBoxHoten.Clear();
            textBoxManv.Clear();
            textBoxNgaysinh.Clear();
            textBoxTimkiem.Clear();
            comboBoxGioitinh.Text = "";
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormNhanvien_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Mã Nhân viên";
            con = new SqlConnection(connectionstring);
            hienthinhanvien();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            hienthinhanvien();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Mã Nhân viên")
            {
                listView1.Items.Clear();
                listView1.View = View.Details;
                con.Open();
                sql = @"select * from Nhanvien where manv like '%" + textBoxTimkiem.Text + @"%'";
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
            if (comboBox1.Text == "Tên Nhân viên")
            {
                listView1.Items.Clear();
                listView1.View = View.Details;
                con.Open();
                sql = @"select * from Nhanvien where tennv like '%" + textBoxTimkiem.Text + @"%'";
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
            textBoxManv.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBoxHoten.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBoxNgaysinh.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBoxGioitinh.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBoxCoso.Text = listView1.SelectedItems[0].SubItems[4].Text;
        }
    
       
        private void buttonThem_Click(object sender, EventArgs e)
        {
            con.Open();
            sql = @"insert into Nhanvien (manv, tennv, ngaysinh, gioitinh, coso)
                values ('"+textBoxManv.Text+@"',
                '"+textBoxHoten.Text+@"', '"+textBoxNgaysinh.Text+@"',
                '"+comboBoxGioitinh.Text+@"', '"+textBoxCoso.Text+@"')";
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Thêm thành công");
            hienthinhanvien();
            cleartxt();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            con.Open();
            sql = @"update Nhanvien set
                    manv = '" + textBoxManv.Text + @"',
                    tennv = '" + textBoxHoten.Text + @"',
                    ngaysinh = '" + textBoxNgaysinh.Text + @"',
                    gioitinh = '" + comboBoxGioitinh.Text + @"',
                    coso = '"+textBoxCoso.Text+@"'
                    where (manv = '" + textBoxManv.Text + @"')";
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sửa thành công");
            hienthinhanvien();
            cleartxt();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            con.Open();
            sql = @"delete from Nhanvien where
                    manv = '" + textBoxManv.Text + @"'";
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Xóa thành công");
            hienthinhanvien();
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
