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

namespace formIndex
{
    public partial class SeatsSelect : Form {
        #region Fields
        private List<Label> lsSeat = new List<Label>();
        private List<string> lsSeatID = new List<string>();
        private List<double> lsSeatPrice = new List<double>();
        private bool[] btnClicked;
        private string id;
        private double price;
        #endregion

        public SeatsSelect() {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e) {
            var chooseFlight = new ChooseFlight();
            chooseFlight.Show();
            this.Hide();
        }

        private void SeatsSelect_Load(object sender, EventArgs e) {
            init();
            fetchData();
        }

        private void init() {
            // Set array seat
            Label[] arrSeat = {
                seatA1,seatA2,seatA3,seatA4,seatA5,seatA6,seatA7,seatA8,seatA9,seatA10,
                seatB1,seatB2,seatB3,seatB4,seatB5,seatB6,seatB7,seatB8,seatB9,seatB10,
                seatC1,seatC2,seatC3,seatC4,seatC5,seatC6,seatC7,seatC8,seatC9,seatC10,
                seatD1,seatD2,seatD3,seatD4,seatD5,seatD6,seatD7,seatD8,seatD9,seatD10
            };
            lsSeat.AddRange(arrSeat);

            // Set array to btnCliked
            btnClicked = new bool[40];
            for (int i = 0; i < 40; i++) btnClicked[i] = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e) {
            bool unselected = true;
            for (int i = 0; i < btnClicked.Length; i++) {
                if (btnClicked[i] == true) {
                    unselected = false;
                    break;
                }
            }


            if (unselected) {
                MessageBox.Show
                (
                       "Please select seat!",
                       "Warning",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning
                );
                return;
            }
            seatData.seatID = id;
            seatData.seatPrice = price;

            //GO TO form booking detail
            var custInfo = new InformationCustomer();
            custInfo.Show();
            this.Hide();
        }

