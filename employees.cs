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
    public partial class frm_emp : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=RANDULA-MSI\SQLEXPRESS;Initial Catalog=se_db_pzdr;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        string imgLoc = "";
        string status = "";
        public frm_emp(string id_load)
        {
            InitializeComponent();
            txt_id_load.Text = id_load;

            try
            {
                con.Open();
                String validate = "SELECT * FROM se_tbl_emp WHERE id = '" + txt_id_load.Text + "'";
                cmd = new SqlCommand(validate, con);
                dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    txt_id_load.Text = dr[0].ToString();
                    txt_pos_load.Text = dr[8].ToString();
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
            else if (txt_pos_load.Text == "sup")
            {
                status = "sup";
            }
            else if (txt_pos_load.Text == "chef")
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

            if (status == "admin")
            {
                panel_admin.Visible = true;
                lbl_admin.Text = "Logged in as an Administrator. FULL ACCESS GRANTED";
            }
            else if (status == "sup")
            {
                panel_sup.Visible = true;
                lbl_sup.Text = "Logged in as a Supervisor. LIMITED ACCESS GRANTED";
                btn_del.Visible = false;
            }
            else if (status == "chef")
            {
                panel_chef.Visible = true;
                lbl_chef.Text = "Logged in as an Chef. LIMITED ACCESS GRANTED";
            }
            else
            {
                panel_cash.Visible = true;
                lbl_cash.Text = "Logged in as a Cashier. LIMITED ACCESS GRANTED";
            }
        }

        private void frm_emp_Load(object sender, EventArgs e)
        {
            lbl_date.Text = DateTime.Now.ToLongDateString();
            lbl_time.Text = DateTime.Now.ToLongTimeString();

            btn_add.Enabled = false;
            btn_del.Enabled = false;
            btn_edit.Enabled = false;
            btn_brws.Enabled = false;
            btn_save.Enabled = false;

            if (txt_pos_load.Text == "sup")
            {
                txt_pw.Visible = false;
                rb_admin.Visible = false;
                rb_sup.Visible = false;
                rb_chef.Visible = false;
                rb_cash.Visible = false;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_date.Text = DateTime.Now.ToLongDateString();
            lbl_time.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_menu fmm = new frm_menu(txt_id_load.Text);
            fmm.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            status = "edit";

            txt_id.ReadOnly = false;
            txt_fname.ReadOnly = false;
            txt_lname.ReadOnly = false;
            txt_age.ReadOnly = false;
            txt_contact.ReadOnly = false;
            txt_address.ReadOnly = false;
            txt_pos.ReadOnly = false;
            txt_pw.ReadOnly = false;

            btn_edit.Enabled = false;
            btn_save.Enabled = true;
            btn_brws.Enabled = true;
        }

        private void btn_scan_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "")
            {
                MessageBox.Show("Enter an ID number!!", "No ID number.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                try
                {
                    con.Open();
                    String validate = "SELECT * FROM se_tbl_emp WHERE id = '" + txt_id.Text + "'";
                    if (con.State != ConnectionState.Open)
                        con.Open();
                    cmd = new SqlCommand(validate, con);
                    dr = cmd.ExecuteReader();
                    dr.Read();

                    if (dr.HasRows)
                    {
                        txt_title.Text = dr[1].ToString();
                        txt_fname.Text = dr[2].ToString();
                        txt_lname.Text = dr[3].ToString();
                        txt_age.Text = dr[5].ToString();
                        txt_contact.Text = dr[6].ToString();
                        txt_address.Text = dr[7].ToString();
                        txt_pos.Text = dr[8].ToString();
                        txt_pw.Text = dr[9].ToString();

                        txt_id.Enabled = false;
                        btn_scan.Enabled = false;

                        btn_del.Enabled = true;
                        btn_edit.Enabled = true;

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
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("No Employee Record for the ID number " + txt_id.Text + ". A new Employee Record can be added if needed", "Empty ID Slot!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btn_add.Enabled = true;
                        txt_id.Enabled = false;
                        btn_scan.Enabled = false;

                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_id.Text = "";
            txt_title.Text = "";
            txt_fname.Text = "";
            txt_lname.Text = "";
            txt_age.Text = "";
            txt_contact.Text = "";
            txt_address.Text = "";
            txt_pos.Text = "";
            txt_pw.Text = "";
            img_emp.Image = null;

            txt_id.Enabled = true;
            btn_scan.Enabled = true;

            btn_add.Enabled = false;
            btn_del.Enabled = false;
            btn_edit.Enabled = false;
            btn_brws.Enabled = false;
            btn_save.Enabled = false;

            txt_title.ReadOnly = true;
            txt_fname.ReadOnly = true;
            txt_lname.ReadOnly = true;
            txt_age.ReadOnly = true;
            txt_contact.ReadOnly = true;
            txt_address.ReadOnly = true;
            txt_pos.ReadOnly = true;
            txt_pw.ReadOnly = true;

            rb_mr.Checked = false;
            rbmrs.Checked = false;
            rbmiss.Checked = false;


            if (txt_pos_load.Text == "sup")
            {
                txt_pw.Visible = false;
            }

            con.Close();
        }

        private void txt_id_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            status = "add";

            txt_fname.ReadOnly = false;
            txt_lname.ReadOnly = false;
            txt_age.ReadOnly = false;
            txt_contact.ReadOnly = false;
            txt_address.ReadOnly = false;
            txt_pw.ReadOnly = false;

            txt_title.Enabled = true;
            txt_fname.Enabled = true;
            txt_lname.Enabled = true;
            txt_age.Enabled = true;
            txt_contact.Enabled = true;
            txt_address.Enabled = true;
            txt_pos.Enabled = true;
            txt_pw.Enabled = true;

            btn_add.Enabled = false;
            btn_brws.Enabled = true;
            btn_save.Enabled = true;

            txt_pw.Visible = true;
        }

        private void txt_age_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_contact_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Select Image";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    img_emp.ImageLocation = imgLoc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_title.Text == "")
            {
                MessageBox.Show("Select the title!!", "Empty Details!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_fname.Text == "")
            {
                MessageBox.Show("Enter First Name!!", "Empty Details!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_lname.Text == "")
            {
                MessageBox.Show("Enter Last Name!!", "Empty Details!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (img_emp.Image == null)
            {
                MessageBox.Show("Select an Image!!", "Empty Details!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_age.Text == "")
            {
                MessageBox.Show("Enter the Age!!", "Empty Details!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_contact.Text == "")
            {
                MessageBox.Show("Enter the Contact Number!!", "Empty Details!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_address.Text == "")
            {
                MessageBox.Show("Enter the Address!!", "Empty Details!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_pos.Text == "")
            {
                MessageBox.Show("Select the Employee Position!!", "Empty Details!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_pw.Text == "")
            {
                MessageBox.Show("Enter the Password!!", "Empty Details!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                {
                    if (status == "add")
                    {
                        try
                        {
                            byte[] img = null;
                            FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                            BinaryReader br = new BinaryReader(fs);
                            img = br.ReadBytes((int)fs.Length);
                            string add = "INSERT INTO se_tbl_emp (id , title , f_name , l_name , img , age , contact , address , position , password) VALUES (" + txt_id.Text + ", '" + txt_title.Text + "' , '" + txt_fname.Text + "' , '" + txt_lname.Text + "' , @img , " + txt_age.Text + " , '" + txt_contact.Text + "' , '" + txt_address.Text + "' , '" + txt_pos.Text + "' , '" + txt_pw.Text + "')";
                            if (con.State != ConnectionState.Open)
                                con.Open();
                            cmd = new SqlCommand(add, con);
                            cmd.Parameters.Add(new SqlParameter("@img", img));
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("You inserted the data Successfully!!", "New Record Entered!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            txt_id.Text = "";
                            txt_title.Text = "";
                            txt_fname.Text = "";
                            txt_lname.Text = "";
                            txt_age.Text = "";
                            txt_contact.Text = "";
                            txt_address.Text = "";
                            txt_pos.Text = "";
                            txt_pw.Text = "";
                            img_emp.Image = null;

                            txt_id.Enabled = true;
                            btn_scan.Enabled = true;

                            btn_add.Enabled = false;
                            btn_del.Enabled = false;
                            btn_edit.Enabled = false;
                            btn_brws.Enabled = false;
                            btn_save.Enabled = false;

                            txt_title.ReadOnly = true;
                            txt_fname.ReadOnly = true;
                            txt_lname.ReadOnly = true;
                            txt_age.ReadOnly = true;
                            txt_contact.ReadOnly = true;
                            txt_address.ReadOnly = true;
                            txt_pos.ReadOnly = true;
                            txt_pw.ReadOnly = true;

                            if (txt_pos_load.Text == "sup")
                            {
                                txt_pw.Visible = false;
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        con.Close();
                    }
                    else
                    {
                        try
                        {
                            con.Open();
                            MemoryStream ms = new MemoryStream();
                            img_emp.Image.Save(ms, img_emp.Image.RawFormat);
                            byte[] img = ms.ToArray();

                            string edit = "UPDATE se_tbl_emp SET title = '" + txt_title.Text + "', f_name = '" + txt_fname.Text + "', l_name = '" + txt_lname.Text + "' , img = @img , age = '" + txt_age.Text + "' , contact = '" + txt_contact.Text + "' , address = '" + txt_address.Text + "' , position = '" + txt_pos.Text + "' , password = '" + txt_pw.Text + "' WHERE id = '" + txt_id.Text + "' ";
                            cmd = new SqlCommand(edit, con);
                            cmd.Parameters.Add(new SqlParameter("@img", img));

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Data has been updated Successfully!!", "Record Updated!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            con.Close();

                            txt_id.Text = "";
                            txt_title.Text = "";
                            txt_fname.Text = "";
                            txt_lname.Text = "";
                            txt_age.Text = "";
                            txt_contact.Text = "";
                            txt_address.Text = "";
                            txt_pos.Text = "";
                            txt_pw.Text = "";
                            img_emp.Image = null;

                            txt_id.Enabled = true;
                            btn_scan.Enabled = true;

                            btn_add.Enabled = false;
                            btn_del.Enabled = false;
                            btn_edit.Enabled = false;
                            btn_brws.Enabled = false;
                            btn_save.Enabled = false;

                            txt_title.ReadOnly = true;
                            txt_fname.ReadOnly = true;
                            txt_lname.ReadOnly = true;
                            txt_age.ReadOnly = true;
                            txt_contact.ReadOnly = true;
                            txt_address.ReadOnly = true;
                            txt_pos.ReadOnly = true;
                            txt_pw.ReadOnly = true;

                            rb_mr.Checked = false;
                            rbmrs.Checked = false;
                            rbmiss.Checked = false;

                            if (txt_pos_load.Text == "sup")
                            {
                                txt_pw.Visible = false;
                            }
                        }
                        catch (Exception ex)
                        {
                            con.Close();
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you Sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    con.Open();
                    string del = "DELETE FROM se_tbl_emp WHERE id = '" + txt_id.Text + "' ";
                    cmd = new SqlCommand(del, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted!!", "Confirmed!!", MessageBoxButtons.OK, MessageBoxIcon.Information );

                    con.Close();

                    txt_id.Text = "";
                    txt_title.Text = "";
                    txt_fname.Text = "";
                    txt_lname.Text = "";
                    txt_age.Text = "";
                    txt_contact.Text = "";
                    txt_address.Text = "";
                    txt_pos.Text = "";
                    txt_pw.Text = "";
                    img_emp.Image = null;

                    txt_id.Enabled = true;
                    btn_scan.Enabled = true;

                    btn_add.Enabled = false;
                    btn_del.Enabled = false;
                    btn_edit.Enabled = false;
                    btn_brws.Enabled = false;
                    btn_save.Enabled = false;

                    txt_title.ReadOnly = true;
                    txt_fname.ReadOnly = true;
                    txt_lname.ReadOnly = true;
                    txt_age.ReadOnly = true;
                    txt_contact.ReadOnly = true;
                    txt_address.ReadOnly = true;
                    txt_pos.ReadOnly = true;
                    txt_pw.ReadOnly = true;

                    rb_mr.Checked = false;
                    rbmrs.Checked = false;
                    rbmiss.Checked = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }            
        }

        private void rb_mr_CheckedChanged(object sender, EventArgs e)
        {
            txt_title.Text = "Mr.";
            rbmrs.Checked = false;
            rbmiss.Checked = false;
        }

        private void rbmrs_CheckedChanged(object sender, EventArgs e)
        {
            txt_title.Text = "Mrs.";
            rb_mr.Checked = false;
            rbmiss.Checked = false;
        }

        private void rbmiss_CheckedChanged(object sender, EventArgs e)
        {
            txt_title.Text = "Miss.";
            rb_mr.Checked = false;
            rbmrs.Checked = false;
        }

        private void txt_pos_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rb_admin_CheckedChanged(object sender, EventArgs e)
        {
            txt_pos.Text = "admin";
            rb_sup.Checked = false;
            rb_chef.Checked = false;
            rb_cash.Checked = false;
        }

        private void rb_sup_CheckedChanged(object sender, EventArgs e)
        {
            txt_pos.Text = "sup";
            rb_admin.Checked = false;
            rb_chef.Checked = false;
            rb_cash.Checked = false;
        }

        private void rb_chef_CheckedChanged(object sender, EventArgs e)
        {
            txt_pos.Text = "chef";
            rb_admin.Checked = false;
            rb_sup.Checked = false;
            rb_cash.Checked = false;
        }

        private void rb_cash_CheckedChanged(object sender, EventArgs e)
        {
            txt_pos.Text = "cash";
            rb_admin.Checked = false;
            rb_sup.Checked = false;
            rb_chef.Checked = false;
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            frm_emp_view fev = new frm_emp_view(txt_pos_load.Text);
            fev.Show();
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
