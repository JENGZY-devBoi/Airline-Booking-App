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
    public partial class Home : Form {
        private List<string> lsFlightTo = new List<string>();
        private List<string> lsDateDepart = new List<string>();
        private List<DateTime> lsDateDepartDT = new List<DateTime>();
        private List<string> lsFlightID = new List<string>();

        public Home() {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e) {
            //
            if (loginData.login) {
                lblSignIn.Text = "< BACK";
            } else {
                lblSignIn.Text = "SIGN IN";
            }
        }

        private void comboSelectOrigin_SelectedIndexChanged(object sender, EventArgs e) {
            fetchTo();
        }

        private bool fetchTo() {
            // CLEAR
            lsFlightTo.Clear();
            comboTo.Items.Clear();
            comboDepart.Items.Clear();

            // DB connnection
            dbConfig.connection.Open();

            var flightAdapter = new SqlDataAdapter();
            var flightTable = new DataTable();
            string sql;

            // Bad practice: because query alway when you select change!!
            sql = "SELECT * FROM flights";
            flightAdapter.SelectCommand = new SqlCommand(sql, dbConfig.connection);
            flightAdapter.Fill(flightTable);

            sql = $"flightExitStation='{comboSelectOrigin.SelectedItem.ToString()}'";
            try {
                DataRow[] flightDR = flightTable.Select(sql);
                var ls = new List<string>();

                foreach (var itm in flightDR) {
                    //Console.WriteLine(itm["flightEntryStation"]);
                    //Console.WriteLine(itm["flightExitTime"]);
                    string flightTo = itm["flightEntryStation"].ToString();

                    // UNIQUE DATA
                    if (!lsFlightTo.Contains(flightTo)) lsFlightTo.Add(flightTo);
                }

                comboTo.Items.AddRange(lsFlightTo.ToArray());
                //comboDepart.Items.AddRange(lsFlightDepart.ToArray());

                comboTo.Enabled = true;

                dbConfig.connection.Close();
                return true;
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                dbConfig.connection.Close();
                comboTo.Enabled = false;
                return false;
            }
        }

        private void comboTo_SelectedIndexChanged(object sender, EventArgs e) {
            fetchDepart();
        }

        private bool fetchDepart() {
            // CLEAR
            lsDateDepart.Clear();
            lsDateDepartDT.Clear();
            comboDepart.Items.Clear();

            // DB connnection
            dbConfig.connection.Open();

            var flightAdapter = new SqlDataAdapter();
            var flightTable = new DataTable();
            string sql;

            // Bad practice: because query alway when you select change!!
            sql = "SELECT * FROM flights";
            flightAdapter.SelectCommand = new SqlCommand(sql, dbConfig.connection);
            flightAdapter.Fill(flightTable);

            sql =
                $"flightExitStation='{comboSelectOrigin.SelectedItem.ToString()}' " +
                $"AND flightEntryStation='{comboTo.SelectedItem.ToString()}'";

            try {
                DataRow[] departDR = flightTable.Select(sql);
                foreach (var itm in departDR) {
                    //Console.WriteLine(itm["flightExitDate"].ToString().Split(' ')[0]);
                    string date = itm["flightExitDate"].ToString().Split(' ')[0];

                    // Unique data
                    if (!lsDateDepart.Contains(date)) lsDateDepart.Add(date);
                }

                lsDateDepart.Sort();
                comboDepart.Items.AddRange(lsDateDepart.ToArray());

                dbConfig.connection.Close();
                comboDepart.Enabled = true;
                return true;
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                dbConfig.connection.Close();
                comboDepart.Enabled = false;
                return false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            if (validFill()) {
                flightData.flightSelFrom = comboSelectOrigin.SelectedItem.ToString();
                flightData.flightSelTo = comboTo.SelectedItem.ToString();
                flightData.flightSelDep = comboDepart.SelectedItem.ToString();

                Console.WriteLine(flightData.flightSelFrom);
                Console.WriteLine(flightData.flightSelTo);
                Console.WriteLine(flightData.flightSelDep);


                // GO TO NEW FORM
                var formChooseFlight = new ChooseFlight();
                formChooseFlight.Show();
                this.Hide();
            }
        }

        private bool validFill() {
            // Valid fill complete info
            if (comboSelectOrigin.SelectedItem == null ||
                comboTo.SelectedItem == null ||
                comboDepart.SelectedItem == null) {
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


        private void lblSignIn_Click(object sender, EventArgs e) {
            if (lblSignIn.Text == "SIGN IN") {
                var form = new SignIn();
                form.Show();
                this.Hide();
            } else {
                var form = new LoginBoard();
                form.Show();
                this.Hide();
            }
        }
    }
}
