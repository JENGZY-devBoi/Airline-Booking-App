
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
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.comboTo = new System.Windows.Forms.ComboBox();
            this.comboSelectOrigin = new System.Windows.Forms.ComboBox();
            this.lblBookingFlight = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboDepart = new System.Windows.Forms.ComboBox();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.DarkViolet;
            this.panelHome.Controls.Add(this.btnSearch);
            this.panelHome.Controls.Add(this.pictureBox1);
            this.panelHome.Controls.Add(this.label2);
            this.panelHome.Controls.Add(this.lblTo);
            this.panelHome.Controls.Add(this.lblFrom);
            this.panelHome.Controls.Add(this.comboDepart);
            this.panelHome.Controls.Add(this.comboTo);
            this.panelHome.Controls.Add(this.comboSelectOrigin);
            this.panelHome.Location = new System.Drawing.Point(41, 173);
            this.panelHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(665, 229);
            this.panelHome.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 80);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.ForeColor = System.Drawing.Color.White;
            this.lblTo.Location = new System.Drawing.Point(173, 21);
            this.lblTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(24, 22);
            this.lblTo.TabIndex = 8;
            this.lblTo.Text = "To";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.Color.White;
            this.lblFrom.Location = new System.Drawing.Point(31, 21);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(40, 22);
            this.lblFrom.TabIndex = 7;
            this.lblFrom.Text = "From";
            // 
            // comboTo
            // 
            this.comboTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTo.Font = new System.Drawing.Font("Poppins", 10F);
            this.comboTo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.comboTo.FormattingEnabled = true;
            this.comboTo.Location = new System.Drawing.Point(176, 45);
            this.comboTo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboTo.Name = "comboTo";
            this.comboTo.Size = new System.Drawing.Size(119, 31);
            this.comboTo.TabIndex = 2;
            this.comboTo.SelectedIndexChanged += new System.EventHandler(this.comboTo_SelectedIndexChanged);
            // 
            // comboSelectOrigin
            // 
            this.comboSelectOrigin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSelectOrigin.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSelectOrigin.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.comboSelectOrigin.FormattingEnabled = true;
            this.comboSelectOrigin.Items.AddRange(new object[] {
            "DMK",
            "CNX",
            "HKT",
            "PHS",
            "CEI",
            "HDY",
            "KKC"});
            this.comboSelectOrigin.Location = new System.Drawing.Point(35, 45);
            this.comboSelectOrigin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboSelectOrigin.Name = "comboSelectOrigin";
            this.comboSelectOrigin.Size = new System.Drawing.Size(119, 31);
            this.comboSelectOrigin.TabIndex = 1;
            this.comboSelectOrigin.SelectedIndexChanged += new System.EventHandler(this.comboSelectOrigin_SelectedIndexChanged);
            // 
            // lblBookingFlight
            // 
            this.lblBookingFlight.AutoSize = true;
            this.lblBookingFlight.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingFlight.ForeColor = System.Drawing.Color.Black;
            this.lblBookingFlight.Location = new System.Drawing.Point(44, 144);
            this.lblBookingFlight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookingFlight.Name = "lblBookingFlight";
            this.lblBookingFlight.Size = new System.Drawing.Size(136, 28);
            this.lblBookingFlight.TabIndex = 1;
            this.lblBookingFlight.Text = "Booking Flight";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkViolet;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(34, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 43);
            this.label5.TabIndex = 13;
            this.label5.Text = "AIR KEY";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.lblSignUp);
            this.panel1.Controls.Add(this.lblSignIn);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 121);
            this.panel1.TabIndex = 14;
            // 
            // lblSignUp
            // 
            this.lblSignUp.BackColor = System.Drawing.Color.White;
            this.lblSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSignUp.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.Location = new System.Drawing.Point(635, 34);
            this.lblSignUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(83, 43);
            this.lblSignUp.TabIndex = 30;
            this.lblSignUp.Text = "SIGN UP";
            this.lblSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSignIn
            // 
            this.lblSignIn.BackColor = System.Drawing.Color.DarkViolet;
            this.lblSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSignIn.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignIn.ForeColor = System.Drawing.Color.White;
            this.lblSignIn.Location = new System.Drawing.Point(548, 34);
            this.lblSignIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(83, 43);
            this.lblSignIn.TabIndex = 29;
            this.lblSignIn.Text = "SIGN IN";
            this.lblSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(502, 93);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 28);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "SEARCH >";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(319, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Departure";
            // 
            // comboDepart
            // 
            this.comboDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDepart.Font = new System.Drawing.Font("Poppins", 10F);
            this.comboDepart.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.comboDepart.FormattingEnabled = true;
            this.comboDepart.Location = new System.Drawing.Point(323, 45);
            this.comboDepart.Margin = new System.Windows.Forms.Padding(2);
            this.comboDepart.Name = "comboDepart";
            this.comboDepart.Size = new System.Drawing.Size(296, 31);
            this.comboDepart.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(745, 452);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblBookingFlight);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.ComboBox comboTo;
        private System.Windows.Forms.ComboBox comboSelectOrigin;
        private System.Windows.Forms.Label lblBookingFlight;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboDepart;
    }
}