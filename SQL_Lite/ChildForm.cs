using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using Microsoft.Data.Sqlite;
using System.Collections;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Kernel.Font;
using iText.IO.Font;
using iText.IO.Font.Constants;
using Xceed.Document.NET;
using OfficeOpenXml;
using System.IO;
using OfficeOpenXml;
using Excel=Microsoft.Office.Interop.Excel;

namespace SQL_Lite
{
    public partial class ChildForm : Form
    {
        private string FONT_FILENAME = "../../arialmt.ttf";
        private string dataGridQuery = "";
        public bool report;
        public ChildForm(ToolStripItemClickedEventArgs e, bool report=false)
        {

            InitializeComponent();
            this.report = report;
            exportReportStripButton.Visible = report;
            deleteStripButton.Visible = !report;
            editStripButton.Visible = !report;
            createStripButton.Visible = !report;
            searchTextBox.Visible = !report;
            searchStripLabel.Visible = !report;
            Text = e.ClickedItem.Text;
            switch (e.ClickedItem.Name)
            {
                case "movieMenuItem":
                    Name = "movieTableForm";
                    break;
                case "sessionMenuItem":
                    Name = "sessionTableForm";
                    break;
                case "hallMenuItem":
                    Name = "hallTableForm";
                    break;
                case "ticketMenuItem":
                    Name = "ticketTableForm";
                    break;
                case "clientMenuItem":
                    Name = "clientTableForm";
                    break;
                case "genreMenuItem":
                    Name = "genreTableForm";
                    break;
                case "vacancySeatReportMenuItem":
                    Name = "vacancySeatReportTableForm";
                    break; 
                case "revenueReportMenuItem":
                    Name = "revenueReportTableForm";
                    break;
                case "genreVievsReportMenuItem":
                    Name = "genreVievsReportTableForm";
                    break;
            }
            upd();


        }

        private void OpenElementForm(bool newElement)
        {
            int editID;
            if (newElement) {
                editID = -1;
            }
            else
            {
                editID = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);
            }
            switch (Name)
            {
                case "movieTableForm":
                    MovieElementForm movieDialogForm = new MovieElementForm(editID, newElement);
                    movieDialogForm.ShowDialog();
                    break;
                case "sessionTableForm":
                    SessionElementForm sessionDialogForm = new SessionElementForm(editID, newElement);
                    sessionDialogForm.ShowDialog();
                    break;
                case "hallTableForm":
                    HallElementForm hallDialogForm = new HallElementForm(editID, newElement);
                    hallDialogForm.ShowDialog();
                    break;
                case "ticketTableForm":
                    TicketElementForm ticketDialogForm = new TicketElementForm(editID, newElement);
                    ticketDialogForm.ShowDialog();
                    break;
                case "clientTableForm":
                    ClientElementForm clientDialogForm = new ClientElementForm(editID, newElement);
                    clientDialogForm.ShowDialog();
                    break;
                case "genreTableForm":
                    GenreElementForm genreDialogForm = new GenreElementForm(editID, newElement);
                    genreDialogForm.ShowDialog();
                    break;
            }
            upd();


        }
        private void ChildForm_Load(object sender, EventArgs e)
        {
            
        }

