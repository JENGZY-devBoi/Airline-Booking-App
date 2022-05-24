using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace formIndex {
    public partial class Payment : Form {
        private double amount = 0;
        private double totalPrice = flightData.flightPrice + seatData.seatPrice;
        private string paymentMethod = "Pay by debit/mastercard";
        private string paymentStatus = "YES";
        private string passenID;
        private string bookingID;
        private string dateNow1;
        private string timeNow1;
        private string dateNow;
        private string timeNow;

        public Payment() {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e) {
            var form = new ContinueBooking();
            form.Show();
            this.Hide();
        }

        private bool validFill() {
            // Valid fill complete info
            if (txtMas.Text == "" ||
                txtCVC.Text == "" ||
                txtExpir.Text == "" ||
                txtFname.Text == "" ||
                txtLname.Text == "") {
                // Check
                // Console.WriteLine("Please fill complete information.");
                MessageBox.Show
                    (
                        "Please fill complete information.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                return false;
            }
            return true;
        }

        private void btnSuccess_Click(object sender, EventArgs e) {
            dateNow = dateNow1;
            timeNow = timeNow1;

            if (validFill()) {
                postPassengerDB();
                postBookingDB();
                postPaymentDB();
                putSeatDB();

                // Interaction to emp: say "SUCCESS!"
                MessageBox.Show(
                    "Booking success!",
                    "Notification"
                );

                // GO TO SEARCH FORM
                //var formSearch = new formSearch();
                //formSearch.Show();
                //this.Hide();
            }
        }

        private void postPassengerDB() {
            // Login

            try {
                dbConfig.connection.Open();
                var adapter = new SqlDataAdapter();
                string sql =
                    $"INSERT INTO passengers " +
                    $"(passengersTitle,passengersFname,passengersLname," +
                    $"passengersDOB,passengersEmail) " +
                    $"VALUES(" +
                    $"'{passengerData.passengerTitle}'," +
                    $"'{passengerData.passengerFname}'," +
                    $"'{passengerData.passengerLname}'," +
                    $"'{passengerData.passengerDOB}'," +
                    $"'{passengerData.passengerEmail}');";
                adapter.InsertCommand = dbConfig.connection.CreateCommand();
                adapter.InsertCommand.CommandText = sql;
                adapter.InsertCommand.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show
                (
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            dbConfig.connection.Close();
        }

        private void postBookingDB() {
            try {
                dbConfig.connection.Open();
                string sql;
                // SELECT PASSENGER ID
                var adapterPass = new SqlDataAdapter();
                var passTB = new DataTable();
                sql = "SELECT * FROM passengers";
                adapterPass.SelectCommand = new SqlCommand(sql, dbConfig.connection);
                adapterPass.Fill(passTB);
                sql =
                    $"passengersFname='{passengerData.passengerFname}' AND " +
                    $"passengersLname='{passengerData.passengerLname}' AND " +
                    $"passengersEmail='{passengerData.passengerEmail}'";
                DataRow[] dr = passTB.Select(sql);
                passenID = dr[0]["passengerID"].ToString();

                // INSERT BOOKING
                var adapterBook = new SqlDataAdapter();
                sql =
                    $"INSERT INTO bookings " +
                    $"(bookingDate,bookingTime,passengerID,seatID) " +
                    $"VALUES(" +
                    $"'{dateNow}'," +
                    $"'{timeNow}'," +
                    $"'{passenID}'," +
                    $"'{seatData.seatID}');";
                adapterBook.InsertCommand = dbConfig.connection.CreateCommand();
                adapterBook.InsertCommand.CommandText = sql;
                adapterBook.InsertCommand.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show
                (
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            dbConfig.connection.Close();
        }

        private void postPaymentDB() {
            try {
                dbConfig.connection.Open();
                string sql;

                // SELECT BOOKING ID
                var adapterBook = new SqlDataAdapter();
                var bookTB = new DataTable();
                sql = $"SELECT * FROM bookings";
                adapterBook.SelectCommand = new SqlCommand(sql, dbConfig.connection);
                adapterBook.Fill(bookTB);
                sql =
                    $"passengerID='{passenID}' AND " +
                    $"seatID='{seatData.seatID}'";
                DataRow[] dr = bookTB.Select(sql);
                bookingID = dr[0]["bookingID"].ToString();

                // INSERT PAYMENT
                var adapterPay = new SqlDataAdapter();
                sql =
                    $"INSERT INTO payments " +
                    $"(paymentTotalPrice,paymentStatus,paymentNotifyDate,paymentNotifyTime," +
                    $"paymentDate,paymentTime,paymentMethod,bookingID) " +
                    $"VALUES(" +
                    $"'{flightData.flightPrice + seatData.seatPrice}'," +
                    $"'{paymentStatus}'," +
                    $"'{dateNow}'," +
                    $"'{timeNow}'," +
                    $"'{dateNow}'," +
                    $"'{timeNow}'," +
                    $"'{paymentMethod}'," +
                    $"'{bookingID}');";
                adapterBook.InsertCommand = dbConfig.connection.CreateCommand();
                adapterBook.InsertCommand.CommandText = sql;
                adapterBook.InsertCommand.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show
                (
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            dbConfig.connection.Close();
        }

        private void putSeatDB() {
            try {
                dbConfig.connection.Open();
                string sql;

                // UPDATE Seat
                var adapterSeat = new SqlDataAdapter();
                sql =
                    $"UPDATE seats " +
                    $"SET seatStatus='{seatData.seatStatus}' " +
                    $"WHERE seatID='{seatData.seatID}'";
                adapterSeat.UpdateCommand = dbConfig.connection.CreateCommand();
                adapterSeat.UpdateCommand.CommandText = sql;
                adapterSeat.UpdateCommand.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show
                (
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            dbConfig.connection.Close();
        }

        private void Payment_Load(object sender, EventArgs e) {
            // Data passenger
            txtFname.Text = passengerData.passengerFname;
            txtLname.Text = passengerData.passengerLname;

            // Timer Now
            timerTimeNow.Start();
            dateNow1 = DateTime.Now.ToString("MM/dd/yyyy");
            timeNow1 = DateTime.Now.ToString("HH:mm:ss");
        }

        private void timerTimeNow_Tick(object sender, EventArgs e) {
            timeNow1 = DateTime.Now.ToString("HH:mm:ss");
            timerTimeNow.Start();
        }
    }
}
