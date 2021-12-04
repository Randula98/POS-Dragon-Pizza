using DGVPrinterHelper;
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
    public partial class frm_pos : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=RANDULA-MSI\SQLEXPRESS;Initial Catalog=se_db_pzdr;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        public frm_pos(string id_load)
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
                    lbl_title.Text = dr[1].ToString();
                    lbl_fname.Text = dr[2].ToString();
                    lbl_age.Text = dr[5].ToString();
                    lbl_contact.Text = dr[6].ToString();
                    txt_pos_load.Text = dr[8].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void frm_pos_Load(object sender, EventArgs e)
        {
            rb_di.Checked = true;
            lbl_date.Text = DateTime.Now.ToLongDateString();
            lbl_time.Text = DateTime.Now.ToLongTimeString();

            txt_id_type.Enabled = false;
            txt_amo.Enabled = false;
            txt_cs.Enabled = false;

            btn_cl.Visible = false;
            btn_pro.Enabled = false;
            btn_bill.Enabled = false;
            btn_eb.Enabled = false;
            btn_cd.Enabled = false;
            btn_cs.Enabled = false;
            btn_gb.Enabled = false;
            btn_print.Enabled = false;
            btn_rid.Enabled = false;

            btn_gb.Visible = false;

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
            btn_mm.Enabled = false;
            btn_cl.Visible = true;
            btn_nb.Enabled = false;
            btn_eb.Enabled = true;

            txt_id_type.Enabled = true;
            btn_pro.Enabled = true;

            con.Open();
            string create = "CREATE TABLE tbl_pos( ID INT PRIMARY KEY NOT NULL, Name VARCHAR(50) NULL, Quantity INT NULL, Price_Rs VARCHAR(5) NULL )";
            cmd = new SqlCommand(create, con);
            cmd.ExecuteNonQuery();
            con.Close();

            try
            {
                con.Open();
                string view = "SELECT * FROM tbl_pos";
                cmd = new SqlCommand(view, con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgv_ps.DataSource = dt;
                con.Close();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void btn_cl_Click(object sender, EventArgs e)
        {
            dgv_ps.DataSource = null;
            btn_mm.Enabled = true;
            btn_nb.Enabled = true;
            btn_cl.Visible = false;
            btn_pro.Enabled = false;
            btn_bill.Enabled = false;
            btn_eb.Enabled = false;
            btn_cd.Enabled = false;
            btn_cs.Enabled = false;
            btn_gb.Enabled = false;
            btn_print.Enabled = false;
            btn_gb.Visible = false;
            btn_rid.Enabled = false;

            txt_id_type.Enabled = false;
            txt_amo.Enabled = false;
            txt_cs.Enabled = false;

            txt_id_type.Text = "";
            txt_name.Text = "";
            txt_amo.Text = "";
            txt_items.Text = "";
            txt_price.Text = "";
            txt_cs.Text = "";
            txt_bal.Text = "";

            con.Open();
            string del = "DROP TABLE tbl_pos";
            cmd = new SqlCommand(del, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void dgv_ps_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_pro_Click(object sender, EventArgs e)
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
                        txt_id_type.Enabled = false;
                        btn_pro.Enabled = false;

                        txt_amo.Enabled = true;
                        btn_bill.Enabled = true;
                        btn_eb.Enabled = false;
                        btn_rid.Enabled = true;

                        txt_name.Text = dr[1].ToString();
                        txt_pr_df.Text = dr[2].ToString();

                    }
                    else
                    {
                        MessageBox.Show("No Item Record for the ID number " + txt_id_type.Text + ". Try Again", "Empty ID Slot!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_id_type.Text = "";
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

        private void btn_bill_Click(object sender, EventArgs e)
        {
            if (txt_id_type.Text == "")
            {
                MessageBox.Show("Enter the Amount!!", "No Amount.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                { 
                double ff, df, amu;

                df = double.Parse(txt_pr_df.Text);
                amu = double.Parse(txt_amo.Text);

                ff = amu * df;

                txt_pr_ff.Text = ff.ToString();

                con.Open();
                string insert = "INSERT INTO tbl_pos (ID , Name , Quantity , Price_Rs) VALUES ('" + txt_id_type.Text + "','" + txt_name.Text + "','" + txt_amo.Text + "','" + txt_pr_ff.Text + "')";
                cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                con.Close();

                txt_id_type.Text = "";
                txt_name.Text = "";
                txt_amo.Text = "";
                txt_amo.Enabled = false;
                btn_bill.Enabled = false;
                btn_eb.Enabled = true;
                btn_pro.Enabled = true;
                txt_id_type.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            try
            {
                con.Open();
                string view = "SELECT * FROM tbl_pos";
                cmd = new SqlCommand(view, con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgv_ps.DataSource = dt;
                con.Close();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
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

        private void txt_am_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_cs_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }

        private void btn_eb_Click(object sender, EventArgs e)
        {
            int C = 0, D = 0;
            for (C = 0; C < dgv_ps.Rows.Count; ++C)
            {
                D += Convert.ToInt32(dgv_ps.Rows[C].Cells[2].Value);
            }
            txt_items.Text = D.ToString();

            int A = 0, B = 0;
            for (A = 0; A < dgv_ps.Rows.Count; ++A)
            {
                B += Convert.ToInt32(dgv_ps.Rows[A].Cells[3].Value);
            }
            txt_gp.Text = B.ToString();

            double gp, mx, tp;

            gp = double.Parse(txt_gp.Text);

            if (rb_di.Checked == true)
            {
                mx = 1.05;
            }
            else if(rb_del.Checked == true)
            {
                mx = 1.10;
            }
            else
            {
                mx = 1;
            }

            tp = gp * mx ;

            txt_price.Text = tp.ToString();

            txt_id_type.Enabled = false;
            btn_cs.Enabled = true;
            btn_cd.Enabled = true;
        }

        private void btn_cd_Click(object sender, EventArgs e)
        {
            btn_pro.Enabled = false;
            btn_bill.Enabled = false;
            btn_eb.Enabled = false;
            btn_cd.Enabled = false;
            btn_cs.Enabled = false;
            btn_gb.Enabled = false;
            btn_print.Enabled = true;

            txt_bal.Text = "00/=";
        }

        private void btn_cs_Click(object sender, EventArgs e)
        {
            btn_pro.Enabled = false;
            btn_bill.Enabled = false;
            btn_eb.Enabled = false;
            btn_cd.Enabled = false;
            btn_cs.Enabled = false;
            btn_gb.Enabled = false;

            txt_cs.Enabled = true;
            btn_gb.Enabled = true;

            btn_gb.Visible = true;
        }

        private void btn_gb_Click(object sender, EventArgs e)
        {
            btn_print.Enabled = true;
            btn_gb.Visible = false;

            double ff, cs, bal;

            ff = double.Parse(txt_price.Text);
            cs = double.Parse(txt_cs.Text);

            bal = cs - ff;

            txt_bal.Text = bal.ToString()+"/=";
        }

        private void txt_gp_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_rid_Click(object sender, EventArgs e)
        {
            txt_id_type.Text = "";
            txt_name.Text = "";
            txt_amo.Text = "";
            txt_amo.Enabled = false;
            btn_bill.Enabled = false;
            btn_eb.Enabled = true;
            btn_pro.Enabled = true;
            txt_id_type.Enabled = true;
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Red Dragon Pizza";
            printer.SubTitle = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = txt_items.Text+" Items. Total Price Rs."+txt_price.Text+"/= Balance Rs." +txt_bal.Text;
            printer.FooterSpacing = 30;
            printer.PrintDataGridView(dgv_ps);
        }
    }
}
