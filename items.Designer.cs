namespace project_pos
{
    partial class frm_items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_items));
            this.txt_price = new System.Windows.Forms.Panel();
            this.lbl_admin = new System.Windows.Forms.Label();
            this.panel_cash = new System.Windows.Forms.Panel();
            this.lbl_cash = new System.Windows.Forms.Label();
            this.panel_chef = new System.Windows.Forms.Panel();
            this.lbl_chef = new System.Windows.Forms.Label();
            this.panel_sup = new System.Windows.Forms.Panel();
            this.lbl_sup = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_id_load = new System.Windows.Forms.TextBox();
            this.txt_pos_load = new System.Windows.Forms.TextBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_mm = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblitemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.se_db_pzdrDataSet = new project_pos.se_db_pzdrDataSet();
            this.btn_scan = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.txt_pr = new System.Windows.Forms.TextBox();
            this.txt_n = new System.Windows.Forms.TextBox();
            this.txt_id_type = new System.Windows.Forms.TextBox();
            this.tbl_itemsTableAdapter = new project_pos.se_db_pzdrDataSetTableAdapters.tbl_itemsTableAdapter();
            this.txt_price.SuspendLayout();
            this.panel_cash.SuspendLayout();
            this.panel_chef.SuspendLayout();
            this.panel_sup.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblitemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.se_db_pzdrDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_price
            // 
            this.txt_price.BackColor = System.Drawing.Color.DarkCyan;
            this.txt_price.Controls.Add(this.lbl_admin);
            this.txt_price.Location = new System.Drawing.Point(4, 218);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(1351, 143);
            this.txt_price.TabIndex = 44;
            this.txt_price.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_admin_Paint);
            // 
            // lbl_admin
            // 
            this.lbl_admin.AutoSize = true;
            this.lbl_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_admin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_admin.Location = new System.Drawing.Point(79, 45);
            this.lbl_admin.Name = "lbl_admin";
            this.lbl_admin.Size = new System.Drawing.Size(421, 51);
            this.lbl_admin.TabIndex = 0;
            this.lbl_admin.Text = "ACCESS GRANTED";
            // 
            // panel_cash
            // 
            this.panel_cash.BackColor = System.Drawing.Color.LimeGreen;
            this.panel_cash.Controls.Add(this.lbl_cash);
            this.panel_cash.Location = new System.Drawing.Point(7, 219);
            this.panel_cash.Name = "panel_cash";
            this.panel_cash.Size = new System.Drawing.Size(1351, 143);
            this.panel_cash.TabIndex = 45;
            // 
            // lbl_cash
            // 
            this.lbl_cash.AutoSize = true;
            this.lbl_cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cash.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_cash.Location = new System.Drawing.Point(76, 45);
            this.lbl_cash.Name = "lbl_cash";
            this.lbl_cash.Size = new System.Drawing.Size(421, 51);
            this.lbl_cash.TabIndex = 0;
            this.lbl_cash.Text = "ACCESS GRANTED";
            // 
            // panel_chef
            // 
            this.panel_chef.BackColor = System.Drawing.Color.Gold;
            this.panel_chef.Controls.Add(this.lbl_chef);
            this.panel_chef.Location = new System.Drawing.Point(7, 219);
            this.panel_chef.Name = "panel_chef";
            this.panel_chef.Size = new System.Drawing.Size(1351, 143);
            this.panel_chef.TabIndex = 46;
            // 
            // lbl_chef
            // 
            this.lbl_chef.AutoSize = true;
            this.lbl_chef.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chef.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_chef.Location = new System.Drawing.Point(89, 45);
            this.lbl_chef.Name = "lbl_chef";
            this.lbl_chef.Size = new System.Drawing.Size(421, 51);
            this.lbl_chef.TabIndex = 0;
            this.lbl_chef.Text = "ACCESS GRANTED";
            // 
            // panel_sup
            // 
            this.panel_sup.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel_sup.Controls.Add(this.lbl_sup);
            this.panel_sup.Location = new System.Drawing.Point(7, 219);
            this.panel_sup.Name = "panel_sup";
            this.panel_sup.Size = new System.Drawing.Size(1351, 143);
            this.panel_sup.TabIndex = 47;
            // 
            // lbl_sup
            // 
            this.lbl_sup.AutoSize = true;
            this.lbl_sup.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_sup.Location = new System.Drawing.Point(65, 45);
            this.lbl_sup.Name = "lbl_sup";
            this.lbl_sup.Size = new System.Drawing.Size(421, 51);
            this.lbl_sup.TabIndex = 0;
            this.lbl_sup.Text = "ACCESS GRANTED";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.BackColor = System.Drawing.Color.RosyBrown;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(1059, 40);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(78, 32);
            this.lbl_time.TabIndex = 42;
            this.lbl_time.Text = "Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(723, 134);
            this.label1.TabIndex = 41;
            this.label1.Text = "The Best Place To Full Fill Your \r\nPizza Cravings\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.txt_id_load);
            this.panel1.Controls.Add(this.txt_pos_load);
            this.panel1.Controls.Add(this.lbl_date);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_time);
            this.panel1.Location = new System.Drawing.Point(4, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1354, 200);
            this.panel1.TabIndex = 43;
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
            // txt_pos_load
            // 
            this.txt_pos_load.Enabled = false;
            this.txt_pos_load.Location = new System.Drawing.Point(753, 157);
            this.txt_pos_load.Name = "txt_pos_load";
            this.txt_pos_load.ReadOnly = true;
            this.txt_pos_load.Size = new System.Drawing.Size(100, 22);
            this.txt_pos_load.TabIndex = 16;
            this.txt_pos_load.Visible = false;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.Color.RosyBrown;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(1060, 107);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(53, 25);
            this.lbl_date.TabIndex = 3;
            this.lbl_date.Text = "Date";
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_mm
            // 
            this.btn_mm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_mm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mm.Location = new System.Drawing.Point(1205, 379);
            this.btn_mm.Name = "btn_mm";
            this.btn_mm.Size = new System.Drawing.Size(150, 70);
            this.btn_mm.TabIndex = 48;
            this.btn_mm.Text = "Go Back To \r\nMain Menu\r\n";
            this.btn_mm.UseVisualStyleBackColor = false;
            this.btn_mm.Click += new System.EventHandler(this.btn_mm_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_clear.Location = new System.Drawing.Point(1003, 390);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(100, 47);
            this.btn_clear.TabIndex = 49;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 32);
            this.label2.TabIndex = 50;
            this.label2.Text = "Item ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 520);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 32);
            this.label3.TabIndex = 50;
            this.label3.Text = "Item Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 651);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 32);
            this.label4.TabIndex = 50;
            this.label4.Text = "Item Price :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.dataGridView1.DataSource = this.tblitemsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(733, 478);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(622, 291);
            this.dataGridView1.TabIndex = 52;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblitemsBindingSource
            // 
            this.tblitemsBindingSource.DataMember = "tbl_items";
            this.tblitemsBindingSource.DataSource = this.se_db_pzdrDataSet;
            // 
            // se_db_pzdrDataSet
            // 
            this.se_db_pzdrDataSet.DataSetName = "se_db_pzdrDataSet";
            this.se_db_pzdrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_scan
            // 
            this.btn_scan.Location = new System.Drawing.Point(521, 451);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(110, 41);
            this.btn_scan.TabIndex = 54;
            this.btn_scan.Text = "Scan";
            this.btn_scan.UseVisualStyleBackColor = true;
            this.btn_scan.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(29, 725);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(134, 44);
            this.btn_add.TabIndex = 55;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(183, 725);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(137, 44);
            this.btn_edit.TabIndex = 56;
            this.btn_edit.Text = "EDIT";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(494, 725);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(137, 44);
            this.btn_save.TabIndex = 57;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_del
            // 
            this.btn_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.Location = new System.Drawing.Point(341, 725);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(137, 44);
            this.btn_del.TabIndex = 58;
            this.btn_del.Text = "DELETE";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // txt_pr
            // 
            this.txt_pr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pr.Location = new System.Drawing.Point(273, 651);
            this.txt_pr.Multiline = true;
            this.txt_pr.Name = "txt_pr";
            this.txt_pr.Size = new System.Drawing.Size(358, 32);
            this.txt_pr.TabIndex = 59;
            this.txt_pr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pr_KeyPress);
            // 
            // txt_n
            // 
            this.txt_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_n.Location = new System.Drawing.Point(273, 520);
            this.txt_n.Multiline = true;
            this.txt_n.Name = "txt_n";
            this.txt_n.Size = new System.Drawing.Size(358, 110);
            this.txt_n.TabIndex = 59;
            // 
            // txt_id_type
            // 
            this.txt_id_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_type.Location = new System.Drawing.Point(273, 460);
            this.txt_id_type.Multiline = true;
            this.txt_id_type.Name = "txt_id_type";
            this.txt_id_type.Size = new System.Drawing.Size(161, 32);
            this.txt_id_type.TabIndex = 59;
            this.txt_id_type.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_type_KeyPress);
            // 
            // tbl_itemsTableAdapter
            // 
            this.tbl_itemsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1370, 806);
            this.Controls.Add(this.txt_id_type);
            this.Controls.Add(this.txt_n);
            this.Controls.Add(this.txt_pr);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_scan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_mm);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.panel_cash);
            this.Controls.Add(this.panel_chef);
            this.Controls.Add(this.panel_sup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frm_items";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Management System";
            this.Load += new System.EventHandler(this.frm_items_Load);
            this.txt_price.ResumeLayout(false);
            this.txt_price.PerformLayout();
            this.panel_cash.ResumeLayout(false);
            this.panel_cash.PerformLayout();
            this.panel_chef.ResumeLayout(false);
            this.panel_chef.PerformLayout();
            this.panel_sup.ResumeLayout(false);
            this.panel_sup.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblitemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.se_db_pzdrDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel txt_price;
        private System.Windows.Forms.Label lbl_admin;
        private System.Windows.Forms.Panel panel_cash;
        private System.Windows.Forms.Label lbl_cash;
        private System.Windows.Forms.Panel panel_chef;
        private System.Windows.Forms.Label lbl_chef;
        private System.Windows.Forms.Panel panel_sup;
        private System.Windows.Forms.Label lbl_sup;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_id_load;
        private System.Windows.Forms.TextBox txt_pos_load;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_mm;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_scan;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.TextBox txt_n;
        private System.Windows.Forms.TextBox txt_id_type;
        private System.Windows.Forms.TextBox txt_pr;
        private se_db_pzdrDataSet se_db_pzdrDataSet;
        private System.Windows.Forms.BindingSource tblitemsBindingSource;
        private se_db_pzdrDataSetTableAdapters.tbl_itemsTableAdapter tbl_itemsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
    }
}