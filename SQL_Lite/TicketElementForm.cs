using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Lite
{
    public partial class TicketElementForm : Form
    {
        int ID;
        bool newElement;
        string clientID = "-1";
        string sessionID = "-1";
        string hallID = "-1";
        int row = -1;
        int seat = -1;

        private int rows = 0;
        private int maxSeatsPerRow = 0;
        private static int footerHeigth = 100;
        private static int headerHeigth = 122;
        private static int seatWidth = 20;
        private static int seatHeight = 20;
        private static int margin = 5;
        private static int footerButtonMargin = 75;
        private HashSet<(int, int)> occupiedSeats = new HashSet<(int, int)> ();
        public class Seat: Button
        {
            
            public string rowID;
            public int rowNumber;
            public int seatNumber;
            public Seat(int rowNumber, int seatNumber, int seatPerRow, int parentWidth, Color color)
            {
                this.rowNumber = rowNumber+1;
                this.seatNumber = seatNumber+1;

                Width = seatWidth;
                Height = seatHeight;
                //Text = $"{seatNumber + 1}";
                int d = seatPerRow * Width + (seatPerRow - 1) * margin;
                int startPositionWidth = (parentWidth - d) / 2;
                Location = new Point(startPositionWidth + seatNumber * (Width+margin), headerHeigth + rowNumber * (Height+margin));
                BackColor = color;
            }
        }
        private Seat[,] seats;
        private int[] seatsPerRow;
        public TicketElementForm(int id, bool newElement)
        {
            InitializeComponent();
            ID = id;
            this.newElement = newElement;
            if (!newElement)
            {
                string query = SQL_Requests.SelectTicketByID();
                string[,] parameters = { { "@id", ID.ToString() } };
                (SqliteConnection connection, SqliteDataReader reader) = Database.NoTransactionExecute(query, parameters);

                while (reader.Read())
                {
                    clientID = reader.GetValue(0).ToString();
                    clientTextBox.Text = reader.GetValue(1).ToString();
                    sessionID = reader.GetValue(2).ToString();
                    hallID = reader.GetValue(3).ToString();
                    //cost reader.GetValue(4).ToString();
                    purcaseTimeTextBox.Text = reader.GetValue(5).ToString();
                    row = System.Int32.Parse(reader.GetValue(6).ToString());
                    seat = System.Int32.Parse(reader.GetValue(7).ToString());
                    rowTextBox.Text = row.ToString();
                    seatTextBox.Text = seat.ToString();
                    string movie = reader.GetValue(8).ToString();
                    string date = reader.GetValue(9).ToString();
                    string start_time = reader.GetValue(10).ToString();
                    string duration = reader.GetValue(11).ToString();
                    string finish_time = Validation.addTime(start_time, duration);
                    sessionTextBox.Text = string.Format("{0} {1} {2}-{3}", movie, date, start_time, finish_time);
                    
                    rows = System.Int32.Parse(reader.GetValue(12).ToString());
                    maxSeatsPerRow = System.Int32.Parse(reader.GetValue(13).ToString());
                }
                connection.Close();
                UpdateRows();
                InitializeCinemaHall();
            }
        }
        private void UpdateRows()
        {
            seatsPerRow = new int[rows];
            string query = SQL_Requests.SelectHallRowsByID();
            string[,] parameters = { { "@id", hallID } };
            (SqliteConnection connection, SqliteDataReader reader) = Database.NoTransactionExecute(query, parameters);

            int i = 0;
            while (reader.Read())
            {
                seatsPerRow[i] = System.Int32.Parse(reader.GetValue(2).ToString());
                i++;
            }
            connection.Close();

            query = SQL_Requests.SelectOtherSeats();
            string [,] newParameters = { { "@ticket_id", ID.ToString() },
                                         { "@session_id", sessionID } };
            (connection, reader) = Database.NoTransactionExecute(query, newParameters);

            while (reader.Read())
            {
                occupiedSeats.Add( (System.Int32.Parse(reader.GetValue(0).ToString()), System.Int32.Parse(reader.GetValue(1).ToString())) );
            }
            connection.Close();
        }

        private void InitializeCinemaHall()
        {
            this.Height = headerHeigth + (seatHeight + margin) * rows + footerHeigth;
            seats = new Seat[rows, maxSeatsPerRow];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < seatsPerRow[i]; j++)
                {
                    Color seatColor = Color.Gray;
                    if (i+1 == row && j+1 == seat) seatColor = Color.Green;
                    if (occupiedSeats.Contains((i+1, j+1))) seatColor = Color.Yellow;
                    seats[i, j] = new Seat(i, j, seatsPerRow[i], this.Width, seatColor);

                    int rowIndex = i;
                    int seatIndex = j;
                    seats[i, j].Click += (s, e) => Button_Click(seats[rowIndex, seatIndex]);
                    this.Controls.Add(seats[i, j]);
                }
            }
            cancelButton.Location = new Point(cancelButton.Location.X, this.Height - footerButtonMargin);
            saveButton.Location = new Point(saveButton.Location.X, this.Height - footerButtonMargin);
        }
        private void ClearCinemaHall()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < seatsPerRow[i]; j++)
                {
                    this.Controls.Remove(seats[i, j]);
                }
            }
            rows = 0;
        }

        private void Button_Click(Seat s)
        {
            if(seats[s.rowNumber-1, s.seatNumber-1].BackColor == Color.Gray)
            {
                if((row != -1)||(seat != -1)) seats[row-1, seat-1].BackColor = Color.Gray;
                seats[s.rowNumber-1, s.seatNumber-1].BackColor = Color.Green;
                row = s.rowNumber;
                seat = s.seatNumber;
                rowTextBox.Text = row.ToString();
                seatTextBox.Text = seat.ToString();
            }
        }

        private void SaveTicket()
        {
            if (newElement)
            {
                string query = SQL_Requests.InsertTicket();
                string[,] parameters = {
                    { "@client_id", clientID},
                    { "@session_id", sessionID},
                    { "@row", rowTextBox.Text},
                    { "@seat", seatTextBox.Text}
                };
                ID = Database.TransactionExecute(query, parameters, needReturnID: true);
            }
            else
            {
                string query = SQL_Requests.UpdateTicket();
                string[,] parameters = {
                    { "@client_id", clientID},
                    { "@session_id", sessionID},
                    { "@row", rowTextBox.Text},
                    { "@seat", seatTextBox.Text},
                    { "@id", ID.ToString()}
                };
                Database.TransactionExecute(query, parameters);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (Validation.CheckFill("Клиент", clientTextBox.Text) && Validation.CheckFill("Сеанс", sessionTextBox.Text) && Validation.CheckFill("Ряд", row.ToString()) && Validation.CheckFill("Место", seat.ToString()))
            {
                SaveTicket();
                Close();
            }
        }

        private void clientButton_Click(object sender, EventArgs e)
        {
            ClientSelectForm clientDialogForm = new ClientSelectForm();
            clientDialogForm.ShowDialog();

            if (clientDialogForm.success)
            {
                clientID = clientDialogForm.selectedClientID;
                clientTextBox.Text = clientDialogForm.selectedClientName;
            }
        }

        private void sessionButton_Click(object sender, EventArgs e)
        {
            SessionSelectForm sessionDialogForm = new SessionSelectForm();
            sessionDialogForm.ShowDialog();

            if (sessionDialogForm.success)
            {
                row = -1;
                seat = -1;
                rowTextBox.Text = "";
                seatTextBox.Text = "";
                if(sessionID != "-1")
                {
                    ClearCinemaHall();
                }
                sessionID = sessionDialogForm.selectedSessionID;
                sessionTextBox.Text = sessionDialogForm.selectedSessionName;
                hallID = sessionDialogForm.selectedHallID;
                rows = sessionDialogForm.selectedRows;
                maxSeatsPerRow = sessionDialogForm.selectedMaxSeats;
                UpdateRows();
                InitializeCinemaHall();
                
            }
        }
    }
}
