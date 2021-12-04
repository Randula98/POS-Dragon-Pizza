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
    public partial class frm_abu : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=RANDULA-MSI\SQLEXPRESS;Initial Catalog=se_db_pzdr;Integrated Security=True");
        DataSet ds;
        DataTable dt;
        SqlDataAdapter Da;
        int scrolVal = 0;
        public frm_abu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_main fm = new frm_main();
            fm.Show();
            this.Hide();

        }

        private void frm_abu_Load(object sender, EventArgs e)
        {
            lbl_date.Text = DateTime.Now.ToLongDateString();
            lbl_time.Text = DateTime.Now.ToLongTimeString();

            lbl_x.Text = "1";
            lbl_y.Text = "2";

            dbfill1();
            dbfill2();

        }
        private void dbfill1()
        {
            string conString = null;
            SqlConnection con;
            string sql = null;
            sql = "SELECT * FROM tbl_items";
            conString = @"Data Source=RANDULA-MSI\SQLEXPRESS;Initial Catalog=se_db_pzdr;Integrated Security=True";
            con = new SqlConnection(conString);
            Da = new SqlDataAdapter(sql, con);
            ds = new DataSet();
            Da.Fill(ds, scrolVal, 15, "TB1");
            dt = ds.Tables["TB1"];
            dgv_items.DataSource = ds.Tables["TB1"];
            count1();
        }
        private void dbfill2()
        {
            string conString = null;
            SqlConnection con;
            string sql = null;
            sql = "SELECT * FROM se_tbl_emp";
            conString = @"Data Source=RANDULA-MSI\SQLEXPRESS;Initial Catalog=se_db_pzdr;Integrated Security=True";
            con = new SqlConnection(conString);
            Da = new SqlDataAdapter(sql, con);
            ds = new DataSet();
            Da.Fill(ds, scrolVal, 15, "TB2");
            dt = ds.Tables["TB2"];
            dgv_items.DataSource = ds.Tables["TB2"];
            count2();
        }
        private void count1()
        {
            lbl_x.Text = ds.Tables["TB1"].Rows.Count.ToString();
        }
        private void count2()
        {
            lbl_y.Text = ds.Tables["TB2"].Rows.Count.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
