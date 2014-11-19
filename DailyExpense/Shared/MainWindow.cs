using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace DailyExpense.Shared
{
    public partial class MainWindow : Form
    {
        Controller.Database database = new Controller.Database();

        public MainWindow()
        {
            InitializeComponent();
            setDBsettings();
            setUIdesign();
            new UserLanding("Default");
        }

        #region settings
        //Sets the font and all of UI design
        private void setUIdesign()
        {
            //Set Design for MainWindow, MenuBar, StatusBar
            Controller.UISettings.SetMainWindowProperties(this);
            Controller.UISettings.SetMenuBarProperties(this.menuBar, panelHeader);
            Controller.UISettings.SetStatusBarProperties(this.statusBar);

            //Set Design for All Border Panels
            Controller.UISettings.SetBorderPanelsDesign(panelTop, 0);
            Controller.UISettings.SetBorderPanelsDesign(panelRight, 1);
            Controller.UISettings.SetBorderPanelsDesign(panelBottom, 2);
            Controller.UISettings.SetBorderPanelsDesign(panelLeft, 4);

            //Set pictures for close and minimise
            pictureBox1.ImageLocation = Controller.UISettingsValues.closeBtn;
            pictureBox2.ImageLocation = Controller.UISettingsValues.minimiseBtn;
            pictureBox3.ImageLocation = Controller.UISettingsValues.HomeBtn;
            pictureBox4.ImageLocation = Controller.UISettingsValues.iconPNG;

            //Disable menu bar at page load
            Controller.UISettings.MenuBar = menuBar;
            Controller.UISettings.ShowMenuItems = false;

            //Disable Home button at page load
            Controller.UISettings.HomeButton = pictureBox3;
            Controller.UISettings.HomeButton.Visible = false;

            Controller.Messages.StatusMessage = statusLabel;
            Controller.Messages.SetStatusMessage(Controller.Messages.Pages.MainWindow);

            pictureBox3.Visible = false;
        }

        //Sets DB connection strings and other settings
        private void setDBsettings()
        {
            saveFile.Filter = Model.DBSettings.fileFilter;
            openFile.Filter = Model.DBSettings.fileFilter;
        }
        #endregion

        #region DragAndButtons

        //Code to Move Window (Dont Change)
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void Panel_OnClick(object sender, MouseEventArgs e)
        { dragging = true; dragCursorPoint = Cursor.Position; dragFormPoint = this.Location; }
        private void Panel_Drag(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        private void Panel_Leave(object sender, MouseEventArgs e)
        { dragging = false; }
        //Code to Move Window End


        //Buttons at top left corner - minimise and close
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBox1_enter(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Controller.UISettingsValues.closeBtnHover;
        }
        private void pictureBox1_leave(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Controller.UISettingsValues.closeBtn;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void pictureBox2_enter(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = Controller.UISettingsValues.minimiseBtnHover;
        }
        private void pictureBox2_leave(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = Controller.UISettingsValues.minimiseBtn;
        }
        private void item_enter(object sender, EventArgs e)
        {
            ToolStripItem item = (ToolStripItem)sender;
            item.ForeColor = Controller.UISettingsValues.menuTextColorHover;
        }
        private void item_leave(object sender, EventArgs e)
        {
            ToolStripItem item = (ToolStripItem)sender;
            item.ForeColor = Controller.UISettingsValues.menuTextColor;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new Common.Home();
        }
        private void pictureBox3_enter(object sender, EventArgs e)
        {
            pictureBox3.ImageLocation = Controller.UISettingsValues.HomeBtnHover;
        }
        private void pictureBox3_leave(object sender, EventArgs e)
        {
            pictureBox3.ImageLocation = Controller.UISettingsValues.HomeBtn;
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (Controller.UISettings.ShowMenuItems)
            {
                new Common.Home();
            }
        }

        #endregion

        #region MenuBar

        #region File
        //Code to fire when new access file is created
        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string status = saveFile.ShowDialog().ToString();
            if (status == "OK")
            {
                Model.DBSettings.FilePath = saveFile.FileName;
                new UserLanding(database.CreateNewDB());
            }
        }

        //Code to open a new file
        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string status = openFile.ShowDialog().ToString();
            if (status == "OK")
            {
                Model.DBSettings.FilePath = openFile.FileName;
                new UserLanding("Open");
            }
        }

        //Code to close current file
        private void closeCurrentFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Controller.UISettings.MenuBar.Visible = false;
            Controller.UISettings.ShowMenuItems = false;
            Controller.UISettings.HomeButton.Visible = false;
            Controller.Messages.SetStatusMessage(Controller.Messages.Pages.MainWindow);
            Model.DBSettings.FilePath = "";
            Model.DBSettings.Password = "";
            new UserLanding("Remove");
        }

        //Code to exit the program
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Manage

        //Code to Add/Edit/Remove Password on Access file
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new Common.Password();
        }

        private void accountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Common.Accounts();
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Common.Category();
        }
        #endregion

        #region Expense
        private void addExpenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Common.AddExpense();
        }

        private void viewEditExpenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Common.ViewExpense();
        }

        private void debtsLoansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Common.Debts();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Common.ViewExpensesCombined();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            new SharedExpenses.SEHome();
        }

        #endregion

        #region Help
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Shared.About();
        }

        #endregion

        #endregion

    }
}
