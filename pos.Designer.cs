using System;

namespace project_pos
{
    partial class frm_pos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_pos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_pos = new System.Windows.Forms.Panel();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.txt_id_load = new System.Windows.Forms.TextBox();
            this.lbl_contact = new System.Windows.Forms.Label();
            this.txt_pos_load = new System.Windows.Forms.TextBox();
            this.lbl_age = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_mm = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_nb = new System.Windows.Forms.Button();
            this.btn_cl = new System.Windows.Forms.Button();
            this.dgv_ps = new System.Windows.Forms.DataGridView();
            this.se_db_pzdrDataSet3 = new project_pos.se_db_pzdrDataSet3();
            this.tblposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_posTableAdapter = new project_pos.se_db_pzdrDataSet3TableAdapters.tbl_posTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_cs = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_cd = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_bill = new System.Windows.Forms.Button();
            this.btn_pro = new System.Windows.Forms.Button();
            this.btn_eb = new System.Windows.Forms.Button();
            this.txt_id_type = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_bal = new System.Windows.Forms.TextBox();
            this.txt_cs = new System.Windows.Forms.TextBox();
            this.txt_items = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_amo = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_gb = new System.Windows.Forms.Button();
            this.txt_gp = new System.Windows.Forms.TextBox();
            this.rb_di = new System.Windows.Forms.RadioButton();
            this.rb_tw = new System.Windows.Forms.RadioButton();
            this.rb_del = new System.Windows.Forms.RadioButton();
            this.txt_pr_df = new System.Windows.Forms.TextBox();
            this.txt_pr_ff = new System.Windows.Forms.TextBox();
            this.btn_rid = new System.Windows.Forms.Button();
            this.dgv_pos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.se_db_pzdrDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblposBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.BackColor = System.Drawing.Color.RosyBrown;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(1652, 50);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(78, 32);
            this.lbl_time.TabIndex = 45;
            this.lbl_time.Text = "Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(723, 134);
            this.label1.TabIndex = 44;
            this.label1.Text = "The Best Place To Full Fill Your \r\nPizza Cravings\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_pos
            // 
            this.dgv_pos.BackColor = System.Drawing.Color.RosyBrown;
            this.dgv_pos.Controls.Add(this.lbl_fname);
            this.dgv_pos.Controls.Add(this.txt_id_load);
            this.dgv_pos.Controls.Add(this.lbl_contact);
            this.dgv_pos.Controls.Add(this.txt_pos_load);
            this.dgv_pos.Controls.Add(this.lbl_age);
            this.dgv_pos.Controls.Add(this.lbl_date);
            this.dgv_pos.Controls.Add(this.lbl_title);
            this.dgv_pos.Controls.Add(this.pictureBox1);
            this.dgv_pos.Controls.Add(this.lbl_time);
            this.dgv_pos.Controls.Add(this.label1);
            this.dgv_pos.Location = new System.Drawing.Point(12, 12);
            this.dgv_pos.Name = "dgv_pos";
            this.dgv_pos.Size = new System.Drawing.Size(2143, 200);
            this.dgv_pos.TabIndex = 46;
            // 
            // lbl_fname
            // 
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fname.Location = new System.Drawing.Point(1211, 20);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(112, 36);
            this.lbl_fname.TabIndex = 53;
            this.lbl_fname.Text = "f_name";
            // 
            // txt_id_load
            // 
            this.txt_id_load.Enabled = false;
            this.txt_id_load.Location = new System.Drawing.Point(500, 157);
            this.txt_id_load.Name = "txt_id_load";
            this.txt_id_load.ReadOnly = true;
            this.txt_id_load.Size = new System.Drawing.Size(100, 22);
            this.txt_id_load.TabIndex = 16;
            this.txt_id_load.Visible = false;
            // 
            // lbl_contact
            // 
            this.lbl_contact.AutoSize = true;
            this.lbl_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contact.Location = new System.Drawing.Point(1142, 137);
            this.lbl_contact.Name = "lbl_contact";
            this.lbl_contact.Size = new System.Drawing.Size(111, 36);
            this.lbl_contact.TabIndex = 54;
            this.lbl_contact.Text = "contact";
            // 
            // txt_pos_load
            // 
            this.txt_pos_load.Enabled = false;
            this.txt_pos_load.Location = new System.Drawing.Point(693, 157);
            this.txt_pos_load.Name = "txt_pos_load";
            this.txt_pos_load.ReadOnly = true;
            this.txt_pos_load.Size = new System.Drawing.Size(100, 22);
            this.txt_pos_load.TabIndex = 16;
            this.txt_pos_load.Visible = false;
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_age.Location = new System.Drawing.Point(1142, 79);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(64, 36);
            this.lbl_age.TabIndex = 55;
            this.lbl_age.Text = "age";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.Color.RosyBrown;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(1653, 110);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(53, 25);
            this.lbl_date.TabIndex = 3;
            this.lbl_date.Text = "Date";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(1142, 20);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(73, 36);
            this.lbl_title.TabIndex = 56;
            this.lbl_title.Text = "Mrs.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_mm
            // 
            this.btn_mm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_mm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mm.Location = new System.Drawing.Point(1720, 240);
            this.btn_mm.Name = "btn_mm";
            this.btn_mm.Size = new System.Drawing.Size(150, 70);
            this.btn_mm.TabIndex = 52;
            this.btn_mm.Text = "Go Back To \r\nMain Menu\r\n";
            this.btn_mm.UseVisualStyleBackColor = false;
            this.btn_mm.Click += new System.EventHandler(this.btn_mm_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 32);
            this.label2.TabIndex = 53;
            this.label2.Text = "Item ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 32);
            this.label3.TabIndex = 53;
            this.label3.Text = "Item Name :";
            // 
            // btn_nb
            // 
            this.btn_nb.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_nb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nb.Location = new System.Drawing.Point(80, 231);
            this.btn_nb.Name = "btn_nb";
            this.btn_nb.Size = new System.Drawing.Size(136, 70);
            this.btn_nb.TabIndex = 55;
            this.btn_nb.Text = "New Bill";
            this.btn_nb.UseVisualStyleBackColor = false;
            this.btn_nb.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_cl
            // 
            this.btn_cl.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_cl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cl.Location = new System.Drawing.Point(1508, 237);
            this.btn_cl.Name = "btn_cl";
            this.btn_cl.Size = new System.Drawing.Size(150, 70);
            this.btn_cl.TabIndex = 56;
            this.btn_cl.Text = "Clear";
            this.btn_cl.UseVisualStyleBackColor = false;
            this.btn_cl.Click += new System.EventHandler(this.btn_cl_Click);
            // 
            // dgv_ps
            // 
            this.dgv_ps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ps.Location = new System.Drawing.Point(1184, 377);
            this.dgv_ps.Name = "dgv_ps";
            this.dgv_ps.ReadOnly = true;
            this.dgv_ps.RowTemplate.Height = 24;
            this.dgv_ps.Size = new System.Drawing.Size(745, 492);
            this.dgv_ps.TabIndex = 57;
            // 
            // se_db_pzdrDataSet3
            // 
            this.se_db_pzdrDataSet3.DataSetName = "se_db_pzdrDataSet3";
            this.se_db_pzdrDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblposBindingSource
            // 
            this.tblposBindingSource.DataMember = "tbl_pos";
            this.tblposBindingSource.DataSource = this.se_db_pzdrDataSet3;
            // 
            // tbl_posTableAdapter
            // 
            this.tbl_posTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 522);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 32);
            this.label4.TabIndex = 53;
            this.label4.Text = "Amount :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 690);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 32);
            this.label5.TabIndex = 53;
            this.label5.Text = "Total Items:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(749, 855);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 44);
            this.label8.TabIndex = 53;
            this.label8.Text = "Balance :";
            // 
            // btn_cs
            // 
            this.btn_cs.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_cs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cs.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cs.Location = new System.Drawing.Point(341, 775);
            this.btn_cs.Name = "btn_cs";
            this.btn_cs.Size = new System.Drawing.Size(135, 55);
            this.btn_cs.TabIndex = 58;
            this.btn_cs.Text = "CASH";
            this.btn_cs.UseVisualStyleBackColor = false;
            this.btn_cs.Click += new System.EventHandler(this.btn_cs_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 781);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 32);
            this.label6.TabIndex = 53;
            this.label6.Text = "Payment Method :";
            // 
            // btn_cd
            // 
            this.btn_cd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_cd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cd.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cd.Location = new System.Drawing.Point(511, 775);
            this.btn_cd.Name = "btn_cd";
            this.btn_cd.Size = new System.Drawing.Size(135, 55);
            this.btn_cd.TabIndex = 59;
            this.btn_cd.Text = "CARD";
            this.btn_cd.UseVisualStyleBackColor = false;
            this.btn_cd.Click += new System.EventHandler(this.btn_cd_Click);
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_print.Location = new System.Drawing.Point(1184, 915);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(135, 55);
            this.btn_print.TabIndex = 60;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_bill
            // 
            this.btn_bill.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_bill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bill.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_bill.Location = new System.Drawing.Point(468, 510);
            this.btn_bill.Name = "btn_bill";
            this.btn_bill.Size = new System.Drawing.Size(220, 61);
            this.btn_bill.TabIndex = 62;
            this.btn_bill.Text = "Add to the Bill";
            this.btn_bill.UseVisualStyleBackColor = false;
            this.btn_bill.Click += new System.EventHandler(this.btn_bill_Click);
            // 
            // btn_pro
            // 
            this.btn_pro.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_pro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pro.Location = new System.Drawing.Point(459, 337);
            this.btn_pro.Name = "btn_pro";
            this.btn_pro.Size = new System.Drawing.Size(153, 61);
            this.btn_pro.TabIndex = 63;
            this.btn_pro.Text = "Process\r\n";
            this.btn_pro.UseVisualStyleBackColor = false;
            this.btn_pro.Click += new System.EventHandler(this.btn_pro_Click);
            // 
            // btn_eb
            // 
            this.btn_eb.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_eb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eb.Location = new System.Drawing.Point(255, 600);
            this.btn_eb.Name = "btn_eb";
            this.btn_eb.Size = new System.Drawing.Size(220, 54);
            this.btn_eb.TabIndex = 64;
            this.btn_eb.Text = "End Bill";
            this.btn_eb.UseVisualStyleBackColor = false;
            this.btn_eb.Click += new System.EventHandler(this.btn_eb_Click);
            // 
            // txt_id_type
            // 
            this.txt_id_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_type.Location = new System.Drawing.Point(255, 355);
            this.txt_id_type.Multiline = true;
            this.txt_id_type.Name = "txt_id_type";
            this.txt_id_type.Size = new System.Drawing.Size(158, 32);
            this.txt_id_type.TabIndex = 65;
            this.txt_id_type.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_type_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(462, 690);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 32);
            this.label7.TabIndex = 53;
            this.label7.Text = "Total Price:";
            // 
            // txt_bal
            // 
            this.txt_bal.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bal.Location = new System.Drawing.Point(933, 855);
            this.txt_bal.Multiline = true;
            this.txt_bal.Name = "txt_bal";
            this.txt_bal.ReadOnly = true;
            this.txt_bal.Size = new System.Drawing.Size(158, 51);
            this.txt_bal.TabIndex = 66;
            // 
            // txt_cs
            // 
            this.txt_cs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cs.Location = new System.Drawing.Point(341, 858);
            this.txt_cs.Multiline = true;
            this.txt_cs.Name = "txt_cs";
            this.txt_cs.Size = new System.Drawing.Size(134, 32);
            this.txt_cs.TabIndex = 66;
            this.txt_cs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cs_KeyPress);
            // 
            // txt_items
            // 
            this.txt_items.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_items.Location = new System.Drawing.Point(255, 690);
            this.txt_items.Multiline = true;
            this.txt_items.Name = "txt_items";
            this.txt_items.ReadOnly = true;
            this.txt_items.Size = new System.Drawing.Size(134, 32);
            this.txt_items.TabIndex = 66;
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(639, 690);
            this.txt_price.Multiline = true;
            this.txt_price.Name = "txt_price";
            this.txt_price.ReadOnly = true;
            this.txt_price.Size = new System.Drawing.Size(134, 32);
            this.txt_price.TabIndex = 66;
            // 
            // txt_amo
            // 
            this.txt_amo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amo.Location = new System.Drawing.Point(255, 522);
            this.txt_amo.Multiline = true;
            this.txt_amo.Name = "txt_amo";
            this.txt_amo.Size = new System.Drawing.Size(158, 32);
            this.txt_amo.TabIndex = 66;
            this.txt_amo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_am_KeyPress);
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(255, 439);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            this.txt_name.Size = new System.Drawing.Size(433, 32);
            this.txt_name.TabIndex = 66;
            // 
            // btn_gb
            // 
            this.btn_gb.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gb.Location = new System.Drawing.Point(341, 915);
            this.btn_gb.Name = "btn_gb";
            this.btn_gb.Size = new System.Drawing.Size(176, 50);
            this.btn_gb.TabIndex = 67;
            this.btn_gb.Text = "Get Balance";
            this.btn_gb.UseVisualStyleBackColor = false;
            this.btn_gb.Click += new System.EventHandler(this.btn_gb_Click);
            // 
            // txt_gp
            // 
            this.txt_gp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gp.Location = new System.Drawing.Point(500, 610);
            this.txt_gp.Multiline = true;
            this.txt_gp.Name = "txt_gp";
            this.txt_gp.Size = new System.Drawing.Size(134, 32);
            this.txt_gp.TabIndex = 66;
            this.txt_gp.Text = "gloss pr";
            this.txt_gp.Visible = false;
            this.txt_gp.TextChanged += new System.EventHandler(this.txt_gp_TextChanged);
            // 
            // rb_di
            // 
            this.rb_di.AutoSize = true;
            this.rb_di.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_di.Location = new System.Drawing.Point(282, 254);
            this.rb_di.Name = "rb_di";
            this.rb_di.Size = new System.Drawing.Size(127, 36);
            this.rb_di.TabIndex = 68;
            this.rb_di.TabStop = true;
            this.rb_di.Text = "Dine-In";
            this.rb_di.UseVisualStyleBackColor = true;
            // 
            // rb_tw
            // 
            this.rb_tw.AutoSize = true;
            this.rb_tw.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_tw.Location = new System.Drawing.Point(456, 254);
            this.rb_tw.Name = "rb_tw";
            this.rb_tw.Size = new System.Drawing.Size(165, 36);
            this.rb_tw.TabIndex = 68;
            this.rb_tw.TabStop = true;
            this.rb_tw.Text = "Takeaway";
            this.rb_tw.UseVisualStyleBackColor = true;
            // 
            // rb_del
            // 
            this.rb_del.AutoSize = true;
            this.rb_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_del.Location = new System.Drawing.Point(661, 254);
            this.rb_del.Name = "rb_del";
            this.rb_del.Size = new System.Drawing.Size(139, 36);
            this.rb_del.TabIndex = 68;
            this.rb_del.TabStop = true;
            this.rb_del.Text = "Delivery";
            this.rb_del.UseVisualStyleBackColor = true;
            // 
            // txt_pr_df
            // 
            this.txt_pr_df.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pr_df.Location = new System.Drawing.Point(728, 439);
            this.txt_pr_df.Multiline = true;
            this.txt_pr_df.Name = "txt_pr_df";
            this.txt_pr_df.Size = new System.Drawing.Size(134, 32);
            this.txt_pr_df.TabIndex = 66;
            this.txt_pr_df.Text = "df price";
            this.txt_pr_df.Visible = false;
            // 
            // txt_pr_ff
            // 
            this.txt_pr_ff.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pr_ff.Location = new System.Drawing.Point(728, 525);
            this.txt_pr_ff.Multiline = true;
            this.txt_pr_ff.Name = "txt_pr_ff";
            this.txt_pr_ff.Size = new System.Drawing.Size(134, 32);
            this.txt_pr_ff.TabIndex = 66;
            this.txt_pr_ff.Text = "f price";
            this.txt_pr_ff.Visible = false;
            // 
            // btn_rid
            // 
            this.btn_rid.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_rid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rid.Location = new System.Drawing.Point(639, 337);
            this.btn_rid.Name = "btn_rid";
            this.btn_rid.Size = new System.Drawing.Size(134, 50);
            this.btn_rid.TabIndex = 69;
            this.btn_rid.Text = "Reset ID";
            this.btn_rid.UseVisualStyleBackColor = false;
            this.btn_rid.Click += new System.EventHandler(this.btn_rid_Click);
            // 
            // frm_pos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1920, 1007);
            this.ControlBox = false;
            this.Controls.Add(this.btn_rid);
            this.Controls.Add(this.rb_del);
            this.Controls.Add(this.rb_tw);
            this.Controls.Add(this.rb_di);
            this.Controls.Add(this.btn_gb);
            this.Controls.Add(this.txt_pr_ff);
            this.Controls.Add(this.txt_pr_df);
            this.Controls.Add(this.txt_gp);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_amo);
            this.Controls.Add(this.txt_items);
            this.Controls.Add(this.txt_cs);
            this.Controls.Add(this.txt_bal);
            this.Controls.Add(this.txt_id_type);
            this.Controls.Add(this.btn_eb);
            this.Controls.Add(this.btn_pro);
            this.Controls.Add(this.btn_bill);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_cd);
            this.Controls.Add(this.btn_cs);
            this.Controls.Add(this.dgv_ps);
            this.Controls.Add(this.btn_cl);
            this.Controls.Add(this.btn_nb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_mm);
            this.Controls.Add(this.dgv_pos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frm_pos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point Of Sale System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_pos_Load);
            this.dgv_pos.ResumeLayout(false);
            this.dgv_pos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.se_db_pzdrDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblposBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel dgv_pos;
        private System.Windows.Forms.TextBox txt_id_load;
        private System.Windows.Forms.TextBox txt_pos_load;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_mm;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_fname;
        private System.Windows.Forms.Label lbl_contact;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_nb;
        private System.Windows.Forms.Button btn_cl;
        private System.Windows.Forms.DataGridView dgv_ps;
        private se_db_pzdrDataSet3 se_db_pzdrDataSet3;
        private se_db_pzdrDataSet3TableAdapters.tbl_posTableAdapter tbl_posTableAdapter;
        private System.Windows.Forms.BindingSource tblposBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_cs;
        private System.Windows.Forms.Button btn_cd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_bill;
        private System.Windows.Forms.Button btn_pro;
        private System.Windows.Forms.Button btn_eb;
        private System.Windows.Forms.TextBox txt_id_type;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_bal;
        private System.Windows.Forms.TextBox txt_cs;
        private System.Windows.Forms.TextBox txt_items;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_amo;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_gb;
        private System.Windows.Forms.TextBox txt_gp;
        private System.Windows.Forms.RadioButton rb_di;
        private System.Windows.Forms.RadioButton rb_tw;
        private System.Windows.Forms.RadioButton rb_del;
        private System.Windows.Forms.TextBox txt_pr_df;
        private System.Windows.Forms.TextBox txt_pr_ff;
        private System.Windows.Forms.Button btn_rid;
    }
}