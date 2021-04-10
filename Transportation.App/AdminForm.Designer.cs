namespace Transportation.App
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.nkjsd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlRed = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.adminBtnHome = new System.Windows.Forms.Button();
            this.schedule1 = new Transportation.App.Schedule();
            this.adminHome1 = new Transportation.App.AdminHome();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.nkjsd);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pnlRed);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.btnSchedule);
            this.panel2.Controls.Add(this.adminBtnHome);
            this.panel2.Location = new System.Drawing.Point(1, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(161, 783);
            this.panel2.TabIndex = 3;
            // 
            // nkjsd
            // 
            this.nkjsd.FlatAppearance.BorderSize = 0;
            this.nkjsd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nkjsd.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nkjsd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nkjsd.Location = new System.Drawing.Point(3, 162);
            this.nkjsd.Margin = new System.Windows.Forms.Padding(4);
            this.nkjsd.Name = "nkjsd";
            this.nkjsd.Size = new System.Drawing.Size(153, 36);
            this.nkjsd.TabIndex = 5;
            this.nkjsd.Text = "Profile";
            this.nkjsd.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(439, 198);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(904, 10);
            this.panel3.TabIndex = 1;
            // 
            // pnlRed
            // 
            this.pnlRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlRed.Location = new System.Drawing.Point(3, 69);
            this.pnlRed.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRed.Name = "pnlRed";
            this.pnlRed.Size = new System.Drawing.Size(13, 41);
            this.pnlRed.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(53, 523);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Logout";
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(53, 478);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(59, 46);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnSchedule
            // 
            this.btnSchedule.FlatAppearance.BorderSize = 0;
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedule.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSchedule.Location = new System.Drawing.Point(4, 118);
            this.btnSchedule.Margin = new System.Windows.Forms.Padding(4);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(153, 36);
            this.btnSchedule.TabIndex = 3;
            this.btnSchedule.Text = "Schedule";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // adminBtnHome
            // 
            this.adminBtnHome.FlatAppearance.BorderSize = 0;
            this.adminBtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminBtnHome.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminBtnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adminBtnHome.Image = ((System.Drawing.Image)(resources.GetObject("adminBtnHome.Image")));
            this.adminBtnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminBtnHome.Location = new System.Drawing.Point(3, 69);
            this.adminBtnHome.Margin = new System.Windows.Forms.Padding(4);
            this.adminBtnHome.Name = "adminBtnHome";
            this.adminBtnHome.Size = new System.Drawing.Size(157, 41);
            this.adminBtnHome.TabIndex = 2;
            this.adminBtnHome.Text = "Home";
            this.adminBtnHome.UseVisualStyleBackColor = true;
            this.adminBtnHome.Click += new System.EventHandler(this.adminBtnHome_Click);
            // 
            // schedule1
            // 
            this.schedule1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.schedule1.Location = new System.Drawing.Point(169, 66);
            this.schedule1.Name = "schedule1";
            this.schedule1.Size = new System.Drawing.Size(1021, 664);
            this.schedule1.TabIndex = 5;
            this.schedule1.Load += new System.EventHandler(this.schedule1_Load);
            // 
            // adminHome1
            // 
            this.adminHome1.Location = new System.Drawing.Point(169, 66);
            this.adminHome1.Name = "adminHome1";
            this.adminHome1.Size = new System.Drawing.Size(1021, 664);
            this.adminHome1.TabIndex = 4;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 785);
            this.Controls.Add(this.schedule1);
            this.Controls.Add(this.adminHome1);
            this.Controls.Add(this.panel2);
            this.Name = "AdminForm";
            this.Text = "AdminHome";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button nkjsd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlRed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button adminBtnHome;
        private AdminHome adminHome1;
        private Schedule schedule1;
    }
}