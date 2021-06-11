
namespace Transportation.App
{
    partial class controlAccount1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(controlAccount1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpReport = new System.Windows.Forms.DateTimePicker();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDate = new System.Windows.Forms.DataGridView();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BusFare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ControlAccountUserSearch = new System.Windows.Forms.RichTextBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.Searchlabel1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgvDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.dtpReport);
            this.panel3.Location = new System.Drawing.Point(564, 70);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(345, 23);
            this.panel3.TabIndex = 41;
            // 
            // dtpReport
            // 
            this.dtpReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dtpReport.Location = new System.Drawing.Point(-1, -2);
            this.dtpReport.Margin = new System.Windows.Forms.Padding(4);
            this.dtpReport.Name = "dtpReport";
            this.dtpReport.Size = new System.Drawing.Size(355, 26);
            this.dtpReport.TabIndex = 14;
            this.dtpReport.ValueChanged += new System.EventHandler(this.dtpReport_ValueChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox3.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(488, 29);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(495, 105);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(540, -6);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 29);
            this.label4.TabIndex = 39;
            this.label4.Text = "Report By Date";
            // 
            // dgvDate
            // 
            this.dgvDate.AllowUserToAddRows = false;
            this.dgvDate.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDate.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDate.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDate.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDate.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (109)))), ((int) (((byte) (122)))), ((int) (((byte) (224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (109)))), ((int) (((byte) (122)))), ((int) (((byte) (224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.salary, this.BusFare, this.TotalAmount, this.Date});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDate.EnableHeadersVisualStyles = false;
            this.dgvDate.Location = new System.Drawing.Point(258, 201);
            this.dgvDate.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDate.Name = "dgvDate";
            this.dgvDate.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDate.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDate.RowHeadersVisible = false;
            this.dgvDate.RowHeadersWidth = 51;
            this.dgvDate.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDate.Size = new System.Drawing.Size(1000, 422);
            this.dgvDate.TabIndex = 133;
            this.dgvDate.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDate_DataBindingComplete);
            // 
            // salary
            // 
            this.salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.salary.DataPropertyName = "UserId";
            this.salary.HeaderText = "User Id";
            this.salary.MinimumWidth = 6;
            this.salary.Name = "salary";
            this.salary.ReadOnly = true;
            // 
            // BusFare
            // 
            this.BusFare.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BusFare.DataPropertyName = "Name";
            this.BusFare.HeaderText = "User Name";
            this.BusFare.MinimumWidth = 6;
            this.BusFare.Name = "BusFare";
            this.BusFare.ReadOnly = true;
            // 
            // TotalAmount
            // 
            this.TotalAmount.DataPropertyName = "TotalAmount";
            this.TotalAmount.HeaderText = "Total Amount";
            this.TotalAmount.MinimumWidth = 6;
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            this.TotalAmount.Width = 125;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 125;
            // 
            // ControlAccountUserSearch
            // 
            this.ControlAccountUserSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ControlAccountUserSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ControlAccountUserSearch.Location = new System.Drawing.Point(272, 152);
            this.ControlAccountUserSearch.Margin = new System.Windows.Forms.Padding(4);
            this.ControlAccountUserSearch.Name = "ControlAccountUserSearch";
            this.ControlAccountUserSearch.Size = new System.Drawing.Size(211, 27);
            this.ControlAccountUserSearch.TabIndex = 135;
            this.ControlAccountUserSearch.Text = "";
            this.ControlAccountUserSearch.TextChanged += new System.EventHandler(this.ControlAccountUserSearch_TextChanged);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox8.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(240, 130);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(276, 71);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 134;
            this.pictureBox8.TabStop = false;
            // 
            // Searchlabel1
            // 
            this.Searchlabel1.AutoSize = true;
            this.Searchlabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Searchlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Searchlabel1.Location = new System.Drawing.Point(524, 152);
            this.Searchlabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Searchlabel1.Name = "Searchlabel1";
            this.Searchlabel1.Size = new System.Drawing.Size(187, 29);
            this.Searchlabel1.TabIndex = 136;
            this.Searchlabel1.Text = "Search by User";
            // 
            // controlAccount1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Searchlabel1);
            this.Controls.Add(this.ControlAccountUserSearch);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.dgvDate);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "controlAccount1";
            this.Size = new System.Drawing.Size(1463, 668);
            this.Load += new System.EventHandler(this.controlAccount1_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgvDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.RichTextBox ControlAccountUserSearch;
        private System.Windows.Forms.Label Searchlabel1;

        private System.Windows.Forms.PictureBox pictureBox8;

        private System.Windows.Forms.DataGridView dgvDate;

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpReport;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn BusFare;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}
