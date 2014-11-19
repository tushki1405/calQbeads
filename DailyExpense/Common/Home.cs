using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;

namespace DailyExpense.Common
{
    public partial class Home : Form
    {
        Controller.Database database = new Controller.Database();
        DataTable chartData;
        Model.HomeEntity home = new Model.HomeEntity();
        private delegate void showChart();
        int[] valArray;


        Thread th; 
        string cb_graph_text;
        string seriesName;
        bool chart_visibility;
        int currentPoint, scale;
        string chartMessage;
        int pnl_grid_width = 460;
        bool onLoad = false;

        DataTable table_grid;

        public Home()
        {
            InitializeComponent();
            Controller.UISettings.SetWindowProperties(this);
            Controller.UISettings.SetErrorMessage(lbl_chartMessage);
            Controller.UISettings.SetErrorMessage(lbl_gridMessage);
            setUI();
            th = new Thread(DrawGraph);
        }

        private void setUI()
        {
            chart_expense.BackColor = Controller.UISettingsValues.backgroundColor;
            chart_expense.Legends.Add("Legend");
            chart_expense.Legends["Legend"].BackColor = Controller.UISettingsValues.backgroundColor;
            chart_expense.ChartAreas["ChartArea1"].AxisX.Enabled = AxisEnabled.False;

            chart_expense.Visible = false;
            pnl_chart.BorderStyle = BorderStyle.FixedSingle;
            pnl_grid.BorderStyle = BorderStyle.FixedSingle;
            gv_accounts.BorderStyle = BorderStyle.None;

            cb_grid.Items.Add("(None)");
            cb_grid.Items.Add("Last 10 Transactions");
            cb_grid.Items.Add("Last 20 Transactions");
            cb_grid.Items.Add("Receivables");
            cb_grid.Items.Add("Payments");
            cb_grid.Items.Add("Account Info");
            this.cb_grid.SelectedIndexChanged -= new System.EventHandler(this.cb_grid_SelectedIndexChanged);
            //cb_grid.SelectedIndex = 1;
            this.cb_grid.SelectedIndexChanged += new System.EventHandler(this.cb_grid_SelectedIndexChanged);
            ErrorMsgs("GridSelect");

            cb_graph.Items.Add("(None)");
            cb_graph.Items.Add("Last Month");
            cb_graph.Items.Add("Last Week");
            //cb_graph.Items.Add("View Accounts");
            this.cb_graph.SelectedIndexChanged -=new EventHandler(this.cb_graph_SelectedIndexChanged);
            //cb_graph.SelectedIndex = 1;
            this.cb_graph.SelectedIndexChanged += new EventHandler(this.cb_graph_SelectedIndexChanged);
            SetDefault();
        }

        //Code to show Error Message according to the action
        private void ErrorMsgs(string action)
        {
            switch (action)
            {
                case "ChartSelect":
                    lbl_chartMessage.Text = "Please select a value.";
                    lbl_chartMessage.Location = new Point(80, 165);
                    break;

                case "NoRecords":
                    lbl_chartMessage.Text = "No Records for the Selected Graph.";
                    lbl_chartMessage.Location = new Point(40, 165);
                    break;

                case "ClearChart":
                    lbl_chartMessage.Text = "";
                    break;

                case "GridSelect":
                    lbl_gridMessage.Text = "Please select a value.";
                    lbl_gridMessage.Location = new Point(165, 165);
                    break;

                case "NoRecordsGrid":
                    lbl_gridMessage.Text = "No Records for the Selected Option.";
                    lbl_gridMessage.Location = new Point(135, 165);
                    break;

                case "ClearGrid":
                    lbl_gridMessage.Text = "";
                    break;

                default:
                    lbl_chartMessage.Text = "";
                    lbl_gridMessage.Text = "";
                    break;
            }
        }

        #region ChartFunctions

