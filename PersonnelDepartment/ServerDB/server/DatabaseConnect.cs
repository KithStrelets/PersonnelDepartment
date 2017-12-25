using System;
using System.Collections.Generic;
using Npgsql;

namespace PersonnelDepartment
{
    public class DatabaseConnect
    {
        internal NpgsqlConnection connection { get; set; }
        internal string server { get; set; }
        internal string database { get; set; }
        internal string user { get; set; }
        internal string password { get; set; }

        public DatabaseConnect()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "localhost";
            database = "personneldb";
            user = "postgres";
            password = "password";
            string connectionString;
            connectionString = string.Format("Server=localhost;Username={0};Password={1};Database={2};", user, password, database);
            connection = new NpgsqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public string Transform(string target)
        {
            string result;
            if (target == null) result = "";
            else { result = "\"" + target + "\""; }
            return result;
        }

        public List<string>[] CommonExecute(string query)
        {
            List<string>[] list = new List<string>[] { };

            if (OpenConnection())
            {
                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                NpgsqlDataReader dataReader = cmd.ExecuteReader();
                int count = 0;
                while (dataReader.Read())
                {
                    count++;
                }
                dataReader.Close();
                try
                {
                    dataReader = cmd.ExecuteReader();
                }
                catch (NpgsqlException)
                {
                    return list;
                }

                list = new List<string>[count];
                for (int a = 0; dataReader.Read(); a++)
                {
                    list[a] = new List<string>();
                    for (int inner = 0; inner < dataReader.FieldCount; inner++)
                    {
                        try
                        {
                            list[a].Add(dataReader.GetValue(inner).ToString());
                        }
                        catch (System.Data.SqlTypes.SqlNullValueException) { list[a].Add(""); }
                    }
                }
                dataReader.Close();
                CloseConnection();
                return list;
            }
            return list;
        }
    }
}
