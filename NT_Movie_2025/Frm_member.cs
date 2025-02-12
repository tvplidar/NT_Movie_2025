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

namespace NT_Movie_2025
{
    public partial class Frm_member : Form
    {
        public Frm_member()
        {
            InitializeComponent();
            
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-CUPFRMS; " +
            "Initial Catalog=Project2025; Integrated Security=SSPI;");
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        string sql;
        public void load_id()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            sql = "SELECT * FROM tbl_login";
            cmd = new SqlCommand(sql, con);
            da = new SqlDataAdapter(sql, con);
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            //mem_id.DataSource = dt;
            //mem_id.DisplayMember = "user_id";
            //mem_id.ValueMember = "user_id";
            //con.Close();
        }

        private void cmb_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("SELECT * FROM tbl_member WHERE Mem_id='" + mem_id.Text + "'", con);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string name = (string)dr["Mem_name"].ToString();
                mem_name.Text = name;
                string mail = (string)dr["Mem_email"].ToString();
                mem_email.Text = mail;
                string status = (string)dr["user_status"].ToString();
                mem_tel.Text = status;
            }
            con.Close();
        }
    }
}
