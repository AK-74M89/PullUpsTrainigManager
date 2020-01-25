using PuullUpsTrainigManager.DataSource;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace PuullUpsTrainigManager.BusinessLogic
{
    class User
    {       
        public void AddUser(string UserName, int InitMax)
        {
            var command = new SQLiteCommand(SQLiteConnectionManager.connection);
            command.CommandText = "INSERT INTO users (name, init_max, current_max) " +
                                        "VALUES ('" + UserName + "', " + Convert.ToString(InitMax) + ", " + Convert.ToString(InitMax) + ");";
            command.ExecuteNonQuery();
        }

        public void DeleteUser(int ID)
        {
            var command = new SQLiteCommand(SQLiteConnectionManager.connection);
            command.CommandText = "DELETE FROM users WHERE id = " + Convert.ToString(ID);
            command.ExecuteNonQuery();
        }

        public void UpdateCurrentMaxForUser(int UserID, int NewCurrentMax)
        {
            var command = new SQLiteCommand(SQLiteConnectionManager.connection);
            command.CommandText = "UPDATE users " +
                                    "SET current_max = " + Convert.ToString(NewCurrentMax) + 
                                    " WHERE id = " + Convert.ToString(UserID) + " and current_max < " + Convert.ToString(NewCurrentMax);
            command.ExecuteNonQuery();
        }

        public IList<UsersListItem> UsersList
        {
            get
            {
                var UsersList = new List<UsersListItem>();
                var item = new UsersListItem();
                var command = new SQLiteCommand(SQLiteConnectionManager.connection);
                command.CommandText = "SELECT id, name, init_max, current_max FROM users;";
                var reader = command.ExecuteReader();           
                while (reader.Read())
                {                                        
                    item.ID = Convert.ToInt32(reader["id"]);
                    item.UserName = Convert.ToString(reader["name"]);
                    item.InitMax = Convert.ToInt32(reader["init_max"]);
                    item.CurrentMax = Convert.ToInt32(reader["current_max"]);
                    UsersList.Add(item);
                }
                reader.Close();
                return UsersList;
            }
        }
    }
}
