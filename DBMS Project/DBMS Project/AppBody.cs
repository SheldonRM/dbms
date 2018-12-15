using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_Project
{
    public partial class AppBody : Form
    {
        public AppBody()
        {
            InitializeComponent();
        }

        private void AppBody_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        //sliding panel code
        bool isSlidingPanelExpanded;
        const int MaxSliderHeight = 53;
        const int MinSliderHeight = 30;

        private void SlidingPanel_ToggleButton_Click(object sender, EventArgs e)
        {
            if(isSlidingPanelExpanded)
            {
                //retract panel
            }
            SlidingPanel_Timer.Start();
        }

        public void expandSlidingPanelGUI()
        {
            //gui adjustments for expanding
            PatientsButton.Text = "BOOKS";
            MedicalRecordsButton.Text = "RECORDS";
            StaffButton.Text = "STAFF";
            SettingsButton.Text = "SETTINGS";
            AboutButton.Text = "ABOUT";
            LogOutButton.Text = "LOG OUT";
        }



        private void SlidingPanel_Timer_Tick(object sender, EventArgs e)
        {
            if(isSlidingPanelExpanded)
            {
                //retract
                SlidingPanel.Height -= 30;
                if(SlidingPanel.Height <= MinSliderHeight)
                {
                    //stop retract
                    isSlidingPanelExpanded = false;
                    SlidingPanel_Timer.Stop();

                    this.Refresh();
                }

            }
            else
            {
                //expand the panel
                SlidingPanel.Height += 30;
                if (SlidingPanel.Height >= MaxSliderHeight)
                {
                    //stop expand
                    isSlidingPanelExpanded = true;
                    SlidingPanel_Timer.Stop();

                    this.Refresh();
                }
            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void PatientsButton_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Patients_UserControl.Instance))
            {
                ContentPanel.Controls.Add(Patients_UserControl.Instance);
                Patients_UserControl.Instance.Dock = DockStyle.Fill;
                Patients_UserControl.Instance.BringToFront();
            }
            else
            {
                Patients_UserControl.Instance.BringToFront();
            }
        }

        private void MedicalRecordsButton_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Records_UserControl.Instance))
            {
                ContentPanel.Controls.Add(Records_UserControl.Instance);
                Records_UserControl.Instance.Dock = DockStyle.Fill;
                Records_UserControl.Instance.BringToFront();
            }
            else
            {
                Records_UserControl.Instance.BringToFront();
            }
        }

        private void StaffButton_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Staff_UserControl.Instance))
            {
                ContentPanel.Controls.Add(Staff_UserControl.Instance);
                Staff_UserControl.Instance.Dock = DockStyle.Fill;
                Staff_UserControl.Instance.BringToFront();
            }
            else
            {
                Staff_UserControl.Instance.BringToFront();
            }
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Settings_UserControl.Instance))
            {
                ContentPanel.Controls.Add(Settings_UserControl.Instance);
                Settings_UserControl.Instance.Dock = DockStyle.Fill;
                Settings_UserControl.Instance.BringToFront();
            }
            else
            {
                Settings_UserControl.Instance.BringToFront();
            }
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(About_UserControl.Instance))
            {
                ContentPanel.Controls.Add(About_UserControl.Instance);
                About_UserControl.Instance.Dock = DockStyle.Fill;
                About_UserControl.Instance.BringToFront();
            }
            else
            {
                About_UserControl.Instance.BringToFront();
            }
        }
    }
}
