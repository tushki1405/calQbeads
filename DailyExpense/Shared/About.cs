using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DailyExpense.Shared
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            Controller.UISettings.SetWindowPropertiesNoParent(this);
            setUI();
        }

        private void setUI()
        {
            //lbl_feedback.Font = new Font("Tahoma", 6);
            //lbl_name.Font = new Font("Tahoma", 9, FontStyle.Bold);
            //lbl_app.Font = new Font("Tahoma", 18, FontStyle.Bold);
            //lbl_version.Font = new Font("Tahoma", 10);
        }

        private void ll_dem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://guptatushar.in/DailyExpense");
        }

        private void ll_gt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://guptatushar.in");
        }
    }
}
