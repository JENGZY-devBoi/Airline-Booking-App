
namespace formIndex
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassward = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(343, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(451, 390);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.White;
            this.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmail.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEmail.Location = new System.Drawing.Point(343, 378);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(435, 41);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email*";
            // 
            // lblPassward
            // 
            this.lblPassward.BackColor = System.Drawing.Color.White;
            this.lblPassward.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPassward.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassward.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPassward.Location = new System.Drawing.Point(343, 436);
            this.lblPassward.Name = "lblPassward";
            this.lblPassward.Size = new System.Drawing.Size(435, 41);
            this.lblPassward.TabIndex = 2;
            this.lblPassward.Text = "Passward*";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.PaleVioletRed;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(343, 501);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(435, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "Login";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(1117, 696);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPassward);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassward;
        private System.Windows.Forms.Label label2;
    }
}