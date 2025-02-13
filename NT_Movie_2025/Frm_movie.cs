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
    public partial class Frm_movie : Form
    {
        public Frm_movie()
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
                string sql = "SELECT MAX(Movie_id) FROM tbl_movie";
                SqlCommand cmd = new SqlCommand(sql, con);
                var maxid = cmd.ExecuteScalar();

                int newId = 1; // Default starting ID if no records exist

                if (maxid != DBNull.Value && maxid != null)
                {
                    newId = Convert.ToInt32(maxid) + 1;
                }

                movie_id.Text = newId.ToString();

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
            

            sql = "SELECT Movie_id as 'ລະຫັດ', Movie_name as 'ຊື່ຫນັງ'," +
                  " Movie_type_id as 'ລະຫັດປະເພດ', Movie_name_type as 'ຊື່ປະເພດ' " +
                  " FROM tbl_movie ORDER BY Movie_id ASC";

            cmd = new SqlCommand(sql, con);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
            movie_name.Select();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                movie_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                movie_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                movie_type_id.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                movie_name_type.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                btn_save.Enabled = false;
                movie_name.Select();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            sql = "INSERT INTO tbl_movie (movie_id, movie_name, movie_type_id, movie_name_type) VALUES ('" + movie_id.Text + "',N'" + movie_name.Text + "',N'" + movie_type_id.Text + "','" + movie_name_type.Text + "')";
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("ບັນທຶກຂໍ້ມູນສຳເລັດ");
            con.Close();
            Auto_id(); 
            movie_name.Text = "";
            movie_type_id.Text = "";
            movie_name_type.Text = "";
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            con.Open();
            sql = "UPDATE tbl_movie SET Movie_name=@movie_name, " +
                "Movie_type_id=@typeid,Movie_name_type=@nametype " +
                "WHERE Movie_id='" + movie_id.Text + "'";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@movie_id", movie_id.Text);
            cmd.Parameters.AddWithValue("@movie_name", movie_name.Text);
            cmd.Parameters.AddWithValue("@typeid", movie_type_id.Text);
            cmd.Parameters.AddWithValue("@nametype", movie_name_type.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("ແກ້ໄຂຂໍ້ມູນສຳເລັດ");
            con.Close();
            Auto_id();
            movie_name.Text = "";
            movie_type_id.Text = "";
            movie_name_type.Text = "";
            btn_save.Enabled = true;
            movie_name.Select();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            con.Open();
            sql = "DELETE tbl_movie WHERE Movie_id='" + movie_id.Text + "'";
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();


            con.Close();
            Auto_id();
            btn_save.Enabled = true;
            movie_name.Select();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
