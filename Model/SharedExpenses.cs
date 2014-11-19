using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace Model
{
    public class SharedExpenses
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        string cmdStr;

        Model.LogEntity Log;

        //Method to Get All Titles
        public DataTable GetTitles()
        {
            OleDbDataAdapter adapter;
            DataTable dt = new DataTable();
            try
            {
                conn = new OleDbConnection(DBSettings.Connection);
                conn.Open();
                cmdStr = "SELECT * FROM SEMain ORDER BY Titlename";
                adapter = new OleDbDataAdapter(cmdStr, conn);
                adapter.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                Log = new LogEntity();
                Log.ErrorMsg = ex.Message;
                Log.Page = ex.StackTrace;
                Common.Log(Log);
                return new DataTable();
            }
        }

        //Add a new Title
        public int AddTitle(Model.SharedEntity shared)
        {
            try
            {
                conn = new OleDbConnection(DBSettings.Connection);
                conn.Open();
                cmdStr = "INSERT INTO SEMain (Titlename,Description,Type) " +
                    "VALUES ('" + shared.Title + "','" + shared.Description + "','" + shared.Type + "')";
                cmd = new OleDbCommand(cmdStr, conn);
                if (cmd.ExecuteNonQuery() != 1)
                {
                    conn.Close();
                    return 0;
                }

                cmdStr = "SELECT TOP 1 TitleId FROM SEMain ORDER BY TitleId desc";
                cmd = new OleDbCommand(cmdStr, conn);
                int titleId = (int)cmd.ExecuteScalar();
                conn.Close();
                
                return titleId;
            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                Log = new LogEntity();
                Log.ErrorMsg = ex.Message;
                Log.Page = ex.StackTrace;
                Common.Log(Log);
                return 0;
            }
        }

        //Add a new participant
        public bool AddParticipant(Model.SharedEntity shared)
        {
            try
            {
                conn = new OleDbConnection(DBSettings.Connection);
                conn.Open();
                cmdStr = "INSERT INTO SEParticipants (TitleId,ParticipantName) " +
                    "VALUES (" + shared.TitleId + ",'" + shared.ParticipantName + "')";
                cmd = new OleDbCommand(cmdStr, conn);
                if (cmd.ExecuteNonQuery() != 1)
                {
                    conn.Close();
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                Log = new LogEntity();
                Log.ErrorMsg = ex.Message;
                Log.Page = ex.StackTrace;
                Common.Log(Log);
                return false;
            }
        }

        //Get all participants 
        public DataTable GetParticipants(int TitleId)
        {
            OleDbDataAdapter adapter;
            DataTable dt = new DataTable();
            try
            {
                conn = new OleDbConnection(DBSettings.Connection);
                conn.Open();
                cmdStr = "SELECT * FROM SEParticipants WHERE TitleId="+ TitleId +" ORDER BY ParticipantName";
                adapter = new OleDbDataAdapter(cmdStr, conn);
                adapter.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                Log = new LogEntity();
                Log.ErrorMsg = ex.Message;
                Log.Page = ex.StackTrace;
                Common.Log(Log);
                return new DataTable();
            }
        }

        //Delete complete expense
        public bool DeleteSharedExpense(Model.SharedEntity shared)
        {
            try
            {
                conn = new OleDbConnection(DBSettings.Connection);
                conn.Open();
                cmdStr = "DELETE FROM SEMain WHERE TitleId=" + shared.TitleId.ToString();
                cmd = new OleDbCommand(cmdStr, conn);
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conn.Close();
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                Log = new LogEntity();
                Log.ErrorMsg = ex.Message;
                Log.Page = ex.StackTrace;
                Common.Log(Log);
                return false;
            }
        }

        //Add all the divided expenses
        public bool AddDivision(Model.SharedEntity shared) 
        {
            int seeid;
            try
            {
                conn = new OleDbConnection(DBSettings.Connection);
                conn.Open();
                cmd = new OleDbCommand(cmdStr, conn);
                cmd.CommandText ="INSERT INTO SEExpense (ParticipantId,Amount,Item,DateSpent) " +
                    "VALUES (" + shared.ParticipantId + "," +
                    shared.Amount + ",'" + shared.Item + "',@Date)";
                cmd.Parameters.AddWithValue("@Date", shared.DateSpent.Date);

                if (cmd.ExecuteNonQuery() != 1)
                {
                    conn.Close();
                    return false;
                }

                cmdStr = "SELECT TOP 1 SEEId FROM SEExpense ORDER BY SEEId DESC";
                cmd = new OleDbCommand(cmdStr, conn);
                seeid = Convert.ToInt32(cmd.ExecuteScalar());

                foreach (Model.SharedParticipants item in shared.Participants)
                {
                    cmdStr = "INSERT INTO SEDivision (SEEId,ParticipantId,Share) " +
                    "VALUES (" + seeid + "," + item.ParticipantId + "," + item.Share + ")";
                    cmd = new OleDbCommand(cmdStr, conn);
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                Log = new LogEntity();
                Log.ErrorMsg = ex.Message;
                Log.Page = ex.StackTrace;
                Common.Log(Log);
                return false;
            }
        }

        public DataTable GetSharedExpenses(SharedEntity shared)
        {
            OleDbDataAdapter adapter;
            DataTable dt = new DataTable();
            try
            {
                conn = new OleDbConnection(DBSettings.Connection);
                conn.Open();
                cmdStr = "SELECT SEExpense.SEEID, SEParticipants.ParticipantName, SEExpense.Amount, SEExpense.Item, SEExpense.DateSpent" +
                    " FROM SEExpense" +
                    " INNER JOIN SEParticipants ON SEParticipants.ParticipantId = SEExpense.ParticipantId" +
                    " WHERE SEParticipants.TitleId = " + shared.TitleId.ToString() +
                    " ORDER BY SEExpense.DateSpent DESC";
                adapter = new OleDbDataAdapter(cmdStr, conn);
                adapter.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                Log = new LogEntity();
                Log.ErrorMsg = ex.Message;
                Log.Page = ex.StackTrace;
                Common.Log(Log);
                return new DataTable();
            }
        }

        //Delete complete expense
        public bool DeleteSharedRecord(int recordId)
        {
            try
            {
                conn = new OleDbConnection(DBSettings.Connection);
                conn.Open();
                cmdStr = "DELETE FROM SEExpense WHERE SEEId=" + recordId;
                cmd = new OleDbCommand(cmdStr, conn);
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conn.Close();
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                Log = new LogEntity();
                Log.ErrorMsg = ex.Message;
                Log.Page = ex.StackTrace;
                Common.Log(Log);
                return false;
            }
        }

        //Get details of currently selected expense
        public Model.SharedEntity GetExpenseDetails(int recordId)
        {
            Model.SharedEntity shared = new Model.SharedEntity();
            try
            {
                conn = new OleDbConnection(DBSettings.Connection);
                conn.Open();
                cmdStr = "SELECT Description,Type FROM SEMain WHERE TitleId=" + recordId;
                cmd = new OleDbCommand(cmdStr, conn);
                OleDbDataReader reader = cmd.ExecuteReader();
                reader.Read();
                shared.Type = reader["Type"].ToString();
                shared.Description = reader["Description"].ToString();

                return shared;
            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                Log = new LogEntity();
                Log.ErrorMsg = ex.Message;
                Log.Page = ex.StackTrace;
                Common.Log(Log);
                return new Model.SharedEntity();
            }
        }

        //Get final data for displaying expenses
        public DataTable GetFinalResult(int titleId)
        {
            OleDbDataAdapter adapter;
            DataTable dt = new DataTable();
            try
            {
                conn = new OleDbConnection(DBSettings.Connection);
                conn.Open();
                //Add split table
                cmdStr = "SELECT m.TitleId, p.ParticipantId AS SpentBy, e.SEEID, e.Amount, d.ParticipantId, d.Share, " +
                    " ROUND(((d.Share * e.Amount)/(SELECT SUM(Share) FROM SEDivision sd WHERE sd.SEEId=d.SEEId)),2) As ShareAmount " +
                    " FROM SEMain m" +
                    " INNER JOIN (SEParticipants p " +
                        " INNER JOIN (SEExpense e " +
                            " INNER JOIN SEDivision d on d.SEEId = e.SEEId) " +
                        " ON e.ParticipantId=p.ParticipantId)" +
                    " ON p.titleId = m.TitleId" +
                    " WHERE m.TitleId=" + titleId.ToString() +
                    " and d.Share <> 0 ";
                cmd = new OleDbCommand(cmdStr, conn);
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                Log = new LogEntity();
                Log.ErrorMsg = ex.Message;
                Log.Page = ex.StackTrace;
                Common.Log(Log);
                return new DataTable();
            }
        }


    }

}
