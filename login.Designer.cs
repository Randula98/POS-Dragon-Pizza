namespace project_pos
{
    partial class frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.lbl_time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_date = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_bh = new System.Windows.Forms.Button();
            this.lbl_enter_id = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_face = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_val = new System.Windows.Forms.Button();
            this.txt_enter_pw = new System.Windows.Forms.TextBox();
            this.txt_enter_id = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_hello = new System.Windows.Forms.Label();
            this.lbl_enter_pw = new System.Windows.Forms.Label();
            this.txt_pos_load = new System.Windows.Forms.TextBox();
            this.txt_pw_load = new System.Windows.Forms.TextBox();
            this.btn_rst = new System.Windows.Forms.Button();
            this.txt_load_id = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.BackColor = System.Drawing.Color.RosyBrown;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(1054, 46);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(78, 32);
            this.lbl_time.TabIndex = 7;
            this.lbl_time.Text = "Time";
            this.lbl_time.Click += new System.EventHandler(this.lbl_time_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(723, 134);
            this.label1.TabIndex = 6;
            this.label1.Text = "The Best Place To Full Fill Your \r\nPizza Cravings\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.lbl_date);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_time);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1359, 200);
            this.panel1.TabIndex = 8;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.Color.RosyBrown;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(1055, 115);
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
            // btn_bh
            // 
            this.btn_bh.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_bh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_bh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bh.Location = new System.Drawing.Point(1218, 244);
            this.btn_bh.Name = "btn_bh";
            this.btn_bh.Size = new System.Drawing.Size(141, 70);
            this.btn_bh.TabIndex = 10;
            this.btn_bh.Text = "Back To\r\nHome";
            this.btn_bh.UseVisualStyleBackColor = false;
            this.btn_bh.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_enter_id
            // 
            this.lbl_enter_id.AutoSize = true;
            this.lbl_enter_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_enter_id.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_enter_id.Location = new System.Drawing.Point(14, 40);
            this.lbl_enter_id.Name = "lbl_enter_id";
            this.lbl_enter_id.Size = new System.Drawing.Size(319, 32);
            this.lbl_enter_id.TabIndex = 11;
            this.lbl_enter_id.Text = "Enter your ID number :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.lbl_face);
            this.panel2.Controls.Add(this.btn_login);
            this.panel2.Controls.Add(this.btn_val);
            this.panel2.Controls.Add(this.txt_enter_pw);
            this.panel2.Controls.Add(this.txt_enter_id);
            this.panel2.Controls.Add(this.lbl_title);
            this.panel2.Controls.Add(this.lbl_hello);
            this.panel2.Controls.Add(this.lbl_enter_pw);
            this.panel2.Controls.Add(this.lbl_enter_id);
            this.panel2.Location = new System.Drawing.Point(24, 276);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(792, 354);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbl_face
            // 
            this.lbl_face.AutoSize = true;
            this.lbl_face.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_face.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_face.Location = new System.Drawing.Point(24, 121);
            this.lbl_face.Name = "lbl_face";
            this.lbl_face.Size = new System.Drawing.Size(53, 55);
            this.lbl_face.TabIndex = 15;
            this.lbl_face.Text = ":)";
            // 
            // btn_login
            // 
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(635, 235);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(109, 37);
            this.btn_login.TabIndex = 14;
            this.btn_login.Text = "Log In";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_val
            // 
            this.btn_val.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_val.Location = new System.Drawing.Point(635, 39);
            this.btn_val.Name = "btn_val";
            this.btn_val.Size = new System.Drawing.Size(121, 38);
            this.btn_val.TabIndex = 13;
            this.btn_val.Text = "Validate";
            this.btn_val.UseVisualStyleBackColor = true;
            this.btn_val.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txt_enter_pw
            // 
            this.txt_enter_pw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_enter_pw.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_enter_pw.Location = new System.Drawing.Point(357, 236);
            this.txt_enter_pw.Multiline = true;
            this.txt_enter_pw.Name = "txt_enter_pw";
            this.txt_enter_pw.PasswordChar = '*';
            this.txt_enter_pw.Size = new System.Drawing.Size(230, 32);
            this.txt_enter_pw.TabIndex = 12;
            this.txt_enter_pw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_enter_pw_KeyPress);
            // 
            // txt_enter_id
            // 
            this.txt_enter_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_enter_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_enter_id.Location = new System.Drawing.Point(357, 40);
            this.txt_enter_id.Multiline = true;
            this.txt_enter_id.Name = "txt_enter_id";
            this.txt_enter_id.Size = new System.Drawing.Size(230, 32);
            this.txt_enter_id.TabIndex = 12;
            this.txt_enter_id.TextChanged += new System.EventHandler(this.txt_enter_id_TextChanged);
            this.txt_enter_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_enter_id_KeyPress);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_title.Location = new System.Drawing.Point(170, 139);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(73, 32);
            this.lbl_title.TabIndex = 11;
            this.lbl_title.Text = "Mrs.";
            // 
            // lbl_hello
            // 
            this.lbl_hello.AutoSize = true;
            this.lbl_hello.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hello.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_hello.Location = new System.Drawing.Point(80, 139);
            this.lbl_hello.Name = "lbl_hello";
            this.lbl_hello.Size = new System.Drawing.Size(94, 32);
            this.lbl_hello.TabIndex = 11;
            this.lbl_hello.Text = "Hello ";
            // 
            // lbl_enter_pw
            // 
            this.lbl_enter_pw.AutoSize = true;
            this.lbl_enter_pw.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_enter_pw.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_enter_pw.Location = new System.Drawing.Point(14, 236);
            this.lbl_enter_pw.Name = "lbl_enter_pw";
            this.lbl_enter_pw.Size = new System.Drawing.Size(312, 32);
            this.lbl_enter_pw.TabIndex = 11;
            this.lbl_enter_pw.Text = "Enter your Password :";
            // 
            // txt_pos_load
            // 
            this.txt_pos_load.Location = new System.Drawing.Point(81, 597);
            this.txt_pos_load.Multiline = true;
            this.txt_pos_load.Name = "txt_pos_load";
            this.txt_pos_load.ReadOnly = true;
            this.txt_pos_load.Size = new System.Drawing.Size(213, 22);
            this.txt_pos_load.TabIndex = 13;
            // 
            // txt_pw_load
            // 
            this.txt_pw_load.Location = new System.Drawing.Point(467, 597);
            this.txt_pw_load.Multiline = true;
            this.txt_pw_load.Name = "txt_pw_load";
            this.txt_pw_load.ReadOnly = true;
            this.txt_pw_load.Size = new System.Drawing.Size(213, 22);
            this.txt_pw_load.TabIndex = 13;
            // 
            // btn_rst
            // 
            this.btn_rst.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_rst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rst.Location = new System.Drawing.Point(976, 256);
            this.btn_rst.Name = "btn_rst";
            this.btn_rst.Size = new System.Drawing.Size(144, 48);
            this.btn_rst.TabIndex = 15;
            this.btn_rst.Text = "RESET";
            this.btn_rst.UseVisualStyleBackColor = false;
            this.btn_rst.Click += new System.EventHandler(this.btn_rst_Click);
            // 
            // txt_load_id
            // 
            this.txt_load_id.Location = new System.Drawing.Point(282, 569);
            this.txt_load_id.Multiline = true;
            this.txt_load_id.Name = "txt_load_id";
            this.txt_load_id.ReadOnly = true;
            this.txt_load_id.Size = new System.Drawing.Size(213, 22);
            this.txt_load_id.TabIndex = 13;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1025, 360);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(263, 259);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1383, 642);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_rst);
            this.Controls.Add(this.btn_bh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_pos_load);
            this.Controls.Add(this.txt_load_id);
            this.Controls.Add(this.txt_pw_load);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_bh;
        private System.Windows.Forms.Label lbl_enter_id;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_enter_id;
        private System.Windows.Forms.Button btn_val;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_hello;
        private System.Windows.Forms.Label lbl_enter_pw;
        private System.Windows.Forms.TextBox txt_enter_pw;
        private System.Windows.Forms.Label lbl_face;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_pos_load;
        private System.Windows.Forms.TextBox txt_pw_load;
        private System.Windows.Forms.Button btn_rst;
        private System.Windows.Forms.TextBox txt_load_id;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}