namespace Blood_Bank
{
    partial class AllDonorReport
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.donorsReport1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // donorsReport1
            // 
            this.donorsReport1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.donorsReport1.Location = new System.Drawing.Point(0, 0);
            this.donorsReport1.Name = "donorsReport1";
            this.donorsReport1.ServerReport.BearerToken = null;
            this.donorsReport1.Size = new System.Drawing.Size(1098, 609);
            this.donorsReport1.TabIndex = 0;
            // 
            // AllDonorReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 609);
            this.Controls.Add(this.donorsReport1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllDonorReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllDonorReport";
            this.Load += new System.EventHandler(this.AllDonorReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Microsoft.Reporting.WinForms.ReportViewer donorsReport1;
    }
}