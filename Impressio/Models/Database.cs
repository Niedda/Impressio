using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using RapeDigital.Properties;

namespace RapeDigital.Models
{
    public class Database
    {
        private static readonly SqlConnection DatabaseConnection = new SqlConnection(Settings.Default.connectionString);

        public static string CommandString;

        public static string ConnectionString
        {
            get { return Settings.Default.connectionString; }
            set
            {
                Settings.Default.connectionString = value;
                Settings.Default.Save();
                DatabaseConnection.Close();
                DatabaseConnection.ConnectionString = Settings.Default.connectionString;
            }
        }

        public static void CheckConnection()
        {
            if(DatabaseConnection.State != ConnectionState.Open)
            {
                DatabaseConnection.Open();
            }
        }

        public static SqlCommand SetCommand()
        {
            return new SqlCommand(CommandString, DatabaseConnection);
        }

        public static SqlDataReader Reader;

        public static void CloseReader()
        {
            if(!Database.Reader.IsClosed)
            {
                Database.Reader.Close();
            }
        }

        public static int InsertSql(string table, Dictionary<string, string> cols)
        {
            try
            {
                CheckConnection();
                CommandString = "INSERT INTO dbo.[" + table + "] ({0}) VALUES ({1})";

                while (cols.Values.Contains(null))
                {
                    var item = cols.First(c => c.Value == null);
                    cols.Remove(item.Key);
                }

                var val = string.Join(",", cols.Keys.ToArray());
                var param = val.Replace("@", "");

                CommandString = string.Format(CommandString, param, val);
                var comm = new SqlCommand(CommandString, DatabaseConnection);

                foreach (var value in cols.Where(c => c.Value != null))
                {
                    comm.Parameters.Add(new SqlParameter(value.Key, value.Value));
                }
                comm.CommandText += "; SELECT SCOPE_IDENTITY();";
                return Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (Exception exception)
            {
                LogClass.WriteToLog(exception.ToString());
                return 0;
            }
        }

        public static bool UpdateSql(string table, Dictionary<string, string> cols, string id, string idCol)
        {
            CheckConnection();

            var setNull = (from a in cols where a.Value == null || string.IsNullOrEmpty(a.Value) select a).ToList();

            foreach (var keyValuePair in setNull)
            {
                cols.Remove(keyValuePair.Key);
            }

            try
            {
                CommandString = string.Format("UPDATE dbo.[{0}] SET ", table);
                
                foreach (var col in cols)
                {
                    CommandString += string.Format("{0} = {1},", col.Key.Replace("@", ""), col.Key);
                }

                CommandString = CommandString.Remove(CommandString.Length - 1, 1) + string.Format(" WHERE {0} = {1}", idCol, id);
                
                var comm = SetCommand();

                foreach (var keyValuePair in cols)
                {
                    comm.Parameters.Add(new SqlParameter(keyValuePair.Key, keyValuePair.Value));
                }
                foreach (var keyValuePair in setNull)
                {
                    comm.Parameters.Add(new SqlParameter(keyValuePair.Key, DBNull.Value));
                }

                comm.ExecuteNonQuery();
                return true;
            }
            catch (Exception exception)
            {
                LogClass.WriteToLog(exception.ToString());
                return false;
            }
        }
    }

    public static class Integer
    {
        public static int GetInt(this object obj)
        {
            try
            {
                return Convert.ToInt32(obj);
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
