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
    public partial class HomeMenu : Form
    {
        string constr = @"Data Source=DESKTOP-NF1C7NA\SQLEXPRESS; initial catalog=GymManagementSystem ;integrated security=true;";

        public HomeMenu()
        {
            InitializeComponent();
        }

        private void HomeMenu_Load(object sender, EventArgs e)
        {/*
            totalclients();
            totalclients();
            totalstaff();
            totalequipments();
            loadExpiryingAccounts();
            loadTopFeePaidgAccounts();
            loadOldMembers();*/
        }
        private void loadExpiryingAccounts()
        {
            SqlConnection con = new SqlConnection(constr);
            //            SqlCommand cmd = new SqlCommand("Select ID, name, [Join Date], [Renewal on] from AddMember Where [Renewal on] Between '" + dateTime.Value.ToString() + "' And '" + dateTime.Value.AddDays(7).ToString() + "' ", con);

            SqlCommand cmd = new SqlCommand("Select Id, Name, [Join Date], [Renewal on] from AddMember Where [Join Date]>[Renewal on]", con);

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtclients = new DataTable();
            dtclients.Load(sdr);
          //  dtclients.AsEnumerable().Select(s=>s[])
            con.Close();
            ExpiryDates.DataSource = dtclients;
        }
        private void loadTopFeePaidgAccounts()
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("Select top 1 Id, Name, FeePaid, [Membership Time] from AddMember order by feepaid desc ", con);

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtclients = new DataTable();
            dtclients.Load(sdr);
            con.Close();
            dgvtop.DataSource = dtclients;
        }
        private void loadOldMembers()
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("Select top 5 Id, Name, FeePaid, [Membership Time],[Join Date]from AddMember order by [Join Date]  ", con);

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtclients = new DataTable();
            dtclients.Load(sdr);
            con.Close();
            dgvoldmembers.DataSource = dtclients;
        }
        //get total clients number
        private void totalclients()
        {
            SqlConnection con = new SqlConnection(constr);
            string sql = "Select * from AddMember";

            con.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(ds);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            totalclientsDGV.DataSource = ds.Tables[0];

            totalclientslabel.Text = ds.Tables[0].Rows.Count.ToString();
        }
        private void totalstaff()
        {
            SqlConnection con = new SqlConnection(constr);
            string sql = "Select * from addStaff";

            con.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(ds);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            totalstaffDGV.DataSource = ds.Tables[0];

            totalstafflabel.Text = ds.Tables[0].Rows.Count.ToString();
        }
        // get total equipments data
        private void totalequipments()
        {
            SqlConnection con = new SqlConnection(constr);
            string sql = "Select * from Equipments";

            con.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(ds);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            TotalequipmentsDGV.DataSource = ds.Tables[0];

            totalequiplabel.Text = ds.Tables[0].Rows.Count.ToString();
        }
    }
}
