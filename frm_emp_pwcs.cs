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

namespace project_pos
{
    public partial class frm_emp_pwcs : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=RANDULA-MSI\SQLEXPRESS;Initial Catalog=se_db_pzdr;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        public frm_emp_pwcs(string load_id)
        {
            InitializeComponent();
            txt_id_load.Text = load_id;
        }

        private void frm_emp_pwcs_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String validate = "SELECT * FROM se_tbl_emp WHERE id = '" + txt_id_load.Text + "'";
                if (con.State != ConnectionState.Open)
                    con.Open();
                cmd = new SqlCommand(validate, con);
                dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    txt_pw_load.Text = dr[9].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_cp.Text = "";
            txt_np.Text = "";
            txt_rnp.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txt_cp.Text == "")
            {
                MessageBox.Show("Enter your currunt Password!!", "Problem!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_np.Text == "")
            {
                MessageBox.Show("Enter your new Password!!", "Problem!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_rnp.Text == "")
            {
                MessageBox.Show("Repeat your new Password!!", "Problem!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_cp.Text != txt_pw_load.Text)
            {
                MessageBox.Show("Current Password is Incorrect!!", "Problem!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_cp.Text = "";
            }
            else if (txt_cp.Text == txt_np.Text)
            {
                MessageBox.Show("New Password is Similar to the old one. Enter a Different Password!!", "Problem!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_np.Text = "";
                txt_rnp.Text = "";
            }
            else if (txt_np.Text != txt_rnp.Text)
            {
                MessageBox.Show("New Passwords don't match!!", "Problem!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_np.Text = "";
                txt_rnp.Text = "";
            }
            else
            {
                con.Open();
                string edit = "UPDATE se_tbl_emp SET password = '" + txt_np.Text + "' WHERE id = '" + txt_id_load.Text + "' ";
                cmd = new SqlCommand(edit, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Password Changed!!", "Successfull!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();
                this.Close();
            }
        }
    }
}
