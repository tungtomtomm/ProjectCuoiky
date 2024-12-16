using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ProjectCuoiky
{
    internal class Modify
    {
        public Modify()
        {
        }
        SqlCommand cmd;
        SqlDataReader doc;
        public void command(string sql)
        {
            using (SqlConnection con = Connection.GetSqlConnection())
            {
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public List<Dangnhap> account (string sql)
        {
            List<Dangnhap> tk = new List<Dangnhap>();
            using (SqlConnection con = Connection.GetSqlConnection())
            {

                con.Open();
                cmd = new SqlCommand(sql, con);
                doc = cmd.ExecuteReader();
                while (doc.Read())
                {
                    tk.Add(new Dangnhap(doc.GetString(0), doc.GetString(1)));
                }
                con.Close();
            }
                return tk;
        }
    }
}
