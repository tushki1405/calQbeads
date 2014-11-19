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
    public partial class Splash : Form
    {
        int i=0;

        public Splash()
        {
            InitializeComponent();
            Controller.UISettings.SetWindowPropertiesNoParent(this, false);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            setUI();
        }

        private void setUI()
        {
            pictureBox1.ImageLocation = Controller.UISettingsValues.iconImagePNG;
            lbl_newName.Font = new Font("Tahoma", 18, FontStyle.Bold);
            lbl_version.Font = new Font("Tahoma", 10);
            lbl_created.Font = new Font("Tahoma", 9);
            lbl_name.Font = new Font("Tahoma", 9, FontStyle.Bold);
            ll_url.Font = new Font("Tahoma", 9);
            lbl_message.Font = new Font("Tahoma", 9);
            lbl_message2.Font = new Font("Tahoma", 9);

            pnl_bottom.BackColor = Controller.UISettingsValues.borderColor;
            pnl_top.BackColor = Controller.UISettingsValues.borderColor;
            pnl_left.BackColor = Controller.UISettingsValues.borderColor;
            pnl_right.BackColor = Controller.UISettingsValues.borderColor;
       }

        private void timer_openApp_Tick(object sender, EventArgs e)
        {
            i++;
            pb_load.PerformStep();
            if (i == 13)
            {
                timer_openApp.Stop();
                Shared.MainWindow win = new Shared.MainWindow();
                win.Show();
                this.Hide();
            }
        }

        private void ll_url_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://guptatushar.in");
        }
    }
}
