using System.Data.SQLite;

namespace PuullUpsTrainigManager.DataSource
{
    static class SQLiteConnectionManager
    {
        static public SQLiteConnection connection = null;

        static private void InitTables()
        {
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandText =   "CREATE TABLE IF NOT EXISTS \"main\".\"users\" (" +
                                        "\"id\" INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, " +
                                        "\"name\" TEXT NOT NULL, " +
                                        "\"init_max\" INTEGER NOT NULL, " +
                                        "\"current_max\" INTEGER);";
            command.ExecuteNonQuery();

            command.CommandText = "CREATE TABLE IF NOT EXISTS \"main\".\"results\" (" +
                                        "\"id\" INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, " +
                                        "\"count\" INTEGER NOT NULL, " +
                                        "\"date_str\" TEXT NOT NULL, " + 
                                        "\"athlete_id\" INTEGER NOT NULL);";
            command.ExecuteNonQuery();
        }

        static public void Connect(string DataBasePath)
        {
            var builder = new SQLiteConnectionStringBuilder();
            builder.DataSource = DataBasePath;
            builder.FailIfMissing = false;
            builder.JournalMode = SQLiteJournalModeEnum.Persist;

            if (connection == null)
            {
                connection = new SQLiteConnection();
            }
            connection.ConnectionString = builder.ConnectionString;
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            InitTables();            
        }

        static public void Disconnect()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
