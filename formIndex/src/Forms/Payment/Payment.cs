using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formIndex {
    public partial class Payment : Form {
        public Payment() {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e) {
            var form = new ContinueBooking();
            form.Show();
            this.Hide();
        }
    }
}
