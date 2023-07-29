namespace Veterinary.PL.Appointment
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labeldays = new System.Windows.Forms.Label();
            this.appoin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labeldays
            // 
            this.labeldays.AutoSize = true;
            this.labeldays.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldays.ForeColor = System.Drawing.Color.Black;
            this.labeldays.Location = new System.Drawing.Point(15, 18);
            this.labeldays.Name = "labeldays";
            this.labeldays.Size = new System.Drawing.Size(41, 30);
            this.labeldays.TabIndex = 0;
            this.labeldays.Text = "00";
            // 
            // appoin
            // 
            this.appoin.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appoin.Location = new System.Drawing.Point(20, 104);
            this.appoin.Name = "appoin";
            this.appoin.Size = new System.Drawing.Size(141, 68);
            this.appoin.TabIndex = 1;
            this.appoin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControlDays
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.appoin);
            this.Controls.Add(this.labeldays);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(184, 184);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.Click += new System.EventHandler(this.UserControlDays_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeldays;
        private System.Windows.Forms.Label appoin;
    }
}
