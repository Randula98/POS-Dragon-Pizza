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
    public partial class frm_emp_view : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=RANDULA-MSI\SQLEXPRESS;Initial Catalog=se_db_pzdr;Integrated Security=True");
        SqlCommand cmd;
        public frm_emp_view(string pos)
        {
            InitializeComponent();
            txt_pos.Text = pos;
        }

        private void frm_emp_view_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string view = "SELECT * FROM se_tbl_emp";
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
            dataGridView1.Columns[4].Visible = false;

            if (txt_pos.Text == "sup")
            {
                dataGridView1.Columns[9].Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
