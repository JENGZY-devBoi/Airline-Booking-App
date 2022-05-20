
namespace formIndex
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panelHome = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSelectPass = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpBooking = new System.Windows.Forms.DateTimePicker();
            this.comboPassengers = new System.Windows.Forms.ComboBox();
            this.comboSelectDes = new System.Windows.Forms.ComboBox();
            this.comboSelectOrigin = new System.Windows.Forms.ComboBox();
            this.lblBookingFlight = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.lblTravelInfo = new System.Windows.Forms.Label();
            this.lblManageBooking = new System.Windows.Forms.Label();
            this.lblBooking = new System.Windows.Forms.Label();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.DarkViolet;
            this.panelHome.Controls.Add(this.pictureBox1);
            this.panelHome.Controls.Add(this.lblSelectPass);
            this.panelHome.Controls.Add(this.lblTo);
            this.panelHome.Controls.Add(this.lblFrom);
            this.panelHome.Controls.Add(this.dtpBooking);
            this.panelHome.Controls.Add(this.comboPassengers);
            this.panelHome.Controls.Add(this.comboSelectDes);
            this.panelHome.Controls.Add(this.comboSelectOrigin);
            this.panelHome.Location = new System.Drawing.Point(50, 253);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(997, 353);
            this.panelHome.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(718, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 278);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // lblSelectPass
            // 
            this.lblSelectPass.AutoSize = true;
            this.lblSelectPass.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectPass.ForeColor = System.Drawing.Color.White;
            this.lblSelectPass.Location = new System.Drawing.Point(761, 42);
            this.lblSelectPass.Name = "lblSelectPass";
            this.lblSelectPass.Size = new System.Drawing.Size(195, 31);
            this.lblSelectPass.TabIndex = 9;
            this.lblSelectPass.Text = "Select passengers";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.ForeColor = System.Drawing.Color.White;
            this.lblTo.Location = new System.Drawing.Point(260, 35);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(38, 31);
            this.lblTo.TabIndex = 8;
            this.lblTo.Text = "To";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.Color.White;
            this.lblFrom.Location = new System.Drawing.Point(47, 35);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(65, 31);
            this.lblFrom.TabIndex = 7;
            this.lblFrom.Text = "From";
            // 
            // dtpBooking
            // 
            this.dtpBooking.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtpBooking.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBooking.Location = new System.Drawing.Point(508, 69);
            this.dtpBooking.Name = "dtpBooking";
            this.dtpBooking.Size = new System.Drawing.Size(223, 40);
            this.dtpBooking.TabIndex = 5;
            // 
            // comboPassengers
            // 
            this.comboPassengers.Font = new System.Drawing.Font("Poppins", 10F);
            this.comboPassengers.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.comboPassengers.FormattingEnabled = true;
            this.comboPassengers.Location = new System.Drawing.Point(765, 67);
            this.comboPassengers.Name = "comboPassengers";
            this.comboPassengers.Size = new System.Drawing.Size(185, 44);
            this.comboPassengers.TabIndex = 4;
            this.comboPassengers.Text = "1 adult";
            // 
            // comboSelectDes
            // 
            this.comboSelectDes.Font = new System.Drawing.Font("Poppins", 10F);
            this.comboSelectDes.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.comboSelectDes.FormattingEnabled = true;
            this.comboSelectDes.Location = new System.Drawing.Point(264, 67);
            this.comboSelectDes.Name = "comboSelectDes";
            this.comboSelectDes.Size = new System.Drawing.Size(214, 44);
            this.comboSelectDes.TabIndex = 2;
            this.comboSelectDes.Text = "Select Destination";
            // 
            // comboSelectOrigin
            // 
            this.comboSelectOrigin.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSelectOrigin.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.comboSelectOrigin.FormattingEnabled = true;
            this.comboSelectOrigin.Location = new System.Drawing.Point(53, 69);
            this.comboSelectOrigin.Name = "comboSelectOrigin";
            this.comboSelectOrigin.Size = new System.Drawing.Size(177, 44);
            this.comboSelectOrigin.TabIndex = 1;
            this.comboSelectOrigin.Text = "Select Origin";
            // 
            // lblBookingFlight
            // 
            this.lblBookingFlight.AutoSize = true;
            this.lblBookingFlight.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingFlight.ForeColor = System.Drawing.Color.Black;
            this.lblBookingFlight.Location = new System.Drawing.Point(54, 208);
            this.lblBookingFlight.Name = "lblBookingFlight";
            this.lblBookingFlight.Size = new System.Drawing.Size(196, 42);
            this.lblBookingFlight.TabIndex = 1;
            this.lblBookingFlight.Text = "Booking Flight";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkViolet;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(51, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 66);
            this.label5.TabIndex = 13;
            this.label5.Text = "AIR KEY";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.lblSignUp);
            this.panel1.Controls.Add(this.lblSignIn);
            this.panel1.Controls.Add(this.lblTravelInfo);
            this.panel1.Controls.Add(this.lblManageBooking);
            this.panel1.Controls.Add(this.lblBooking);
            this.panel1.Location = new System.Drawing.Point(0, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 189);
            this.panel1.TabIndex = 14;
            // 
            // lblSignUp
            // 
            this.lblSignUp.BackColor = System.Drawing.Color.DarkGray;
            this.lblSignUp.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.Location = new System.Drawing.Point(953, 52);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(125, 63);
            this.lblSignUp.TabIndex = 30;
            this.lblSignUp.Text = "SIGN UP";
            this.lblSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSignIn
            // 
            this.lblSignIn.BackColor = System.Drawing.Color.DarkGray;
            this.lblSignIn.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignIn.Location = new System.Drawing.Point(822, 52);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(125, 63);
            this.lblSignIn.TabIndex = 29;
            this.lblSignIn.Text = "SIGN IN";
            this.lblSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTravelInfo
            // 
            this.lblTravelInfo.BackColor = System.Drawing.Color.Gainsboro;
            this.lblTravelInfo.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTravelInfo.Location = new System.Drawing.Point(638, 80);
            this.lblTravelInfo.Name = "lblTravelInfo";
            this.lblTravelInfo.Size = new System.Drawing.Size(152, 39);
            this.lblTravelInfo.TabIndex = 28;
            this.lblTravelInfo.Text = "Travel Info";
            this.lblTravelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblManageBooking
            // 
            this.lblManageBooking.BackColor = System.Drawing.Color.Gainsboro;
            this.lblManageBooking.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageBooking.Location = new System.Drawing.Point(480, 79);
            this.lblManageBooking.Name = "lblManageBooking";
            this.lblManageBooking.Size = new System.Drawing.Size(152, 39);
            this.lblManageBooking.TabIndex = 27;
            this.lblManageBooking.Text = "Manage Booking";
            this.lblManageBooking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBooking
            // 
            this.lblBooking.BackColor = System.Drawing.Color.Gainsboro;
            this.lblBooking.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooking.Location = new System.Drawing.Point(319, 79);
            this.lblBooking.Name = "lblBooking";
            this.lblBooking.Size = new System.Drawing.Size(152, 36);
            this.lblBooking.TabIndex = 26;
            this.lblBooking.Text = "Booking";
            this.lblBooking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1117, 696);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblBookingFlight);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.DateTimePicker dtpBooking;
        private System.Windows.Forms.ComboBox comboPassengers;
        private System.Windows.Forms.ComboBox comboSelectDes;
        private System.Windows.Forms.ComboBox comboSelectOrigin;
        private System.Windows.Forms.Label lblBookingFlight;
        private System.Windows.Forms.Label lblSelectPass;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTravelInfo;
        private System.Windows.Forms.Label lblManageBooking;
        private System.Windows.Forms.Label lblBooking;
        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}