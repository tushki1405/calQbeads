using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Controller
{
    public static class UISettings
    {

        #region Variables

        //Variable for MDIContainer
        private static Form mainWindow;

        private static MenuStrip menuBar;
        public static MenuStrip MenuBar
        {
            get { return UISettings.menuBar; }
            set { UISettings.menuBar = value; }
        }

        private static bool showMenuItems;
        public static bool ShowMenuItems
        {
            set 
            {
                foreach (ToolStripItem item in MenuBar.Items)
                {
                    if (item.Text != "&File" && item.Text != "&Help")
                    {
                        item.Visible = value;
                    }
                }
                UISettings.showMenuItems = value; 
            }
            get
            {
                return UISettings.showMenuItems;
            }
        }

        private static PictureBox homeButton;

        public static PictureBox HomeButton
        {
            get { return UISettings.homeButton; }
            set { UISettings.homeButton = value; }
        }


        #endregion

        #region functions

        //Set individual control properties dynamically
        private static void SetControlProperties(Control ctr)
        {
            //Button
            if (ctr.GetType() == typeof(Button))
            {
                ctr.BackColor = Controller.UISettingsValues.buttonBackColor;
                ctr.ForeColor = Controller.UISettingsValues.buttonForeColor;
            }
            //ComboBox
            else if (ctr.GetType() == typeof(ComboBox))
            {
                ComboBox temp = (ComboBox)ctr;
                ctr.BackColor = Controller.UISettingsValues.comboBoxColor;
                ctr.Font = Controller.UISettingsValues.comboBoxFont;
                temp.KeyDown +=new KeyEventHandler(Validations.Suppress);
            }
            //Text Box
            else if (ctr.GetType() == typeof(TextBox))
            {
                TextBox temp = (TextBox)ctr;
                temp.BorderStyle = BorderStyle.FixedSingle;
            }
            //LinkLabel
            else if (ctr.GetType() == typeof(LinkLabel))
            {
                LinkLabel temp = (LinkLabel)ctr;
                temp.Font = Controller.UISettingsValues.linkLabelFont;
            }
            else if (ctr.GetType() == typeof(ListBox))
            {
            }
            //GridView
            else if (ctr.GetType() == typeof(DataGridView))
            {
                DataGridView temp = (DataGridView)ctr;
                temp.AllowUserToAddRows = false;
                temp.AllowUserToDeleteRows = false;
                temp.AllowUserToOrderColumns = false;
                temp.RowHeadersVisible = false;
                temp.ColumnHeadersDefaultCellStyle = SetGridViewCellStyle(true);
                temp.DefaultCellStyle = SetGridViewCellStyle(false);
                temp.BackgroundColor = UISettingsValues.gridViewBackColor;
                temp.EnableHeadersVisualStyles = false;
                temp.AllowUserToResizeRows = false;
            }
        }

        static void temp_DrawItem(object sender, DrawItemEventArgs e)
        {
            throw new NotImplementedException();
        }

        //Set all windows properties
        public static void SetWindowProperties(Form win)
        {
            //win.Size = new Size(700, 480);
            win.Size = new Size(577, 404);
            win.Text = "CalQBeads v2.0";
            win.FormBorderStyle = FormBorderStyle.None;
            win.MinimizeBox = false;
            win.MaximizeBox = false;
            win.ControlBox = false;
            win.ShowIcon = false;
            win.Dock = DockStyle.Fill;
            //win.WindowState = FormWindowState.Maximized;
            
            //Set colors and font
            win.Font = Controller.UISettingsValues.textFont;
            win.ForeColor = Controller.UISettingsValues.textColor;
            win.BackColor = Controller.UISettingsValues.backgroundColor;


            //To execute when new form is to be opened
            //code sets the parent for current child
            Form[] children = mainWindow.MdiChildren;
            foreach (Form child in children)
            {
                child.Close();
            }

            win.MdiParent = mainWindow;
            win.StartPosition = FormStartPosition.Manual;
            win.Location = new Point(0, 0);

            //Apply design to every control
            foreach (Control ctr in win.Controls)
            {
                SetControlProperties(ctr);
                
                //1st level Nesting
                foreach (Control child in ctr.Controls)
                {
                    SetControlProperties(child);
                    
                    //2nd Level Nesting
                    foreach (Control child2 in child.Controls)
                    {
                        SetControlProperties(child2);
                    }
                }
            }
            win.Show();
        }

        //Set all windows properties without opening in parent
        public static void SetWindowPropertiesNoParent(Form win, bool show = true)
        {
            //win.Size = new Size(320, 250);
            win.Text = "CalQBeads v2.0";
            win.FormBorderStyle = FormBorderStyle.FixedSingle;
            win.MinimizeBox = false;
            win.MaximizeBox = false;
            win.ControlBox = true;
            win.ShowIcon = false;
            win.ShowInTaskbar = false;
            win.Dock = DockStyle.Fill;
            //win.WindowState = FormWindowState.Maximized;

            //Set colors and font
            win.Font = Controller.UISettingsValues.textFont;
            win.ForeColor = Controller.UISettingsValues.textColor;
            win.BackColor = Controller.UISettingsValues.backgroundColor;


            win.StartPosition = FormStartPosition.CenterScreen;

            //Apply design to every control
            foreach (Control ctr in win.Controls)
            {
                SetControlProperties(ctr);

                //1st level Nesting
                foreach (Control child in ctr.Controls)
                {
                    SetControlProperties(child);

                    //2nd Level Nesting
                    foreach (Control child2 in child.Controls)
                    {
                        SetControlProperties(child2);
                    }
                }
            }

            if (show)
            {
                win.ShowDialog();
            }
        }


        //Set properties for Main Window
        public static void SetMainWindowProperties(Form win)
        {
            win.IsMdiContainer = true;
            win.FormBorderStyle = FormBorderStyle.None;
            win.MaximizeBox = false;
            win.StartPosition = FormStartPosition.CenterScreen;
            win.Size = new Size(850, 600);
            win.Icon = new Icon(UISettingsValues.icon);
            win.Text = "CalQBeads v2.0";

            mainWindow = win;
        }

        //Set properties for Menu Bar
        public static void SetMenuBarProperties(MenuStrip menu, Panel panel)
        {
            menu.Font = Controller.UISettingsValues.menuFont;
            menu.BackColor = Controller.UISettingsValues.menuBackgroundColor;
            panel.BackColor = Controller.UISettingsValues.menuBackgroundColor;
            menu.ForeColor = Controller.UISettingsValues.menuTextColor;
            menu.Height = 137;
        }

        //Set properties for Status Bar
        public static void SetStatusBarProperties(StatusStrip status)
        {
            status.Font = Controller.UISettingsValues.statusFont;
            status.BackColor = Controller.UISettingsValues.statusBackgroundColor;
            status.ForeColor = Controller.UISettingsValues.statusTextColor;
        }

        //Set properties for Panels
        public static void SetBorderPanelsDesign(Panel panel, int orientation)
        {
            
            if (orientation == 0)
            {
                panel.BackColor = UISettingsValues.borderColor;
                panel.Height = 2;
            }
            else if (orientation == 1)
            {
                panel.BackColor = UISettingsValues.borderColor;
                panel.Width = 2;
            }
            else if (orientation == 2)
            {
                panel.BackColor = UISettingsValues.borderColor;
                panel.Height = 2;
            }
            else
            {
                panel.BackColor = UISettingsValues.borderColor;
                panel.Width = 2;
            }
        }

        //Code for setting property of Error Messages
        public static void SetErrorMessage(Label msg)
        {
            msg.Font = UISettingsValues.errorFont;
            msg.ForeColor = UISettingsValues.errorColor;
            //msg.Visible = false;
            msg.Text = "";
        }

        //Code for setting dataGridViewHeader Style
        public static DataGridViewCellStyle SetGridViewCellStyle(bool Head)
        {
            DataGridViewCellStyle head = new DataGridViewCellStyle();
            if (Head)
            {
                head.Alignment = DataGridViewContentAlignment.MiddleCenter;
                head.Font = UISettingsValues.gridViewHeaderFont;
                head.BackColor = UISettingsValues.gridViewHeaderColor;
            }
            else
            {
                head.BackColor = UISettingsValues.gridViewColor;
                head.Font = UISettingsValues.gridViewFont;
            }
            return head;
        }

        #endregion
    }
}
