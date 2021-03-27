namespace Transportation.App
{
    partial class Schedule
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
            this.scheduleHeading = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addScheduleBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // scheduleHeading
            // 
            this.scheduleHeading.AutoSize = true;
            this.scheduleHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.scheduleHeading.Font = new System.Drawing.Font("Bernard MT Condensed", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleHeading.Location = new System.Drawing.Point(325, 53);
            this.scheduleHeading.Name = "scheduleHeading";
            this.scheduleHeading.Size = new System.Drawing.Size(156, 47);
            this.scheduleHeading.TabIndex = 0;
            this.scheduleHeading.Text = "Schedule";
            this.scheduleHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(823, 391);
            this.dataGridView1.TabIndex = 1;
            // 
            // addScheduleBtn
            // 
            this.addScheduleBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.addScheduleBtn.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addScheduleBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addScheduleBtn.Location = new System.Drawing.Point(691, 43);
            this.addScheduleBtn.Name = "addScheduleBtn";
            this.addScheduleBtn.Size = new System.Drawing.Size(176, 57);
            this.addScheduleBtn.TabIndex = 10;
            this.addScheduleBtn.Text = "Add Schedule";
            this.addScheduleBtn.UseVisualStyleBackColor = false;
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addScheduleBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.scheduleHeading);
            this.Name = "Schedule";
            this.Size = new System.Drawing.Size(919, 599);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scheduleHeading;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addScheduleBtn;
    }
}
