
namespace BuaDaw
{
    partial class LogIn
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
            this.label2 = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.LinkLabel();
            this.email = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.UserLogInButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BackToLandingPage = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.TAC = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.AdminLogInButton = new System.Windows.Forms.Button();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Log in";
            // 
            // Register
            // 
            this.Register.ActiveLinkColor = System.Drawing.Color.Blue;
            this.Register.AutoSize = true;
            this.Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register.LinkColor = System.Drawing.Color.Black;
            this.Register.Location = new System.Drawing.Point(266, 111);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(83, 25);
            this.Register.TabIndex = 4;
            this.Register.TabStop = true;
            this.Register.Text = "Register";
            this.Register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FAQ_LinkClicked);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(119, 188);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(241, 26);
            this.email.TabIndex = 5;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            this.email.Leave += new System.EventHandler(this.email_Leave);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(119, 245);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(241, 26);
            this.password.TabIndex = 6;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(119, 278);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(87, 19);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "I accept all ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(200, 279);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(132, 15);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Tearm\'s and condition.";
            // 
            // UserLogInButton
            // 
            this.UserLogInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.UserLogInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserLogInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLogInButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UserLogInButton.Location = new System.Drawing.Point(119, 310);
            this.UserLogInButton.Name = "UserLogInButton";
            this.UserLogInButton.Size = new System.Drawing.Size(241, 42);
            this.UserLogInButton.TabIndex = 9;
            this.UserLogInButton.Text = "Log in";
            this.UserLogInButton.UseVisualStyleBackColor = false;
            this.UserLogInButton.Click += new System.EventHandler(this.GetStarted_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Email ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password";
            // 
            // BackToLandingPage
            // 
            this.BackToLandingPage.ActiveLinkColor = System.Drawing.Color.Blue;
            this.BackToLandingPage.AutoSize = true;
            this.BackToLandingPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToLandingPage.LinkColor = System.Drawing.Color.Black;
            this.BackToLandingPage.Location = new System.Drawing.Point(116, 74);
            this.BackToLandingPage.Name = "BackToLandingPage";
            this.BackToLandingPage.Size = new System.Drawing.Size(51, 17);
            this.BackToLandingPage.TabIndex = 12;
            this.BackToLandingPage.TabStop = true;
            this.BackToLandingPage.Text = "< Back";
            this.BackToLandingPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BackToLandingPage_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 608);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "©️ All rights reserved - 2021";
            // 
            // linkLabel3
            // 
            this.linkLabel3.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.LinkColor = System.Drawing.Color.Black;
            this.linkLabel3.Location = new System.Drawing.Point(241, 583);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(118, 17);
            this.linkLabel3.TabIndex = 15;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "about developers";
            // 
            // TAC
            // 
            this.TAC.ActiveLinkColor = System.Drawing.Color.Blue;
            this.TAC.AutoSize = true;
            this.TAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TAC.LinkColor = System.Drawing.Color.Black;
            this.TAC.Location = new System.Drawing.Point(96, 583);
            this.TAC.Name = "TAC";
            this.TAC.Size = new System.Drawing.Size(139, 17);
            this.TAC.TabIndex = 14;
            this.TAC.TabStop = true;
            this.TAC.Text = "terms and conditions";
            // 
            // linkLabel4
            // 
            this.linkLabel4.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel4.LinkColor = System.Drawing.Color.Black;
            this.linkLabel4.Location = new System.Drawing.Point(42, 583);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(46, 17);
            this.linkLabel4.TabIndex = 13;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "FAQ\'s";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // AdminLogInButton
            // 
            this.AdminLogInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.AdminLogInButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AdminLogInButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLogInButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AdminLogInButton.Location = new System.Drawing.Point(119, 358);
            this.AdminLogInButton.Name = "AdminLogInButton";
            this.AdminLogInButton.Size = new System.Drawing.Size(241, 42);
            this.AdminLogInButton.TabIndex = 17;
            this.AdminLogInButton.Text = "Log in as Admin";
            this.AdminLogInButton.UseVisualStyleBackColor = false;
            this.AdminLogInButton.Click += new System.EventHandler(this.AdminLogInButton_Click);
            // 
            // linkLabel5
            // 
            this.linkLabel5.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel5.LinkColor = System.Drawing.Color.Black;
            this.linkLabel5.Location = new System.Drawing.Point(212, 415);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(148, 23);
            this.linkLabel5.TabIndex = 18;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Forgotten password?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BuaDaw.Properties.Resources.log_in;
            this.pictureBox1.Location = new System.Drawing.Point(467, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(535, 481);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1014, 641);
            this.Controls.Add(this.linkLabel5);
            this.Controls.Add(this.AdminLogInButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.TAC);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.BackToLandingPage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserLogInButton);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel Register;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button UserLogInButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel BackToLandingPage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel TAC;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button AdminLogInButton;
        private System.Windows.Forms.LinkLabel linkLabel5;
    }
}
