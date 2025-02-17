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

namespace NT_Movie_2025
{
    public partial class Frm_movie_type : Form
    {
        public Frm_movie_type()
        {
            InitializeComponent();
            Auto_id();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-CUPFRMS; " +
           "Initial Catalog=NT_Movie_2025; Integrated Security=SSPI;");
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        string sql;
        public void Auto_id()
        {
            try
            {
                con.Open();
                string sql = "SELECT MAX(Movie_type_id) FROM tbl_movie_type";
                SqlCommand cmd = new SqlCommand(sql, con);
                var maxid = cmd.ExecuteScalar();

                int newId = 1; // Default starting ID if no records exist

                if (maxid != DBNull.Value && maxid != null)
                {
                    newId = Convert.ToInt32(maxid) + 1;
                }

                movie_type_id.Text = newId.ToString();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            con.Open();


            sql = "SELECT Movie_type_id as 'ລະຫັດ', Movie_name_type as 'ຊື່ປະເພດ' " +
                  " FROM tbl_movie_type ORDER BY Movie_type_id ASC";

            cmd = new SqlCommand(sql, con);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
            movie_name_type.Select();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                movie_type_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                movie_name_type.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
               

                btn_save.Enabled = false;
                movie_name_type.Select();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            sql = "INSERT INTO tbl_movie_type (Movie_type_id, Movie_name_type) VALUES ('" + movie_type_id.Text + "',N'" + movie_name_type.Text + "')";
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("ບັນທຶກຂໍ້ມູນສຳເລັດ");
            con.Close();
            Auto_id();
            movie_name_type.Text = "";
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            con.Open();
            sql = "UPDATE tbl_movie_type SET " +
                "Movie_name_type=@nametype " +
                "WHERE Movie_type_id='" + movie_type_id.Text + "'";
            cmd = new SqlCommand(sql, con);
            
            cmd.Parameters.AddWithValue("@typeid", movie_type_id.Text);
            cmd.Parameters.AddWithValue("@nametype", movie_name_type.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("ແກ້ໄຂຂໍ້ມູນສຳເລັດ");
            con.Close();
            Auto_id();
            movie_name_type.Text = "";
            btn_save.Enabled = true;
            movie_name_type.Select();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            con.Open();
            sql = "DELETE tbl_movie_type WHERE Movie_type_id='" + movie_type_id.Text + "'";
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();


            con.Close();
            Auto_id();
            btn_save.Enabled = true;
            movie_name_type.Select();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            con.Open();
            sql = "SELECT  " +
                " Movie_type_id as 'ລະຫັດຫນັງ',Movie_name_type as 'ຊື່ປະເພດ'" +
                " FROM tbl_movie_type WHERE Movie_name_type LIKE N'%" + txt_search.Text + "%'";
            cmd = new SqlCommand(sql, con);
            da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
