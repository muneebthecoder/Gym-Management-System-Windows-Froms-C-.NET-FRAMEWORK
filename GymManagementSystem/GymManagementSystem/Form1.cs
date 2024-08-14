using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GymManagementSystem
{
    public partial class Form1 : Form
    {
        DBHelper db = new DBHelper();
        DataSet ds;
        SqlDataAdapter sda;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnexit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void lblregistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            iconPictureBox1.Visible = false;
            iconPictureBox2.Visible = false;
            pnlreg.Visible = true;
            pnlreg.Dock = DockStyle.Fill;
            linkuname.Visible=false;
        }

        private void lblalready_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlreg.Visible = false;
        }

        private void txtrusername_Click(object sender, EventArgs e)
        {
            txtrusername.SelectAll();
            txtrusername.Clear();
            txtrusername.ForeColor = Color.White;
        }

        private void txtrfname_Click(object sender, EventArgs e)
        {
            txtrfname.SelectAll();
            txtrfname.Clear();
            txtrfname.ForeColor = Color.White;
        }

        private void txtrpassword_Click(object sender, EventArgs e)
        {
            txtrpassword.SelectAll();
            txtrpassword.Clear();
            txtrpassword.PasswordChar = '*';
            txtrpassword.ForeColor = Color.White;
        }

        private void txtremail_Click(object sender, EventArgs e)
        {
            txtremail.SelectAll();
            txtremail.Clear();
            txtremail.ForeColor = Color.White;
        }

        private void txtrmobile_Click(object sender, EventArgs e)
        {
            txtrmobile.SelectAll();
            txtrmobile.Clear();
            txtrmobile.ForeColor = Color.White;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool ValidUser()
            {
                /*                string q = "select username,password from Register where username='" + txtUsername.Text + "' and password='" + txtpassword.Text + "'";
                                SqlDataReader sdr = db.GetReader(q);
                                bool valid = false;

                                if (sdr.Read())
                                {
                                    if (sdr["username"].ToString() == txtUsername.Text && sdr["password"].ToString() == txtpassword.Text)
                                    {
                                        valid = true;
                                    }
                                }
                                sdr.Close();
                                db.CloseCon();*/
                bool valid=false;

                if (txtUsername.Text=="muneeb" && txtpassword.Text=="123")
                {
                    valid = true;
                }

                return valid;
            }
        
            if (ValidUser() == false)
            {
                linkuname.Visible = true;
            }
            else
            {
                Home hm = new Home();
                this.Hide();
                hm.Show();
            }
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            if (txtrusername.Text== "Enter UserName" || txtrfname.Text== "Enter Full Name" || txtrpassword.Text== "Password" || txtremail.Text== "Email" || txtrmobile.Text== "Mobile #")
            {
                MB m = new MB();
                m.Show();
            }
            else
            {
                string constr = @"Data Source=DESKTOP-NF1C7NA\SQLEXPRESS; initial catalog=GymManagementSystem ;integrated security=true;";
                ds = new DataSet();
                string gender = "Male";
                if (rdbtnmale.Checked == true)
                {
                    gender = rdbtnmale.Text;
                }
                else
                {
                    gender = rdbtnfemale.Text;
                }

                SqlConnection con = new SqlConnection(constr);
                con.Open();
                string q = "Select * from register";
                sda = new SqlDataAdapter(q, con);
                sda.Fill(ds, "tblreg");

                SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                ds.Tables["tblreg"].Rows.Add(txtrusername.Text, txtrfname.Text, txtrpassword.Text, txtremail.Text, txtrmobile.Text, gender);
                sda.Update(ds.Tables["tblreg"]);
                ds.AcceptChanges();

                pnlreg.Visible = false;
                lblcreated.Visible = true;
            }
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtpassword.Text == "Password")
            {
                txtpassword.Text = "";
                txtpassword.ForeColor = Color.White;
                txtpassword.PasswordChar = '*';

            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.White;
            }
        }
    }
}