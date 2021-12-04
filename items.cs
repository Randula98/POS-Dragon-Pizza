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
    public partial class frm_items : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=RANDULA-MSI\SQLEXPRESS;Initial Catalog=se_db_pzdr;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        string status = "";
        public frm_items(string id_load)
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
            txt_price.Visible = false;
            panel_cash.Visible = false;
            panel_chef.Visible = false;

            if (status == "admin")
            {
                txt_price.Visible = true;
                lbl_admin.Text = "Logged in as an Administrator. FULL ACCESS GRANTED";
            }
            else if (status == "sup")
            {
                panel_sup.Visible = true;
                lbl_sup.Text = "Logged in as a Supervisor. FULL ACCESS GRANTED";
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

        private void frm_items_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'se_db_pzdrDataSet.tbl_items' table. You can move, or remove it, as needed.
            this.tbl_itemsTableAdapter.Fill(this.se_db_pzdrDataSet.tbl_items);
            lbl_date.Text = DateTime.Now.ToLongDateString();
            lbl_time.Text = DateTime.Now.ToLongTimeString();

            txt_n.ReadOnly = true;
            txt_pr.ReadOnly = true;

            txt_n.Enabled = false;
            txt_pr.Enabled = false;

            btn_add.Enabled = false;
            btn_edit.Enabled = false;
            btn_del.Enabled = false;
            btn_save.Enabled = false;

            if (status == "chef")
            {
                btn_del.Visible = false;
            }

            try
            {
                con.Open();
                string view = "SELECT * FROM tbl_items";
                cmd = new SqlCommand(view, con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel_admin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_date.Text = DateTime.Now.ToLongDateString();
            lbl_time.Text = DateTime.Now.ToLongTimeString();
        }

        private void btn_mm_Click(object sender, EventArgs e)
        {
            frm_menu fmm = new frm_menu(txt_id_load.Text);
            fmm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_id_type.Text == "")
            {
                MessageBox.Show("Enter an ID number!!", "No ID number.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    string select = "SELECT * FROM tbl_items WHERE id =  '" + txt_id_type.Text + "' ";
                    cmd = new SqlCommand(select, con);
                    dr = cmd.ExecuteReader();
                    dr.Read();

                    if (dr.HasRows)
                    {
                        txt_n.Enabled = true;
                        txt_pr.Enabled = true;

                        txt_n.Text = dr[1].ToString();
                        txt_pr.Text = dr[2].ToString();

                        btn_edit.Enabled = true;
                        txt_id_type.Enabled = false;
                        btn_scan.Enabled = false;
                        btn_del.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("No Employee Record for the ID number " + txt_id_type.Text + ". A new Item Record can be added if needed", "Empty ID Slot!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btn_add.Enabled = true;
                        txt_id_type.Enabled = false;
                        btn_scan.Enabled = false;

                        txt_n.Enabled = true;
                        txt_pr.Enabled = true;

                        con.Close();
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            status = "add";

            btn_save.Enabled = true;

            txt_n.ReadOnly = false;
            txt_pr.ReadOnly = false;

            btn_add.Enabled = false;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_n.ReadOnly = true;
            txt_pr.ReadOnly = true;

            txt_id_type.Enabled = true;
            txt_n.Enabled = false;
            txt_pr.Enabled = false;

            btn_add.Enabled = false;
            btn_edit.Enabled = false;
            btn_del.Enabled = false;
            btn_save.Enabled = false;
            btn_scan.Enabled = true;

            txt_id_type.Text = "";
            txt_n.Text = "";
            txt_pr.Text = "";

            con.Close();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            status = "edit";

            btn_save.Enabled = true;

            txt_n.ReadOnly = false;
            txt_pr.ReadOnly = false;

            btn_edit.Enabled = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(txt_n.Text == "")
            {
                MessageBox.Show("Enter Item's Name!!", "Empty Details!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txt_pr.Text == "")
            {
                MessageBox.Show("Enter Item's Price!!", "Empty Details!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                { 
                    if (status == "add")
                    {
                        con.Open();
                        string insert = "INSERT INTO tbl_items (ID , Name , Price) VALUES ('" + txt_id_type.Text + "','" + txt_n.Text + "','" + txt_pr.Text + "')";
                        cmd = new SqlCommand(insert, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("You Inserted the data Successfully!!", "New Record Entered!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        con.Close();

                        txt_n.ReadOnly = true;
                        txt_pr.ReadOnly = true;

                        txt_id_type.Enabled = true;
                        txt_n.Enabled = false;
                        txt_pr.Enabled = false;
    
                        btn_add.Enabled = false;
                        btn_edit.Enabled = false;
                        btn_del.Enabled = false;
                        btn_save.Enabled = false;
                        btn_scan.Enabled = true;
                            
                        txt_id_type.Text = "";
                        txt_n.Text = "";
                        txt_pr.Text = "";
                    }
                    else
                    {
                        con.Open();
                        string edit = "UPDATE tbl_items SET Name = '" + txt_n.Text + "', Price = '" + txt_pr.Text + "' WHERE id = '" + txt_id_type.Text + "' ";
                        cmd = new SqlCommand(edit, con);    
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("You Updated the data Successfully!!", "Record Updated!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        con.Close();

                        txt_n.ReadOnly = true;
                        txt_pr.ReadOnly = true;

                        txt_id_type.Enabled = true;
                        txt_n.Enabled = false;
                        txt_pr.Enabled = false;

                        btn_add.Enabled = false;
                        btn_edit.Enabled = false;
                        btn_del.Enabled = false;
                        btn_save.Enabled = false;
                        btn_scan.Enabled = true;

                        txt_id_type.Text = "";
                        txt_n.Text = "";
                        txt_pr.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            try
            {
                con.Open();
                string view = "SELECT * FROM tbl_items";
                cmd = new SqlCommand(view, con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_id_type_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_pr_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    con.Open();
                    string del = "DELETE FROM tbl_items WHERE id = '" + txt_id_type.Text + "' ";
                    cmd = new SqlCommand(del, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted!!", "Confirmed!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    con.Close();

                    txt_n.ReadOnly = true;
                    txt_pr.ReadOnly = true;

                    txt_id_type.Enabled = true;
                    txt_n.Enabled = false;
                    txt_pr.Enabled = false;

                    btn_add.Enabled = false;
                    btn_edit.Enabled = false;
                    btn_del.Enabled = false;
                    btn_save.Enabled = false;
                    btn_scan.Enabled = true;

                    txt_id_type.Text = "";
                    txt_n.Text = "";
                    txt_pr.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            try
            {
                con.Open();
                string view = "SELECT * FROM tbl_items";
                cmd = new SqlCommand(view, con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
