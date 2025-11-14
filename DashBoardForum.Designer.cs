namespace AppointmentUI
{
    partial class DashBoardForum
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
            clinicNameLAbel = new Label();
            continueLabel = new LinkLabel();
            logOutLabel = new LinkLabel();
            dateLabel = new Label();
            userNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            firstNameLabel = new Label();
            textBox2 = new TextBox();
            lastNameLabel = new Label();
            providerLabel = new Label();
            InsuranceIDTextBox = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            dataGridViewAppointments = new DataGridView();
            appointmentTodayLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointments).BeginInit();
            SuspendLayout();
            // 
            // clinicNameLAbel
            // 
            clinicNameLAbel.AutoSize = true;
            clinicNameLAbel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clinicNameLAbel.Location = new Point(238, 9);
            clinicNameLAbel.Name = "clinicNameLAbel";
            clinicNameLAbel.Size = new Size(284, 30);
            clinicNameLAbel.TabIndex = 0;
            clinicNameLAbel.Text = "ItsAllGoodMan Clinic and Co.";
            // 
            // continueLabel
            // 
            continueLabel.AutoSize = true;
            continueLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            continueLabel.Location = new Point(715, 420);
            continueLabel.Name = "continueLabel";
            continueLabel.Size = new Size(73, 21);
            continueLabel.TabIndex = 1;
            continueLabel.TabStop = true;
            continueLabel.Text = "Continue";
            // 
            // logOutLabel
            // 
            logOutLabel.AutoSize = true;
            logOutLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logOutLabel.Location = new Point(662, 20);
            logOutLabel.Name = "logOutLabel";
            logOutLabel.Size = new Size(66, 21);
            logOutLabel.TabIndex = 2;
            logOutLabel.TabStop = true;
            logOutLabel.Text = "Log Out";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateLabel.Location = new Point(56, 67);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(45, 21);
            dateLabel.TabIndex = 3;
            dateLabel.Text = "Date:";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(142, 67);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(142, 23);
            userNameTextBox.TabIndex = 4;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(142, 111);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(142, 23);
            firstNameTextBox.TabIndex = 6;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameLabel.Location = new Point(47, 111);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(89, 21);
            firstNameLabel.TabIndex = 5;
            firstNameLabel.Text = "First Name:";
            firstNameLabel.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(142, 160);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(142, 23);
            textBox2.TabIndex = 8;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameLabel.Location = new Point(47, 162);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(87, 21);
            lastNameLabel.TabIndex = 7;
            lastNameLabel.Text = "Last Name:";
            // 
            // providerLabel
            // 
            providerLabel.AutoSize = true;
            providerLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            providerLabel.Location = new Point(417, 69);
            providerLabel.Name = "providerLabel";
            providerLabel.Size = new Size(69, 21);
            providerLabel.TabIndex = 9;
            providerLabel.Text = "Provider";
            // 
            // InsuranceIDTextBox
            // 
            InsuranceIDTextBox.Location = new Point(505, 136);
            InsuranceIDTextBox.Name = "InsuranceIDTextBox";
            InsuranceIDTextBox.Size = new Size(223, 23);
            InsuranceIDTextBox.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(387, 134);
            label4.Name = "label4";
            label4.Size = new Size(99, 21);
            label4.TabIndex = 11;
            label4.Text = "Insurance ID:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(505, 71);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(223, 23);
            comboBox1.TabIndex = 15;
            // 
            // dataGridViewAppointments
            // 
            dataGridViewAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAppointments.Location = new Point(56, 253);
            dataGridViewAppointments.Name = "dataGridViewAppointments";
            dataGridViewAppointments.Size = new Size(653, 185);
            dataGridViewAppointments.TabIndex = 16;
            // 
            // appointmentTodayLabel
            // 
            appointmentTodayLabel.AutoSize = true;
            appointmentTodayLabel.Location = new Point(67, 226);
            appointmentTodayLabel.Name = "appointmentTodayLabel";
            appointmentTodayLabel.Size = new Size(126, 15);
            appointmentTodayLabel.TabIndex = 17;
            appointmentTodayLabel.Text = "Today's Appointments";
            appointmentTodayLabel.Click += label1_Click_1;
            // 
            // DashBoardForum
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(appointmentTodayLabel);
            Controls.Add(dataGridViewAppointments);
            Controls.Add(comboBox1);
            Controls.Add(InsuranceIDTextBox);
            Controls.Add(label4);
            Controls.Add(providerLabel);
            Controls.Add(textBox2);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameTextBox);
            Controls.Add(firstNameLabel);
            Controls.Add(userNameTextBox);
            Controls.Add(dateLabel);
            Controls.Add(logOutLabel);
            Controls.Add(continueLabel);
            Controls.Add(clinicNameLAbel);
            Name = "DashBoardForum";
            Text = "DashBoardForum";
            Load += DashBoardForum_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label clinicNameLAbel;
        private LinkLabel continueLabel;
        private LinkLabel logOutLabel;
        private Label dateLabel;
        private TextBox userNameTextBox;
        private TextBox firstNameTextBox;
        private Label firstNameLabel;
        private TextBox textBox2;
        private Label lastNameLabel;
        private Label providerLabel;
        private TextBox InsuranceIDTextBox;
        private Label label4;
        private ComboBox comboBox1;
        private DataGridView dataGridViewAppointments;
        private Label appointmentTodayLabel;
    }
}