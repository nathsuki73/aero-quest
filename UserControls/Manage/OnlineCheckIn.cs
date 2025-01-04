using aero_quest.Objects;
using aero_quest.Sql;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aero_quest.UserControls.Manage
{
    public partial class OnlineCheckIn : UserControl
    {
        public OnlineCheckIn()
        {
            InitializeComponent();
            LoadBookings();
        }

        private void LoadBookings()
        {
            try
            {
                // Fetch booking data from the database
                DataTable allSchedBooked = ConvertSchedulesToDataTable(SqlQueries.GetAllBookingSchedules()); // Assuming this returns a DataTable

                // Check if data exists
                if (allSchedBooked != null && allSchedBooked.Rows.Count > 0)
                {
                    // Bind the data to the DataGridView
                    guna2DataGridView1.DataSource = allSchedBooked;
                    guna2DataGridView1.Columns[8].Visible = false;
                    guna2DataGridView1.Columns[7].Visible = false;
                    guna2DataGridView1.Columns[6].Visible = false;


                }
                else
                {
                    // Clear the DataGridView if no data exists
                    guna2DataGridView1.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                // Handle potential exceptions
                MessageBox.Show($"An error occurred while loading bookings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static DataTable ConvertSchedulesToDataTable(List<List<string>> schedules)
        {
            DataTable dataTable = new DataTable();

            // Define columns
            // Define columns
            dataTable.Columns.Add("From", typeof(string));
            dataTable.Columns.Add("To", typeof(string));
            dataTable.Columns.Add("Departure", typeof(string));
            dataTable.Columns.Add("Arrival", typeof(string));
            dataTable.Columns.Add("Date", typeof(string));

            /*guna2DataGridView1.Columns["from"].HeaderText = "From";
            guna2DataGridView1.Columns["to"].HeaderText = "To";
            guna2DataGridView1.Columns["departureTime"].HeaderText = "Departure Time";
            guna2DataGridView1.Columns["arrivalTime"].HeaderText = "Arrival Time";
            guna2DataGridView1.Columns["aircraft"].HeaderText = "Aircraft";
            guna2DataGridView1.Columns["passengerCount"].HeaderText = "Passenger Count";
            guna2DataGridView1.Columns["date"].HeaderText = "Date";
            guna2DataGridView1.Columns["price"].HeaderText = "Price";*/
            dataTable.Columns.Add("Status", typeof(string));
            dataTable.Columns.Add("Reference", typeof(string));
            dataTable.Columns.Add("SeatId", typeof(string));
            dataTable.Columns.Add("id", typeof(string));

            foreach (var schedule in schedules)
            {
                // Assume the schedule contains: [original_schedule, status, reference, seatId]

                DataRow row = dataTable.NewRow();

                row["From"] = schedule[1];
                row["To"] = schedule[2];
                row["Departure"] = schedule[3];
                row["Arrival"] = schedule[4];
                row["Date"] = DateTime.Parse(schedule[7].ToString()).ToString("yyyy-MM-dd");
                row["Status"] = schedule[9];
                row["Reference"] = schedule[10];
                row["SeatId"] = schedule[11];
                row["id"] = schedule[12];

                dataTable.Rows.Add(row);
            }

            return dataTable;
        }


        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            UserControlManager.RemoveControlByName("onlineCheckIn");

        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = guna2DataGridView1.SelectedRows[0];

                string id = selectedRow.Cells["id"].Value.ToString();
                string status = selectedRow.Cells["status"].Value.ToString();

                string seatId = selectedRow.Cells["seatId"].Value.ToString();
                string from = selectedRow.Cells["from"].Value.ToString();
                string to = selectedRow.Cells["to"].Value.ToString();
                Console.WriteLine($"AAAAA:{seatId}:{from}:{to}");
                if (status == "Checked in")
                {
                    MessageBox.Show("Already Checked In");
                }
                else
                {
                    SqlQueries.UpdateScheduleStatus(Convert.ToInt32(id), "Checked in");
                    SendMail(seatId, from, to);
                    LoadBookings();
                }

            } else
            {

            }
        }

        private void SendMail(string seatId, string from, string to)
        {
            Guid id = Guid.NewGuid();
            Mails mails = new Mails();
            mails.Id = id;
            mails.Type = "Check in";
            mails.From = from;
            mails.To = to;
            mails.Code = seatId;
            mails.DateTime = DateTime.Now;
            mails.IsRead = false;
            mails.IsDeleted = false;
            mails.IsPermanentlyDeleted = false;
            User._userMails.Add(mails);
        }
    }
}
