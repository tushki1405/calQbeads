using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DailyExpense.SharedExpenses
{
    public partial class SEHome : Form
    {
        Controller.Database database = new Controller.Database();
        Model.SharedEntity shared = new Model.SharedEntity();

        public SEHome()
        {
            InitializeComponent();
            Controller.UISettings.SetWindowProperties(this);
            Controller.UISettings.SetErrorMessage(lbl_error);
            setUI();
        }

        #region commonFunctions
        private void setUI()
        {
            Controller.Messages.SetStatusMessage(Controller.Messages.Pages.SEHome);

            cb_type.Items.Add("Shopping");
            cb_type.Items.Add("Party");
            cb_type.Items.Add("Outing");
            cb_type.Items.Add("Food");
            cb_type.Items.Add("Travelling");

            tt_description.ToolTipTitle = "Current Selection";
            tt_description.SetToolTip(lb_se,"");

            reloadNames();
        }

        private void reloadNames()
        {
            txt_title.Text = "";
            txt_description.Text = "";

            lb_se.DataSource = database.GetTitles();
            lb_se.DisplayMember = "Titlename";
            lb_se.ValueMember = "TitleId";
            cb_type.SelectedIndex = 0;

            txt_title.Focus();
        }

        //Code to show Error Message according to the action
        private void ErrorMsgs(string action)
        {
            switch (action)
            {
                case "NoData":
                    lbl_error.Text = "Field cannot be left empty";
                    lbl_error.Location = new Point(520, 295);
                    break;

                case "AddSuccessful":
                    lbl_error.Text = "Title Added Successfully";
                    lbl_error.Location = new Point(528, 295);
                    break;
                
                case "AddFailed":
                    lbl_error.Text = "Failed to Add Title";
                    lbl_error.Location = new Point(547, 295);
                    break;

                case "Invalid":
                    lbl_error.Text = "Invalid Characters.";
                    lbl_error.Location = new Point(543, 295);
                    break;

                default:
                    lbl_error.Text = "";
                    break;
            }
        }

        #endregion

        #region Events
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_title.Text == "")
            {
                ErrorMsgs("NoData");
            }
            else
            {
                if (!Controller.Validations.ProperText(txt_title) || !Controller.Validations.ProperText(txt_description))
                {
                    ErrorMsgs("Invalid");
                    return;
                }
                shared.Title = txt_title.Text;
                shared.Description = txt_description.Text;
                shared.Type = cb_type.Text;
                int titleId = database.AddTitle(shared);
                if (titleId > 0)
                {
                    ErrorMsgs("AddSuccessful");
                    reloadNames();
                    MessageBox.Show("Title Added Successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    new SharedExpenses.SEEdit(titleId);
                }
                else
                {
                    ErrorMsgs("AddFailed");
                }
            }
        }
        
        private void btn_open_Click(object sender, EventArgs e)
        {
            new SharedExpenses.SETran((int)lb_se.SelectedValue);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            new SharedExpenses.SEEdit((int)lb_se.SelectedValue);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult resultAdjust = MessageBox.Show("Are you sure you want to Delete?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resultAdjust.ToString() == "Yes")
            {
                shared.TitleId = Convert.ToInt32(lb_se.SelectedValue.ToString());
                database.DeleteSharedExpense(shared);
                System.Threading.Thread.Sleep(1000);
                reloadNames();
            }
        }
        
        private void lb_se_MouseHover(object sender, EventArgs e)
        {
            Model.SharedEntity selectedItem = database.GetExpenseDetails(Convert.ToInt32(lb_se.SelectedValue));
            string toolTipdata = "Description: " + selectedItem.Description + System.Environment.NewLine +
                 "Type: " + selectedItem.Type;
            tt_description.SetToolTip(lb_se, toolTipdata);
        }

        private void lb_se_DoubleClick(object sender, EventArgs e)
        {
            new SharedExpenses.SETran((int)lb_se.SelectedValue);
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            new SharedExpenses.SEReport((int)lb_se.SelectedValue);
        }

        #endregion
    }
}
