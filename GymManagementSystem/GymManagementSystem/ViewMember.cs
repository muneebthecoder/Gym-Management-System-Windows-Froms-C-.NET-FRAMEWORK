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
    public partial class ViewMember : Form
    {
        string constr = @"Data Source=DESKTOP-NF1C7NA\SQLEXPRESS; initial catalog=GymManagementSystem ;integrated security=true;";
        string q = "select * from addmember";
        DataSet ds;
        SqlDataAdapter sda;
        int a1 = 0;
        public ViewMember()
        {
            InitializeComponent();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("Please selet any record", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand("Delete From addmember Where ID = '" + txtid.Text + "'", con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfully deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ViewMember_Load_1(sender, e);
                clear();
            }
        }
        private void clear()
        {
            txtname.Clear();
            txtmobile.Clear();
            txtemail.Clear();
            cbxgymtime.SelectedIndex = -1;
            txtage.Clear();
            txtFeepaid.Clear();
            renewalDatepicker.Value = DateTime.Now;
            cbxmembershiptime.SelectedIndex = -1;
            cbxgender.SelectedIndex = -1;
        }

        private void ViewMember_Load_1(object sender, EventArgs e)
        {
/*            ds = new DataSet();
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand(q, con);
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            con.Close();
            dgvsearch.DataSource = ds.Tables[0];
            GetMembersData();*/
        }
        private void GetMembersData()
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("Select * from addMember", con);

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();

            DataTable dtclients = new DataTable();
            dtclients.Load(sdr);
            con.Close();
            dgvsearch.DataSource = dtclients;

            decimal Total = 0;

            for (int i = 0; i < dgvsearch.Rows.Count; i++)
            {
                Total += Convert.ToDecimal(dgvsearch.Rows[i].Cells["FeePaid"].Value);
            }


            totallabel.Text = Total.ToString();


            string sql = "Select * from AddMember";

            con.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(ds);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            dgvsearch.DataSource = ds.Tables[0];

            totalmemberslabel.Text = ds.Tables[0].Rows.Count.ToString();
        }

        private void dgvsearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row1 = this.dgvsearch.Rows[e.RowIndex];
            a1= int.Parse(row1.Cells["FeePaid"].Value.ToString());
            DateTime t= DateTime.Parse(row1.Cells["Renewal on"].Value.ToString());
            if (e.RowIndex >= 0 && t>= DateTime.Now)
            {
                DataGridViewRow row2 = this.dgvsearch.Rows[e.RowIndex];

                top();
                txtid.Text = row2.Cells["ID"].Value.ToString();
                txtname.Text = row2.Cells["Name"].Value.ToString();
                cbxgender.Text = row2.Cells["Gender"].Value.ToString();
                txtage.Text = row2.Cells["Age"].Value.ToString();
                txtmobile.Text = row2.Cells["Mobile no"].Value.ToString();
                txtemail.Text = row2.Cells["Email"].Value.ToString();
                renewalDatepicker.Text = row2.Cells["Renewal on"].Value.ToString();
        //        cbxmembershiptime.Text = row2.Cells["Membership Time"].Value.ToString();
                txtFeepaid.Text = row2.Cells["FeePaid"].Value.ToString();
                cbxgymtime.Text = row2.Cells["Gym Time"].Value.ToString();
            }
            else if (e.RowIndex >= 0)
            {
                DataGridViewRow row3 = this.dgvsearch.Rows[e.RowIndex];

                txtFeepaid.Enabled = true;
                cbxmembershiptime.Enabled = true;
                txtid.Text = row3.Cells["ID"].Value.ToString();
                txtname.Text = row3.Cells["Name"].Value.ToString();
                cbxgender.Text = row3.Cells["Gender"].Value.ToString();
                txtage.Text = row3.Cells["Age"].Value.ToString();
                txtmobile.Text = row3.Cells["Mobile no"].Value.ToString();
                txtemail.Text = row3.Cells["Email"].Value.ToString();
                renewalDatepicker.Text = row3.Cells["Renewal on"].Value.ToString();
          //      cbxmembershiptime.Text = row3.Cells["Membership Time"].Value.ToString();
                txtFeepaid.Text = row3.Cells["FeePaid"].Value.ToString();
                cbxgymtime.Text = row3.Cells["Gym Time"].Value.ToString();
            }
        }

        void top() {
            txtFeepaid.Enabled = false;
            cbxmembershiptime.Enabled = false;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("Please selet any record", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand("Update AddMember set Name = '" + txtname.Text + "', Gender = '" + cbxgender.Text + "', Age = '" + txtage.Text + "', [Mobile no] = '" + txtmobile.Text + "', Email = '" + txtemail.Text + "', [Renewal on] = '" + renewalDatepicker.Text + "', [Membership Time] = '" + cbxmembershiptime.Text + "', FeePaid = '" + txtFeepaid.Text + "', [Gym Time] = '" + cbxgymtime.Text + "' Where ID ='" + txtid.Text + "' ", con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Member Details Updated Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                GetMembersData();
            }
            
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtsearch.Text == "Search By Name" || txtsearch.Text == string.Empty)
            {
                MessageBox.Show("Please enter Member Name to Search");
            }
            else
            {
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand("Select * from AddMember Where name LIKE '%" + txtsearch.Text + "%'", con);

                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                DataTable dtmember = new DataTable();
                dtmember.Load(sdr);
                con.Close();
                dgvsearch.DataSource = dtmember;
            }
        }

        private void txtsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtsearch.Text == "Search By Name")
            {
                txtsearch.Text = "";
                txtsearch.ForeColor = Color.White;
            }
        }

        private void cbxmembershiptime_SelectedIndexChanged(object sender, EventArgs e)
        {
            int m1 = 500, m3 = 1500, m6 = 3000, m12 = 6000;
            
            if (cbxmembershiptime.SelectedIndex == 0)
            {
                renewalDatepicker.Value = DateTime.Now.AddDays(30);
                m1 += a1;
                txtFeepaid.Text= m1.ToString();
            }
            if (cbxmembershiptime.SelectedIndex == 1)
            {
                renewalDatepicker.Value = DateTime.Now.AddDays(90);
                m3 += a1;
                txtFeepaid.Text = m1.ToString();
                txtFeepaid.Text = m3.ToString();
            }
            if (cbxmembershiptime.SelectedIndex == 2)
            {
                renewalDatepicker.Value = DateTime.Now.AddDays(160);
                m6 += a1;
                txtFeepaid.Text = m1.ToString();
                txtFeepaid.Text = m6.ToString();
            }
            if (cbxmembershiptime.SelectedIndex == 3)
            {
                renewalDatepicker.Value = DateTime.Now.AddDays(365);
                m12 += a1;
                txtFeepaid.Text = m1.ToString();
                txtFeepaid.Text = m12.ToString();
            }
        }
    }
}
