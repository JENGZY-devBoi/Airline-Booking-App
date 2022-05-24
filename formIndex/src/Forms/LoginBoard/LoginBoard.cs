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
    public partial class LoginBoard : Form {
        public LoginBoard() {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e) {
            loginData.login = false;

            var form = new Home();
            form.Show();
            this.Hide();
        }

        private void LoginBoard_Load(object sender, EventArgs e) {
            init();
            fetchData();
        }

        private void fetchData() {
            ///
        }

        private void init() {
            lblEmail.Text = memberData.mem_email;
            lblName.Text = memberData.mem_fname + " " + memberData.mem_lname;
        }

        private void btnSearchFlight_Click(object sender, EventArgs e) {
            var form = new Home();
            form.Show();
            this.Hide();
        }

        private void btnAccountDetail_Click(object sender, EventArgs e) {
            var form = new AccountDetail();
            form.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e) {
            var form = new ManageBooking();
            form.Show();
            this.Hide();
        }
    }
}