        //Main Function to Draw Graphs
        private void DrawGraph()
        {
            try
            {
                MethodInvoker UpdateChartPointDelegate = new MethodInvoker(UpdateChartPoint);
                //MethodInvoker ClearChartPointDelegate = new MethodInvoker(ClearChartPoint);
                MethodInvoker SetChartVisibilityDelegate = new MethodInvoker(SetChartVisibility);
                MethodInvoker GetComboSelectionDelegate = new MethodInvoker(GetComboSelection);
                MethodInvoker SetScaleDelegate = new MethodInvoker(SetScale);
                MethodInvoker SetChartPointsDelegate = new MethodInvoker(SetChartPoints);

                ////Delete the current series
                //Invoke(ClearChartPointDelegate);

                //Get the currently selected value
                Invoke(GetComboSelectionDelegate);
                if (cb_graph_text == "(None)")
                {
                    chart_visibility = false;
                    chartMessage = "ChartSelect";
                    Invoke(SetChartVisibilityDelegate);
                }
                else
                {
                    if (cb_graph_text == "Last Month")
                    {
                        home.EndDate = DateTime.Now;
                        home.StartDate = home.EndDate.AddDays(-30);
                        chartData = database.CategoryWiseBetweenDates(home);
                    }
                    else if (cb_graph_text == "Last Week")
                    {
                        home.EndDate = DateTime.Now;
                        home.StartDate = home.EndDate.AddDays(-7);
                        chartData = database.CategoryWiseBetweenDates(home);
                    }
                    else if (cb_graph_text == "View Accounts")
                    {
                        chartData = database.GetAccountsHome();
                    }

                    //Set the chart points so that it can be cleared and added
                    Invoke(SetChartPointsDelegate);

                    valArray = new int[chartData.Rows.Count];
                    int i = 0, max = 0; //, speed = 0;

                    //Get all values in the datatable
                    foreach (DataRow dr in chartData.Rows)
                    {
                        valArray[i] = Convert.ToInt32(dr["Amount"]);
                        i++;
                    }

                    //Get max value from the set
                    foreach (int val in valArray)
                    {
                        if (val > max)
                            max = val;
                    }

                    if (max > 0 || cb_graph_text == "View Accounts")
                    {
                        //Common Code
                        chart_visibility = true;
                        chartMessage = "ClearChart";
                        Invoke(SetChartVisibilityDelegate);
                    }
                    else
                    {
                        //Common Code
                        chart_visibility = false;
                        chartMessage = "NoRecords";
                        Invoke(SetChartVisibilityDelegate);
                    }

                    //Calculate the scale
                    scale = Convert.ToInt32((Math.Ceiling(Convert.ToDouble(max / 100)) + 1) * 100);
                    Invoke(SetScaleDelegate);

                    //Keep on increasing till max is achieved
                    for (currentPoint = 0; currentPoint <= max; currentPoint++)
                    {
                        foreach (DataRow dr in chartData.Rows)
                        {
                            if (Convert.ToInt32(dr["Amount"]) >= currentPoint)
                            {
                                if (max <= 1000)
                                {
                                    seriesName = dr["Category"].ToString();
                                    Invoke(UpdateChartPointDelegate);
                                }
                                else if (max > 1000 && max <= 3000 && currentPoint % 11 == 0)
                                {
                                    seriesName = dr["Category"].ToString();
                                    Invoke(UpdateChartPointDelegate);
                                }
                                else if (max > 3000 && max <= 5000 && currentPoint % 17 == 0)
                                {
                                    seriesName = dr["Category"].ToString();
                                    Invoke(UpdateChartPointDelegate);
                                }
                                else if (max > 5000 && max <= 7000 && currentPoint % 23 == 0)
                                {
                                    seriesName = dr["Category"].ToString();
                                    Invoke(UpdateChartPointDelegate);
                                }
                                else if (max > 7000 && currentPoint % 31 == 0)
                                {
                                    seriesName = dr["Category"].ToString();
                                    Invoke(UpdateChartPointDelegate);
                                }
                            }
                        }
                        Thread.Sleep(1);
                    }

                    //Update with final points
                    foreach (DataRow dr in chartData.Rows)
                    {
                        currentPoint = Convert.ToInt32(dr["Amount"]);
                        seriesName = dr["Category"].ToString();
                        Invoke(UpdateChartPointDelegate);
                    }
                }
            }
            catch (Exception ex)
            {
                try
                {
                    cb_showValues.Visible = false;
                }
                catch (Exception ex2)
                { }
            }
        }

        //To fire on selected index change
        private void cb_graph_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_showValues.Checked = false;
            th = new Thread(DrawGraph);
            th.IsBackground = false;
            th.Start();
        }

