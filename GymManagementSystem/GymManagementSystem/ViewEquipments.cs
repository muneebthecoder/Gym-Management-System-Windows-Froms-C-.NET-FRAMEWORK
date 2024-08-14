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
    public partial class ViewEquipments : Form
    {
        string constr = @"Data Source=DESKTOP-NF1C7NA\SQLEXPRESS; initial catalog=GymManagementSystem ;integrated security=true;";
        string q = "select * from equipments";
        DataSet ds;
        SqlDataAdapter sda;
        public ViewEquipments()
        {
            InitializeComponent();
        }
        private void resetboxes()
        {
            txtename.Clear();
            txtename.Text = "Equpiment Name";
            txtename.ForeColor = Color.Gray;

            txtcost.Clear();
            txtcost.Text = "Equipment Cost";
            txtcost.ForeColor = Color.Gray;

            txtquantity.Clear();
            txtquantity.Text = "Equipment Quantity";
            txtquantity.ForeColor = Color.Gray;

            txtweight.Clear();
            txtweight.Text = "Equipment Weight";
            txtweight.ForeColor = Color.Gray;

            cbxtype.SelectedIndex = -1;
        }
        private void GetEquipmentData()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("Select * from Equipments", con);

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();

            dt.Load(sdr);
            con.Close();

            dgvsearch.DataSource = dt;

            decimal Total = 0;

            for (int i = 0; i < dgvsearch.Rows.Count; i++)
            {
                Total += Convert.ToDecimal(dgvsearch.Rows[i].Cells["Equipment Cost"].Value);
            }


            totalspentlabel.Text = Total.ToString();

            string sql = "Select * from Equipments";

            con.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(ds);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            dgvsearch.DataSource = ds.Tables[0];

            totalequiplabel.Text = ds.Tables[0].Rows.Count.ToString();
        }

        private void dgvsearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtweight.ForeColor = Color.White;
            txtename.ForeColor = Color.White;
            txtquantity.ForeColor = Color.White;
            txtcost.ForeColor = Color.White;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvsearch.Rows[e.RowIndex];
                txtid.Text = row.Cells["ID"].Value.ToString();
                txtename.Text = row.Cells["Equipment Name"].Value.ToString();
                txtquantity.Text = row.Cells["Equipment Quantity"].Value.ToString();
                txtcost.Text = row.Cells["Equipment Cost"].Value.ToString();
                txtweight.Text = row.Cells["Equipment Weight"].Value.ToString();
                cbxtype.Text = row.Cells["Equipment Cost"].Value.ToString();
                dtpdd.Text = row.Cells["Delivery Date"].Value.ToString();
            }
        }

        private void ViewEquipments_Load(object sender, EventArgs e)
        {
            /*ds = new DataSet();
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand(q, con);
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            con.Close();
            dgvsearch.DataSource = ds.Tables[0];
            GetEquipmentData();*/
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

                SqlCommand cmd = new SqlCommand("Update Equipments Set [Equipment Name] = '" + txtename.Text + "', [Equipment Type] = '" + cbxtype.Text + "', [Equipment Quantity] = '" + txtquantity.Text + "', [Equipment Weight] = '" + txtweight.Text + "', [Equipment Cost] = '" + txtcost.Text + "',[Delivery Date] = '" + dtpdd.Text + "' Where ID ='" + txtid.Text + "'", con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetboxes();
            }
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
                SqlCommand cmd = new SqlCommand("Delete From Equipments Where ID = '" + txtid.Text + "'", con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfully deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ViewEquipments_Load(sender, e);
            }
        }
    }
}
