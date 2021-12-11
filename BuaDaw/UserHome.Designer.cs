
namespace BuaDaw
{
    partial class UserHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserHome));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UserUpdateInfoButton = new System.Windows.Forms.Button();
            this.UserLogOutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHireMaid = new System.Windows.Forms.Button();
            this.txtHireMaidID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hello!";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UserUpdateInfoButton);
            this.panel1.Controls.Add(this.UserLogOutButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 85);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // UserUpdateInfoButton
            // 
            this.UserUpdateInfoButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserUpdateInfoButton.Location = new System.Drawing.Point(793, 23);
            this.UserUpdateInfoButton.Name = "UserUpdateInfoButton";
            this.UserUpdateInfoButton.Size = new System.Drawing.Size(118, 41);
            this.UserUpdateInfoButton.TabIndex = 9;
            this.UserUpdateInfoButton.Text = "Update info";
            this.UserUpdateInfoButton.UseVisualStyleBackColor = true;
            this.UserUpdateInfoButton.Click += new System.EventHandler(this.UserUpdateInfoButton_Click);
            // 
            // UserLogOutButton
            // 
            this.UserLogOutButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UserLogOutButton.BackgroundImage")));
            this.UserLogOutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UserLogOutButton.Location = new System.Drawing.Point(917, 23);
            this.UserLogOutButton.Name = "UserLogOutButton";
            this.UserLogOutButton.Size = new System.Drawing.Size(46, 41);
            this.UserLogOutButton.TabIndex = 8;
            this.UserLogOutButton.UseVisualStyleBackColor = true;
            this.UserLogOutButton.Click += new System.EventHandler(this.UserLogOutButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "user name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(220, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(782, 452);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "MaidID";
            this.Column6.HeaderText = "Maid ID";
            this.Column6.Name = "Column6";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "FullName";
            this.Column1.HeaderText = "Full Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "WorkTime";
            this.Column2.HeaderText = "Work Time";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "WorkExperience";
            this.Column3.HeaderText = "Work Experience";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Gender";
            this.Column4.HeaderText = "Gender";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ExpectedSalary";
            this.Column5.HeaderText = "Expected Salary";
            this.Column5.Name = "Column5";
            // 
            // btnHireMaid
            // 
            this.btnHireMaid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.btnHireMaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHireMaid.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHireMaid.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHireMaid.Location = new System.Drawing.Point(31, 281);
            this.btnHireMaid.Name = "btnHireMaid";
            this.btnHireMaid.Size = new System.Drawing.Size(144, 44);
            this.btnHireMaid.TabIndex = 9;
            this.btnHireMaid.Text = "Hire";
            this.btnHireMaid.UseVisualStyleBackColor = false;
            this.btnHireMaid.Click += new System.EventHandler(this.btnHireMaid_Click);
            // 
            // txtHireMaidID
            // 
            this.txtHireMaidID.Location = new System.Drawing.Point(31, 249);
            this.txtHireMaidID.Name = "txtHireMaidID";
            this.txtHireMaidID.Size = new System.Drawing.Size(144, 26);
            this.txtHireMaidID.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Enter Maid ID";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1014, 641);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHireMaidID);
            this.Controls.Add(this.btnHireMaid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "UserHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.UserHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button UserLogOutButton;
        private System.Windows.Forms.Button UserUpdateInfoButton;
        private System.Windows.Forms.Button btnHireMaid;
        private System.Windows.Forms.TextBox txtHireMaidID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
