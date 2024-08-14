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
using System.Text.RegularExpressions;

namespace GymManagementSystem
{
    public partial class AddMember : Form
    {
        DBHelper db = new DBHelper();
        DataSet ds;
        SqlDataAdapter sda;
        DateTime joindate = DateTime.Now;
        string gender = "Male";

        public static string emailpattern = @"^[a-z]+@(gmail).com$";
        public static string nopattern = @"^(03|\+923)(\d{2}-?\d{7})$";
        public AddMember()
        {
            InitializeComponent();
        }
        Regex e1 = new Regex(emailpattern);
        Regex n = new Regex(nopattern);

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtfirstname.Text== "Enter Name" || txtemail.Text== "Email" || txtmobile.Text== "Mobile No" || cbxgymtime.Text=="" || cbxmembershiptime.Text=="")
            {
                MB m = new MB();
                m.Show();
            }
            else
            {
                bool p1 = n.IsMatch(txtmobile.Text);
                bool p2 = e1.IsMatch(txtemail.Text);
                if (p1 == true && p2 == true)
                {
                    string constr = @"Data Source=DESKTOP-NF1C7NA\SQLEXPRESS; initial catalog=GymManagementSystem ;integrated security=true;";
                    ds = new DataSet();
                    if (rdbtnmale.Checked == true)
                    {
                        gender = rdbtnmale.Text;
                    }
                    else
                    {
                        gender = rdbtnfemale.Text;
                    }
                    DateTime dob = dtpdob.Value;
                    double days = DateTime.Now.Subtract(dob).TotalDays;

                    SqlConnection con = new SqlConnection(constr);
                    con.Open();
                    string q = "Select * from addmember";
                    sda = new SqlDataAdapter(q, con);
                    sda.Fill(ds, "tbladd");

                    SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                    ds.Tables["tbladd"].Rows.Add(txtfirstname.Text, txtemail.Text, txtmobile.Text, (int)days / 365, gender, cbxgymtime.Text, txtfee.Text, cbxmembershiptime.Text, DateTime.Now.ToShortDateString(), renewalDatepicker.Value.ToShortDateString());
                    sda.Update(ds.Tables["tbladd"]);
                    ds.AcceptChanges();
                    MBAdd mb = new MBAdd();
                    mb.Show();
                    resetboxes();
                    txtfee.ForeColor = Color.Gray;
                }
                else 
                {
                    MessageBox.Show("Pattern Does Not Matched", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cbxmembershiptime_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtfee.ForeColor = Color.White;

            int m1 = 500, m3 = 1500, m6 = 3000, m12 = 6000;
            if (cbxmembershiptime.SelectedIndex == 0)
            {
                renewalDatepicker.Value = DateTime.Now.AddDays(30);
                txtfee.Text =m1.ToString() ;
            }
            if (cbxmembershiptime.SelectedIndex == 1)
            {
                renewalDatepicker.Value = DateTime.Now.AddDays(90);
                txtfee.Text = m3.ToString();
            }
            if (cbxmembershiptime.SelectedIndex == 2)
            {
                renewalDatepicker.Value = DateTime.Now.AddDays(160);
                txtfee.Text = m6.ToString();
            }
            if (cbxmembershiptime.SelectedIndex == 3)
            {
                renewalDatepicker.Value = DateTime.Now.AddDays(365);
                txtfee.Text = m12.ToString();
            }
        }

        private void AddMember_Load(object sender, EventArgs e)
        {

        }
        private void resetboxes()
        {
            txtfirstname.Clear();
            txtfirstname.Text = "Enter Name";
            txtfirstname.ForeColor = Color.Gray;

            txtemail.Clear();
            txtemail.Text = "Email";
            txtemail.ForeColor = Color.Gray;

            txtmobile.Clear();
            txtmobile.Text = "Mobile No";
            txtmobile.ForeColor = Color.Gray;

            txtfee.Clear();
            txtfee.Text = "Fee Paid";
            txtfee.ForeColor = Color.Gray;

            cbxgymtime.SelectedIndex = -1;
            cbxmembershiptime.SelectedIndex = -1;
            dtpdob.Value = DateTime.Now;
            renewalDatepicker.Value = DateTime.Now;
        }
        private void btnviewequipments_Click(object sender, EventArgs e)
        {
            resetboxes();
        }

        private void txtfirstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtfirstname.Text == "Enter Name")
            {
                txtfirstname.Text = "";
                txtfirstname.ForeColor = Color.White;
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

        private void txtfee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtfee.Text == "Fee Paid")
            {
                txtfee.Text = "";
                txtfee.ForeColor = Color.White;
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        int a = 111;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (txtfirstname.Text == "Enter Name" || txtemail.Text == "Email" || txtmobile.Text == "Mobile No" || cbxgymtime.Text == "" || cbxmembershiptime.Text == "")
            {
                MessageBox.Show("Please Add member first", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                a++;
                DateTime dob = dtpdob.Value;
                double days = joindate.Subtract(dob).TotalDays;
                int y = 35;
                string line = "___________________________________________________________________________________________________________";
                e.Graphics.DrawString("Gym Management System", new Font("Arial", 25, FontStyle.Bold), Brushes.Black, new Point(250, y));
                y += 70;
                e.Graphics.DrawString(line, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(0, y));
                y += 70;
                e.Graphics.DrawString("Date : " + joindate.ToShortDateString() + "", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(600, y));

                e.Graphics.DrawString("Receipt no : " + a + "", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(45, y));

                y += 50;
                e.Graphics.DrawString("Member Detail :", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(50, y));
                y += 40;
                e.Graphics.DrawString("Name : " + txtfirstname.Text + " ", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(50, y));
                y += 30;
                e.Graphics.DrawString("Email : " + txtemail.Text + "", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(50, y));
                y += 30;
                e.Graphics.DrawString("Mobile no : " + txtmobile.Text + "", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(50, y));
                y += 30;
                e.Graphics.DrawString("Age : " + (int)days / 365 + "", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(50, y));
                y += 30;
                e.Graphics.DrawString("Gender : " + gender + "", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(50, y));
                y += 50;
                e.Graphics.DrawString("MemberShip Detail :", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(50, y));
                y += 40;
                e.Graphics.DrawString("Date of joining : " + joindate.ToShortDateString() + "", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(50, y));
                y += 30;
                e.Graphics.DrawString("Expire on : " + renewalDatepicker.Value.ToShortDateString() + "", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(50, y));
                y += 30;
                e.Graphics.DrawString("Gym Time : " + cbxgymtime.Text + "", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(50, y));
                y += 30;
                e.Graphics.DrawString("Membership Time : " + cbxmembershiptime.Text + "", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(50, y));
                y += 30;
                e.Graphics.DrawString("Fee Paid : " + txtfee.Text + "", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(50, y));
                y += 30;
                e.Graphics.DrawString(line, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(50, y));
                y += 50;
                e.Graphics.DrawString("Thanks For Joining", new Font("Arial", 23, FontStyle.Regular), Brushes.Black, new Point(250, y));

            }
        }
    }
}
