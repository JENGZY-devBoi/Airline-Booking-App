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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e) {
            var form = new SignUp();
            form.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            if (validFill()) {
                if (validLogin()) {

                }
            }
        }

        private bool validFill() {
            // Valid fill complete info
            if (txtEmail.Text == "" ||
                txtPwd.Text == "" ) {
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

        private bool validLogin() {
            // DB connection open
            dbConfig.connection.Open();

            // Fields
            var adapter = new SqlDataAdapter();
            var memTB = new DataTable();

            // SQL command
            string sql = "SELECT * FROM members ";
            adapter.SelectCommand = new SqlCommand(sql, dbConfig.connection);
            adapter.Fill(memTB);

            // SELECT FROM DATATABLE
            sql =
                $"memberEmail='{txtEmail.Text}' " +
                $"and memberPassword='{txtPwd.Text}'";

            try {
                DataRow[] dr = memTB.Select(sql);
                // FetchData and Storage
                memberData.mem_id = dr[0]["memberID"].ToString();
                memberData.mem_title = dr[0]["memberTitle"].ToString();
                memberData.mem_fname = dr[0]["memberFname"].ToString();
                memberData.mem_lname = dr[0]["memberLname"].ToString();
                memberData.mem_gender = dr[0]["memberGender"].ToString();
                memberData.mem_DOB = dr[0]["memberDOB"].ToString();
                memberData.mem_houseno = dr[0]["memberHouseNo"].ToString();
                memberData.mem_road = dr[0]["memberPhone"].ToString();
                memberData.mem_email = dr[0]["memberEmail"].ToString();
                memberData.mem_pwd = dr[0]["memberPassword"].ToString();

                addressData.addr_id = dr[0]["addressID"].ToString();

                // Login
                loginData.login = true;

                var form = new LoginBoard();
                form.Show();
                this.Hide();

                } catch (Exception ex) {
                    // Login fail
                    MessageBox.Show
                        (
                            "Username or Password is wrong!",
                            "Login fail",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                    //MessageBox.Show(ex.Message);
                    dbConfig.connection.Close();
                    return false;
                }

            dbConfig.connection.Close();
            return true;
        }

        private void btnBack_Click(object sender, EventArgs e) {
            var form = new Home();
            form.Show();
            this.Hide();
        }
    }
}
