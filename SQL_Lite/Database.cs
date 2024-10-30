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
        public static (SqliteConnection, SqliteDataReader) Select(string request)
        {
            SqliteConnection connection = new SqliteConnection(GetConnectionString("ReadOnly"));
            connection.Open();
            SqliteCommand myCommand = new SqliteCommand(request, connection);
            SqliteDataReader reader = myCommand.ExecuteReader();
            return (connection, reader);
        }
        public static void FillDataGridView(DataGridView dataGridView, string request)
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            (SqliteConnection connection, SqliteDataReader reader) = Select(request);

            for (int i = 0; i < reader.FieldCount; i++)
            {
                dataGridView.Columns.Add(reader.GetName(i), reader.GetName(i));
            }

            while (reader.Read())
            {
                object[] rowData = new object[reader.FieldCount];
                reader.GetValues(rowData);
                dataGridView.Rows.Add(rowData);
            }

            connection.Close();
        }
    }
}
