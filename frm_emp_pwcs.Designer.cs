namespace project_pos
{
    partial class frm_emp_pwcs
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
            this.button1 = new System.Windows.Forms.Button();
            this.txt_id_load = new System.Windows.Forms.TextBox();
            this.txt_pw_load = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_rnp = new System.Windows.Forms.TextBox();
            this.txt_np = new System.Windows.Forms.TextBox();
            this.txt_cp = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(527, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_id_load
            // 
            this.txt_id_load.Location = new System.Drawing.Point(146, 46);
            this.txt_id_load.Name = "txt_id_load";
            this.txt_id_load.Size = new System.Drawing.Size(100, 22);
            this.txt_id_load.TabIndex = 1;
            this.txt_id_load.Visible = false;
            // 
            // txt_pw_load
            // 
            this.txt_pw_load.Location = new System.Drawing.Point(353, 46);
            this.txt_pw_load.Name = "txt_pw_load";
            this.txt_pw_load.Size = new System.Drawing.Size(100, 22);
            this.txt_pw_load.TabIndex = 1;
            this.txt_pw_load.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter your Currunt Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter your New Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Re-Enter your New Password :";
            // 
            // txt_rnp
            // 
            this.txt_rnp.Location = new System.Drawing.Point(378, 266);
            this.txt_rnp.Multiline = true;
            this.txt_rnp.Name = "txt_rnp";
            this.txt_rnp.PasswordChar = '*';
            this.txt_rnp.Size = new System.Drawing.Size(263, 29);
            this.txt_rnp.TabIndex = 3;
            // 
            // txt_np
            // 
            this.txt_np.Location = new System.Drawing.Point(378, 200);
            this.txt_np.Multiline = true;
            this.txt_np.Name = "txt_np";
            this.txt_np.PasswordChar = '*';
            this.txt_np.Size = new System.Drawing.Size(263, 29);
            this.txt_np.TabIndex = 3;
            // 
            // txt_cp
            // 
            this.txt_cp.Location = new System.Drawing.Point(378, 139);
            this.txt_cp.Multiline = true;
            this.txt_cp.Name = "txt_cp";
            this.txt_cp.PasswordChar = '*';
            this.txt_cp.Size = new System.Drawing.Size(263, 29);
            this.txt_cp.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(95, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 70);
            this.button2.TabIndex = 4;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(414, 373);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 70);
            this.button3.TabIndex = 5;
            this.button3.Text = "Change \r\nPassword";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frm_emp_pwcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(683, 473);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_cp);
            this.Controls.Add(this.txt_np);
            this.Controls.Add(this.txt_rnp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_pw_load);
            this.Controls.Add(this.txt_id_load);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_emp_pwcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.frm_emp_pwcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_id_load;
        private System.Windows.Forms.TextBox txt_pw_load;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_rnp;
        private System.Windows.Forms.TextBox txt_np;
        private System.Windows.Forms.TextBox txt_cp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}