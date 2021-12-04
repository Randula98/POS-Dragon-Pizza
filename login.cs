using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_pos
{
    public partial class frm_login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=RANDULA-MSI\SQLEXPRESS;Initial Catalog=se_db_pzdr;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        public frm_login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            lbl_date.Text = DateTime.Now.ToLongDateString();
            lbl_time.Text = DateTime.Now.ToLongTimeString();

            lbl_hello.Visible = false;
            lbl_title.Visible = false;
            lbl_face.Visible = false;
            lbl_enter_pw.Visible = false;
            txt_enter_pw.Visible = false;
            btn_login.Visible = false;
        }

        private void lbl_time_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_date.Text = DateTime.Now.ToLongDateString();
            lbl_time.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_main fm = new frm_main();
            fm.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(txt_enter_id.Text == ""){
                MessageBox.Show("Enter an ID number!!", "No ID number.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else{
                try
                {
                    con.Open();
                    String validate = "SELECT * FROM se_tbl_emp WHERE id = '" + txt_enter_id.Text + "'";
                    if (con.State != ConnectionState.Open)
                        con.Open();
                    cmd = new SqlCommand(validate, con);
                    dr = cmd.ExecuteReader();
                    dr.Read();

                    if (dr.HasRows)
                    {
                        lbl_hello.Visible = true;
                        lbl_title.Visible = true;
                        lbl_face.Visible = true;
                        lbl_enter_pw.Visible = true;
                        txt_enter_pw.Visible = true;
                        btn_login.Visible = true;

                        txt_enter_id.Enabled = false;
                        btn_val.Enabled = false;

                        txt_load_id.Text = dr[0].ToString();
                        lbl_title.Text = dr[1].ToString() + " " + dr[2].ToString();
                        txt_pos_load.Text = dr[8].ToString();
                        txt_pw_load.Text = dr[9].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No Employee Record for the ID number " + txt_enter_id.Text + ". Check the ID number again. If you are a new Employee, Please contact one of our Administrator or a Supervisor.", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_enter_pw.Text == txt_pw_load.Text)
            {
                frm_menu fmm = new frm_menu(txt_load_id.Text);
                fmm.Show();
                this.Hide();
            }
            else if(txt_enter_pw.Text == "")
            {
                MessageBox.Show("Enter Password!!" , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Warning);
            }
            else if (txt_enter_pw.Text != txt_pw_load.Text)
            {
                MessageBox.Show("Wrong Password. Try Again!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_enter_pw.Text = "";
            }
        }

        private void txt_enter_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_enter_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_rst_Click(object sender, EventArgs e)
        {
            lbl_hello.Visible = false;
            lbl_title.Visible = false;
            lbl_face.Visible = false;
            lbl_enter_pw.Visible = false;
            txt_enter_pw.Visible = false;
            btn_login.Visible = false;


            txt_enter_id.Text = "";
            txt_enter_pw.Text = "";
            txt_enter_id.Enabled = true;
            btn_val.Enabled = true;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_enter_pw_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}
