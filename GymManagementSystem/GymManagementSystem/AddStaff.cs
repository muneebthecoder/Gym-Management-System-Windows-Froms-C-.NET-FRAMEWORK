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
    public partial class AddStaff : Form
    {
        string constr = @"Data Source=DESKTOP-NF1C7NA\SQLEXPRESS; initial catalog=GymManagementSystem ;integrated security=true;";
        DataSet ds;
        SqlDataAdapter sda;
        public AddStaff()
        {
            InitializeComponent();
        }
        private void resetboxes()
        {
            txtname.Clear();
            txtname.Text = "Enter Name";
            txtname.ForeColor = Color.Gray;

            txtemail.Clear();
            txtemail.Text = "Email";
            txtemail.ForeColor = Color.Gray;

            txtmobile.Clear();
            txtmobile.Text = "Mobile No";
            txtmobile.ForeColor = Color.Gray;

            txtsalary.Clear();
            txtsalary.Text = "Salary";
            txtsalary.ForeColor = Color.Gray;

            txtage.Clear();
            txtage.Text = "Age";
            txtage.ForeColor = Color.Gray;

            cbxsd.SelectedIndex = -1;
            cbxstime.SelectedIndex = -1;

            joindatedpt.Value = DateTime.Now;
        }


        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "Enter Name" || txtemail.Text == "Email" || txtmobile.Text == "Mobile No" || cbxstime.Text == "" || cbxsd.Text == "" || txtage.Text=="Age" || txtsalary.Text=="Salary")
            {
                MB m = new MB();
                m.Show();
            }
            else
            {
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
                string q = "Select * from addstaff";
                sda = new SqlDataAdapter(q, con);
                sda.Fill(ds, "tbladd");

                SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                ds.Tables["tbladd"].Rows.Add(txtname.Text, txtemail.Text, txtmobile.Text,txtsalary.Text,txtage.Text,joindatedpt.Text, gender, cbxstime.Text, cbxsd.Text);
                sda.Update(ds.Tables["tbladd"]);
                ds.AcceptChanges();
                MBAdd mb = new MBAdd();
                mb.Show();
                resetboxes();
            }
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtname.Text == "Enter Name")
            {
                txtname.Text = "";
                txtname.ForeColor = Color.White;
            }
        }

        private void txtemail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtemail.Text == "Email")
            {
                txtemail.Text = "";
                txtemail.ForeColor = Color.White;
            }
        }

        private void txtmobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtmobile.Text == "Mobile No")
            {
                txtmobile.Text = "";
                txtmobile.ForeColor = Color.White;
            }
        }

        private void txtsalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtsalary.Text == "Salary")
            {
                txtsalary.Text = "";
                txtsalary.ForeColor = Color.White;
            }
        }

        private void txtage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtage.Text == "Age")
            {
                txtage.Text = "";
                txtage.ForeColor = Color.White;
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            resetboxes();
        }
    }
}
