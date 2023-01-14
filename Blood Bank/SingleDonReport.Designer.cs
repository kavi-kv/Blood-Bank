namespace Blood_Bank
{
    partial class SingleDonReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingleDonReport));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.saaFormControlBox1 = new SaaUI.SaaFormControlBox();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(3, 35);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(818, 449);
            this.reportViewer1.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.saaFormControlBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(821, 34);
            this.guna2Panel1.TabIndex = 1;
            // 
            // saaFormControlBox1
            // 
            this.saaFormControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saaFormControlBox1.CloseActive = ((System.Drawing.Image)(resources.GetObject("saaFormControlBox1.CloseActive")));
            this.saaFormControlBox1.CloseInActive = ((System.Drawing.Image)(resources.GetObject("saaFormControlBox1.CloseInActive")));
            this.saaFormControlBox1.CloseTip = "Close";
            this.saaFormControlBox1.DisableClose = false;
            this.saaFormControlBox1.DisableMaximize = false;
            this.saaFormControlBox1.DisableMinimize = false;
            this.saaFormControlBox1.Location = new System.Drawing.Point(711, 1);
            this.saaFormControlBox1.MaximizeActive = ((System.Drawing.Image)(resources.GetObject("saaFormControlBox1.MaximizeActive")));
            this.saaFormControlBox1.MaximizeInActive = null;
            this.saaFormControlBox1.MaximizeTip = "Maximize";
            this.saaFormControlBox1.MinimizeActive = null;
            this.saaFormControlBox1.MinimizeInActive = null;
            this.saaFormControlBox1.MinimizeTip = "Minimize";
            this.saaFormControlBox1.Name = "saaFormControlBox1";
            this.saaFormControlBox1.ShowClose = true;
            this.saaFormControlBox1.ShowMaximize = true;
            this.saaFormControlBox1.ShowMinimize = true;
            this.saaFormControlBox1.Size = new System.Drawing.Size(107, 30);
            this.saaFormControlBox1.TabIndex = 2;
            // 
            // SingleDonReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 485);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SingleDonReport";
            this.Text = "SingleDonReport";
            this.Load += new System.EventHandler(this.SingleDonReport_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private SaaUI.SaaFormControlBox saaFormControlBox1;
    }
}