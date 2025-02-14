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
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_login_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_email.Text == "")
            {
                MessageBox.Show("ກາລຸນາເພີ່ມຂໍ້ມູນ");
                txt_email.Text = "";
                txt_pass.Text = "";
                txt_email.Select();
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=LAPTOP-4VE89B5T; Initial Catalog=Project2025; Integrated Security=SSPI;");
                    SqlCommand cmd = new SqlCommand(" SELECT * FROM tbl_login WHERE user_name=@user_name and user_password=@user_password", con);
                    cmd.Parameters.AddWithValue("@user_name", txt_email.Text);
                    cmd.Parameters.AddWithValue("@user_password", txt_pass.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("ຍິນດີຕ້ອນຮັບເຂົ້າສຸ່ລະບົບ");
                        Frm_movie f = new Frm_movie();
                        f.ShowDialog();
                        this.Hide();
                        txt_email.Text = "";
                        txt_pass.Text = "";
                        txt_email.Select();
                    }
                    else
                    {
                        MessageBox.Show("ຊື່ຜູ້ໃຊ້ ຫຼື ລະຫັດຜ່ານບໍ່ຖືກຕ້ອງ");
                        txt_email.Text = "";
                        txt_pass.Text = "";
                        txt_email.Select();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}

