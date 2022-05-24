using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formIndex
{
    public partial class ContinueBooking : Form
    {
        public ContinueBooking()
        {
            InitializeComponent();
        }


        private void btnBack_Click(object sender, EventArgs e) {
            var form = new InformationCustomer();
            form.Show();
            this.Hide();
        }

        private void btnConfirm_Click(object sender, EventArgs e) {
            var form = new Payment();
            form.Show();
            this.Hide();
        }

        private void ContinueBooking_Load(object sender, EventArgs e) {
            init();
        }

        private void init() {
            // Show Flight Info
            // Depart
            lblDepartStation.Text = flightData.flightFrom;
            lblDepartDate.Text = flightData.flightDateTime;
            lblDepartTime.Text = flightData.flightDepart;
            // Arrival
            lblArrivalStation.Text = flightData.flightTo;
            lblArrivalDate.Text = flightData.flightDateTime;
            lblArrivalTime.Text = flightData.flightArrival;
            // Flight
            lblFlightID.Text = flightData.flightID;
            lblAirline.Text = flightData.flightAirline;
            lblFlightDur.Text = flightData.flightInfo;
            lblFlightPrice.Text = flightData.flightPrice.ToString("#,#.00");

            // Show Seat Info
            lblSeatID.Text = seatData.seatID;
            lblSeatAmount.Text = "1"; // improve in the future
            lblSeatPrice.Text = seatData.seatPrice.ToString("#,#.00");

            // Show Passenger Info
            lblTitle.Text = passengerData.passengerTitle;
            lblFname.Text = passengerData.passengerFname;
            lblLname.Text = passengerData.passengerLname;
            lblDOB.Text = passengerData.passengerDOB;
            lblEmail.Text = passengerData.passengerEmail;

            // Show Booking Info
            lblFlightPriceBInfo.Text = flightData.flightPrice.ToString("#,#.00");
            lblSeatPriceBInfo.Text = seatData.seatPrice.ToString("#,#.00");
            lblTotal.Text = (flightData.flightPrice + seatData.seatPrice).ToString("#,#.00");
        }
    }
}
