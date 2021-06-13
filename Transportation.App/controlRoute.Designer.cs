
namespace Transportation.App
{
    partial class controlRoute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(controlRoute));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbBus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.departureText = new System.Windows.Forms.RichTextBox();
            this.departureTextFiled = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.disabledRouteIdForm = new System.Windows.Forms.PictureBox();
            this.disableBusIdText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtSearch = new System.Windows.Forms.RichTextBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.dgvRoute = new System.Windows.Forms.DataGridView();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScheduleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BusFare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeStatusBtn = new System.Windows.Forms.Button();
            this.routeStatus = new System.Windows.Forms.Label();
            this.invisibleScheduleIdText = new System.Windows.Forms.RichTextBox();
            this.disabledScheduleIdBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReturnRoute = new System.Windows.Forms.Button();
            this.BusTypeTextField = new System.Windows.Forms.TextBox();
            this.fareTextField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize) (this.departureTextFiled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.disabledRouteIdForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgvRoute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.disabledScheduleIdBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label7.Location = new System.Drawing.Point(17, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 29);
            this.label7.TabIndex = 99;
            this.label7.Text = "Departure From";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label8.Location = new System.Drawing.Point(531, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 29);
            this.label8.TabIndex = 100;
            this.label8.Text = "Destination";
            // 
            // cmbBus
            // 
            this.cmbBus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cmbBus.FormattingEnabled = true;
            this.cmbBus.Location = new System.Drawing.Point(536, 245);
            this.cmbBus.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBus.Name = "cmbBus";
            this.cmbBus.Size = new System.Drawing.Size(271, 37);
            this.cmbBus.TabIndex = 104;
            this.cmbBus.SelectedIndexChanged += new System.EventHandler(this.cmbBus_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label9.Location = new System.Drawing.Point(541, 197);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 29);
            this.label9.TabIndex = 103;
            this.label9.Text = "Bus Number";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(709, 460);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(212, 50);
            this.btnClear.TabIndex = 106;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(463, 460);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(225, 50);
            this.btnSave.TabIndex = 105;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label10.Location = new System.Drawing.Point(19, 198);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 29);
            this.label10.TabIndex = 108;
            this.label10.Text = "Departure Time";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(223, 260);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(157, 22);
            this.dateTimePicker2.TabIndex = 109;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label11.Location = new System.Drawing.Point(19, 256);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 29);
            this.label11.TabIndex = 110;
            this.label11.Text = "Arrival Time";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(223, 204);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 22);
            this.dateTimePicker1.TabIndex = 111;
            // 
            // departureText
            // 
            this.departureText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.departureText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.departureText.Location = new System.Drawing.Point(40, 96);
            this.departureText.Margin = new System.Windows.Forms.Padding(4);
            this.departureText.Name = "departureText";
            this.departureText.Size = new System.Drawing.Size(209, 27);
            this.departureText.TabIndex = 115;
            this.departureText.Text = "";
            // 
            // departureTextFiled
            // 
            this.departureTextFiled.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.departureTextFiled.Image = ((System.Drawing.Image) (resources.GetObject("departureTextFiled.Image")));
            this.departureTextFiled.Location = new System.Drawing.Point(19, 64);
            this.departureTextFiled.Margin = new System.Windows.Forms.Padding(4);
            this.departureTextFiled.Name = "departureTextFiled";
            this.departureTextFiled.Size = new System.Drawing.Size(265, 92);
            this.departureTextFiled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.departureTextFiled.TabIndex = 114;
            this.departureTextFiled.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.richTextBox1.Location = new System.Drawing.Point(552, 96);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(232, 27);
            this.richTextBox1.TabIndex = 117;
            this.richTextBox1.Text = "";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox3.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(531, 64);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(277, 92);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 116;
            this.pictureBox3.TabStop = false;
            // 
            // disabledRouteIdForm
            // 
            this.disabledRouteIdForm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.disabledRouteIdForm.Image = ((System.Drawing.Image) (resources.GetObject("disabledRouteIdForm.Image")));
            this.disabledRouteIdForm.Location = new System.Drawing.Point(532, 302);
            this.disabledRouteIdForm.Margin = new System.Windows.Forms.Padding(4);
            this.disabledRouteIdForm.Name = "disabledRouteIdForm";
            this.disabledRouteIdForm.Size = new System.Drawing.Size(277, 71);
            this.disabledRouteIdForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.disabledRouteIdForm.TabIndex = 118;
            this.disabledRouteIdForm.TabStop = false;
            this.disabledRouteIdForm.Visible = false;
            // 
            // disableBusIdText
            // 
            this.disableBusIdText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.disableBusIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.disableBusIdText.Location = new System.Drawing.Point(552, 327);
            this.disableBusIdText.Margin = new System.Windows.Forms.Padding(4);
            this.disableBusIdText.Name = "disableBusIdText";
            this.disableBusIdText.ReadOnly = true;
            this.disableBusIdText.Size = new System.Drawing.Size(232, 21);
            this.disableBusIdText.TabIndex = 119;
            this.disableBusIdText.Text = "";
            this.disableBusIdText.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(1337, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 29);
            this.label1.TabIndex = 121;
            this.label1.Text = "Search by Route";
            // 
            // rtxtSearch
            // 
            this.rtxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.rtxtSearch.Location = new System.Drawing.Point(1057, 78);
            this.rtxtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtSearch.Name = "rtxtSearch";
            this.rtxtSearch.Size = new System.Drawing.Size(211, 27);
            this.rtxtSearch.TabIndex = 127;
            this.rtxtSearch.Text = "";
            this.rtxtSearch.TextChanged += new System.EventHandler(this.rtxtSearch_TextChanged);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox8.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(1025, 57);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(276, 71);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 126;
            this.pictureBox8.TabStop = false;
            // 
            // dgvRoute
            // 
            this.dgvRoute.AllowUserToAddRows = false;
            this.dgvRoute.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvRoute.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRoute.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRoute.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRoute.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRoute.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (109)))), ((int) (((byte) (122)))), ((int) (((byte) (224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (109)))), ((int) (((byte) (122)))), ((int) (((byte) (224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoute.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRoute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoute.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.user_id, this.ScheduleId, this.name, this.email, this.phone, this.address, this.salary, this.status, this.BusFare});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoute.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRoute.EnableHeadersVisualStyles = false;
            this.dgvRoute.Location = new System.Drawing.Point(948, 164);
            this.dgvRoute.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRoute.Name = "dgvRoute";
            this.dgvRoute.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoute.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRoute.RowHeadersVisible = false;
            this.dgvRoute.RowHeadersWidth = 51;
            this.dgvRoute.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoute.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoute.Size = new System.Drawing.Size(724, 399);
            this.dgvRoute.TabIndex = 128;
            this.dgvRoute.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvRoute_DataBindingComplete);
            this.dgvRoute.DoubleClick += new System.EventHandler(this.dgvRoute_DoubleClick);
            // 
            // user_id
            // 
            this.user_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.user_id.DataPropertyName = "RouteId";
            this.user_id.HeaderText = "RouteId";
            this.user_id.MinimumWidth = 6;
            this.user_id.Name = "user_id";
            this.user_id.ReadOnly = true;
            this.user_id.Visible = false;
            // 
            // ScheduleId
            // 
            this.ScheduleId.DataPropertyName = "ScheduleId";
            this.ScheduleId.HeaderText = "ScheduleId";
            this.ScheduleId.MinimumWidth = 6;
            this.ScheduleId.Name = "ScheduleId";
            this.ScheduleId.ReadOnly = true;
            this.ScheduleId.Visible = false;
            this.ScheduleId.Width = 125;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "DeptLocation";
            this.name.HeaderText = "Departure";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.DataPropertyName = "Destination";
            this.email.HeaderText = "Destination";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phone.DataPropertyName = "DeptTime";
            this.phone.HeaderText = "Departure Time";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.address.DataPropertyName = "ArrivalTime";
            this.address.HeaderText = "Arrival Time";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // salary
            // 
            this.salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.salary.DataPropertyName = "BusNo";
            this.salary.HeaderText = "Bus No.";
            this.salary.MinimumWidth = 6;
            this.salary.Name = "salary";
            this.salary.ReadOnly = true;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.DataPropertyName = "Status";
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // BusFare
            // 
            this.BusFare.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BusFare.DataPropertyName = "Fare";
            this.BusFare.HeaderText = "Fare";
            this.BusFare.Name = "BusFare";
            this.BusFare.ReadOnly = true;
            // 
            // changeStatusBtn
            // 
            this.changeStatusBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changeStatusBtn.Location = new System.Drawing.Point(19, 354);
            this.changeStatusBtn.Margin = new System.Windows.Forms.Padding(4);
            this.changeStatusBtn.Name = "changeStatusBtn";
            this.changeStatusBtn.Size = new System.Drawing.Size(133, 43);
            this.changeStatusBtn.TabIndex = 131;
            this.changeStatusBtn.Text = "Change Status";
            this.changeStatusBtn.UseVisualStyleBackColor = false;
            this.changeStatusBtn.Visible = false;
            this.changeStatusBtn.Click += new System.EventHandler(this.changeStatusBtn_Click);
            // 
            // routeStatus
            // 
            this.routeStatus.AutoSize = true;
            this.routeStatus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.routeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.routeStatus.Location = new System.Drawing.Point(21, 320);
            this.routeStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.routeStatus.Name = "routeStatus";
            this.routeStatus.Size = new System.Drawing.Size(0, 29);
            this.routeStatus.TabIndex = 132;
            // 
            // invisibleScheduleIdText
            // 
            this.invisibleScheduleIdText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.invisibleScheduleIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.invisibleScheduleIdText.Location = new System.Drawing.Point(551, 409);
            this.invisibleScheduleIdText.Margin = new System.Windows.Forms.Padding(4);
            this.invisibleScheduleIdText.Name = "invisibleScheduleIdText";
            this.invisibleScheduleIdText.ReadOnly = true;
            this.invisibleScheduleIdText.Size = new System.Drawing.Size(232, 21);
            this.invisibleScheduleIdText.TabIndex = 134;
            this.invisibleScheduleIdText.Text = "";
            this.invisibleScheduleIdText.Visible = false;
            // 
            // disabledScheduleIdBox
            // 
            this.disabledScheduleIdBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.disabledScheduleIdBox.Image = ((System.Drawing.Image) (resources.GetObject("disabledScheduleIdBox.Image")));
            this.disabledScheduleIdBox.Location = new System.Drawing.Point(531, 382);
            this.disabledScheduleIdBox.Margin = new System.Windows.Forms.Padding(4);
            this.disabledScheduleIdBox.Name = "disabledScheduleIdBox";
            this.disabledScheduleIdBox.Size = new System.Drawing.Size(277, 71);
            this.disabledScheduleIdBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.disabledScheduleIdBox.TabIndex = 133;
            this.disabledScheduleIdBox.TabStop = false;
            this.disabledScheduleIdBox.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(19, 434);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 135;
            this.label2.Text = "Bus Type";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(139, 417);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 136;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(139, 491);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(223, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 139;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(59, 510);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 29);
            this.label3.TabIndex = 138;
            this.label3.Text = "Fare";
            // 
            // btnReturnRoute
            // 
            this.btnReturnRoute.BackColor = System.Drawing.SystemColors.Control;
            this.btnReturnRoute.Location = new System.Drawing.Point(548, 518);
            this.btnReturnRoute.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturnRoute.Name = "btnReturnRoute";
            this.btnReturnRoute.Size = new System.Drawing.Size(311, 50);
            this.btnReturnRoute.TabIndex = 142;
            this.btnReturnRoute.Text = "Return Routes";
            this.btnReturnRoute.UseVisualStyleBackColor = false;
            this.btnReturnRoute.Click += new System.EventHandler(this.btnReturnRoute_Click);
            // 
            // BusTypeTextField
            // 
            this.BusTypeTextField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BusTypeTextField.Location = new System.Drawing.Point(156, 439);
            this.BusTypeTextField.Margin = new System.Windows.Forms.Padding(4);
            this.BusTypeTextField.Multiline = true;
            this.BusTypeTextField.Name = "BusTypeTextField";
            this.BusTypeTextField.ReadOnly = true;
            this.BusTypeTextField.Size = new System.Drawing.Size(189, 24);
            this.BusTypeTextField.TabIndex = 143;
            // 
            // fareTextField
            // 
            this.fareTextField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fareTextField.Location = new System.Drawing.Point(156, 514);
            this.fareTextField.Margin = new System.Windows.Forms.Padding(4);
            this.fareTextField.Name = "fareTextField";
            this.fareTextField.Size = new System.Drawing.Size(168, 15);
            this.fareTextField.TabIndex = 144;
            // 
            // controlRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.fareTextField);
            this.Controls.Add(this.BusTypeTextField);
            this.Controls.Add(this.btnReturnRoute);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.invisibleScheduleIdText);
            this.Controls.Add(this.disabledScheduleIdBox);
            this.Controls.Add(this.routeStatus);
            this.Controls.Add(this.changeStatusBtn);
            this.Controls.Add(this.dgvRoute);
            this.Controls.Add(this.rtxtSearch);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.disableBusIdText);
            this.Controls.Add(this.disabledRouteIdForm);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.departureText);
            this.Controls.Add(this.departureTextFiled);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbBus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "controlRoute";
            this.Size = new System.Drawing.Size(1687, 578);
            this.Load += new System.EventHandler(this.controlRoute_Load);
            ((System.ComponentModel.ISupportInitialize) (this.departureTextFiled)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.disabledRouteIdForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgvRoute)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.disabledScheduleIdBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn BusFare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.PictureBox disabledScheduleIdBox;
        private System.Windows.Forms.RichTextBox invisibleScheduleIdText;

        private System.Windows.Forms.Label routeStatus;

        private System.Windows.Forms.Button changeStatusBtn;

        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduleId;

        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;

        private System.Windows.Forms.PictureBox pictureBox8;

        private System.Windows.Forms.RichTextBox rtxtSearch;

        private System.Windows.Forms.DataGridView dgvRoute;

        private System.Windows.Forms.DataGridView dgvUser;

        //private System.Windows.Forms.DataGridView dgvUser;

        private System.Windows.Forms.RichTextBox disableBusIdText;

        private System.Windows.Forms.PictureBox disabledRouteIdForm;

        private System.Windows.Forms.RichTextBox departureText;

        private System.Windows.Forms.PictureBox departureTextFiled;

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbBus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        /*private System.Windows.Forms.RichTextBox rtxtSearch;
        private System.Windows.Forms.PictureBox pictureBox8;*/
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReturnRoute;
        private System.Windows.Forms.TextBox BusTypeTextField;
        private System.Windows.Forms.TextBox fareTextField;
        //private System.Windows.Forms.DataGridView dgvUser;
        /*private System.Windows.Forms.DataGridViewTextBoxColumn dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.ComboBox comboBox1;*/
    }
}
