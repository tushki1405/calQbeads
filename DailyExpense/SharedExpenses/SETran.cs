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
    public partial class SETran : Form
    {
        #region declarations
        Controller.Database database = new Controller.Database();
        Model.SharedEntity shared = new Model.SharedEntity();
        DataTable dtParticipants;
        DataTable dtParticipants2;
        DataGridViewCheckBoxColumn col_select;
        DataGridViewColumn col_name;
        DataGridViewButtonColumn col_sub;
        DataGridViewColumn col_share;
        DataGridViewButtonColumn col_add;
        DataGridViewColumn col_amount;
        bool eventAdded = false;

        DataGridViewColumn col_del_item;
        DataGridViewColumn col_del_spentby;
        DataGridViewColumn col_del_amount;
        DataGridViewColumn col_del_date;
        DataGridViewLinkColumn col_del;
        DataTable dtRecords;


        public SETran(int titleId)
        {
            InitializeComponent();
            shared.TitleId = titleId;
            Controller.UISettings.SetWindowProperties(this);
            Controller.UISettings.SetErrorMessage(lbl_error);
            setUI();
        }

        private void setUI()
        {
            Controller.Messages.SetStatusMessage(Controller.Messages.Pages.SETran);
            dtParticipants = database.GetParticipants(shared.TitleId);

            cb_spender.DataSource = new DataView(dtParticipants);
            cb_spender.DisplayMember = "ParticipantName";
            cb_spender.ValueMember = "ParticipantId";

            //Font of grid view
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Font = Controller.UISettingsValues.gridViewFontBig;
            style.BackColor = Controller.UISettingsValues.backgroundColor;
            style.SelectionBackColor = Controller.UISettingsValues.backgroundColor;
            gv_data.DefaultCellStyle = style;
            gv_data.RowTemplate.Height = 30;

            gv_data.CellBorderStyle = DataGridViewCellBorderStyle.None;
            gv_data.BorderStyle = BorderStyle.None;
            gv_data.ColumnHeadersVisible = false;
            gv_data.AllowUserToResizeColumns = false;
            gv_data.EditMode = DataGridViewEditMode.EditOnEnter;

            //Setting for Data Grid View
            col_select = new DataGridViewCheckBoxColumn();
            col_select.Name = "Select";
            col_select.DataPropertyName = "ParticipantId";
            col_select.Width = 20;
            col_select.TrueValue = true;
            col_select.FalseValue = false;

            col_name = new DataGridViewTextBoxColumn();
            col_name.Name = "Participant";
            col_name.DataPropertyName = "ParticipantName";
            col_name.Width = 150;

            col_sub = new DataGridViewButtonColumn();
            col_sub.DataPropertyName = "ParticipantId";
            col_sub.Name = "Subtract";
            col_sub.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_sub.Width = 30;
            col_sub.Text = "-";
            col_sub.UseColumnTextForButtonValue = true;

            col_share = new DataGridViewTextBoxColumn();
            col_share.Name = "Share";
            col_share.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_share.Width = 60;

            col_add = new DataGridViewButtonColumn();
            col_add.DataPropertyName = "ParticipantId";
            col_add.Name = "Add";
            col_add.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_add.Width = 30;
            col_add.Text = "+";
            col_add.UseColumnTextForButtonValue = true;

            col_amount = new DataGridViewTextBoxColumn();
            col_amount.Name = "Amount";
            col_amount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_amount.Width = 90;

            //Setting for second datagrid view
            col_del_spentby = new DataGridViewTextBoxColumn();
            col_del_spentby.Name = "Spent By";
            col_del_spentby.DataPropertyName = "ParticipantName";
            col_del_spentby.Width = 180;

            col_del_item = new DataGridViewTextBoxColumn();
            col_del_item.Name = "Spent On";
            col_del_item.DataPropertyName = "Item";
            col_del_item.Width = 200;

            col_del_amount = new DataGridViewTextBoxColumn();
            col_del_amount.Name = "Amount";
            col_del_amount.DataPropertyName = "Amount";
            col_del_amount.Width = 130;
            col_del_amount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            col_del_date = new DataGridViewTextBoxColumn();
            col_del_date.Name = "Date";
            col_del_date.DataPropertyName = "DateSpent";
            col_del_date.Width = 170;
            col_del_date.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            col_del = new DataGridViewLinkColumn();
            col_del.UseColumnTextForLinkValue = true;
            col_del.DataPropertyName = "SEEID";
            col_del.Name = "";
            col_del.Text = "DELETE";
            col_del.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_del.Width = 60;

            Reload();
        }

        //Code to show Error Message according to the action
        private void ErrorMsgs(string action)
        {
            switch (action)
            {
                case "InValid":
                    lbl_error.Text = "Invalid Characters.";
                    lbl_error.Location = new Point(326, 235);
                    break;

                case "AddError":
                    lbl_error.Text = "Error Adding Records.";
                    lbl_error.Location = new Point(318, 235);
                    break;

                default:
                    lbl_error.Text = "";
                    break;
            }
        }

        #endregion

        #region commonFunctions
        //Load data grid view again
        private void Reload()
        {
            dtParticipants2 = database.GetParticipants(shared.TitleId);
            gv_data.DataSource = new DataView(dtParticipants2);

            gv_data.Columns.Clear();
            gv_data.Columns.Add(col_select);
            gv_data.Columns.Add(col_name);
            gv_data.Columns.Add(col_sub);
            gv_data.Columns.Add(col_share);
            gv_data.Columns.Add(col_add);
            gv_data.Columns.Add(col_amount);

            col_select.DisplayIndex = 0;
            col_name.DisplayIndex = 1;
            col_sub.DisplayIndex = 2;
            col_share.DisplayIndex = 3;
            col_add.DisplayIndex = 4;
            col_amount.DisplayIndex = 5;
            
            foreach (DataGridViewRow dr in gv_data.Rows)
            {
                dr.Cells["Share"].Value = "0";
                dr.Cells["Select"].Value = false;
                dr.Cells["Amount"].Value = "0.00";
                (dr.Cells["Select"] as DataGridViewCheckBoxCell).ReadOnly = true;
            }

            dtRecords = database.GetSharedExpenses(shared);
            gv_delete.DataSource = new DataView(dtRecords);

            gv_delete.Columns.Clear();
            gv_delete.Columns.Add(col_del_spentby);
            gv_delete.Columns.Add(col_del_item);
            gv_delete.Columns.Add(col_del_amount);
            gv_delete.Columns.Add(col_del_date);
            gv_delete.Columns.Add(col_del);

            col_del_spentby.DisplayIndex = 0;
            col_del_item.DisplayIndex = 1;
            col_del_amount.DisplayIndex = 2;
            col_del_date.DisplayIndex = 3;
            col_del.DisplayIndex = 4;

            if (!eventAdded)
            {
                gv_data.CellContentClick += new DataGridViewCellEventHandler(this.gv_data_CellContentClick);
                gv_delete.CellContentClick += new DataGridViewCellEventHandler(this.gv_delete_CellContentClick);
                eventAdded = true;
            }


        }

        private void ReloadAll()
        {
            txt_name.Text = "";
            txt_amount.Text = "";
            txt_name.Focus();
            Reload();
        }

        private void calculateAll()
        {
            int totalShare = 0;
            double amountPerShare = 0;
            double currShare;

            foreach (DataGridViewRow dr in gv_data.Rows)
            {
                if (dr.Cells["Select"].EditedFormattedValue.ToString() == "0" || dr.Cells["Select"].EditedFormattedValue.ToString().ToLower() == "false")
                {
                    dr.Cells["Share"].Value = "0";
                    dr.Cells["Amount"].Value = "0.00";
                }
                else
                {
                    totalShare += Convert.ToInt32(dr.Cells["Share"].Value.ToString());
                }
            }
            if (!string.IsNullOrEmpty(txt_amount.Text) && Convert.ToInt32(txt_amount.Text) > 0 && totalShare > 0)
            {
                amountPerShare = Convert.ToDouble(txt_amount.Text) / Convert.ToDouble(totalShare);
                foreach (DataGridViewRow dr in gv_data.Rows)
                {
                    currShare = Convert.ToInt32(dr.Cells["Share"].Value) * amountPerShare;
                    currShare = Math.Round(currShare,2,MidpointRounding.AwayFromZero);
                    dr.Cells["Amount"].Value = currShare.ToString("0.00"); 
                }
            }
        }
        #endregion

        #region functionality
        private void gv_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_amount.Text))
            {
                MessageBox.Show("Please Enter Amount First", "Enter Amount", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            else
            {
                //Checkbox
                if (e.ColumnIndex == 0)
                {
                    if (gv_data.Rows[e.RowIndex].Cells["Select"].EditedFormattedValue.ToString() == "True")
                    {
                        gv_data["Share", e.RowIndex].Value = "1";
                    }
                    else
                    {
                        gv_data["Share", e.RowIndex].Value = "0";
                    }
                    //MessageBox.Show(gv_data.Rows[e.RowIndex].Cells["Select"].EditedFormattedValue.ToString());
                }
                //Subtract
                else if (e.ColumnIndex == 2)
                {
                    int value = Convert.ToInt32(gv_data["Share", e.RowIndex].Value.ToString());
                    if (value > 0)
                    {
                        value--;
                        gv_data["Share", e.RowIndex].Value = value.ToString();
                        if (value == 0)
                        {
                            gv_data.Rows[e.RowIndex].Cells["Select"].Value = false;
                        }
                    }
                }
                //Add
                else if (e.ColumnIndex == 4)
                {
                    int value = Convert.ToInt32(gv_data["Share", e.RowIndex].Value.ToString());
                    if (value == 0)
                    {
                        gv_data.Rows[e.RowIndex].Cells["Select"].Value = true;
                    }
                    value++;
                    gv_data["Share", e.RowIndex].Value = value.ToString();
                }
                calculateAll();
            }
        }

        private void gv_delete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRowView dv;
            DataRow dr;
            int selectedId;

            if (e.ColumnIndex == 4)
            {
                DialogResult resultAdjust = MessageBox.Show("Are you sure you want to Delete?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resultAdjust.ToString() == "Yes")
                {
                    dv = (DataRowView)gv_delete.Rows[e.RowIndex].DataBoundItem;
                    dr = dv.Row;
                    selectedId = Convert.ToInt32(dr.ItemArray[0]);
                    database.DeleteSharedRecord(selectedId);
                    System.Threading.Thread.Sleep(1000);
                }
                Reload();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            new SharedExpenses.SEHome();
        }

        private void txt_amount_TextChanged(object sender, EventArgs e)
        {
            int result;
            if (!int.TryParse(txt_amount.Text, out result) && !string.IsNullOrEmpty(txt_amount.Text))
            {
                txt_amount.Text = txt_amount.Text.Remove(txt_amount.Text.Length - 1);
                txt_amount.SelectionStart = txt_amount.Text.Length;
            }

            if (string.IsNullOrEmpty(txt_amount.Text))
            {
                foreach (DataGridViewRow dr in gv_data.Rows)
                {
                    dr.Cells["Select"].Value = false;
                    (dr.Cells["Select"] as DataGridViewCheckBoxCell).ReadOnly = true;
                }
            }
            else
            {
                foreach (DataGridViewRow dr in gv_data.Rows)
                {
                    (dr.Cells["Select"] as DataGridViewCheckBoxCell).ReadOnly = false;
                }
            }
            calculateAll();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Model.SharedParticipants participants;
            string participantName;
            DataRow[] foundRows;

            if (!Controller.Validations.ProperText(txt_name) || string.IsNullOrEmpty(txt_amount.Text) || string.IsNullOrEmpty(txt_name.Text))
            {
                ErrorMsgs("InValid");
                return;
            }
            shared.Item = txt_name.Text;
            shared.Amount = Convert.ToDouble(txt_amount.Text);
            shared.ParticipantId = Convert.ToInt32(cb_spender.SelectedValue.ToString());
            shared.DateSpent = Convert.ToDateTime(dtp_date.Text);
            shared.Participants = new List<Model.SharedParticipants>();
            foreach (DataGridViewRow dr in gv_data.Rows)
            {
                participants = new Model.SharedParticipants();
                participantName = dr.Cells["Participant"].Value.ToString();
                foundRows = dtParticipants.Select("ParticipantName='" + participantName + "'");
                participants.ParticipantId = Convert.ToInt32(foundRows[0]["ParticipantId"]);
                participants.Share = Convert.ToInt32(dr.Cells["Share"].Value);
                shared.Participants.Add(participants);
            }
            if (database.AddDivision(shared))
            {
                ReloadAll();
            }
            else
            {
                ErrorMsgs("AddError");
            }
        }

        #endregion
    }
}
