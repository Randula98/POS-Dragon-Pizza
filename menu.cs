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
    public partial class frm_menu : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=RANDULA-MSI\SQLEXPRESS;Initial Catalog=se_db_pzdr;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        public frm_menu(string id_load)
        {
            InitializeComponent();
            txt_id_load.Text = id_load;
            string status;

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
                    txt_id_load.Text = dr[0].ToString();
                    lbl_title.Text = dr[1].ToString()+ " " +dr[2].ToString();
                    lbl_age.Text = dr[5].ToString();
                    lbl_contact.Text = dr[6].ToString();
                    txt_pos_load.Text = dr[8].ToString();

                    byte[] img = (byte[])(dr[4]);

                    if (img == null)
                    {
                        img_emp.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        img_emp.Image = Image.FromStream(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                con.Close();

                if (txt_pos_load.Text == "admin")
            {
                status = "admin";
            }
            else if ( txt_pos_load.Text == "sup")
            {
                status = "sup";
            }
            else if ( txt_pos_load.Text == "chef")
            {
                status = "chef";
            }
            else
            {
                status = "cash";
            }

            panel_sup.Visible = false;
            panel_admin.Visible = false;
            panel_cash.Visible = false;
            panel_chef.Visible = false;

            pos_online.Visible = false;
            pos_offline.Visible = false;
            btn_fix.Visible = false;


            if (status == "admin")
            {
                panel_admin.Visible = true;
                lbl_admin.Text = "Logged in as an Administrator. FULL ACCESS GRANTED";
                pos_online.Visible = true;
            }
            else if(status == "sup")
            {
                panel_sup.Visible = true;
                lbl_sup.Text = "Logged in as a Supervisor. FULL ACCESS GRANTED";
                pos_online.Visible = true;
            }
            else if(status == "chef")
            {
                panel_chef.Visible = true;
                lbl_chef.Text = "Logged in as an Chef. LIMITED ACCESS GRANTED";
                btn_emp.Enabled = false;
                btn_pos.Enabled = false;
                pos_offline.Visible = true;
                img_emp.Enabled = false;
            }
            else
            {
                panel_cash.Visible = true;
                lbl_cash.Text = "Logged in as a Cashier. LIMITED ACCESS GRANTED";
                btn_emp.Enabled = false;
                btn_items.Enabled = false;
                pos_online.Visible = true;
            }

            if (status == "admin"){
                try
                {
                    con.Open();
                    string view = "SELECT * FROM tbl_pos";
                    cmd = new SqlCommand(view, con);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dgv_pos.DataSource = dt;
                    MessageBox.Show("POS System OFFLINE", "System Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("All Systems are Fully Functional!! :)", "System Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (dgv_pos.DataSource != null)
                {
                    pos_online.Visible = false;
                    pos_offline.Visible = true;
                    btn_fix.Visible = true;
                    btn_pos.Enabled = false;
                    img_pos_off.Visible = true;
                }
                else
                {
                    pos_online.Visible = true;
                    pos_offline.Visible = false;
                    btn_fix.Visible = false;
                    img_pos_off.Visible = false;
                }
            }else if (status == "sup")
            {
                try
                {
                    con.Open();
                    string view = "SELECT * FROM tbl_pos";
                    cmd = new SqlCommand(view, con);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dgv_pos.DataSource = dt;
                    MessageBox.Show("POS System OFFLINE", "System Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("All Systems are Fully Functional!! :)", "System Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (dgv_pos.DataSource != null)
                {
                    pos_online.Visible = false;
                    pos_offline.Visible = true;
                    btn_fix.Visible = true;
                    btn_pos.Enabled = false;
                    img_pos_off.Visible = true;
                }
                else
                {
                    pos_online.Visible = true;
                    pos_offline.Visible = false;
                    btn_fix.Visible = false;
                    img_pos_off.Visible = false;
                }
            }
            else if (status == "cash")
            {
                try
                {
                    con.Open();
                    string view = "SELECT * FROM tbl_pos";
                    cmd = new SqlCommand(view, con);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dgv_pos.DataSource = dt;
                    MessageBox.Show("POS System OFFLINE" , "System Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("All Systems are Fully Functional!! :)", "System Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (dgv_pos.DataSource != null)
                {
                    pos_online.Visible = false;
                    pos_offline.Visible = true;
                    btn_fix.Visible = true;
                    btn_pos.Enabled = false;
                    img_pos_off.Visible = true;
                }
                else
                {
                    pos_online.Visible = true;
                    pos_offline.Visible = false;
                    btn_fix.Visible = false;
                    img_pos_off.Visible = false;
                }
            }
        }

        private void frm_menu_Load(object sender, EventArgs e)
        {
            lbl_date.Text = DateTime.Now.ToLongDateString();
            lbl_time.Text = DateTime.Now.ToLongTimeString();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_date.Text = DateTime.Now.ToLongDateString();
            lbl_time.Text = DateTime.Now.ToLongTimeString();
        }

        private void btn_fix_Click(object sender, EventArgs e)
        {
            con.Open();
            string del = "DROP TABLE tbl_pos";
            cmd = new SqlCommand(del, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("POS System back ONLINE !!!" , "Operation Successfull !" , MessageBoxButtons.OK , MessageBoxIcon.Asterisk);
            con.Close();

            pos_online.Visible = true;
            pos_offline.Visible = false;
            btn_fix.Visible = false;

            btn_pos.Enabled = true;
            img_pos_off.Visible = false;
        }

        private void btn_emp_Click(object sender, EventArgs e)
        {
            frm_emp fe = new frm_emp(txt_id_load.Text);
            fe.Show();
            this.Hide();
        }

        private void btn_pos_Click(object sender, EventArgs e)
        {
            frm_pos fpos = new frm_pos(txt_id_load.Text);
            fpos.Show();
            this.Hide();
        }

        private void btn_items_Click(object sender, EventArgs e)
        {
            frm_items fi = new frm_items(txt_id_load.Text);
            fi.Show();
            this.Hide();
        }

        private void btn_lo_Click(object sender, EventArgs e)
        {
            frm_main fm = new frm_main();
            fm.Show();
            this.Hide();
        }

        private void panel_admin_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void btn_cpw_Click(object sender, EventArgs e)
        {
            frm_emp_pwcs fpw = new frm_emp_pwcs(txt_id_load.Text);
            fpw.Show();
        }
    }
}
