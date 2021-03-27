namespace Transportation.App
{
    partial class AdminHome
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
            this.searchEmployeeBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.headingEmployee = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.addEmpBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchEmployeeBtn
            // 
            this.searchEmployeeBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.searchEmployeeBtn.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchEmployeeBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchEmployeeBtn.Location = new System.Drawing.Point(161, 164);
            this.searchEmployeeBtn.Name = "searchEmployeeBtn";
            this.searchEmployeeBtn.Size = new System.Drawing.Size(133, 38);
            this.searchEmployeeBtn.TabIndex = 7;
            this.searchEmployeeBtn.Text = "Search";
            this.searchEmployeeBtn.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 117);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 41);
            this.textBox1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(24, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(968, 334);
            this.dataGridView1.TabIndex = 0;
            // 
            // headingEmployee
            // 
            this.headingEmployee.AutoSize = true;
            this.headingEmployee.Font = new System.Drawing.Font("Verdana", 25.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingEmployee.Location = new System.Drawing.Point(356, 49);
            this.headingEmployee.Name = "headingEmployee";
            this.headingEmployee.Size = new System.Drawing.Size(289, 53);
            this.headingEmployee.TabIndex = 8;
            this.headingEmployee.Text = "Employees";
            // 
            // addEmpBtn
            // 
            this.addEmpBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.addEmpBtn.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmpBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addEmpBtn.Location = new System.Drawing.Point(831, 49);
            this.addEmpBtn.Name = "addEmpBtn";
            this.addEmpBtn.Size = new System.Drawing.Size(176, 57);
            this.addEmpBtn.TabIndex = 9;
            this.addEmpBtn.Text = "Add Employee";
            this.addEmpBtn.UseVisualStyleBackColor = false;
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addEmpBtn);
            this.Controls.Add(this.headingEmployee);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchEmployeeBtn);
            this.Controls.Add(this.textBox1);
            this.Name = "AdminHome";
            this.Size = new System.Drawing.Size(1021, 664);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchEmployeeBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label headingEmployee;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button addEmpBtn;
    }
}
