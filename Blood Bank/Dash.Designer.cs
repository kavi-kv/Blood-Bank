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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dash));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtFullName = new System.Windows.Forms.Label();
            this.CompanyName = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.userIcon = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.donorDashBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.logOutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.userBtn = new Guna.UI2.WinForms.Guna2Button();
            this.staffBtn = new Guna.UI2.WinForms.Guna2Button();
            this.transBtn = new Guna.UI2.WinForms.Guna2Button();
            this.bloodBnkBtn = new Guna.UI2.WinForms.Guna2Button();
            this.bloodBtn = new Guna.UI2.WinForms.Guna2Button();
            this.dashBtn = new Guna.UI2.WinForms.Guna2Button();
            this.saaFormControlBox1 = new SaaUI.SaaFormControlBox();
            this.reportsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.reports1 = new Blood_Bank.View.Reports();
            this.userBoard1 = new Blood_Bank.View.UserBoard();
            this.dashBoard1 = new Blood_Bank.View.DashBoard();
            this.staffBoard1 = new Blood_Bank.View.StaffBoard();
            this.transaction1 = new Blood_Bank.View.Transaction();
            this.bbankBoard1 = new Blood_Bank.View.BbankBoard();
            this.donorBoard2 = new Blood_Bank.View.DonorBoard();
            this.bloodBoard2 = new Blood_Bank.View.BloodBoard();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.guna2Panel1.Controls.Add(this.donorDashBtn);
            this.guna2Panel1.Controls.Add(this.logOutBtn);
            this.guna2Panel1.Controls.Add(this.reportsBtn);
            this.guna2Panel1.Controls.Add(this.userBtn);
            this.guna2Panel1.Controls.Add(this.staffBtn);
            this.guna2Panel1.Controls.Add(this.transBtn);
            this.guna2Panel1.Controls.Add(this.bloodBnkBtn);
            this.guna2Panel1.Controls.Add(this.bloodBtn);
            this.guna2Panel1.Controls.Add(this.dashBtn);
            this.guna2Panel1.Controls.Add(this.guna2Panel3);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 33);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(188, 767);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(188, 122);
            this.guna2Panel3.TabIndex = 8;
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
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(28)))), ((int)(((byte)(78)))));
            this.guna2Panel2.Controls.Add(this.txtFullName);
            this.guna2Panel2.Controls.Add(this.CompanyName);
            this.guna2Panel2.Controls.Add(this.userIcon);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(188, 33);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1312, 43);
            this.guna2Panel2.TabIndex = 2;
            // 
            // txtFullName
            // 
            this.txtFullName.AutoSize = true;
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.ForeColor = System.Drawing.Color.White;
            this.txtFullName.Location = new System.Drawing.Point(60, 11);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(53, 21);
            this.txtFullName.TabIndex = 8;
            this.txtFullName.Text = "Name";
            // 
            // CompanyName
            // 
            this.CompanyName.AutoSize = true;
            this.CompanyName.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyName.ForeColor = System.Drawing.Color.White;
            this.CompanyName.Location = new System.Drawing.Point(490, 6);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(332, 30);
            this.CompanyName.TabIndex = 7;
            this.CompanyName.Text = "Somalia International Blood Bank";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 8;
            this.guna2Elipse1.TargetControl = this;
            // 
            // userIcon
            // 
            this.userIcon.Image = ((System.Drawing.Image)(resources.GetObject("userIcon.Image")));
            this.userIcon.ImageRotate = 0F;
            this.userIcon.Location = new System.Drawing.Point(18, 7);
            this.userIcon.Name = "userIcon";
            this.userIcon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.userIcon.Size = new System.Drawing.Size(30, 30);
            this.userIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userIcon.TabIndex = 7;
            this.userIcon.TabStop = false;
            this.userIcon.Click += new System.EventHandler(this.userIcon_Click);
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
            this.donorDashBtn.Location = new System.Drawing.Point(0, 189);
            this.donorDashBtn.Name = "donorDashBtn";
            this.donorDashBtn.Size = new System.Drawing.Size(185, 45);
            this.donorDashBtn.TabIndex = 5;
            this.donorDashBtn.Text = "Donor";
            this.donorDashBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.donorDashBtn.Click += new System.EventHandler(this.donorDashBtn_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(43, 11);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(90, 90);
            this.guna2CirclePictureBox1.TabIndex = 7;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // logOutBtn
            // 
            this.logOutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logOutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logOutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logOutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logOutBtn.FillColor = System.Drawing.Color.Transparent;
            this.logOutBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.logOutBtn.ForeColor = System.Drawing.Color.White;
            this.logOutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logOutBtn.Image")));
            this.logOutBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.logOutBtn.ImageOffset = new System.Drawing.Point(-5, 0);
            this.logOutBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.logOutBtn.Location = new System.Drawing.Point(1, 717);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(188, 45);
            this.logOutBtn.TabIndex = 6;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // userBtn
            // 
            this.userBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.userBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.userBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.userBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.userBtn.FillColor = System.Drawing.Color.Transparent;
            this.userBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.userBtn.ForeColor = System.Drawing.Color.White;
            this.userBtn.Image = ((System.Drawing.Image)(resources.GetObject("userBtn.Image")));
            this.userBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.userBtn.ImageOffset = new System.Drawing.Point(-6, 0);
            this.userBtn.ImageSize = new System.Drawing.Size(33, 33);
            this.userBtn.Location = new System.Drawing.Point(0, 499);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(185, 45);
            this.userBtn.TabIndex = 6;
            this.userBtn.Text = "Users";
            this.userBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click);
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
            this.staffBtn.ImageOffset = new System.Drawing.Point(-6, 0);
            this.staffBtn.ImageSize = new System.Drawing.Size(33, 33);
            this.staffBtn.Location = new System.Drawing.Point(0, 437);
            this.staffBtn.Name = "staffBtn";
            this.staffBtn.Size = new System.Drawing.Size(185, 45);
            this.staffBtn.TabIndex = 6;
            this.staffBtn.Text = "Staff";
            this.staffBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.staffBtn.Click += new System.EventHandler(this.staffBtn_Click);
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
            this.transBtn.Location = new System.Drawing.Point(0, 375);
            this.transBtn.Name = "transBtn";
            this.transBtn.Size = new System.Drawing.Size(185, 45);
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
            this.bloodBnkBtn.Location = new System.Drawing.Point(0, 313);
            this.bloodBnkBtn.Name = "bloodBnkBtn";
            this.bloodBnkBtn.Size = new System.Drawing.Size(185, 45);
            this.bloodBnkBtn.TabIndex = 5;
            this.bloodBnkBtn.Text = "Blood Bank";
            this.bloodBnkBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bloodBnkBtn.Click += new System.EventHandler(this.bloodBnkBtn_Click);
            // 
            // bloodBtn
            // 
            this.bloodBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bloodBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bloodBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bloodBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bloodBtn.FillColor = System.Drawing.Color.Transparent;
            this.bloodBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bloodBtn.ForeColor = System.Drawing.Color.White;
            this.bloodBtn.Image = ((System.Drawing.Image)(resources.GetObject("bloodBtn.Image")));
            this.bloodBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bloodBtn.ImageOffset = new System.Drawing.Point(-4, 0);
            this.bloodBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.bloodBtn.Location = new System.Drawing.Point(0, 251);
            this.bloodBtn.Name = "bloodBtn";
            this.bloodBtn.Size = new System.Drawing.Size(185, 45);
            this.bloodBtn.TabIndex = 5;
            this.bloodBtn.Text = "Blood";
            this.bloodBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bloodBtn.Click += new System.EventHandler(this.guna2Button2_Click);
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
            this.dashBtn.Location = new System.Drawing.Point(0, 127);
            this.dashBtn.Name = "dashBtn";
            this.dashBtn.Size = new System.Drawing.Size(185, 45);
            this.dashBtn.TabIndex = 3;
            this.dashBtn.Text = "Dashboard";
            this.dashBtn.Click += new System.EventHandler(this.guna2Button1_Click);
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
            // reportsBtn
            // 
            this.reportsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reportsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reportsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reportsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reportsBtn.FillColor = System.Drawing.Color.Transparent;
            this.reportsBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.reportsBtn.ForeColor = System.Drawing.Color.White;
            this.reportsBtn.Image = ((System.Drawing.Image)(resources.GetObject("reportsBtn.Image")));
            this.reportsBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.reportsBtn.ImageOffset = new System.Drawing.Point(-6, 0);
            this.reportsBtn.ImageSize = new System.Drawing.Size(33, 33);
            this.reportsBtn.Location = new System.Drawing.Point(0, 553);
            this.reportsBtn.Name = "reportsBtn";
            this.reportsBtn.Size = new System.Drawing.Size(185, 45);
            this.reportsBtn.TabIndex = 6;
            this.reportsBtn.Text = "Reports";
            this.reportsBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.reportsBtn.Click += new System.EventHandler(this.reportsBtn_Click);
            // 
            // reports1
            // 
            this.reports1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reports1.Location = new System.Drawing.Point(188, 76);
            this.reports1.Name = "reports1";
            this.reports1.Size = new System.Drawing.Size(1312, 724);
            this.reports1.TabIndex = 10;
            this.reports1.Visible = false;
            // 
            // userBoard1
            // 
            this.userBoard1.BackColor = System.Drawing.Color.White;
            this.userBoard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userBoard1.email = null;
            this.userBoard1.Location = new System.Drawing.Point(188, 76);
            this.userBoard1.Name = "userBoard1";
            this.userBoard1.Size = new System.Drawing.Size(1312, 724);
            this.userBoard1.TabIndex = 9;
            this.userBoard1.Visible = false;
            // 
            // dashBoard1
            // 
            this.dashBoard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashBoard1.Location = new System.Drawing.Point(188, 76);
            this.dashBoard1.Name = "dashBoard1";
            this.dashBoard1.Size = new System.Drawing.Size(1312, 724);
            this.dashBoard1.TabIndex = 8;
            // 
            // staffBoard1
            // 
            this.staffBoard1.BackColor = System.Drawing.Color.White;
            this.staffBoard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.staffBoard1.Location = new System.Drawing.Point(188, 76);
            this.staffBoard1.Name = "staffBoard1";
            this.staffBoard1.Size = new System.Drawing.Size(1312, 724);
            this.staffBoard1.TabIndex = 7;
            this.staffBoard1.Visible = false;
            // 
            // transaction1
            // 
            this.transaction1.BackColor = System.Drawing.Color.White;
            this.transaction1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transaction1.Location = new System.Drawing.Point(188, 76);
            this.transaction1.Name = "transaction1";
            this.transaction1.Size = new System.Drawing.Size(1312, 724);
            this.transaction1.TabIndex = 6;
            this.transaction1.Visible = false;
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
            // donorBoard2
            // 
            this.donorBoard2.BackColor = System.Drawing.Color.White;
            this.donorBoard2.dName = null;
            this.donorBoard2.dNum = 0;
            this.donorBoard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.donorBoard2.existedDonorAddress = null;
            this.donorBoard2.existedDonorBlood = null;
            this.donorBoard2.existedDonorName = null;
            this.donorBoard2.existedDonorSex = null;
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
            // Dash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.Controls.Add(this.reports1);
            this.Controls.Add(this.userBoard1);
            this.Controls.Add(this.dashBoard1);
            this.Controls.Add(this.staffBoard1);
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
            this.Load += new System.EventHandler(this.Dash_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button dashBtn;
        private SaaUI.SaaFormControlBox saaFormControlBox1;
        private Guna.UI2.WinForms.Guna2Button bloodBtn;
        private Guna.UI2.WinForms.Guna2Button staffBtn;
        private View.BloodBoard bloodBoard2;
        private View.DonorBoard donorBoard2;
        private Guna.UI2.WinForms.Guna2Button bloodBnkBtn;
        private View.BbankBoard bbankBoard1;
        private View.Transaction transaction1;
        private Guna.UI2.WinForms.Guna2Button transBtn;
        private View.StaffBoard staffBoard1;
        private View.DashBoard dashBoard1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button logOutBtn;
        private System.Windows.Forms.Label CompanyName;
        private Guna.UI2.WinForms.Guna2Button userBtn;
        private View.UserBoard userBoard1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox userIcon;
        private System.Windows.Forms.Label txtFullName;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button donorDashBtn;
        private Guna.UI2.WinForms.Guna2Button reportsBtn;
        private View.Reports reports1;
    }
}

