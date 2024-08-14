using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class Home : Form
    {
        bool sidebarExpand;
        public Home()
        {
            InitializeComponent();
        }

        private void sidebartimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                flp.Width -= 10;
                if (flp.Width == flp.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebartimer.Stop();
                }
            }
            else
            {
                flp.Width += 10;
                if (flp.Width == flp.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebartimer.Stop();
                }
            }
        }

        private void iconbar_Click(object sender, EventArgs e)
        {
            sidebartimer.Start();
        }

        private void btnx_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnaddmember_Click(object sender, EventArgs e)
        {
            AddMember am = new AddMember();
            am.TopLevel = false;
            panel8.Controls.Add(am);
            am.BringToFront();
            am.Show();
        }

        private void btnequipments_Click(object sender, EventArgs e)
        {
            Equipments eq = new Equipments();
            eq.TopLevel = false;
            panel8.Controls.Add(eq);
            eq.BringToFront();
            eq.Show();
        }

        private void btnexitss_Click(object sender, EventArgs e)
        {
            Form1 lg = new Form1();
            this.Hide();
            lg.Show();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            HomeMenu hm = new HomeMenu();
            hm.TopLevel = false;
            panel8.Controls.Add(hm);
            hm.BringToFront();
            hm.Show();

        }

        private void Home_Load(object sender, EventArgs e)
        {
            HomeMenu hm = new HomeMenu();
            hm.TopLevel = false;
            panel8.Controls.Add(hm);
            hm.BringToFront();
            hm.Show();
        }

        private void btnsearchmember_Click(object sender, EventArgs e)
        {
            ViewEquipments hm = new ViewEquipments();
            hm.TopLevel = false;
            panel8.Controls.Add(hm);
            hm.BringToFront();
            hm.Show();
        }

        private void btndeletemember_Click(object sender, EventArgs e)
        {
            ViewMember hm = new ViewMember();
            hm.TopLevel = false;
            panel8.Controls.Add(hm);
            hm.BringToFront();
            hm.Show();
        }

        private void btnaddstaff_Click(object sender, EventArgs e)
        {
            AddStaff hm = new AddStaff();
            hm.TopLevel = false;
            panel8.Controls.Add(hm);
            hm.BringToFront();
            hm.Show();
        }

        private void btnViewStaff_Click(object sender, EventArgs e)
        {
            ViewStaff hm = new ViewStaff();
            hm.TopLevel = false;
            panel8.Controls.Add(hm);
            hm.BringToFront();
            hm.Show();
        }
    }
}
