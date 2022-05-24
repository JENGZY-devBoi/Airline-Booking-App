
namespace formIndex {
    partial class Payment {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Label();
            this.btnSuccess = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtMas = new System.Windows.Forms.TextBox();
            this.txtExpir = new System.Windows.Forms.TextBox();
            this.txtCVC = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblSeatPriceBInfo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFlightPriceBInfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timerTimeNow = new System.Windows.Forms.Timer(this.components);
            this.panel8.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkViolet;
            this.label5.Location = new System.Drawing.Point(27, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 43);
            this.label5.TabIndex = 23;
            this.label5.Text = "AIR KEY";
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
            // btnSuccess
            // 
            this.btnSuccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSuccess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuccess.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuccess.Location = new System.Drawing.Point(313, 385);
            this.btnSuccess.Name = "btnSuccess";
            this.btnSuccess.Size = new System.Drawing.Size(163, 46);
            this.btnSuccess.TabIndex = 0;
            this.btnSuccess.Text = "Check out";
            this.btnSuccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSuccess.Click += new System.EventHandler(this.btnSuccess_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel8.Controls.Add(this.btnBack);
            this.panel8.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.ForeColor = System.Drawing.Color.Black;
            this.panel8.Location = new System.Drawing.Point(27, 83);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1273, 68);
            this.panel8.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(27, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1273, 522);
            this.panel2.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnSuccess);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtLname);
            this.panel1.Controls.Add(this.txtFname);
            this.panel1.Controls.Add(this.txtMas);
            this.panel1.Controls.Add(this.txtExpir);
            this.panel1.Controls.Add(this.txtCVC);
            this.panel1.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(621, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 460);
            this.panel1.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(59, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 28);
            this.label11.TabIndex = 26;
            this.label11.Text = "Expiration date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(144, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 28);
            this.label12.TabIndex = 26;
            this.label12.Text = "CVC";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label14.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(555, 36);
            this.label14.TabIndex = 2;
            this.label14.Text = "Payment Method";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(93, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 31);
            this.label10.TabIndex = 2;
            this.label10.Text = "Last name";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(93, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 31);
            this.label8.TabIndex = 2;
            this.label8.Text = "First name";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 31);
            this.label9.TabIndex = 2;
            this.label9.Text = "Debit/Master card";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLname
            // 
            this.txtLname.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLname.Location = new System.Drawing.Point(198, 325);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(278, 35);
            this.txtLname.TabIndex = 25;
            // 
            // txtFname
            // 
            this.txtFname.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.Location = new System.Drawing.Point(198, 267);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(278, 35);
            this.txtFname.TabIndex = 25;
            // 
            // txtMas
            // 
            this.txtMas.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMas.Location = new System.Drawing.Point(198, 93);
            this.txtMas.Name = "txtMas";
            this.txtMas.Size = new System.Drawing.Size(278, 35);
            this.txtMas.TabIndex = 25;
            this.txtMas.Text = "1234567890123";
            // 
            // txtExpir
            // 
            this.txtExpir.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpir.Location = new System.Drawing.Point(198, 209);
            this.txtExpir.MaxLength = 3;
            this.txtExpir.Name = "txtExpir";
            this.txtExpir.Size = new System.Drawing.Size(64, 35);
            this.txtExpir.TabIndex = 28;
            this.txtExpir.Text = "5/23";
            // 
            // txtCVC
            // 
            this.txtCVC.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCVC.Location = new System.Drawing.Point(198, 151);
            this.txtCVC.MaxLength = 3;
            this.txtCVC.Name = "txtCVC";
            this.txtCVC.Size = new System.Drawing.Size(64, 35);
            this.txtCVC.TabIndex = 28;
            this.txtCVC.Text = "010";
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(132, 265);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(426, 221);
            this.panel4.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(317, 36);
            this.label6.TabIndex = 2;
            this.label6.Text = "Select Method";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 22);
            this.label2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Debit/Master card";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(426, 36);
            this.label7.TabIndex = 2;
            this.label7.Text = "Payment Method";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.label21);
            this.panel9.Controls.Add(this.lblTotal);
            this.panel9.Controls.Add(this.label20);
            this.panel9.Controls.Add(this.lblSeatPriceBInfo);
            this.panel9.Controls.Add(this.label4);
            this.panel9.Controls.Add(this.lblFlightPriceBInfo);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel9.ForeColor = System.Drawing.Color.Black;
            this.panel9.Location = new System.Drawing.Point(132, 26);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(426, 221);
            this.panel9.TabIndex = 7;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label21.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(0, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(426, 36);
            this.label21.TabIndex = 2;
            this.label21.Text = "Booking Info";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(274, 160);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(110, 31);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "1000.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(48, 160);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(124, 31);
            this.label20.TabIndex = 2;
            this.label20.Text = "Total(THB)";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSeatPriceBInfo
            // 
            this.lblSeatPriceBInfo.BackColor = System.Drawing.Color.White;
            this.lblSeatPriceBInfo.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeatPriceBInfo.ForeColor = System.Drawing.Color.Silver;
            this.lblSeatPriceBInfo.Location = new System.Drawing.Point(275, 105);
            this.lblSeatPriceBInfo.Name = "lblSeatPriceBInfo";
            this.lblSeatPriceBInfo.Size = new System.Drawing.Size(109, 31);
            this.lblSeatPriceBInfo.TabIndex = 2;
            this.lblSeatPriceBInfo.Text = "1000.00";
            this.lblSeatPriceBInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(48, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "Seat price";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFlightPriceBInfo
            // 
            this.lblFlightPriceBInfo.BackColor = System.Drawing.Color.White;
            this.lblFlightPriceBInfo.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightPriceBInfo.ForeColor = System.Drawing.Color.Silver;
            this.lblFlightPriceBInfo.Location = new System.Drawing.Point(275, 74);
            this.lblFlightPriceBInfo.Name = "lblFlightPriceBInfo";
            this.lblFlightPriceBInfo.Size = new System.Drawing.Size(109, 31);
            this.lblFlightPriceBInfo.TabIndex = 2;
            this.lblFlightPriceBInfo.Text = "1000.00";
            this.lblFlightPriceBInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(48, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Flight price";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerTimeNow
            // 
            this.timerTimeNow.Enabled = true;
            this.timerTimeNow.Tick += new System.EventHandler(this.timerTimeNow_Tick);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(1327, 697);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.panel8.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label btnBack;
        private System.Windows.Forms.Label btnSuccess;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblSeatPriceBInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFlightPriceBInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtMas;
        private System.Windows.Forms.TextBox txtExpir;
        private System.Windows.Forms.TextBox txtCVC;
        private System.Windows.Forms.Timer timerTimeNow;
    }
}