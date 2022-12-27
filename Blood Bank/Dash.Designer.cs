namespace Blood_Bank
{
    partial class Dash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dash));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.staffBtn = new Guna.UI2.WinForms.Guna2Button();
            this.transBtn = new Guna.UI2.WinForms.Guna2Button();
            this.bloodBnkBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.donorDashBtn = new Guna.UI2.WinForms.Guna2Button();
            this.dashBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saaFormControlBox1 = new SaaUI.SaaFormControlBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.donorBoard2 = new Blood_Bank.View.DonorBoard();
            this.bloodBoard2 = new Blood_Bank.View.BloodBoard();
            this.bbankBoard1 = new Blood_Bank.View.BbankBoard();
            this.transaction1 = new Blood_Bank.View.Transaction();
            this.guna2Panel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.guna2Panel1.Controls.Add(this.staffBtn);
            this.guna2Panel1.Controls.Add(this.transBtn);
            this.guna2Panel1.Controls.Add(this.bloodBnkBtn);
            this.guna2Panel1.Controls.Add(this.guna2Button2);
            this.guna2Panel1.Controls.Add(this.donorDashBtn);
            this.guna2Panel1.Controls.Add(this.dashBtn);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 33);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(188, 767);
            this.guna2Panel1.TabIndex = 0;
            // 
            // staffBtn
            // 
            this.staffBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.staffBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.staffBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.staffBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.staffBtn.FillColor = System.Drawing.Color.Transparent;
            this.staffBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.staffBtn.ForeColor = System.Drawing.Color.White;
            this.staffBtn.Image = ((System.Drawing.Image)(resources.GetObject("staffBtn.Image")));
            this.staffBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.staffBtn.ImageOffset = new System.Drawing.Point(-5, 0);
            this.staffBtn.ImageSize = new System.Drawing.Size(33, 33);
            this.staffBtn.Location = new System.Drawing.Point(0, 461);
            this.staffBtn.Name = "staffBtn";
            this.staffBtn.Size = new System.Drawing.Size(188, 45);
            this.staffBtn.TabIndex = 6;
            this.staffBtn.Text = "Staff";
            this.staffBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // transBtn
            // 
            this.transBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.transBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.transBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.transBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.transBtn.FillColor = System.Drawing.Color.Transparent;
            this.transBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.transBtn.ForeColor = System.Drawing.Color.White;
            this.transBtn.Image = ((System.Drawing.Image)(resources.GetObject("transBtn.Image")));
            this.transBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.transBtn.ImageOffset = new System.Drawing.Point(-4, 0);
            this.transBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.transBtn.Location = new System.Drawing.Point(0, 398);
            this.transBtn.Name = "transBtn";
            this.transBtn.Size = new System.Drawing.Size(188, 45);
            this.transBtn.TabIndex = 5;
            this.transBtn.Text = "Transaction";
            this.transBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.transBtn.Click += new System.EventHandler(this.transBtn_Click);
            // 
            // bloodBnkBtn
            // 
            this.bloodBnkBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bloodBnkBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bloodBnkBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bloodBnkBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bloodBnkBtn.FillColor = System.Drawing.Color.Transparent;
            this.bloodBnkBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bloodBnkBtn.ForeColor = System.Drawing.Color.White;
            this.bloodBnkBtn.Image = ((System.Drawing.Image)(resources.GetObject("bloodBnkBtn.Image")));
            this.bloodBnkBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bloodBnkBtn.ImageOffset = new System.Drawing.Point(-3, 0);
            this.bloodBnkBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.bloodBnkBtn.Location = new System.Drawing.Point(0, 335);
            this.bloodBnkBtn.Name = "bloodBnkBtn";
            this.bloodBnkBtn.Size = new System.Drawing.Size(188, 45);
            this.bloodBnkBtn.TabIndex = 5;
            this.bloodBnkBtn.Text = "Blood Bank";
            this.bloodBnkBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bloodBnkBtn.Click += new System.EventHandler(this.bloodBnkBtn_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.ImageOffset = new System.Drawing.Point(-4, 0);
            this.guna2Button2.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button2.Location = new System.Drawing.Point(0, 272);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(188, 45);
            this.guna2Button2.TabIndex = 5;
            this.guna2Button2.Text = "Blood";
            this.guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // donorDashBtn
            // 
            this.donorDashBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.donorDashBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.donorDashBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.donorDashBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.donorDashBtn.FillColor = System.Drawing.Color.Transparent;
            this.donorDashBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.donorDashBtn.ForeColor = System.Drawing.Color.White;
            this.donorDashBtn.Image = ((System.Drawing.Image)(resources.GetObject("donorDashBtn.Image")));
            this.donorDashBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.donorDashBtn.ImageOffset = new System.Drawing.Point(-4, 0);
            this.donorDashBtn.ImageSize = new System.Drawing.Size(33, 33);
            this.donorDashBtn.Location = new System.Drawing.Point(0, 209);
            this.donorDashBtn.Name = "donorDashBtn";
            this.donorDashBtn.Size = new System.Drawing.Size(188, 45);
            this.donorDashBtn.TabIndex = 4;
            this.donorDashBtn.Text = "Donor";
            this.donorDashBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.donorDashBtn.Click += new System.EventHandler(this.donorDashBtn_Click);
            // 
            // dashBtn
            // 
            this.dashBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dashBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dashBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dashBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dashBtn.FillColor = System.Drawing.Color.Transparent;
            this.dashBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.dashBtn.ForeColor = System.Drawing.Color.White;
            this.dashBtn.Image = ((System.Drawing.Image)(resources.GetObject("dashBtn.Image")));
            this.dashBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dashBtn.ImageOffset = new System.Drawing.Point(-4, 0);
            this.dashBtn.ImageSize = new System.Drawing.Size(28, 28);
            this.dashBtn.Location = new System.Drawing.Point(0, 146);
            this.dashBtn.Name = "dashBtn";
            this.dashBtn.Size = new System.Drawing.Size(188, 45);
            this.dashBtn.TabIndex = 3;
            this.dashBtn.Text = "Dashboard";
            this.dashBtn.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.saaFormControlBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 33);
            this.panel1.TabIndex = 1;
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
            this.saaFormControlBox1.Location = new System.Drawing.Point(1410, 1);
            this.saaFormControlBox1.MaximizeActive = ((System.Drawing.Image)(resources.GetObject("saaFormControlBox1.MaximizeActive")));
            this.saaFormControlBox1.MaximizeInActive = ((System.Drawing.Image)(resources.GetObject("saaFormControlBox1.MaximizeInActive")));
            this.saaFormControlBox1.MaximizeTip = "Maximize";
            this.saaFormControlBox1.MinimizeActive = ((System.Drawing.Image)(resources.GetObject("saaFormControlBox1.MinimizeActive")));
            this.saaFormControlBox1.MinimizeInActive = ((System.Drawing.Image)(resources.GetObject("saaFormControlBox1.MinimizeInActive")));
            this.saaFormControlBox1.MinimizeTip = "Minimize";
            this.saaFormControlBox1.Name = "saaFormControlBox1";
            this.saaFormControlBox1.ShowClose = true;
            this.saaFormControlBox1.ShowMaximize = true;
            this.saaFormControlBox1.ShowMinimize = true;
            this.saaFormControlBox1.Size = new System.Drawing.Size(90, 30);
            this.saaFormControlBox1.TabIndex = 4;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.guna2Panel2.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(188, 33);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1312, 43);
            this.guna2Panel2.TabIndex = 2;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(1271, 2);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(35, 35);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // donorBoard2
            // 
            this.donorBoard2.BackColor = System.Drawing.Color.White;
            this.donorBoard2.dName = null;
            this.donorBoard2.dNum = 0;
            this.donorBoard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.donorBoard2.Location = new System.Drawing.Point(188, 76);
            this.donorBoard2.Name = "donorBoard2";
            this.donorBoard2.Size = new System.Drawing.Size(1312, 724);
            this.donorBoard2.status = "Pending";
            this.donorBoard2.TabIndex = 4;
            this.donorBoard2.Visible = false;
            // 
            // bloodBoard2
            // 
            this.bloodBoard2.BackColor = System.Drawing.Color.White;
            this.bloodBoard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bloodBoard2.Location = new System.Drawing.Point(188, 76);
            this.bloodBoard2.Name = "bloodBoard2";
            this.bloodBoard2.Size = new System.Drawing.Size(1312, 724);
            this.bloodBoard2.TabIndex = 3;
            this.bloodBoard2.Visible = false;
            // 
            // bbankBoard1
            // 
            this.bbankBoard1.BackColor = System.Drawing.Color.White;
            this.bbankBoard1.bId = 0;
            this.bbankBoard1.bloodGroup = null;
            this.bbankBoard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bbankBoard1.Location = new System.Drawing.Point(188, 76);
            this.bbankBoard1.Name = "bbankBoard1";
            this.bbankBoard1.quantity = 0D;
            this.bbankBoard1.Size = new System.Drawing.Size(1312, 724);
            this.bbankBoard1.TabIndex = 5;
            this.bbankBoard1.Visible = false;
            // 
            // transaction1
            // 
            this.transaction1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.transaction1.BackColor = System.Drawing.Color.White;
            this.transaction1.Location = new System.Drawing.Point(188, 89);
            this.transaction1.Name = "transaction1";
            this.transaction1.Size = new System.Drawing.Size(1312, 711);
            this.transaction1.TabIndex = 6;
            this.transaction1.Visible = false;
            // 
            // Dash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.Controls.Add(this.transaction1);
            this.Controls.Add(this.bbankBoard1);
            this.Controls.Add(this.donorBoard2);
            this.Controls.Add(this.bloodBoard2);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dash";
            this.guna2Panel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button dashBtn;
        private Guna.UI2.WinForms.Guna2Button donorDashBtn;
        private SaaUI.SaaFormControlBox saaFormControlBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button staffBtn;
        private View.BloodBoard bloodBoard2;
        private View.DonorBoard donorBoard2;
        private Guna.UI2.WinForms.Guna2Button bloodBnkBtn;
        private View.BbankBoard bbankBoard1;
        private View.Transaction transaction1;
        private Guna.UI2.WinForms.Guna2Button transBtn;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}

