﻿
namespace BuaDaw
{
    partial class ViewHiringStatus
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BackToAdminHome = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hiringSearchTxt = new System.Windows.Forms.TextBox();
            this.close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(990, 431);
            this.dataGridView1.TabIndex = 0;
            // 
            // BackToAdminHome
            // 
            this.BackToAdminHome.ActiveLinkColor = System.Drawing.Color.Blue;
            this.BackToAdminHome.AutoSize = true;
            this.BackToAdminHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToAdminHome.LinkColor = System.Drawing.Color.Black;
            this.BackToAdminHome.Location = new System.Drawing.Point(15, 35);
            this.BackToAdminHome.Name = "BackToAdminHome";
            this.BackToAdminHome.Size = new System.Drawing.Size(51, 17);
            this.BackToAdminHome.TabIndex = 65;
            this.BackToAdminHome.TabStop = true;
            this.BackToAdminHome.Text = "< Back";
            this.BackToAdminHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BackToAdminHome_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 34);
            this.label2.TabIndex = 64;
            this.label2.Text = "Maid Hiring Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 28);
            this.label1.TabIndex = 67;
            this.label1.Text = "search";
            // 
            // hiringSearchTxt
            // 
            this.hiringSearchTxt.Location = new System.Drawing.Point(315, 107);
            this.hiringSearchTxt.Name = "hiringSearchTxt";
            this.hiringSearchTxt.Size = new System.Drawing.Size(305, 31);
            this.hiringSearchTxt.TabIndex = 66;
            this.hiringSearchTxt.TextChanged += new System.EventHandler(this.hiringSearchTxt_TextChanged);
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(950, 35);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(52, 37);
            this.close.TabIndex = 68;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // ViewHiringStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1014, 641);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hiringSearchTxt);
            this.Controls.Add(this.BackToAdminHome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "ViewHiringStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewHiringStatus";
            this.Load += new System.EventHandler(this.ViewHiringStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel BackToAdminHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hiringSearchTxt;
        private System.Windows.Forms.Button close;
    }
}