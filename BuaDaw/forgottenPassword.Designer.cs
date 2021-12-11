
namespace BuaDaw
{
    partial class forgottenPassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.BackToLandingPage = new System.Windows.Forms.LinkLabel();
            this.SendButton = new System.Windows.Forms.Button();
            this.txtVerCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.verify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Email ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(176, 117);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(241, 31);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // BackToLandingPage
            // 
            this.BackToLandingPage.ActiveLinkColor = System.Drawing.Color.Blue;
            this.BackToLandingPage.AutoSize = true;
            this.BackToLandingPage.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToLandingPage.LinkColor = System.Drawing.Color.Black;
            this.BackToLandingPage.Location = new System.Drawing.Point(172, 51);
            this.BackToLandingPage.Name = "BackToLandingPage";
            this.BackToLandingPage.Size = new System.Drawing.Size(52, 23);
            this.BackToLandingPage.TabIndex = 13;
            this.BackToLandingPage.TabStop = true;
            this.BackToLandingPage.Text = "< Back";
            this.BackToLandingPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BackToLandingPage_LinkClicked);
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SendButton.Location = new System.Drawing.Point(176, 154);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(119, 34);
            this.SendButton.TabIndex = 14;
            this.SendButton.Text = "Send Code";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // txtVerCode
            // 
            this.txtVerCode.Location = new System.Drawing.Point(176, 224);
            this.txtVerCode.Name = "txtVerCode";
            this.txtVerCode.Size = new System.Drawing.Size(241, 31);
            this.txtVerCode.TabIndex = 15;
            this.txtVerCode.TextChanged += new System.EventHandler(this.txtVerCode_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Verification Code";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // verify
            // 
            this.verify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.verify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verify.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verify.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.verify.Location = new System.Drawing.Point(177, 261);
            this.verify.Name = "verify";
            this.verify.Size = new System.Drawing.Size(119, 34);
            this.verify.TabIndex = 17;
            this.verify.Text = "Verify";
            this.verify.UseVisualStyleBackColor = false;
            this.verify.Click += new System.EventHandler(this.verify_Click);
            // 
            // forgottenPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(662, 445);
            this.Controls.Add(this.verify);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVerCode);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.BackToLandingPage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "forgottenPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "forgottenPassword";
            this.Load += new System.EventHandler(this.forgottenPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.LinkLabel BackToLandingPage;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox txtVerCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button verify;
    }
}