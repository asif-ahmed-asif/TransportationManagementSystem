
namespace Transportation.App
{
    partial class cashierTicketControl2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvCashierSchedule = new System.Windows.Forms.DataGridView();
            this.schedule_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrival_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.available_seat_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashierSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(31, 15);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dgvCashierSchedule
            // 
            this.dgvCashierSchedule.AllowUserToAddRows = false;
            this.dgvCashierSchedule.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvCashierSchedule.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCashierSchedule.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCashierSchedule.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCashierSchedule.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCashierSchedule.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCashierSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCashierSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCashierSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.schedule_id,
            this.dept_time,
            this.arrival_time,
            this.available_seat_count});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCashierSchedule.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCashierSchedule.EnableHeadersVisualStyles = false;
            this.dgvCashierSchedule.Location = new System.Drawing.Point(53, 74);
            this.dgvCashierSchedule.Name = "dgvCashierSchedule";
            this.dgvCashierSchedule.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCashierSchedule.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCashierSchedule.RowHeadersVisible = false;
            this.dgvCashierSchedule.RowHeadersWidth = 51;
            this.dgvCashierSchedule.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCashierSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCashierSchedule.Size = new System.Drawing.Size(399, 457);
            this.dgvCashierSchedule.TabIndex = 129;
            this.dgvCashierSchedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCashierSchedule_CellClick);
            this.dgvCashierSchedule.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCashierSchedule_CellContentDoubleClick);
            // 
            // schedule_id
            // 
            this.schedule_id.DataPropertyName = "schedule_id";
            this.schedule_id.HeaderText = "Id";
            this.schedule_id.Name = "schedule_id";
            this.schedule_id.ReadOnly = true;
            // 
            // dept_time
            // 
            this.dept_time.DataPropertyName = "dept_time";
            this.dept_time.HeaderText = "Departure Time";
            this.dept_time.Name = "dept_time";
            this.dept_time.ReadOnly = true;
            // 
            // arrival_time
            // 
            this.arrival_time.DataPropertyName = "arrival_time";
            this.arrival_time.HeaderText = "Arrival Time";
            this.arrival_time.Name = "arrival_time";
            this.arrival_time.ReadOnly = true;
            // 
            // available_seat_count
            // 
            this.available_seat_count.DataPropertyName = "available_seat_count";
            this.available_seat_count.HeaderText = "Available Number of Seats";
            this.available_seat_count.Name = "available_seat_count";
            this.available_seat_count.ReadOnly = true;
            // 
            // cashierTicketControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCashierSchedule);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBack);
            this.Name = "cashierTicketControl2";
            this.Size = new System.Drawing.Size(749, 500);
            this.Load += new System.EventHandler(this.cashierTicketControl2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashierSchedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvCashierSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn schedule_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrival_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn available_seat_count;
    }
}
