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
    public partial class InformationCustomer : Form
    {
        public InformationCustomer()
        {
            InitializeComponent();
        }

        private void InformationCustomer_Load(object sender, EventArgs e)
        {
            init();
        }

        private void btnBack_Click(object sender, EventArgs e) {
            // GO TO PREVIOUS FORM
            var form = new SeatsSelect();
            form.Show();
            this.Hide();
        }

        private void btnConfirm_Click(object sender, EventArgs e) {
            if (validFill()) submit();
        }

        private bool validFill() {
            // Valid fill complete info
            if (comboTitle.SelectedItem == null ||
                textFname.Text == "" ||
                textLname.Text == "" ||
                textEmail.Text == "" ||
                comboEmail.Text == "") {
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

        private void submit() {
            //Console.WriteLine(dateTimeDOB.Value.ToString().Split(' ')[0]);
            passengerData.passengerTitle = comboTitle.SelectedItem.ToString();
            passengerData.passengerFname = textFname.Text;
            passengerData.passengerLname = textLname.Text;
            passengerData.passengerDOB = dateTimeDOB.Value.ToString().Split(' ')[0];
            passengerData.passengerEmail = textEmail.Text + "@" + comboEmail.SelectedItem.ToString();


            var form = new ContinueBooking();
            form.Show();
            this.Hide();
        }

        private void init() {
            // Set the Format type and the CustomFormat string.
            dateTimeDOB.Format = DateTimePickerFormat.Custom;
            dateTimeDOB.CustomFormat = "MM - dd - yyyy";

            // Set passenger data (when back)
            textFname.Text = passengerData.passengerFname;
            textLname.Text = passengerData.passengerLname;
            if (passengerData.passengerEmail != null) {
                comboTitle.Text = passengerData.passengerTitle;
                textEmail.Text = passengerData.passengerEmail.Split('@')[0];
                comboEmail.Text = passengerData.passengerEmail.Split('@')[1];
                dateTimeDOB.Value = new DateTime
                    (
                        Convert.ToInt32(passengerData.passengerDOB.Split('/')[2]), // Year
                        Convert.ToInt32(passengerData.passengerDOB.Split('/')[0]), // Month
                        Convert.ToInt32(passengerData.passengerDOB.Split('/')[1]) // Day
                    );
            }

            // Sign in code
            if (loginData.login) {
                comboTitle.Text = memberData.mem_title;
                textFname.Text = memberData.mem_fname;
                textLname.Text = memberData.mem_lname;
                textEmail.Text = memberData.mem_email.Split('@')[0];
                comboEmail.Text = memberData.mem_email.Split('@')[1];
                dateTimeDOB.Value = new DateTime
                    (
                        Convert.ToInt32(memberData.mem_DOB.Split('/')[2]), // Year
                        Convert.ToInt32(memberData.mem_DOB.Split('/')[0]), // Month
                        Convert.ToInt32(memberData.mem_DOB.Split('/')[1]) // Day
                    );
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e) {
            textEmail.Text = textFname.Text = textLname.Text = "";
            dateTimeDOB.Value = DateTime.Now;
            passengerData.passengerDOB = null;
            passengerData.passengerEmail = null;
            passengerData.passengerFname = null;
            passengerData.passengerLname = null;
            passengerData.passengerTitle = null;
        }
    }
}
