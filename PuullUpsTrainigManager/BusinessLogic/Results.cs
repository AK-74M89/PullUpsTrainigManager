using PuullUpsTrainigManager.DataSource;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace PuullUpsTrainigManager.BusinessLogic
{
    class Results
    {
        public void AddResult(int Result, DateTime Date, int UserId)
        {
            var command = new SQLiteCommand(SQLiteConnectionManager.connection);
            command.CommandText = "INSERT INTO results (count, date_str, athlete_id) VALUES (" + 
                                    Convert.ToString(Result) + ", '" + 
                                    Date.ToShortDateString() + "', " + 
                                    Convert.ToString(UserId) + ");";
            command.ExecuteNonQuery();
            var user = new User();
            user.UpdateCurrentMaxForUser(UserId, Result);
        }

        public void DeleteResult(int ID)
        {
            var command = new SQLiteCommand(SQLiteConnectionManager.connection);
            command.CommandText = "DELETE FROM results WHERE id = " + Convert.ToString(ID);
            command.ExecuteNonQuery();
        }

        public void ClearResults(int UserID)
        {
            var command = new SQLiteCommand(SQLiteConnectionManager.connection);
            command.CommandText = "DELETE FROM results WHERE athlete_id = " + Convert.ToString(UserID);
            command.ExecuteNonQuery();
        }

        public IList<ResultsListItem> GetAllResults(int UserID)
        {
            var results = new List<ResultsListItem>();
            var item = new ResultsListItem();

            var command = new SQLiteCommand(SQLiteConnectionManager.connection);
            command.CommandText = "SELECT id, date_str, count FROM results WHERE athlete_id = " + Convert.ToString(UserID);
            var reader = command.ExecuteReader();
            while (reader.Read())                
            {                
                item.ID = Convert.ToInt32(reader["id"]);
                item.Date = Convert.ToDateTime(reader["date_str"]);
                item.Result = Convert.ToInt32(reader["count"]);
                results.Add(item);
            }
            return results;
        }
    }
}
