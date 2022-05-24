
namespace formIndex
{
    partial class InformationCustomer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationCustomer));
            this.label5 = new System.Windows.Forms.Label();
            this.timerTimeNow = new System.Windows.Forms.Timer(this.components);
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Label();
            this.panelFlight1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Label();
            this.dateTimeDOB = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textLname = new System.Windows.Forms.TextBox();
            this.textFname = new System.Windows.Forms.TextBox();
            this.comboEmail = new System.Windows.Forms.ComboBox();
            this.comboTitle = new System.Windows.Forms.ComboBox();
            this.panel8.SuspendLayout();
            this.panelFlight1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkViolet;
            this.label5.Location = new System.Drawing.Point(25, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 43);
            this.label5.TabIndex = 15;
            this.label5.Text = "AIR KEY";
            // 
            // timerTimeNow
            // 
            this.timerTimeNow.Enabled = true;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel8.Controls.Add(this.btnConfirm);
            this.panel8.Controls.Add(this.btnBack);
            this.panel8.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.ForeColor = System.Drawing.Color.Black;
            this.panel8.Location = new System.Drawing.Point(23, 79);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1039, 68);
            this.panel8.TabIndex = 20;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(864, 11);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(163, 46);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(146, 68);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "< BACK";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelFlight1
            // 
            this.panelFlight1.AutoScroll = true;
            this.panelFlight1.BackColor = System.Drawing.Color.White;
            this.panelFlight1.Controls.Add(this.btnClear);
            this.panelFlight1.Controls.Add(this.dateTimeDOB);
            this.panelFlight1.Controls.Add(this.label13);
            this.panelFlight1.Controls.Add(this.label14);
            this.panelFlight1.Controls.Add(this.label16);
            this.panelFlight1.Controls.Add(this.label12);
            this.panelFlight1.Controls.Add(this.label6);
            this.panelFlight1.Controls.Add(this.label2);
            this.panelFlight1.Controls.Add(this.textEmail);
            this.panelFlight1.Controls.Add(this.textLname);
            this.panelFlight1.Controls.Add(this.textFname);
            this.panelFlight1.Controls.Add(this.comboEmail);
            this.panelFlight1.Controls.Add(this.comboTitle);
            this.panelFlight1.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFlight1.Location = new System.Drawing.Point(23, 146);
            this.panelFlight1.Name = "panelFlight1";
            this.panelFlight1.Size = new System.Drawing.Size(1039, 493);
            this.panelFlight1.TabIndex = 21;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkGray;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(949, 21);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(78, 45);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dateTimeDOB
            // 
            this.dateTimeDOB.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDOB.Location = new System.Drawing.Point(374, 274);
            this.dateTimeDOB.Name = "dateTimeDOB";
            this.dateTimeDOB.Size = new System.Drawing.Size(181, 35);
            this.dateTimeDOB.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(258, 281);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 28);
            this.label13.TabIndex = 2;
            this.label13.Text = "Date of birth";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(563, 344);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 28);
            this.label14.TabIndex = 2;
            this.label14.Text = "@";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(313, 344);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 28);
            this.label16.TabIndex = 2;
            this.label16.Text = "Email";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(273, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 28);
            this.label12.TabIndex = 2;
            this.label12.Text = "Last name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(273, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 28);
            this.label6.TabIndex = 2;
            this.label6.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title name";
            // 
            // textEmail
            // 
            this.textEmail.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.Location = new System.Drawing.Point(374, 337);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(181, 35);
            this.textEmail.TabIndex = 4;
            // 
            // textLname
            // 
            this.textLname.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLname.Location = new System.Drawing.Point(375, 211);
            this.textLname.Name = "textLname";
            this.textLname.Size = new System.Drawing.Size(374, 35);
            this.textLname.TabIndex = 2;
            // 
            // textFname
            // 
            this.textFname.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFname.Location = new System.Drawing.Point(375, 148);
            this.textFname.Name = "textFname";
            this.textFname.Size = new System.Drawing.Size(374, 35);
            this.textFname.TabIndex = 1;
            // 
            // comboEmail
            // 
            this.comboEmail.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEmail.FormattingEnabled = true;
            this.comboEmail.Items.AddRange(new object[] {
            "gmail.com",
            "hotmail.com",
            "outlook.com",
            "mail.com"});
            this.comboEmail.Location = new System.Drawing.Point(599, 337);
            this.comboEmail.Name = "comboEmail";
            this.comboEmail.Size = new System.Drawing.Size(149, 36);
            this.comboEmail.TabIndex = 5;
            // 
            // comboTitle
            // 
            this.comboTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTitle.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTitle.FormattingEnabled = true;
            this.comboTitle.Items.AddRange(new object[] {
            "Mr",
            "Mrs",
            "Ms"});
            this.comboTitle.Location = new System.Drawing.Point(374, 84);
            this.comboTitle.Name = "comboTitle";
            this.comboTitle.Size = new System.Drawing.Size(96, 36);
            this.comboTitle.TabIndex = 0;
            // 
            // InformationCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(1085, 676);
            this.Controls.Add(this.panelFlight1);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InformationCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information Customer";
            this.Load += new System.EventHandler(this.InformationCustomer_Load);
            this.panel8.ResumeLayout(false);
            this.panelFlight1.ResumeLayout(false);
            this.panelFlight1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timerTimeNow;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label btnConfirm;
        private System.Windows.Forms.Label btnBack;
        private System.Windows.Forms.Panel panelFlight1;
        private System.Windows.Forms.Label btnClear;
        private System.Windows.Forms.DateTimePicker dateTimeDOB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textLname;
        private System.Windows.Forms.TextBox textFname;
        private System.Windows.Forms.ComboBox comboEmail;
        private System.Windows.Forms.ComboBox comboTitle;
    }
}