        private bool fetchData() {
            dbConfig.connection.Open();
            var seatAdapter = new SqlDataAdapter();
            var seatTable = new DataTable();
            string sql;

            sql = $"SELECT * from seats " +
                $"WHERE flightID='{flightData.flightID}'";

            seatAdapter.SelectCommand = new SqlCommand(sql, dbConfig.connection);
            seatAdapter.Fill(seatTable);

            sql =
                $"flightID='{flightData.flightID}'";
            try {
                DataRow[] seatDR = seatTable.Select(sql);

                int idx = 0;
                foreach (var itm in seatDR) {
                    if (itm["seatStatus"].ToString() == "reserve") {
                        bookedSeatColor(lsSeat[idx]);
                        lsSeat[idx].Enabled = false;
                    }
                    lsSeatID.Add(itm["seatID"].ToString());
                    lsSeatPrice.Add(Convert.ToDouble(itm["seatPrice"].ToString()));

                    idx++;
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                dbConfig.connection.Close();
                return false;
            }

            dbConfig.connection.Close();
            return true;
        }

        private void selectedClick(Label lbl, bool click, int idx) {
            if (click) {
                defaultAllSeat(idx);
                selectedColor(lbl);
            } else {
                unselectedColor(lbl);
            }
        }

        private void defaultAllSeat(int idx) {
            for (var i = 0; i < lsSeat.Count; i++) {
                if (lsSeat[i].BackColor == Color.LightGreen) {
                    lsSeat[i].BackColor = Color.FromArgb(192, 192, 255);
                    break;
                }
            }
        }

        private bool checkClicked(bool click) {
            if (click) return false;
            return true;
        }

        private int convertIdxSeat(string str) {
            int idx = Convert.ToInt32(str.Split(' ')[1]) - 1;

            // Keep value to calc in next form
            id = lsSeatID[idx];
            price = lsSeatPrice[idx];

            return idx;
        }

        private void selectedColor(Label lbl) {
            lbl.BackColor = Color.LightGreen;
        }

        private void unselectedColor(Label lbl) {
            lbl.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void bookedSeatColor(Label lbl) {
            lbl.BackColor = Color.FromArgb(255, 192, 192);
        }

        private void detectCliked(Label lbl) {
            int idx = convertIdxSeat(lbl.Tag.ToString());

            btnClicked[idx] = checkClicked(btnClicked[idx]);
            selectedClick(lbl, btnClicked[idx], idx);
        }

        private void seatA1_Click(object sender, EventArgs e) {
            detectCliked(seatA1);
        }

        private void seatA2_Click(object sender, EventArgs e) {
            detectCliked(seatA2);
        }

        private void seatA3_Click(object sender, EventArgs e) {
            detectCliked(seatA3);
        }

        private void seatA4_Click(object sender, EventArgs e) {
            detectCliked(seatA4);
        }

        private void seatA5_Click(object sender, EventArgs e) {
            detectCliked(seatA5);
        }

        private void seatA6_Click(object sender, EventArgs e) {
            detectCliked(seatA6);
        }

        private void seatA7_Click(object sender, EventArgs e) {
            detectCliked(seatA7);
        }

        private void seatA8_Click(object sender, EventArgs e) {
            detectCliked(seatA8);
        }

        private void seatA9_Click(object sender, EventArgs e) {
            detectCliked(seatA9);
        }

        private void seatA10_Click(object sender, EventArgs e) {
            detectCliked(seatA10);
        }

        private void seatB1_Click(object sender, EventArgs e) {
            detectCliked(seatB1);
        }

        private void seatB2_Click(object sender, EventArgs e) {
            detectCliked(seatB2);

        }

        private void seatB3_Click(object sender, EventArgs e) {
            detectCliked(seatB3);

        }

        private void seatB4_Click(object sender, EventArgs e) {
            detectCliked(seatB4);
        }

        private void seatB5_Click(object sender, EventArgs e) {
            detectCliked(seatB5);
        }

        private void seatB6_Click(object sender, EventArgs e) {
            detectCliked(seatB6);
        }

        private void seatB7_Click(object sender, EventArgs e) {
            detectCliked(seatB7);
        }

        private void seatB8_Click(object sender, EventArgs e) {
            detectCliked(seatB8);
        }

        private void seatB9_Click(object sender, EventArgs e) {
            detectCliked(seatB9);
        }

        private void seatB10_Click(object sender, EventArgs e) {
            detectCliked(seatB10);
        }

        private void seatC1_Click(object sender, EventArgs e) {
            detectCliked(seatC1);
        }

        private void seatC2_Click(object sender, EventArgs e) {
            detectCliked(seatC2);
        }

        private void seatC3_Click(object sender, EventArgs e) {
            detectCliked(seatC3);
        }

        private void seatC4_Click(object sender, EventArgs e) {
            detectCliked(seatC4);
        }

        private void seatC5_Click(object sender, EventArgs e) {
            detectCliked(seatC5);
        }

        private void seatC6_Click(object sender, EventArgs e) {
            detectCliked(seatC6);
        }

        private void seatC7_Click(object sender, EventArgs e) {
            detectCliked(seatC7);
        }

        private void seatC8_Click(object sender, EventArgs e) {
            detectCliked(seatC8);
        }

        private void seatC9_Click(object sender, EventArgs e) {
            detectCliked(seatC9);
        }

        private void seatC10_Click(object sender, EventArgs e) {
            detectCliked(seatC10);
        }

        private void seatD1_Click(object sender, EventArgs e) {
            detectCliked(seatD1);
        }

        private void seatD2_Click(object sender, EventArgs e) {
            detectCliked(seatD2);
        }

        private void seatD3_Click(object sender, EventArgs e) {
            detectCliked(seatD3);
        }

        private void seatD4_Click(object sender, EventArgs e) {
            detectCliked(seatD4);
        }

        private void seatD5_Click(object sender, EventArgs e) {
            detectCliked(seatD5);
        }

        private void seatD6_Click(object sender, EventArgs e) {
            detectCliked(seatD6);
        }

        private void seatD7_Click(object sender, EventArgs e) {
            detectCliked(seatD7);
        }

        private void seatD8_Click(object sender, EventArgs e) {
            detectCliked(seatD8);
        }

        private void seatD9_Click(object sender, EventArgs e) {
            detectCliked(seatD9);
        }

        private void seatD10_Click(object sender, EventArgs e) {
            detectCliked(seatD10);
        }
    }
}
