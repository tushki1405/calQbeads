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
    public partial class SEEdit : Form
    {
        Controller.Database database = new Controller.Database();
        Model.SharedEntity shared = new Model.SharedEntity();

        public SEEdit(int titleId)
        {
            InitializeComponent();
            shared.TitleId = titleId;
            Controller.UISettings.SetWindowProperties(this);
            Controller.UISettings.SetErrorMessage(lbl_error);
            Controller.UISettings.SetErrorMessage(lbl_note);
            setUI();
        }

        private void setUI()
        {
            Controller.Messages.SetStatusMessage(Controller.Messages.Pages.SEEdit);
            lbl_note.Text = "Note: Participants once added cannot be edited or removed.";
            reloadNames();
        }

        private void reloadNames()
        {
            txt_name.Text = "";
            
            lb_name.DataSource = database.GetParticipants(shared.TitleId);
            lb_name.DisplayMember = "ParticipantName";
            lb_name.ValueMember = "ParticipantId";
            
            txt_name.Focus();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                ErrorMsgs("NoData");
            }
            else
            {
                if (!Controller.Validations.ProperText(txt_name))
                {
                    ErrorMsgs("InValid");
                    return;
                }
                shared.ParticipantName = txt_name.Text;
                if (database.AddParticipant(shared))
                {
                    ErrorMsgs("AddSuccessful");
                    System.Threading.Thread.Sleep(1000);
                    reloadNames();
                }
                else
                {
                    ErrorMsgs("AddFailed");
                }
            }
        }

        //Code to show Error Message according to the action
        private void ErrorMsgs(string action)
        {
            switch (action)
            {
                case "NoData":
                    lbl_error.Text = "Field cannot be left empty";
                    lbl_error.Location = new Point(143, 115);
                    break;

                case "AddSuccessful":
                    lbl_error.Text = "Participant Added Successfully";
                    lbl_error.Location = new Point(130, 115);
                    break;

                case "AddFailed":
                    lbl_error.Text = "Failed to Add Participant";
                    lbl_error.Location = new Point(147, 115);
                    break;

                case "InValid":
                    lbl_error.Text = "Invalid Characters.";
                    lbl_error.Location = new Point(164, 115);
                    break;

                default:
                    lbl_error.Text = "";
                    break;
            }
        }

        private void txt_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_add_Click(null, null);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            new SharedExpenses.SEHome();
        }
    }
}
