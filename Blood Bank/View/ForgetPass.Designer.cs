namespace Blood_Bank.View
{
    partial class ForgetPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPass));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.EmailPnl = new Guna.UI2.WinForms.Guna2Panel();
            this.SecQPnl = new Guna.UI2.WinForms.Guna2Panel();
            this.secConfBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.secAnswerCmbBx = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.secQCombx = new Guna.UI2.WinForms.Guna2ComboBox();
            this.changePassPnl = new Guna.UI2.WinForms.Guna2Panel();
            this.passChangeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.txtConfrimNwPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNewPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EmailChildPnl = new Guna.UI2.WinForms.Guna2Panel();
            this.EmailVerComfBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEMailVercode = new Guna.UI2.WinForms.Guna2TextBox();
            this.confirmEmailBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTxtBx = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.byEmailBtn = new Guna.UI2.WinForms.Guna2Button();
            this.bySecQBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ExitBtn = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.EmailPnl.SuspendLayout();
            this.SecQPnl.SuspendLayout();
            this.changePassPnl.SuspendLayout();
            this.EmailChildPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forget Password";
            // 
            // EmailPnl
            // 
            this.EmailPnl.Controls.Add(this.SecQPnl);
            this.EmailPnl.Controls.Add(this.changePassPnl);
            this.EmailPnl.Controls.Add(this.EmailChildPnl);
            this.EmailPnl.Controls.Add(this.confirmEmailBtn);
            this.EmailPnl.Controls.Add(this.label2);
            this.EmailPnl.Controls.Add(this.emailTxtBx);
            this.EmailPnl.Controls.Add(this.label4);
            this.EmailPnl.Location = new System.Drawing.Point(12, 44);
            this.EmailPnl.Name = "EmailPnl";
            this.EmailPnl.Size = new System.Drawing.Size(369, 405);
            this.EmailPnl.TabIndex = 1;
            this.EmailPnl.Visible = false;
            // 
            // SecQPnl
            // 
            this.SecQPnl.Controls.Add(this.secConfBtn);
            this.SecQPnl.Controls.Add(this.label8);
            this.SecQPnl.Controls.Add(this.secAnswerCmbBx);
            this.SecQPnl.Controls.Add(this.label7);
            this.SecQPnl.Controls.Add(this.secQCombx);
            this.SecQPnl.Location = new System.Drawing.Point(17, 68);
            this.SecQPnl.Name = "SecQPnl";
            this.SecQPnl.Size = new System.Drawing.Size(335, 332);
            this.SecQPnl.TabIndex = 7;
            this.SecQPnl.Visible = false;
            // 
            // secConfBtn
            // 
            this.secConfBtn.BorderRadius = 10;
            this.secConfBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.secConfBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.secConfBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.secConfBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.secConfBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secConfBtn.ForeColor = System.Drawing.Color.White;
            this.secConfBtn.Location = new System.Drawing.Point(39, 241);
            this.secConfBtn.Name = "secConfBtn";
            this.secConfBtn.Size = new System.Drawing.Size(135, 42);
            this.secConfBtn.TabIndex = 8;
            this.secConfBtn.Text = "Confirm";
            this.secConfBtn.Click += new System.EventHandler(this.secConfBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Security Answer";
            // 
            // secAnswerCmbBx
            // 
            this.secAnswerCmbBx.BorderRadius = 10;
            this.secAnswerCmbBx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.secAnswerCmbBx.DefaultText = "";
            this.secAnswerCmbBx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.secAnswerCmbBx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.secAnswerCmbBx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.secAnswerCmbBx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.secAnswerCmbBx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.secAnswerCmbBx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secAnswerCmbBx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.secAnswerCmbBx.Location = new System.Drawing.Point(39, 187);
            this.secAnswerCmbBx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.secAnswerCmbBx.Name = "secAnswerCmbBx";
            this.secAnswerCmbBx.PasswordChar = '\0';
            this.secAnswerCmbBx.PlaceholderText = "";
            this.secAnswerCmbBx.SelectedText = "";
            this.secAnswerCmbBx.Size = new System.Drawing.Size(257, 39);
            this.secAnswerCmbBx.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(97, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Security Question";
            // 
            // secQCombx
            // 
            this.secQCombx.BackColor = System.Drawing.Color.Transparent;
            this.secQCombx.BorderRadius = 10;
            this.secQCombx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.secQCombx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.secQCombx.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.secQCombx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.secQCombx.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.secQCombx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.secQCombx.ItemHeight = 30;
            this.secQCombx.Location = new System.Drawing.Point(39, 117);
            this.secQCombx.Name = "secQCombx";
            this.secQCombx.Size = new System.Drawing.Size(257, 36);
            this.secQCombx.StartIndex = 0;
            this.secQCombx.TabIndex = 0;
            // 
            // changePassPnl
            // 
            this.changePassPnl.Controls.Add(this.passChangeBtn);
            this.changePassPnl.Controls.Add(this.txtConfrimNwPass);
            this.changePassPnl.Controls.Add(this.txtNewPass);
            this.changePassPnl.Controls.Add(this.label6);
            this.changePassPnl.Location = new System.Drawing.Point(14, 68);
            this.changePassPnl.Name = "changePassPnl";
            this.changePassPnl.Size = new System.Drawing.Size(335, 302);
            this.changePassPnl.TabIndex = 3;
            this.changePassPnl.Visible = false;
            // 
            // passChangeBtn
            // 
            this.passChangeBtn.BorderRadius = 5;
            this.passChangeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.passChangeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.passChangeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.passChangeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.passChangeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passChangeBtn.ForeColor = System.Drawing.Color.White;
            this.passChangeBtn.Location = new System.Drawing.Point(92, 230);
            this.passChangeBtn.Name = "passChangeBtn";
            this.passChangeBtn.Size = new System.Drawing.Size(150, 45);
            this.passChangeBtn.TabIndex = 6;
            this.passChangeBtn.Text = "Change";
            this.passChangeBtn.Click += new System.EventHandler(this.passChangeBtn_Click);
            // 
            // txtConfrimNwPass
            // 
            this.txtConfrimNwPass.BorderRadius = 10;
            this.txtConfrimNwPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfrimNwPass.DefaultText = "";
            this.txtConfrimNwPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConfrimNwPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConfrimNwPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfrimNwPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfrimNwPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfrimNwPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfrimNwPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfrimNwPass.Location = new System.Drawing.Point(35, 169);
            this.txtConfrimNwPass.Name = "txtConfrimNwPass";
            this.txtConfrimNwPass.PasswordChar = '\0';
            this.txtConfrimNwPass.PlaceholderText = "Confirm Password";
            this.txtConfrimNwPass.SelectedText = "";
            this.txtConfrimNwPass.Size = new System.Drawing.Size(273, 46);
            this.txtConfrimNwPass.TabIndex = 5;
            // 
            // txtNewPass
            // 
            this.txtNewPass.BorderRadius = 10;
            this.txtNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPass.DefaultText = "";
            this.txtNewPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPass.Location = new System.Drawing.Point(35, 105);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '\0';
            this.txtNewPass.PlaceholderText = "Enter New Password";
            this.txtNewPass.SelectedText = "";
            this.txtNewPass.Size = new System.Drawing.Size(273, 46);
            this.txtNewPass.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(98, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Change Password";
            // 
            // EmailChildPnl
            // 
            this.EmailChildPnl.Controls.Add(this.EmailVerComfBtn);
            this.EmailChildPnl.Controls.Add(this.label5);
            this.EmailChildPnl.Controls.Add(this.txtEMailVercode);
            this.EmailChildPnl.Location = new System.Drawing.Point(17, 108);
            this.EmailChildPnl.Name = "EmailChildPnl";
            this.EmailChildPnl.Size = new System.Drawing.Size(335, 238);
            this.EmailChildPnl.TabIndex = 4;
            this.EmailChildPnl.Visible = false;
            // 
            // EmailVerComfBtn
            // 
            this.EmailVerComfBtn.BorderRadius = 5;
            this.EmailVerComfBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EmailVerComfBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EmailVerComfBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EmailVerComfBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EmailVerComfBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailVerComfBtn.ForeColor = System.Drawing.Color.White;
            this.EmailVerComfBtn.Location = new System.Drawing.Point(32, 161);
            this.EmailVerComfBtn.Name = "EmailVerComfBtn";
            this.EmailVerComfBtn.Size = new System.Drawing.Size(150, 45);
            this.EmailVerComfBtn.TabIndex = 2;
            this.EmailVerComfBtn.Text = "Confirm";
            this.EmailVerComfBtn.Click += new System.EventHandler(this.EmailVerComfBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(288, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "We have send a verification code to your email check";
            // 
            // txtEMailVercode
            // 
            this.txtEMailVercode.BorderRadius = 2;
            this.txtEMailVercode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEMailVercode.DefaultText = "";
            this.txtEMailVercode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEMailVercode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEMailVercode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEMailVercode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEMailVercode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEMailVercode.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEMailVercode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEMailVercode.Location = new System.Drawing.Point(32, 102);
            this.txtEMailVercode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEMailVercode.Name = "txtEMailVercode";
            this.txtEMailVercode.PasswordChar = '\0';
            this.txtEMailVercode.PlaceholderText = "Enter the code";
            this.txtEMailVercode.SelectedText = "";
            this.txtEMailVercode.Size = new System.Drawing.Size(271, 48);
            this.txtEMailVercode.TabIndex = 0;
            // 
            // confirmEmailBtn
            // 
            this.confirmEmailBtn.BorderRadius = 10;
            this.confirmEmailBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.confirmEmailBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.confirmEmailBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.confirmEmailBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.confirmEmailBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmEmailBtn.ForeColor = System.Drawing.Color.White;
            this.confirmEmailBtn.Location = new System.Drawing.Point(48, 215);
            this.confirmEmailBtn.Name = "confirmEmailBtn";
            this.confirmEmailBtn.Size = new System.Drawing.Size(96, 39);
            this.confirmEmailBtn.TabIndex = 8;
            this.confirmEmailBtn.Text = "Confirm";
            this.confirmEmailBtn.Click += new System.EventHandler(this.confirmEmailBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email";
            // 
            // emailTxtBx
            // 
            this.emailTxtBx.BorderRadius = 10;
            this.emailTxtBx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTxtBx.DefaultText = "";
            this.emailTxtBx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailTxtBx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailTxtBx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTxtBx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTxtBx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTxtBx.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.emailTxtBx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTxtBx.Location = new System.Drawing.Point(46, 165);
            this.emailTxtBx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailTxtBx.Name = "emailTxtBx";
            this.emailTxtBx.PasswordChar = '\0';
            this.emailTxtBx.PlaceholderText = "Email";
            this.emailTxtBx.SelectedText = "";
            this.emailTxtBx.Size = new System.Drawing.Size(276, 43);
            this.emailTxtBx.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(126, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Verify By Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Choose a way to recover password";
            // 
            // byEmailBtn
            // 
            this.byEmailBtn.BorderRadius = 10;
            this.byEmailBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.byEmailBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.byEmailBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.byEmailBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.byEmailBtn.FillColor = System.Drawing.Color.FloralWhite;
            this.byEmailBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.byEmailBtn.ForeColor = System.Drawing.Color.Black;
            this.byEmailBtn.Location = new System.Drawing.Point(33, 183);
            this.byEmailBtn.Name = "byEmailBtn";
            this.byEmailBtn.Size = new System.Drawing.Size(240, 45);
            this.byEmailBtn.TabIndex = 2;
            this.byEmailBtn.Text = "By Email";
            this.byEmailBtn.Click += new System.EventHandler(this.byEmailBtn_Click);
            // 
            // bySecQBtn
            // 
            this.bySecQBtn.BorderRadius = 10;
            this.bySecQBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bySecQBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bySecQBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bySecQBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bySecQBtn.FillColor = System.Drawing.Color.FloralWhite;
            this.bySecQBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bySecQBtn.ForeColor = System.Drawing.Color.Black;
            this.bySecQBtn.Location = new System.Drawing.Point(32, 234);
            this.bySecQBtn.Name = "bySecQBtn";
            this.bySecQBtn.Size = new System.Drawing.Size(240, 45);
            this.bySecQBtn.TabIndex = 2;
            this.bySecQBtn.Text = "Security Question";
            this.bySecQBtn.Click += new System.EventHandler(this.bySecQBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.ImageRotate = 0F;
            this.ExitBtn.Location = new System.Drawing.Point(343, 7);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ExitBtn.Size = new System.Drawing.Size(42, 31);
            this.ExitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.TabStop = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ForgetPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(393, 496);
            this.Controls.Add(this.EmailPnl);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.bySecQBtn);
            this.Controls.Add(this.byEmailBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgetPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgetPass";
            this.EmailPnl.ResumeLayout(false);
            this.EmailPnl.PerformLayout();
            this.SecQPnl.ResumeLayout(false);
            this.SecQPnl.PerformLayout();
            this.changePassPnl.ResumeLayout(false);
            this.changePassPnl.PerformLayout();
            this.EmailChildPnl.ResumeLayout(false);
            this.EmailChildPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel EmailPnl;
        private Guna.UI2.WinForms.Guna2Button bySecQBtn;
        private Guna.UI2.WinForms.Guna2Button byEmailBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Panel EmailChildPnl;
        private Guna.UI2.WinForms.Guna2Button confirmEmailBtn;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox emailTxtBx;
        private Guna.UI2.WinForms.Guna2TextBox txtEMailVercode;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button EmailVerComfBtn;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ExitBtn;
        private Guna.UI2.WinForms.Guna2Panel changePassPnl;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPass;
        private Guna.UI2.WinForms.Guna2TextBox txtConfrimNwPass;
        private Guna.UI2.WinForms.Guna2Button passChangeBtn;
        private Guna.UI2.WinForms.Guna2Panel SecQPnl;
        private Guna.UI2.WinForms.Guna2TextBox secAnswerCmbBx;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox secQCombx;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button secConfBtn;
    }
}