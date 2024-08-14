
namespace GymManagementSystem
{
    partial class Home
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
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iconbar = new FontAwesome.Sharp.IconPictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnhome = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnaddmember = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnequipments = new FontAwesome.Sharp.IconButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnaddstaff = new FontAwesome.Sharp.IconButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btndeletemember = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnsearchmember = new FontAwesome.Sharp.IconButton();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnViewStaff = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnexitss = new FontAwesome.Sharp.IconButton();
            this.sidebartimer = new System.Windows.Forms.Timer(this.components);
            this.btnx = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.flp.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconbar)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flp
            // 
            this.flp.BackColor = System.Drawing.Color.Black;
            this.flp.Controls.Add(this.panel1);
            this.flp.Controls.Add(this.panel7);
            this.flp.Controls.Add(this.panel2);
            this.flp.Controls.Add(this.panel4);
            this.flp.Controls.Add(this.panel9);
            this.flp.Controls.Add(this.panel6);
            this.flp.Controls.Add(this.panel5);
            this.flp.Controls.Add(this.panel10);
            this.flp.Controls.Add(this.panel3);
            this.flp.Dock = System.Windows.Forms.DockStyle.Left;
            this.flp.Location = new System.Drawing.Point(0, 0);
            this.flp.MaximumSize = new System.Drawing.Size(228, 788);
            this.flp.MinimumSize = new System.Drawing.Size(65, 788);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(66, 788);
            this.flp.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.iconbar);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 128);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // iconbar
            // 
            this.iconbar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconbar.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.iconbar.IconColor = System.Drawing.Color.White;
            this.iconbar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbar.IconSize = 54;
            this.iconbar.Location = new System.Drawing.Point(3, 31);
            this.iconbar.Name = "iconbar";
            this.iconbar.Size = new System.Drawing.Size(56, 54);
            this.iconbar.TabIndex = 1;
            this.iconbar.TabStop = false;
            this.iconbar.Click += new System.EventHandler(this.iconbar_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnhome);
            this.panel7.Location = new System.Drawing.Point(3, 137);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(225, 59);
            this.panel7.TabIndex = 4;
            // 
            // btnhome
            // 
            this.btnhome.FlatAppearance.BorderSize = 0;
            this.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.ForeColor = System.Drawing.Color.White;
            this.btnhome.IconChar = FontAwesome.Sharp.IconChar.TvAlt;
            this.btnhome.IconColor = System.Drawing.Color.White;
            this.btnhome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnhome.IconSize = 50;
            this.btnhome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhome.Location = new System.Drawing.Point(0, 0);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(225, 59);
            this.btnhome.TabIndex = 3;
            this.btnhome.Text = "   DashBoard";
            this.btnhome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnhome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnaddmember);
            this.panel2.Location = new System.Drawing.Point(3, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 59);
            this.panel2.TabIndex = 2;
            // 
            // btnaddmember
            // 
            this.btnaddmember.FlatAppearance.BorderSize = 0;
            this.btnaddmember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddmember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddmember.ForeColor = System.Drawing.Color.White;
            this.btnaddmember.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnaddmember.IconColor = System.Drawing.Color.White;
            this.btnaddmember.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnaddmember.IconSize = 50;
            this.btnaddmember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddmember.Location = new System.Drawing.Point(0, 0);
            this.btnaddmember.Name = "btnaddmember";
            this.btnaddmember.Size = new System.Drawing.Size(225, 59);
            this.btnaddmember.TabIndex = 3;
            this.btnaddmember.Text = "   Add Member";
            this.btnaddmember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaddmember.UseVisualStyleBackColor = true;
            this.btnaddmember.Click += new System.EventHandler(this.btnaddmember_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnequipments);
            this.panel4.Location = new System.Drawing.Point(3, 267);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(225, 59);
            this.panel4.TabIndex = 3;
            // 
            // btnequipments
            // 
            this.btnequipments.FlatAppearance.BorderSize = 0;
            this.btnequipments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnequipments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnequipments.ForeColor = System.Drawing.Color.White;
            this.btnequipments.IconChar = FontAwesome.Sharp.IconChar.Dumbbell;
            this.btnequipments.IconColor = System.Drawing.Color.White;
            this.btnequipments.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnequipments.IconSize = 50;
            this.btnequipments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnequipments.Location = new System.Drawing.Point(0, 0);
            this.btnequipments.Name = "btnequipments";
            this.btnequipments.Size = new System.Drawing.Size(225, 59);
            this.btnequipments.TabIndex = 3;
            this.btnequipments.Text = "   Equipments";
            this.btnequipments.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnequipments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnequipments.UseVisualStyleBackColor = true;
            this.btnequipments.Click += new System.EventHandler(this.btnequipments_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnaddstaff);
            this.panel9.Location = new System.Drawing.Point(3, 332);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(225, 59);
            this.panel9.TabIndex = 5;
            // 
            // btnaddstaff
            // 
            this.btnaddstaff.FlatAppearance.BorderSize = 0;
            this.btnaddstaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddstaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddstaff.ForeColor = System.Drawing.Color.White;
            this.btnaddstaff.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnaddstaff.IconColor = System.Drawing.Color.White;
            this.btnaddstaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnaddstaff.IconSize = 50;
            this.btnaddstaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddstaff.Location = new System.Drawing.Point(0, 0);
            this.btnaddstaff.Name = "btnaddstaff";
            this.btnaddstaff.Size = new System.Drawing.Size(225, 59);
            this.btnaddstaff.TabIndex = 3;
            this.btnaddstaff.Text = "   Add Staff";
            this.btnaddstaff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaddstaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaddstaff.UseVisualStyleBackColor = true;
            this.btnaddstaff.Click += new System.EventHandler(this.btnaddstaff_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btndeletemember);
            this.panel6.Location = new System.Drawing.Point(3, 397);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(225, 59);
            this.panel6.TabIndex = 3;
            // 
            // btndeletemember
            // 
            this.btndeletemember.BackColor = System.Drawing.Color.Black;
            this.btndeletemember.FlatAppearance.BorderSize = 0;
            this.btndeletemember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeletemember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletemember.ForeColor = System.Drawing.Color.White;
            this.btndeletemember.IconChar = FontAwesome.Sharp.IconChar.UsersViewfinder;
            this.btndeletemember.IconColor = System.Drawing.Color.White;
            this.btndeletemember.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btndeletemember.IconSize = 50;
            this.btndeletemember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndeletemember.Location = new System.Drawing.Point(0, 0);
            this.btndeletemember.Name = "btndeletemember";
            this.btndeletemember.Size = new System.Drawing.Size(225, 59);
            this.btndeletemember.TabIndex = 3;
            this.btndeletemember.Text = "   View All Member";
            this.btndeletemember.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndeletemember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndeletemember.UseVisualStyleBackColor = false;
            this.btndeletemember.Click += new System.EventHandler(this.btndeletemember_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnsearchmember);
            this.panel5.Location = new System.Drawing.Point(3, 462);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(225, 59);
            this.panel5.TabIndex = 3;
            // 
            // btnsearchmember
            // 
            this.btnsearchmember.FlatAppearance.BorderSize = 0;
            this.btnsearchmember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearchmember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearchmember.ForeColor = System.Drawing.Color.White;
            this.btnsearchmember.IconChar = FontAwesome.Sharp.IconChar.Dumbbell;
            this.btnsearchmember.IconColor = System.Drawing.Color.White;
            this.btnsearchmember.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsearchmember.IconSize = 50;
            this.btnsearchmember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsearchmember.Location = new System.Drawing.Point(0, 0);
            this.btnsearchmember.Name = "btnsearchmember";
            this.btnsearchmember.Size = new System.Drawing.Size(225, 59);
            this.btnsearchmember.TabIndex = 3;
            this.btnsearchmember.Text = "    View Equipments";
            this.btnsearchmember.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsearchmember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsearchmember.UseVisualStyleBackColor = false;
            this.btnsearchmember.Click += new System.EventHandler(this.btnsearchmember_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnViewStaff);
            this.panel10.Location = new System.Drawing.Point(3, 527);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(225, 59);
            this.panel10.TabIndex = 6;
            // 
            // btnViewStaff
            // 
            this.btnViewStaff.FlatAppearance.BorderSize = 0;
            this.btnViewStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStaff.ForeColor = System.Drawing.Color.White;
            this.btnViewStaff.IconChar = FontAwesome.Sharp.IconChar.Elevator;
            this.btnViewStaff.IconColor = System.Drawing.Color.White;
            this.btnViewStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnViewStaff.IconSize = 50;
            this.btnViewStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewStaff.Location = new System.Drawing.Point(0, 0);
            this.btnViewStaff.Name = "btnViewStaff";
            this.btnViewStaff.Size = new System.Drawing.Size(225, 59);
            this.btnViewStaff.TabIndex = 3;
            this.btnViewStaff.Text = "   View Staff";
            this.btnViewStaff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewStaff.UseVisualStyleBackColor = true;
            this.btnViewStaff.Click += new System.EventHandler(this.btnViewStaff_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnexitss);
            this.panel3.Location = new System.Drawing.Point(3, 592);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 59);
            this.panel3.TabIndex = 4;
            // 
            // btnexitss
            // 
            this.btnexitss.FlatAppearance.BorderSize = 0;
            this.btnexitss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexitss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexitss.ForeColor = System.Drawing.Color.White;
            this.btnexitss.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btnexitss.IconColor = System.Drawing.Color.White;
            this.btnexitss.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnexitss.IconSize = 50;
            this.btnexitss.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexitss.Location = new System.Drawing.Point(0, 0);
            this.btnexitss.Name = "btnexitss";
            this.btnexitss.Size = new System.Drawing.Size(225, 59);
            this.btnexitss.TabIndex = 3;
            this.btnexitss.Text = "   Logout";
            this.btnexitss.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexitss.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexitss.UseVisualStyleBackColor = true;
            this.btnexitss.Click += new System.EventHandler(this.btnexitss_Click);
            // 
            // sidebartimer
            // 
            this.sidebartimer.Interval = 2;
            this.sidebartimer.Tick += new System.EventHandler(this.sidebartimer_Tick);
            // 
            // btnx
            // 
            this.btnx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnx.FlatAppearance.BorderSize = 0;
            this.btnx.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnx.ForeColor = System.Drawing.Color.White;
            this.btnx.Location = new System.Drawing.Point(1358, 0);
            this.btnx.Name = "btnx";
            this.btnx.Size = new System.Drawing.Size(42, 29);
            this.btnx.TabIndex = 1;
            this.btnx.Text = "X";
            this.btnx.UseVisualStyleBackColor = true;
            this.btnx.Click += new System.EventHandler(this.btnx_Click);
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(228, 26);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1154, 762);
            this.panel8.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(90)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.btnx);
            this.Controls.Add(this.flp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.flp.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconbar)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnaddmember;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton btnsearchmember;
        private System.Windows.Forms.Panel panel6;
        private FontAwesome.Sharp.IconButton btndeletemember;
        private FontAwesome.Sharp.IconPictureBox iconbar;
        private System.Windows.Forms.Panel panel7;
        private FontAwesome.Sharp.IconButton btnhome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer sidebartimer;
        private System.Windows.Forms.Button btnx;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnequipments;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnexitss;
        private System.Windows.Forms.Panel panel9;
        private FontAwesome.Sharp.IconButton btnaddstaff;
        private System.Windows.Forms.Panel panel10;
        private FontAwesome.Sharp.IconButton btnViewStaff;
    }
}