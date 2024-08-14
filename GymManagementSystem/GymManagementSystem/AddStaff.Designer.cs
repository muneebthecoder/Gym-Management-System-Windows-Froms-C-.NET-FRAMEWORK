
namespace GymManagementSystem
{
    partial class AddStaff
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
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.cbxsd = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxstime = new System.Windows.Forms.ComboBox();
            this.joindatedpt = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtmobile = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtname = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnreset = new System.Windows.Forms.Button();
            this.rdbtnmale = new System.Windows.Forms.RadioButton();
            this.rdbtnfemale = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.txtsalary);
            this.panel9.Location = new System.Drawing.Point(177, 282);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(261, 58);
            this.panel9.TabIndex = 33;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Location = new System.Drawing.Point(12, 31);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(285, 1);
            this.panel10.TabIndex = 9;
            // 
            // txtsalary
            // 
            this.txtsalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(90)))), ((int)(((byte)(97)))));
            this.txtsalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalary.ForeColor = System.Drawing.Color.Gray;
            this.txtsalary.Location = new System.Drawing.Point(12, 13);
            this.txtsalary.Multiline = true;
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(243, 17);
            this.txtsalary.TabIndex = 1;
            this.txtsalary.Text = "Salary";
            this.txtsalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsalary_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(79, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "Salary";
            // 
            // btnadd
            // 
            this.btnadd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.btnadd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(372, 472);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(149, 33);
            this.btnadd.TabIndex = 43;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // cbxsd
            // 
            this.cbxsd.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbxsd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxsd.FormattingEnabled = true;
            this.cbxsd.Items.AddRange(new object[] {
            "Operations Manager",
            "Group Fitness Instructor",
            "Certified Personal Trainer",
            "Maintenance Personnel",
            "Service Technician",
            "Front-Desk Staff"});
            this.cbxsd.Location = new System.Drawing.Point(770, 212);
            this.cbxsd.Name = "cbxsd";
            this.cbxsd.Size = new System.Drawing.Size(158, 23);
            this.cbxsd.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(592, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "Staff Designation";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(645, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Shift Time";
            // 
            // cbxstime
            // 
            this.cbxstime.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbxstime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxstime.FormattingEnabled = true;
            this.cbxstime.Items.AddRange(new object[] {
            "Morning Shift",
            "Evening Shift",
            "Night Shift"});
            this.cbxstime.Location = new System.Drawing.Point(770, 147);
            this.cbxstime.Name = "cbxstime";
            this.cbxstime.Size = new System.Drawing.Size(158, 23);
            this.cbxstime.TabIndex = 38;
            // 
            // joindatedpt
            // 
            this.joindatedpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joindatedpt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.joindatedpt.Location = new System.Drawing.Point(770, 92);
            this.joindatedpt.Name = "joindatedpt";
            this.joindatedpt.Size = new System.Drawing.Size(158, 21);
            this.joindatedpt.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(627, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Joining Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(57, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Mobile No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(84, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Email ";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.txtmobile);
            this.panel7.Location = new System.Drawing.Point(177, 212);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(258, 50);
            this.panel7.TabIndex = 32;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(12, 31);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(285, 1);
            this.panel8.TabIndex = 9;
            // 
            // txtmobile
            // 
            this.txtmobile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(90)))), ((int)(((byte)(97)))));
            this.txtmobile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmobile.ForeColor = System.Drawing.Color.Gray;
            this.txtmobile.Location = new System.Drawing.Point(12, 13);
            this.txtmobile.Multiline = true;
            this.txtmobile.Name = "txtmobile";
            this.txtmobile.Size = new System.Drawing.Size(243, 17);
            this.txtmobile.TabIndex = 1;
            this.txtmobile.Text = "Mobile No";
            this.txtmobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmobile_KeyPress);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.txtemail);
            this.panel5.Location = new System.Drawing.Point(177, 147);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(258, 50);
            this.panel5.TabIndex = 31;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(12, 31);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(285, 1);
            this.panel6.TabIndex = 9;
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(90)))), ((int)(((byte)(97)))));
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.ForeColor = System.Drawing.Color.Gray;
            this.txtemail.Location = new System.Drawing.Point(12, 13);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(243, 17);
            this.txtemail.TabIndex = 1;
            this.txtemail.Text = "Email";
            this.txtemail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtemail_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(81, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Location = new System.Drawing.Point(177, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 50);
            this.panel1.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(12, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 1);
            this.panel2.TabIndex = 9;
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(90)))), ((int)(((byte)(97)))));
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.ForeColor = System.Drawing.Color.Gray;
            this.txtname.Location = new System.Drawing.Point(12, 13);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(243, 17);
            this.txtname.TabIndex = 1;
            this.txtname.Text = "Enter Name";
            this.txtname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtname_KeyPress);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.txtage);
            this.panel3.Location = new System.Drawing.Point(177, 355);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(261, 58);
            this.panel3.TabIndex = 45;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(12, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(285, 1);
            this.panel4.TabIndex = 9;
            // 
            // txtage
            // 
            this.txtage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(90)))), ((int)(((byte)(97)))));
            this.txtage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtage.ForeColor = System.Drawing.Color.Gray;
            this.txtage.Location = new System.Drawing.Point(12, 13);
            this.txtage.Multiline = true;
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(243, 17);
            this.txtage.TabIndex = 1;
            this.txtage.Text = "Age";
            this.txtage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtage_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Age";
            // 
            // btnreset
            // 
            this.btnreset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.btnreset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.Color.White;
            this.btnreset.Location = new System.Drawing.Point(596, 472);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(149, 33);
            this.btnreset.TabIndex = 47;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // rdbtnmale
            // 
            this.rdbtnmale.AutoSize = true;
            this.rdbtnmale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnmale.Location = new System.Drawing.Point(52, 42);
            this.rdbtnmale.Name = "rdbtnmale";
            this.rdbtnmale.Size = new System.Drawing.Size(58, 22);
            this.rdbtnmale.TabIndex = 0;
            this.rdbtnmale.TabStop = true;
            this.rdbtnmale.Text = "Male";
            this.rdbtnmale.UseVisualStyleBackColor = true;
            // 
            // rdbtnfemale
            // 
            this.rdbtnfemale.AutoSize = true;
            this.rdbtnfemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnfemale.Location = new System.Drawing.Point(188, 44);
            this.rdbtnfemale.Name = "rdbtnfemale";
            this.rdbtnfemale.Size = new System.Drawing.Size(75, 22);
            this.rdbtnfemale.TabIndex = 1;
            this.rdbtnfemale.TabStop = true;
            this.rdbtnfemale.Text = "Female";
            this.rdbtnfemale.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtnfemale);
            this.groupBox1.Controls.Add(this.rdbtnmale);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(614, 282);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 96);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Gender";
            // 
            // AddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(90)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(1138, 723);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.cbxsd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxstime);
            this.Controls.Add(this.joindatedpt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AddStaff";
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.ComboBox cbxsd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxstime;
        private System.Windows.Forms.DateTimePicker joindatedpt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtmobile;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.RadioButton rdbtnmale;
        private System.Windows.Forms.RadioButton rdbtnfemale;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}