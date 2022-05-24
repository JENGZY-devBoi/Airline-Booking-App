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
    public partial class AccountDetail : Form {
        string mode = "EDIT";

        public AccountDetail() {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e) {
            var form = new LoginBoard();
            form.Show();
            this.Hide();
        }

        private void AccountDetail_Load(object sender, EventArgs e) {
            dateTimeDOB.Format = DateTimePickerFormat.Custom;
            dateTimeDOB.CustomFormat = "MM - dd - yyyy";

            textEmail.Text = memberData.mem_email.Split('@')[0];
            comboEmail.Text = memberData.mem_email.Split('@')[1];
            textFname.Text = memberData.mem_fname;
            textLname.Text = memberData.mem_lname;
            comboGender.Text = memberData.mem_gender;
            comboTitle.Text = memberData.mem_title;
            txtPhone.Text = memberData.mem_phone;
           
            dateTimeDOB.Value = new DateTime
            (
                Convert.ToInt32(memberData.mem_DOB.Split('/')[2]), // Year
                Convert.ToInt32(memberData.mem_DOB.Split('/')[0]), // Month
                Convert.ToInt32(memberData.mem_DOB.Split('/')[1]) // Day
            );
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            if (btnEdit.Text == "EDIT") btnEdit.Text = "CANCLE";
            else btnEdit.Text = "EDIT";

            if (btnEdit.Text == "CANCLE") {
                textEmail.Enabled = true;
                textFname.Enabled = true;
                textLname.Enabled = true;
                comboEmail.Enabled = true;
                comboGender.Enabled = true;
                comboTitle.Enabled = true;
                txtPhone.Enabled = true;
                dateTimeDOB.Enabled = true;

                btnSave.Visible = true;
            } else {
                btnSave.Visible = false;
                textEmail.Enabled = false;
                textFname.Enabled = false;
                textLname.Enabled = false;
                comboEmail.Enabled = false;
                comboGender.Enabled = false;
                comboTitle.Enabled = false;
                txtPhone.Enabled = false;
                dateTimeDOB.Enabled = false;
            }
        }
    }
}
