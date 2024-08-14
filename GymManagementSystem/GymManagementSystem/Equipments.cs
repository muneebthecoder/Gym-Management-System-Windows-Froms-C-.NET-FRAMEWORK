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
    public partial class Equipments : Form
    {
        DataSet ds;
        SqlDataAdapter sda;
        string constr = @"Data Source=DESKTOP-NF1C7NA\SQLEXPRESS; initial catalog=GymManagementSystem ;integrated security=true;";
        string q = "Select * from equipments";

        public Equipments()
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
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtename.Text == "Equpiment Name" || txtcost.Text == "Equipment Cost" || txtquantity.Text == "Equipment Quantity" || txtweight.Text == "Equipment Weight" || cbxtype.SelectedIndex==-1)
            {
                MB m = new MB();
                m.Show();
            }
            else
            {
                ds = new DataSet();
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                sda = new SqlDataAdapter(q, con);
                sda.Fill(ds, "tbleq");

                SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                ds.Tables["tbleq"].Rows.Add(txtename.Text, txtquantity.Text, txtcost.Text, txtweight.Text, dtpdd.Text,cbxtype.Text);
                sda.Update(ds.Tables["tbleq"]);
                ds.AcceptChanges();
                resetboxes();
            }
        }

        private void btnviewequipments_Click(object sender, EventArgs e)
        {
            resetboxes();
        }

        private void txtename_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtename.Text == "Equpiment Name")
            {
                txtename.Text = "";
                txtename.ForeColor = Color.White;
            }
        }

        private void txtquantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtquantity.Text == "Equipment Quantity")
            {
                txtquantity.Text = "";
                txtquantity.ForeColor = Color.White;
            }
        }

        private void txtcost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtcost.Text == "Equipment Cost")
            {
                txtcost.Text = "";
                txtcost.ForeColor = Color.White;
            }
        }

        private void txtweight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtweight.Text == "Equipment Weight")
            {
                txtweight.Text = "";
                txtweight.ForeColor = Color.White;
            }
        }

        private void Equipments_Load(object sender, EventArgs e)
        {

        }
    }
}
