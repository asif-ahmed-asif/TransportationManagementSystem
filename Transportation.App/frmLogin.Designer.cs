
namespace Transportation.App
{
    partial class frmLogin
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(4, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(472, 604);
            this.panel2.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.textBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox2.Location = new System.Drawing.Point(240, 356);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 33);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Location = new System.Drawing.Point(240, 279);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 33);
            this.textBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(73, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(54, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 45F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(123, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 90);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(15, 604);
            this.panel4.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 16.25F);
            this.button1.Location = new System.Drawing.Point(240, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 603);
            this.Controls.Add(this.panel2);
            this.Name = "frmLogin";
            this.Text = "Login form";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}