using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DailyExpense.Common
{
    public partial class Password : Form
    {
        Controller.Database database;
        ToolTip toolTip;

        public Password()
        {
            InitializeComponent();
            setUI();
        }

        #region UISettings
        //Set UI - which panel will be shown
        private void setUI()
        {
            Controller.UISettings.SetWindowProperties(this);
            Controller.UISettings.SetErrorMessage(lbl_error);
            pnl_new.Visible = false;
            pnl_existing.Visible = false;

            //Code to decide which panel to show
            if (string.IsNullOrEmpty(Model.DBSettings.Password))
            {
                pnl_new.Location = new Point(280, 70);
                pnl_new.Visible = true;
            }
            else
            {
                pnl_existing.Location = new Point(280, 70);
                pnl_new.Location = new Point(280, 130);
                pnl_existing.Visible = true;
                pnl_new.Visible = true;
                txt_currPass.Focus();
            }

            toolTip = new ToolTip();

            Controller.Messages.SetStatusMessage(Controller.Messages.Pages.Password);
            btn_removePass.ImageLocation = Controller.UISettingsValues.deleteBtn;
            toolTip.SetToolTip(btn_removePass, "Remove Password from File.");

            //Set parameters
            database = new Controller.Database();
        }

        private void deletebtn_enter(object sender, EventArgs e)
        {
            btn_removePass.ImageLocation = Controller.UISettingsValues.deleteBtnHover;
        }

        private void deletebtn_leave(object sender, EventArgs e)
        {
            btn_removePass.ImageLocation = Controller.UISettingsValues.deleteBtn;
        }
        #endregion

        //Code to show Error Message according to the action
        private void ErrorMsgs(string action)
        {
            switch (action)
            { 
                case "Success":
                    lbl_error.Text = "Password Applied Successfully.";
                    lbl_error.Location = new Point(58, 172);
                    break;

                case "Different":
                    lbl_error.Text = "Passwords do not match.";
                    lbl_error.Location = new Point(71, 172);
                    break;

                case "Empty":
                    lbl_error.Text = "Please enter a Value.";
                    lbl_error.Location = new Point(85, 172);
                    break;
                
                case "Invalid":
                    lbl_error.Text = "Field contains invalid characters.";
                    lbl_error.Location = new Point(50, 172);
                    break;

                case "Failure":
                    lbl_error.Text = "Failed to Update Password.";
                    lbl_error.Location = new Point(65, 172);
                    break;

                case "Remove":
                    lbl_error.Text = "Password Removed Successfully.";
                    lbl_error.Location = new Point(58, 172);
                    break;

                case "RemoveFail":
                    lbl_error.Text = "Failed to Remove Password.";
                    lbl_error.Location = new Point(65, 172);
                    break;

                default:
                    lbl_error.Text = "";
                    break;
            }
        }
        
        //Apply Or Update Password Based on Last Password
        private void btn_update_Click(object sender, EventArgs e)
        {
            Model.PasswordEntity pass = new Model.PasswordEntity();

            if ((string.IsNullOrEmpty(Model.DBSettings.Password) && (string.IsNullOrEmpty(txt_pass.Text)
                || string.IsNullOrEmpty(txt_passAgain.Text))) || (!string.IsNullOrEmpty(Model.DBSettings.Password) 
                && (string.IsNullOrEmpty(txt_pass.Text) || string.IsNullOrEmpty(txt_passAgain.Text)
                || string.IsNullOrEmpty(txt_currPass.Text))))
            {
                ErrorMsgs("Empty");
            }
            else if (txt_pass.Text != txt_passAgain.Text)
            {
                ErrorMsgs("Different");
            }
            else if ((string.IsNullOrEmpty(Model.DBSettings.Password) && (Controller.Validations.ProperText(txt_pass) == false
                || Controller.Validations.ProperText(txt_passAgain) == false) || (!string.IsNullOrEmpty(Model.DBSettings.Password)
                && (Controller.Validations.ProperText(txt_pass) == false
                || Controller.Validations.ProperText(txt_passAgain) == false || Controller.Validations.ProperText(txt_currPass) == false))))
            {
                ErrorMsgs("Invalid");
            }
            else
            {
                pass.NewPass = txt_pass.Text;
                pass.OldPass = txt_currPass.Text;
                if (database.EditPassword(pass))
                {
                    Model.DBSettings.Password = pass.NewPass;
                    txt_currPass.Text = "";
                    txt_pass.Text = "";
                    txt_passAgain.Text = "";
                    ErrorMsgs("Success");
                    if (pnl_existing.Visible == false)
                    {
                        for (int i = 70; i <= 130; i++)
                        {
                            pnl_new.Location = new Point(280, i);
                            System.Threading.Thread.Sleep(Controller.UISettingsValues.delay);
                        }
                        pnl_existing.Location = new Point(280, 70);
                        pnl_existing.Visible = true;
                    }
                }
                else
                {
                    ErrorMsgs("Failure");
                }
            }
        }

        new private void KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { 
                btn_update_Click(new object(),new EventArgs());
                btn_update.Focus();
            }
        }

        private void btn_removePass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_currPass.Text))
            {
                ErrorMsgs("Empty");
            }
            else
            {
                Model.PasswordEntity pass = new Model.PasswordEntity();
                pass.NewPass = "";
                pass.OldPass = txt_currPass.Text;
                if (database.EditPassword(pass))
                {
                    Model.DBSettings.Password = pass.NewPass;
                    txt_currPass.Text = "";
                    txt_pass.Text = "";
                    txt_passAgain.Text = "";
                    ErrorMsgs("Remove");
                    pnl_existing.Visible = false;
                    for (int i = 130; i >= 70; i--)
                    {
                        pnl_new.Location = new Point(280, i);
                        System.Threading.Thread.Sleep(Controller.UISettingsValues.delay);
                    }
                }
                else
                {
                    ErrorMsgs("RemoveFail");
                }
            }
        }


    }
}
