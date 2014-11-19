using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DailyExpense.SharedExpenses
{
    public partial class SEReport : Form
    {
        DataTable dtRaw;
        DataTable dtParticipants;
        DataTable dtCalculation;
        int titleId;
        Controller.Database database = new Controller.Database();
        int count;
        Dictionary<string,int> rowIndex = new Dictionary<string,int>();
        DataTable chartData;
        DataGridViewColumn col_from;
        DataGridViewColumn col_to;
        DataGridViewColumn col_amount;

        public SEReport(int titleId)
        {
            InitializeComponent();
            Controller.UISettings.SetWindowProperties(this);
            this.titleId = titleId;
            setUI();
        }

        private void setUI()
        {

            Controller.Messages.SetStatusMessage(Controller.Messages.Pages.SEReport);

            #region setUp
            lbl_breakup.ForeColor = Controller.UISettingsValues.errorColor;
            lbl_overall.ForeColor = Controller.UISettingsValues.errorColor;
            lbl_error.ForeColor = Controller.UISettingsValues.errorColor;
            lbl_error.Text = "";

            
            //Getdata
            dtParticipants = database.GetParticipants(titleId);
            count = dtParticipants.Rows.Count;
            dtRaw = database.GetFinalResult(titleId);

            col_from = new DataGridViewTextBoxColumn();
            col_from.Name = "Participant";
            col_from.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_from.Width = 300;

            col_to = new DataGridViewTextBoxColumn();
            col_to.Name = "Should Pay";
            col_to.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            col_to.Width = 300;

            col_amount = new DataGridViewTextBoxColumn();
            col_amount.Name = "Amount";
            col_amount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col_amount.Width = 180;

            gv_final.Columns.Clear();
            gv_final.Columns.Add(col_from);
            gv_final.Columns.Add(col_to);
            gv_final.Columns.Add(col_amount);

            #endregion

            if (dtRaw.Rows.Count > 0)
            {
                #region calculationLogic
                dtCalculation = new DataTable();
                dtCalculation.Columns.Add("ID");
                dtCalculation.Columns.Add("Name");
                dtCalculation.Columns.Add("Receive");
                dtCalculation.Columns.Add("Pay");
                dtCalculation.Columns.Add("Balance");

                for (int i = 0; i < count; i++)
                {
                    rowIndex.Add(dtParticipants.Rows[i]["ParticipantId"].ToString(), i);
                    dtCalculation.Rows.Add(dtParticipants.Rows[i]["ParticipantId"].ToString(), dtParticipants.Rows[i]["ParticipantName"].ToString(), 0, 0, 0);
                }


                double amount;
                //add data to calculation tables
                foreach (DataRow dr in dtRaw.Rows)
                {
                    if (dr["SpentBy"].ToString() != dr["ParticipantId"].ToString())
                    {
                        amount = Convert.ToDouble(dr["ShareAmount"].ToString());
                        dtCalculation.Rows[rowIndex[dr["SpentBy"].ToString()]]["Receive"] = Convert.ToDouble(dtCalculation.Rows[rowIndex[dr["SpentBy"].ToString()]]["Receive"]) + amount;
                        dtCalculation.Rows[rowIndex[dr["ParticipantId"].ToString()]]["Pay"] = Convert.ToDouble(dtCalculation.Rows[rowIndex[dr["ParticipantId"].ToString()]]["Pay"]) + amount;
                    }
                }

                dtCalculation.Columns.Add("Processed");
                foreach (DataRow dr in dtCalculation.Rows)
                {
                    dr["Balance"] = Math.Round(Convert.ToDouble(dr["Receive"]) - Convert.ToDouble(dr["Pay"]), 2, MidpointRounding.AwayFromZero);
                    dr["Processed"] = 0;
                }


                double max = 0;
                int maxIndex = 0;
                double min = 0;
                int minIndex = 0;
                double balance = 0;

                //Get final calculation
                while (HasUnprocessed())
                {
                    //get values based on balance
                    if (balance == 0)
                    {
                        maxIndex = GetValue(true);
                        minIndex = GetValue(false);
                        max = Convert.ToDouble(dtCalculation.Rows[maxIndex]["Balance"]);
                        min = Convert.ToDouble(dtCalculation.Rows[minIndex]["Balance"]);
                    }
                    else if (balance > 0)
                    {
                        minIndex = GetValue(false);
                        min = Convert.ToDouble(dtCalculation.Rows[minIndex]["Balance"]);
                        max = balance;
                    }
                    else
                    {
                        maxIndex = GetValue(true);
                        max = Convert.ToDouble(dtCalculation.Rows[maxIndex]["Balance"]);
                        min = balance;
                    }

                    if (max >= -min)
                    {
                        balance = max + min;
                        if (min != 0)
                        {
                            gv_final.Rows.Add(dtCalculation.Rows[minIndex]["Name"], dtCalculation.Rows[maxIndex]["Name"], (-min).ToString("0.00"));
                        }
                    }
                    else if (max < -min)
                    {
                        balance = max + min;
                        if (max != 0)
                        {
                            gv_final.Rows.Add(dtCalculation.Rows[minIndex]["Name"], dtCalculation.Rows[maxIndex]["Name"], max.ToString("0.00"));
                        }
                    }
                }
                #endregion

                #region chartLogic
                chart_expense.BackColor = Controller.UISettingsValues.backgroundColor;
                chart_expense.Legends.Add("Legend");
                chart_expense.Legends["Legend"].BackColor = Controller.UISettingsValues.backgroundColor;
                chart_expense.ChartAreas["ChartArea1"].AxisX.Enabled = AxisEnabled.False;

                chartData = dtCalculation.Copy();
                chartData.Columns.Remove("ID");
                chartData.Columns.Remove("Receive");
                chartData.Columns.Remove("Pay");
                chartData.Columns.Remove("Processed");


                //Clear chart points
                Series[] newSeries = new Series[chart_expense.Series.Count];
                chart_expense.Series.CopyTo(newSeries, 0);
                foreach (Series s in newSeries)
                {
                    chart_expense.Series.Remove(s);
                }

                //Add chart points
                foreach (DataRow dr in chartData.Rows)
                {
                    chart_expense.Series.Add(dr["Name"].ToString());
                    chart_expense.Series[dr["Name"].ToString()].IsValueShownAsLabel = false;
                }

                double maxValue = 0;
                double minValue = 0;

                //Get the max value
                foreach (DataRow dr in chartData.Rows)
                {
                    if (Convert.ToDouble(dr["Balance"]) > maxValue)
                        maxValue = Convert.ToDouble(dr["Balance"]);
                    if (Convert.ToDouble(dr["Balance"]) < minValue)
                        minValue = Convert.ToDouble(dr["Balance"]);
                }

                if (maxValue > 0)
                {
                    //Calculate the scale
                    int highScale = Convert.ToInt32((Math.Ceiling(Convert.ToDouble(maxValue / 100)) + 1) * 100);
                    chart_expense.ChartAreas["ChartArea1"].AxisY.Maximum = highScale;
                }
                if (minValue < 0)
                {
                    int lowScale = Convert.ToInt32((Math.Ceiling(Convert.ToDouble(minValue / 100)) - 1) * 100);
                    chart_expense.ChartAreas["ChartArea1"].AxisY.Minimum = lowScale;
                }

                //Update with final points
                foreach (DataRow dr in chartData.Rows)
                {
                    chart_expense.Series[dr["Name"].ToString()].Points.Clear();
                    chart_expense.Series[dr["Name"].ToString()].Points.Add(Convert.ToDouble(dr["Balance"]));
                    chart_expense.Series[dr["Name"].ToString()].IsValueShownAsLabel = true;
                }

                #endregion
            }
            else
            {
                chart_expense.Visible = false;
                lbl_breakup.Visible = false;
                lbl_overall.Visible = false;

                lbl_error.Location = new Point(290, 240);
                lbl_error.Text = "Please add some expenses first.";
                gv_final.Visible = false;
            }
        }

        private int GetValue(bool getMax)
        {
            int index = 0;
            int finalIndex = -1;
            double amount = Convert.ToDouble(dtCalculation.Rows[0]["Balance"]);
            int gotValue = 0;
            foreach (DataRow dr in dtCalculation.Rows)
            {
                if (gotValue == 0 && Convert.ToInt32(dr["Processed"]) == 0)
                {
                    gotValue = 1;
                    amount = Convert.ToDouble(dtCalculation.Rows[index]["Balance"]);
                    finalIndex = index;
                }

                if (getMax)
                {
                    if (Convert.ToInt32(dr["Processed"]) == 0 && Convert.ToDouble(dr["Balance"]) > amount)
                    {
                        amount = Convert.ToDouble(dtCalculation.Rows[index]["Balance"]);
                        finalIndex = index;
                    }
                }
                else
                {
                    if (Convert.ToInt32(dr["Processed"]) == 0 && Convert.ToDouble(dr["Balance"]) < amount)
                    {
                        amount = Convert.ToDouble(dtCalculation.Rows[index]["Balance"]);
                        finalIndex = index;
                    }
                }
                index++;
            }
            dtCalculation.Rows[finalIndex]["Processed"] = 1;
            return finalIndex;
        }

        private bool HasUnprocessed()
        {
            foreach (DataRow dr in dtCalculation.Rows)
            {
                if (Convert.ToInt32(dr["Processed"]) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            new SharedExpenses.SEHome();
        }
    }
}
