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
    public partial class ViewStaff : Form
    {
        string constr = @"Data Source=DESKTOP-NF1C7NA\SQLEXPRESS; initial catalog=GymManagementSystem ;integrated security=true;";
        string q = "select * from Addstaff";
        DataSet ds;
        SqlDataAdapter sda;
        public ViewStaff()
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

            cbxgender.SelectedIndex = -1;
            cbxsdes.SelectedIndex = -1;
            cbxstime.SelectedIndex = -1;
            joindatedpt.Value = DateTime.Now;
        }
        private void GetStaffDetails()
        {

            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("Select * from addStaff", con);

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();

            DataTable dtstaff = new DataTable();
            dtstaff.Load(sdr);
            con.Close();
            dgvsearch.DataSource = dtstaff;

            decimal Total = 0;

            for (int i = 0; i < dgvsearch.Rows.Count; i++)
            {
                Total += Convert.ToDecimal(dgvsearch.Rows[i].Cells["Salary"].Value);
            }
            totallabel.Text = Total.ToString();


            string sql = "Select * from addStaff";

            con.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(ds);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            dgvsearch.DataSource = ds.Tables[0];

            totalmemberslabel.Text = ds.Tables[0].Rows.Count.ToString();
        }

        private void ViewStaff_Load(object sender, EventArgs e)
        {
            /*ds = new DataSet();
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand(q, con);
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            con.Close();
            dgvsearch.DataSource = ds.Tables[0];
            GetStaffDetails();*/
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
                SqlCommand cmd = new SqlCommand("Update addstaff set Name = '" + txtname + "', Gender ='" + cbxgender.Text + "', Age = '" + txtage.Text + "', [Mobile No] = '" + txtmobile.Text + "', Email = '" + txtemail.Text + "', [Joining Date] ='" + joindatedpt.Text + "' , [Staff Designation] = '" + cbxsdes.Text + "', Salary = '" + txtsalary.Text + "', [Staff Time] = '" + cbxstime.Text + "'  Where Id ='" + txtid.Text + "'", con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Staff Details Updated Successfully", "Saved Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ViewStaff_Load(sender, e);
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            resetboxes();
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
                SqlCommand cmd = new SqlCommand("Delete From addStaff Where id ='" + txtid.Text + "'", con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Staff Reocrd Deleted Successfully", "Delete Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ViewStaff_Load(sender, e);
                resetboxes();
            }
        }

        private void dgvsearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtname.ForeColor = Color.White;
            txtemail.ForeColor = Color.White;
            txtmobile.ForeColor = Color.White;
            txtsalary.ForeColor = Color.White;
            txtage.ForeColor = Color.White;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvsearch.Rows[e.RowIndex];

                txtid.Text = row.Cells["ID"].Value.ToString();
                txtname.Text = row.Cells["Name"].Value.ToString();
                cbxgender.Text = row.Cells["Gender"].Value.ToString();
                txtage.Text = row.Cells["Age"].Value.ToString();
                txtmobile.Text = row.Cells["Mobile No"].Value.ToString();
                txtemail.Text = row.Cells["Email"].Value.ToString();
                joindatedpt.Text = row.Cells["Joining Date"].Value.ToString();
                cbxsdes.Text = row.Cells["Staff Designation"].Value.ToString();
                txtsalary.Text = row.Cells["Salary"].Value.ToString();
                cbxstime.Text = row.Cells["Staff Time"].Value.ToString();
            }
        }
    }
}