        //Funtion to update chart points
        private void UpdateChartPoint()
        {
            chart_expense.Series[seriesName].Points.Clear();
            chart_expense.Series[seriesName].Points.Add(currentPoint);
        }

        //Funtions to clear chart points
        private void ClearChartPoint()
        {
            Series[] newSeries = new Series[chart_expense.Series.Count];
            chart_expense.Series.CopyTo(newSeries,0);
            foreach (Series s in newSeries)
            {
                chart_expense.Series.Remove(s);
            }
        }

        //Change the visibility of the chart
        private void SetChartVisibility()
        {
            chart_expense.Visible = chart_visibility;
            cb_showValues.Visible = chart_visibility;
            ErrorMsgs(chartMessage);
        }

        //Get the currently selected value in combobox
        private void GetComboSelection()
        {
            cb_graph_text = cb_graph.Text;
        }

        //Set the scale for the graph
        private void SetScale()
        {
            chart_expense.ChartAreas["ChartArea1"].AxisY.Maximum = scale;
        }

        //Set the chart points
        private void SetChartPoints()
        {
            ClearChartPoint();

            foreach (DataRow dr in chartData.Rows)
            {
                chart_expense.Series.Add(dr["Category"].ToString());
                chart_expense.Series[dr["Category"].ToString()].IsValueShownAsLabel = false;
            }
        }

        //Abort the thread before closing the form
        private void Home_Close(object sender, FormClosingEventArgs e)
        {
            if (th.IsAlive)
            {
                th.Abort();
            }
        }

        //Show values on top of bars in chart
        private void cb_showValues_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataRow dr in chartData.Rows)
            {
                chart_expense.Series[dr["Category"].ToString()].IsValueShownAsLabel = cb_showValues.Checked;
            }
        }
        #endregion

        private void cb_grid_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maxWidth = gv_accounts.Width;
            if (!onLoad)
            {
                ShowHidePanel(false);
            }
            ErrorMsgs("ClearGrid");
            if (cb_grid.Text == "(None)")
            {
                gv_accounts.Visible = false;
                ShowHidePanel(true);
                ErrorMsgs("GridSelect");
            }
            else
            {
                if (cb_grid.Text == "Last 10 Transactions")
                {
                    table_grid = database.GetLastTransactions(10);
                }
                else if (cb_grid.Text == "Last 20 Transactions")
                {
                    table_grid = database.GetLastTransactions(20);
                }
                else if (cb_grid.Text == "Receivables")
                {
                    table_grid = database.GetDebts(1,false);
                }
                else if (cb_grid.Text == "Payments")
                {
                    table_grid = database.GetDebts(0,false);
                }
                else if (cb_grid.Text == "Account Info")
                {
                    table_grid = database.GetAccountsHome();
                }

                if (table_grid.Rows.Count > 14)
                {
                    maxWidth -= 18;
                }

                int columnWidth = maxWidth / table_grid.Columns.Count;
                foreach (DataGridViewColumn col in gv_accounts.Columns)
                {
                    col.Width = columnWidth;
                }

                if (!onLoad)
                {
                    ShowHidePanel(true);
                }

                if (table_grid.Rows.Count == 0)
                {
                    ErrorMsgs("NoRecordsGrid");
                    gv_accounts.Visible = false;
                }
                else
                {
                    gv_accounts.DataSource = table_grid;
                }
            }
        }

        //Code to animate the grid dropdown
        private void ShowHidePanel(bool show)
        {
            if (show)
                gv_accounts.Visible = false;

            for (int i = 0; i <= pnl_grid_width; i++)
            {
                if (show)
                {
                    pnl_grid.Width = i;
                }
                else
                {
                    pnl_grid.Width = pnl_grid_width - i;
                }
                Thread.Sleep(Controller.UISettingsValues.delayFast);
            }

            if (show && cb_grid.Text != "(None)")
                gv_accounts.Visible = true;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            SetDefault();
        }

        private void SetDefault()
        {
            try
            {
                onLoad = true;
                cb_grid.SelectedIndex = 1;
                cb_graph.SelectedIndex = 1;
                onLoad = false;
            }
            catch (Exception ex)
            { }
        }
    }
}
