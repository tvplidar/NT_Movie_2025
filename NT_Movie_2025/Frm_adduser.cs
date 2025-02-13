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
    public partial class Frm_adduser : Form
    {
        public Frm_adduser()
        {
            InitializeComponent();
            Auto_id();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-CUPFRMS; " +
            "Initial Catalog=NT_Movie_2025; Integrated Security=SSPI;");
        SqlCommand cmd;
        SqlDataAdapter da;
        string sql;
        public void Auto_id()
        {
            try
            {
                con.Open();
                sql = "SELECT MAX(user_id) FROM [user]";
                cmd = new SqlCommand(sql, con);
                var maxid = cmd.ExecuteScalar() as string;
                if (maxid == null)
                {
                    txt_id.Text = "A-000001";
                }
                else
                {
                    int inval = int.Parse(maxid.Substring(2, 6));
                    inval++;
                    txt_id.Text = string.Format("A-{0:000000}", inval);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            sql = "SELECT user_id as 'ລະຫັດ', username as 'ຊື່ຜູ້ໃຊ້'," +
                  " email as 'ອີເມວ', password as 'ລະຫັດຜ່ານ' " +
                  " FROM [user] ORDER BY user_id ASC";

            cmd = new SqlCommand(sql, con);
            da = new SqlDataAdapter(cmd); 
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close(); 
            txt_name.Select();

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_mail.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_pass.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                btn_save.Enabled = false;
                txt_name.Select();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            sql = "INSERT INTO [user] VALUES ('" + txt_id.Text + "',N'" + txt_name.Text + "',N'" + txt_mail.Text + "','" + txt_pass.Text + "')";
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("ບັນທຶກຂໍ້ມູນສຳເລັດ");
            con.Close();
            Auto_id();
            txt_name.Text = "";
            txt_mail.Text = "";
            txt_pass.Text = "";
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            con.Open();
            sql = "UPDATE [user] SET username=@user_name, " +
                "email=@user_email,password=@user_password " +
                "WHERE user_id='" + txt_id.Text + "'";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@user_id", txt_id.Text);
            cmd.Parameters.AddWithValue("@user_name", txt_name.Text);
            cmd.Parameters.AddWithValue("@user_email", txt_mail.Text);
            cmd.Parameters.AddWithValue("@user_password", txt_pass.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("ແກ້ໄຂຂໍ້ມູນສຳເລັດ");
            con.Close();
            Auto_id();
            txt_name.Text = "";
            txt_mail.Text = "";
            txt_pass.Text = "";
            btn_save.Enabled = true;
            txt_name.Select();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            con.Open();
            sql = "DELETE [user] WHERE user_id='" + txt_id.Text + "'";
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
           

            con.Close();
            Auto_id();
            btn_save.Enabled = true;
            txt_name.Select();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            con.Open();
            sql = "SELECT user_id as 'ລະຫັດ', username as 'ຊື່ຜູ້ໃຊ້', " +
                "email as 'ອີເມວ',password as 'ລະຫັດຜ່ານ'" +
                " FROM [user] WHERE username LIKE N'%"
                + txt_search.Text + "%' or password LIKE N'%" + txt_search.Text + "%'";
            cmd = new SqlCommand(sql, con);
            da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            sql = "SELECT user_id as 'ລະຫັດ', username as 'ຊື່ຜູ້ໃຊ້', " +
                "email as 'ອີເມວ',password as 'ລະຫັດຜ່ານ'" +
                " FROM [user] WHERE username LIKE N'%"
                + txt_search.Text + "%' or password LIKE N'%" + txt_search.Text + "%'";
            cmd = new SqlCommand(sql, con);
            da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
        
    //    public void check_dgv()
    //    {
    //        int i = dataGridView1.RowCount;
    //        if (i <= 0)
    //        {
    //            MessageBox.Show("ບໍ່ມີຂໍ້ມູນໃຫ້ລົບແລ້ວ");
    //            txt_name.Text = "";
    //            txt_pass.Text = "";
    //            txt_name.Select();
    //        }
    //        else
    //        {
    //            MessageBox.Show("ລົບຂໍ້ມູນສຳເລັດແລ້ວ");
    //            txt_name.Text = "";
    //            txt_pass.Text = "";
    //            txt_name.Select();
    //        }
    //    }
  

    //    public void check_lid()
    //    {
    //        int i = dataGridView1.RowCount;
    //        if (i <= 0)
    //        {
    //            MessageBox.Show("ບໍ່ມີຂໍ້ມູນ");
    //            txt_name.Text = "";
    //            txt_pass.Text = "";
    //            txt_name.Select();
    //        }
    //        else
    //        {
    //            MessageBox.Show("ມີຂໍ້ມູນ");
    //            txt_name.Text = "";
    //            txt_pass.Text = "";
    //            txt_name.Select();
    //        }
    //    }