        private void exitStripButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void createStripButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentCell == null)
                return;
            OpenElementForm(true);
        }

        private void editStripButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentCell == null)
                return;
            OpenElementForm(false);
        }

        private void deleteStripButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentCell == null)
                return;
            string tableName = Name.Substring(0, Name.Length - 9);
            string query = SQL_Requests.DeleteByID(tableName);
            int deleteID = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);
            string[,] parameters = { { "@id", deleteID.ToString() } };
            Database.TransactionExecute(query, parameters);
            upd();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void upd()
        {
            if (report)
            {
                switch (Name)
                {
                    case "vacancySeatReportTableForm":
                        dataGridQuery = SQL_Requests.SelectVacancySeatReport();
                        DataGridExtension.UpdateDataGridView(dataGridView, dataGridQuery, new string[0, 2]);
                        break;
                    case "revenueReportTableForm":
                        dataGridQuery = SQL_Requests.SelectRevenueReport();
                        DataGridExtension.UpdateDataGridView(dataGridView, dataGridQuery, new string[0, 2]);
                        break;
                    case "genreVievsReportTableForm":
                        dataGridQuery = SQL_Requests.SelectGenreVievsReport();
                        DataGridExtension.UpdateDataGridView(dataGridView, dataGridQuery, new string[0, 2]);
                        break;
                }
            }
            else if (searchTextBox.Text.Length == 0)
            {
                switch (Name)
                {
                    case "movieTableForm":
                        dataGridQuery = SQL_Requests.SelectMovies();
                        DataGridExtension.UpdateDataGridView(dataGridView, dataGridQuery, new string[0, 2]);
                        break;
                    case "sessionTableForm":
                        dataGridQuery = SQL_Requests.SelectSessions();
                        DataGridExtension.UpdateDataGridView(dataGridView, dataGridQuery, new string[0, 2]);
                        break;
                    case "hallTableForm":
                        dataGridQuery = SQL_Requests.SelectHalls();
                        DataGridExtension.UpdateDataGridView(dataGridView, dataGridQuery, new string[0, 2]);
                        break;
                    case "ticketTableForm":
                        dataGridQuery = SQL_Requests.SelectTickets();
                        DataGridExtension.UpdateDataGridView(dataGridView, dataGridQuery, new string[0, 2], hiddenRows: 0);
                        break;
                    case "clientTableForm":
                        dataGridQuery = SQL_Requests.SelectClients();
                        DataGridExtension.UpdateDataGridView(dataGridView, dataGridQuery, new string[0, 2]);
                        break;
                    case "genreTableForm":
                        dataGridQuery = SQL_Requests.SelectGenres();
                        DataGridExtension.UpdateDataGridView(dataGridView, dataGridQuery, new string[0, 2]);
                        break;
                }
            }
            else
            {
                switch (Name)
                {
                    case "movieTableForm":
                        dataGridQuery = string.Format("{0} WHERE {1} LIKE @{1}", SQL_Requests.SelectMovies(), "movie_title");
                        string[,] movieParameters = { { "@movie_title", string.Format("%{0}%", searchTextBox.Text) } };
                        DataGridExtension.UpdateDataGridView(dataGridView, dataGridQuery, movieParameters);
                        break;
                    case "sessionTableForm":
                        dataGridQuery = string.Format("{0} WHERE {1} LIKE @{1}", SQL_Requests.SelectSessions(), "movie_title");
                        string[,] sessionParameters = { { "@movie_title", string.Format("%{0}%", searchTextBox.Text) } };
                        DataGridExtension.UpdateDataGridView(dataGridView, dataGridQuery, sessionParameters);
                        break;
                    case "hallTableForm":
                        string group = "GROUP BY \r\n                    hall.hall_id,\r\n                    hall_title";
                        dataGridQuery = string.Format("{0} WHERE {1} LIKE @{1} {2}", SQL_Requests.SelectHalls().Replace(group, ""), "hall_title", group);
                        string[,] hallParameters = { { "@hall_title", string.Format("%{0}%", searchTextBox.Text) } };
                        DataGridExtension.UpdateDataGridView(dataGridView, dataGridQuery, hallParameters);
                        break;
                    case "ticketTableForm":
                        dataGridQuery = string.Format("{0} WHERE ticket.{1} LIKE @{1}", SQL_Requests.SelectTickets(), "ticket_id");
                        string[,] ticketParameters = { { "@ticket_id", string.Format("%{0}%", searchTextBox.Text) } };
                        DataGridExtension.UpdateDataGridView(dataGridView, dataGridQuery, ticketParameters, hiddenRows: 0);
                        break;
                    case "clientTableForm":
                        dataGridQuery = string.Format("{0} WHERE {1} LIKE @{1}", SQL_Requests.SelectClients(), "name");
                        string[,] clientParameters = { { "@name", string.Format("%{0}%", searchTextBox.Text) } };
                        DataGridExtension.UpdateDataGridView(dataGridView, dataGridQuery, clientParameters);
                        break;
                    case "genreTableForm":
                        dataGridQuery = SQL_Requests.SelectGenres();
                        dataGridQuery = string.Format("{0} WHERE {1} LIKE @{1}", SQL_Requests.SelectGenres(), "genre_title");
                        string[,] genreParameters = { { "@genre_title", string.Format("%{0}%", searchTextBox.Text) } };
                        DataGridExtension.UpdateDataGridView(dataGridView, dataGridQuery, genreParameters);
                        break;
                }
            }
        }
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            upd();


        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void exportReportStripButton_Click(object sender, EventArgs e)
        {

        }

        private void pDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF files (*.pdf)|*.pdf";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (PdfWriter writer = new PdfWriter(sfd.FileName))
                    {
                        using (PdfDocument pdf = new PdfDocument(writer))
                        {
                            iText.Layout.Document document = new iText.Layout.Document(pdf);
                            PdfFont font = PdfFontFactory.CreateFont(FONT_FILENAME, PdfEncodings.IDENTITY_H);
                            document.SetFont(font);
                            iText.Layout.Element.Table table = new iText.Layout.Element.Table(dataGridView.Columns.Count-1);
                            // Add header
                            for (int i = 1; i < dataGridView.Columns.Count; i++)
                            {
                                table.AddHeaderCell(dataGridView.Columns[i].HeaderText);
                            }

                            // Add rows
                            foreach (DataGridViewRow row in dataGridView.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    for (int i = 1; i < row.Cells.Count; i++)
                                    {
                                        table.AddCell(new iText.Layout.Element.Cell().SetFont(font).Add(new iText.Layout.Element.Paragraph(row.Cells[i].Value?.ToString() ?? "")));
                                    }
                                }
                            }

                            document.Add(table);
                        }
                    }
                }
            }
        }
    

        private void mSWORDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Word files (*.docx)|*.docx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (Xceed.Words.NET.DocX document = Xceed.Words.NET.DocX.Create(sfd.FileName))
                    {
                        Xceed.Document.NET.Table table = document.InsertTable(dataGridView.Rows.Count + 1, dataGridView.Columns.Count-1);

                        // Add header
                        for (int i = 1; i < dataGridView.Columns.Count; i++)
                        {
                            table.Rows[0].Cells[i-1].Paragraphs.First().Append(dataGridView.Columns[i].HeaderText);
                        }

                        // Add rows
                        for (int i = 0; i < dataGridView.Rows.Count; i++)
                        {
                            for (int j = 1; j < dataGridView.Columns.Count; j++)
                            {
                                if (dataGridView.Rows[i].Cells[j].Value != null)
                                {
                                    table.Rows[i + 1].Cells[j-1].Paragraphs.First().Append(dataGridView.Rows[i].Cells[j].Value.ToString());
                                }
                            }
                        }
                        document.Save();
                    }
                }
            }
            
        }
        
        private void mSEXELToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel files (*.xlsx)|*.xlsx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                    using (ExcelPackage package = new ExcelPackage())

                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet1");

                        // Add header
                        for (int i = 1; i < dataGridView.Columns.Count; i++)
                        {
                            worksheet.Cells[1, i].Value = dataGridView.Columns[i].HeaderText;
                        }

                        // Add rows
                        for (int i = 0; i < dataGridView.Rows.Count; i++)
                        {
                            for (int j = 1; j < dataGridView.Columns.Count; j++)
                            {
                                if (dataGridView.Rows[i].Cells[j].Value != null)
                                {
                                    worksheet.Cells[i + 2, j].Value = dataGridView.Rows[i].Cells[j].Value.ToString();
                                }
                            }
                        }

                        package.SaveAs(new FileInfo(sfd.FileName));
                    }
                }
            }
        }
    }
}
