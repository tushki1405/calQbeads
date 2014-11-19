using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using Controller;

namespace DailyExpense.Shared
{
    public partial class UserLanding : Form
    {
        Controller.Database database = new Controller.Database();

        //Default Landing Page on Startup
        public UserLanding(string action)
        {
            InitializeComponent();
            setUI();
            if (action.ToLower() == "default")
            {
                AutoOpen();
            }
            else if (action.ToLower() == "remove")
            {
                RemoveAutoOpen();
            }
            else if (action.ToLower() == "open")
            {
                OpenFile();
            }
        }

        //Landing Page after User Selects DB
        public UserLanding(int DBStatus)
        {
            InitializeComponent();
            setUI();
            if (DBStatus == 1)
            {
                OpenNextTime();
            }
            else
            {
                Controller.Messages.SetStatusMessage(Controller.Messages.ErrorMsgs.NoCreateDB);
            }
        }

        //Code to set UI appearance
        private void setUI()
        {
            Controller.UISettings.SetWindowProperties(this);
            Controller.UISettings.SetErrorMessage(str_error);
            pnl_password.Visible = false;
            pnl_logo.Visible = true;
            lbl_app.Font = new Font(Controller.UISettingsValues.fontGeneral, 16, FontStyle.Bold);
            lbl_app0.Font = new Font(Controller.UISettingsValues.fontGeneral, 20, FontStyle.Bold);
            pb_logo.ImageLocation = Controller.UISettingsValues.iconImagePNG;
        }

        //Check path of file and open the file automatically
        private void AutoOpen()
        {
            if (File.Exists(ConfigurationManager.AppSettings["BackToMainPath"] + "config"))
            {
                string filepath = File.ReadAllText(ConfigurationManager.AppSettings["BackToMainPath"] + "config");
                if (File.Exists(filepath))
                {
                    if (filepath.EndsWith(".accdb") || filepath.EndsWith(".mdb"))
                    {
                        Model.DBSettings.FilePath = filepath;
                        CheckDB();
                    }
                    else
                    {
                        RemoveAutoOpen();
                        Controller.Messages.SetStatusMessage(Controller.Messages.ErrorMsgs.FilePathCorrupt);
                    }
                }
                else
                {
                    RemoveAutoOpen();
                    Controller.Messages.SetStatusMessage(Controller.Messages.ErrorMsgs.FilePathCorrupt);
                }
            }
        }

        //Remove config file when closed from File->Close Current File
        private void RemoveAutoOpen()
        {
            if (File.Exists(ConfigurationManager.AppSettings["BackToMainPath"] + "config"))
            {
                File.Delete(ConfigurationManager.AppSettings["BackToMainPath"] + "config");
            }
        }

        //Remove Auto open and Open Selected File
        private void OpenFile()
        {
            RemoveAutoOpen();
            OpenNextTime();
        }

        //Show message to open file automatically next time
        private void OpenNextTime()
        {
            DialogResult result = MessageBox.Show(Controller.Messages.OpenNextTimeMsg, "Open Next Time",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result.ToString() == "Yes")
            {
                File.WriteAllText(ConfigurationManager.AppSettings["BackToMainPath"] + "config",
                    Model.DBSettings.FilePath);
            }
            else
            {
                File.Delete(ConfigurationManager.AppSettings["BackToMainPath"] + "config");
            }
            CheckDB();
        }

        //Code to execute when enter is pressed
        private void keyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Model.DBSettings.Password = txt_password.Text;
                CheckDB();
            }
        }

        //Check DB if format and all tables are existing
        private void CheckDB()
        {
            int status = database.CheckDB(Controller.UISettingsValues.dbVersion);
            //when file is opened
            if (status == 1)
            {
                //Controller.UISettings.MenuBar.Visible = true;
                Controller.UISettings.ShowMenuItems = true;
                Controller.UISettings.HomeButton.Visible = true;
                Controller.Messages.SetStatusMessage("Opened File : " + Model.DBSettings.FilePath);
                new Common.Home();
            }
            else if (status == 2)
            {
                //Show password panel
                if (pnl_password.Visible == false)
                {
                    pnl_logo.Visible = false;
                    pnl_password.Visible = true;
                }
                //Incorrect Password
                else
                {
                    txt_password.Text = "";
                    str_error.Text = "Incorrect Password";
                    str_error.Visible = true;
                }
                txt_password.Focus();
                Controller.Messages.SetStatusMessage("Enter Password for File : " + Model.DBSettings.FilePath);
            }
            else
            {
                Controller.Messages.SetStatusMessage(Controller.Messages.ErrorMsgs.FileCorrupt);
            }
        }

        
    }
}
