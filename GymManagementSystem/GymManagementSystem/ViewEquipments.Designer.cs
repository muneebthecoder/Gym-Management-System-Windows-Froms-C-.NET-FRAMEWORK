
namespace GymManagementSystem
{
    partial class ViewEquipments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label9 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtweight = new System.Windows.Forms.TextBox();
            this.cbxtype = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpdd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtcost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtename = new System.Windows.Forms.TextBox();
            this.dgvsearch = new System.Windows.Forms.DataGridView();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.totalequiplabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.totalspentlabel = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(420, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 29);
            this.label9.TabIndex = 26;
            this.label9.Text = "View Equipments";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.txtweight);
            this.panel7.Location = new System.Drawing.Point(737, 175);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 50);
            this.panel7.TabIndex = 33;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(12, 31);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(285, 1);
            this.panel8.TabIndex = 9;
            // 
            // txtweight
            // 
            this.txtweight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(90)))), ((int)(((byte)(97)))));
            this.txtweight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtweight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtweight.ForeColor = System.Drawing.Color.Gray;
            this.txtweight.Location = new System.Drawing.Point(15, 10);
            this.txtweight.Multiline = true;
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(268, 27);
            this.txtweight.TabIndex = 1;
            this.txtweight.Text = "Equipment Weight";
            // 
            // cbxtype
            // 
            this.cbxtype.FormattingEnabled = true;
            this.cbxtype.Items.AddRange(new object[] {
            "Machines",
            "Weights",
            "Bars",
            "Others"});
            this.cbxtype.Location = new System.Drawing.Point(737, 138);
            this.cbxtype.Name = "cbxtype";
            this.cbxtype.Size = new System.Drawing.Size(200, 21);
            this.cbxtype.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(559, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "Equipment Type";
            // 
            // dtpdd
            // 
            this.dtpdd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdd.Location = new System.Drawing.Point(737, 83);
            this.dtpdd.Name = "dtpdd";
            this.dtpdd.Size = new System.Drawing.Size(200, 20);
            this.dtpdd.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(580, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Delivery Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(543, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Equipment Weight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Equipment Quantity";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.txtquantity);
            this.panel5.Location = new System.Drawing.Point(229, 139);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(280, 50);
            this.panel5.TabIndex = 35;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(12, 31);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(285, 1);
            this.panel6.TabIndex = 9;
            // 
            // txtquantity
            // 
            this.txtquantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(90)))), ((int)(((byte)(97)))));
            this.txtquantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantity.ForeColor = System.Drawing.Color.Gray;
            this.txtquantity.Location = new System.Drawing.Point(12, 11);
            this.txtquantity.Multiline = true;
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(265, 27);
            this.txtquantity.TabIndex = 1;
            this.txtquantity.Text = "Equipment Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(52, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Equipment Cost";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.txtcost);
            this.panel3.Location = new System.Drawing.Point(229, 195);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 50);
            this.panel3.TabIndex = 32;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(12, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(285, 1);
            this.panel4.TabIndex = 9;
            // 
            // txtcost
            // 
            this.txtcost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(90)))), ((int)(((byte)(97)))));
            this.txtcost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcost.ForeColor = System.Drawing.Color.Gray;
            this.txtcost.Location = new System.Drawing.Point(12, 11);
            this.txtcost.Multiline = true;
            this.txtcost.Name = "txtcost";
            this.txtcost.Size = new System.Drawing.Size(268, 18);
            this.txtcost.TabIndex = 1;
            this.txtcost.Text = "Equipment Cost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Equipment Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtename);
            this.panel1.Location = new System.Drawing.Point(229, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 50);
            this.panel1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(12, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 1);
            this.panel2.TabIndex = 9;
            // 
            // txtename
            // 
            this.txtename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(90)))), ((int)(((byte)(97)))));
            this.txtename.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtename.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtename.ForeColor = System.Drawing.Color.Gray;
            this.txtename.Location = new System.Drawing.Point(12, 13);
            this.txtename.Multiline = true;
            this.txtename.Name = "txtename";
            this.txtename.Size = new System.Drawing.Size(265, 17);
            this.txtename.TabIndex = 1;
            this.txtename.Text = "Equpiment Name";
            // 
            // dgvsearch
            // 
            this.dgvsearch.AllowUserToAddRows = false;
            this.dgvsearch.AllowUserToDeleteRows = false;
            this.dgvsearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvsearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.dgvsearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvsearch.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvsearch.Location = new System.Drawing.Point(47, 358);
            this.dgvsearch.Name = "dgvsearch";
            this.dgvsearch.ReadOnly = true;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvsearch.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvsearch.RowTemplate.Height = 25;
            this.dgvsearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvsearch.Size = new System.Drawing.Size(907, 199);
            this.dgvsearch.TabIndex = 42;
            this.dgvsearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsearch_CellClick);
            // 
            // btndelete
            // 
            this.btndelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.btndelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(679, 279);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(149, 33);
            this.btndelete.TabIndex = 44;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.btnupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(471, 279);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(149, 33);
            this.btnupdate.TabIndex = 43;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(286, 576);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 19);
            this.label12.TabIndex = 45;
            this.label12.Text = "Total Equipments";
            // 
            // totalequiplabel
            // 
            this.totalequiplabel.AutoSize = true;
            this.totalequiplabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalequiplabel.ForeColor = System.Drawing.Color.White;
            this.totalequiplabel.Location = new System.Drawing.Point(431, 576);
            this.totalequiplabel.Name = "totalequiplabel";
            this.totalequiplabel.Size = new System.Drawing.Size(45, 19);
            this.totalequiplabel.TabIndex = 46;
            this.totalequiplabel.Text = "0000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(497, 576);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(227, 19);
            this.label11.TabIndex = 47;
            this.label11.Text = "Total Spent On Equipments =";
            // 
            // totalspentlabel
            // 
            this.totalspentlabel.AutoSize = true;
            this.totalspentlabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalspentlabel.ForeColor = System.Drawing.Color.White;
            this.totalspentlabel.Location = new System.Drawing.Point(734, 576);
            this.totalspentlabel.Name = "totalspentlabel";
            this.totalspentlabel.Size = new System.Drawing.Size(45, 19);
            this.totalspentlabel.TabIndex = 48;
            this.totalspentlabel.Text = "0000";
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(90)))), ((int)(((byte)(97)))));
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.ForeColor = System.Drawing.Color.Gray;
            this.txtid.Location = new System.Drawing.Point(584, 240);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(268, 18);
            this.txtid.TabIndex = 10;
            // 
            // ViewEquipments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(90)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(1122, 684);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.totalequiplabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.totalspentlabel);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.dgvsearch);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.cbxtype);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewEquipments";
            this.Text = "SearchMember";
            this.Load += new System.EventHandler(this.ViewEquipments_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtweight;
        private System.Windows.Forms.ComboBox cbxtype;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtcost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtename;
        private System.Windows.Forms.DataGridView dgvsearch;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label totalequiplabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label totalspentlabel;
        private System.Windows.Forms.TextBox txtid;
    }
}