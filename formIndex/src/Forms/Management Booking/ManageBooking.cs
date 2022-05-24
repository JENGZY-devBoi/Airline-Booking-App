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
    public partial class ManageBooking : Form
    {
        public ManageBooking()
        {
            InitializeComponent();
        }

        private void btnBACK_Click(object sender, EventArgs e) {
            var form = new LoginBoard();
            form.Show();
            this.Hide();
        }

        private void ManageBooking_Load(object sender, EventArgs e) {
            lblEmail.Text = memberData.mem_email;
            lblName.Text = memberData.mem_fname + " " + memberData.mem_lname;
        }

        private void btnPostpone_Click(object sender, EventArgs e) {
            var form = new Postpone();
            form.Show();
            this.Hide();
        }

        private void btnCancle_Click(object sender, EventArgs e) {
            var form = new Cancle();
            form.Show();
            this.Hide();
        }
    }
}
