using Microsoft.Data.Sqlite;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using SQL_Lite;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;

namespace SQL_Lite
{
    public static class Database
    {
        static string ReadSettings()
        {
            string jsonString = File.ReadAllText("settings.json");
            var jsonDocument = JsonDocument.Parse(jsonString);
            return jsonDocument.RootElement.GetProperty("DataSource").GetString();
        }
        static string GetConnectionString(string connectionMode)
        {
            return String.Format("Data Source={0};" +
                                "Mode={1};",
                                ReadSettings(), connectionMode);
        }

        private static void FillCommandParameters(SqliteCommand command, string[,] requestParameters)
        {
            for (int i = 0; i < requestParameters.GetLength(0); i++)
            {
                command.Parameters.AddWithValue(requestParameters[i, 0], requestParameters[i, 1]);
            }
        }
        public static (SqliteConnection, SqliteDataReader) NoTransactionExecute(string request, string[,] requestParameters)
        {
            SqliteConnection connection = new SqliteConnection(GetConnectionString("ReadOnly"));
            connection.Open();
            SqliteCommand command = new SqliteCommand(request, connection);
            FillCommandParameters(command, requestParameters);
            SqliteDataReader reader = command.ExecuteReader();
            return (connection, reader);
        }

        public static int TransactionExecute(string request, string[,] requestParameters, bool needReturnID=false)
        {
            using (SqliteConnection connection = new SqliteConnection(GetConnectionString("ReadWrite")))
            {
                connection.Open();

                SqliteCommand command = connection.CreateCommand();
                SqliteTransaction transaction;

                transaction = connection.BeginTransaction();
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    if (needReturnID)
                    {
                        request = string.Format("{0};SELECT last_insert_rowid()", request);
                        command.CommandText = request;
                        FillCommandParameters(command, requestParameters);
                        int newId = Convert.ToInt32(command.ExecuteScalar());
                        transaction.Commit();
                        return newId;
                    }
                    else
                    {
                        command.CommandText = request;
                        FillCommandParameters(command, requestParameters);
                        command.ExecuteNonQuery();
                        transaction.Commit();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                    Console.WriteLine("Message: {0}", ex.Message);
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                        Console.WriteLine("Message: {0}", ex2.Message);
                    }
                }
            }
            return -1;
        }
    }
}
