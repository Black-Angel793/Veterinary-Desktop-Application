namespace Veterinary
{
    partial class Events
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.starttime = new System.Windows.Forms.Label();
            this.cname = new System.Windows.Forms.Label();
            this.reason = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.reason);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.starttime);
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 185);
            this.panel1.TabIndex = 0;
            // 
            // starttime
            // 
            this.starttime.AutoSize = true;
            this.starttime.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starttime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.starttime.Location = new System.Drawing.Point(137, 8);
            this.starttime.Name = "starttime";
            this.starttime.Size = new System.Drawing.Size(111, 29);
            this.starttime.TabIndex = 0;
            this.starttime.Text = "start time";
            this.starttime.Click += new System.EventHandler(this.starttime_Click);
            // 
            // cname
            // 
            this.cname.AutoSize = true;
            this.cname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cname.Location = new System.Drawing.Point(157, 120);
            this.cname.Name = "cname";
            this.cname.Size = new System.Drawing.Size(136, 29);
            this.cname.TabIndex = 1;
            this.cname.Text = "Client Name";
            // 
            // reason
            // 
            this.reason.AutoSize = true;
            this.reason.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reason.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reason.Location = new System.Drawing.Point(108, 64);
            this.reason.Name = "reason";
            this.reason.Size = new System.Drawing.Size(82, 29);
            this.reason.TabIndex = 1;
            this.reason.Text = "reason";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Time :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(3, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Client Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Reason :";
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Events";
            this.Size = new System.Drawing.Size(319, 191);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label reason;
        private System.Windows.Forms.Label cname;
        private System.Windows.Forms.Label starttime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
