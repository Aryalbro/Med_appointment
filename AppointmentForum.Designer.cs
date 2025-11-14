namespace AppointmentUI
{
    partial class AppointmentForum
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
            goBackLabel = new LinkLabel();
            continueLabel = new LinkLabel();
            dateTimePickerStarttime = new DateTimePicker();
            numericUpDownDuration = new NumericUpDown();
            reasonVisitBox = new TextBox();
            appointmentStatusComboBox = new ComboBox();
            startTimeLabel = new Label();
            durationLabel = new Label();
            reasonVisitTypeLabel = new Label();
            appointmentStatusLabel = new Label();
            emergencyContactLabel = new Label();
            emergencyContactTextBox = new TextBox();
            headsUPLabel = new Label();
            headsUPText = new TextBox();
            saveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDuration).BeginInit();
            SuspendLayout();
            // 
            // clinicNameLAbel
            // 
            clinicNameLAbel.AutoSize = true;
            clinicNameLAbel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clinicNameLAbel.Location = new Point(281, 9);
            clinicNameLAbel.Name = "clinicNameLAbel";
            clinicNameLAbel.Size = new Size(284, 30);
            clinicNameLAbel.TabIndex = 1;
            clinicNameLAbel.Text = "ItsAllGoodMan Clinic and Co.";
            // 
            // goBackLabel
            // 
            goBackLabel.AutoSize = true;
            goBackLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            goBackLabel.Location = new Point(26, 396);
            goBackLabel.Name = "goBackLabel";
            goBackLabel.Size = new Size(66, 21);
            goBackLabel.TabIndex = 3;
            goBackLabel.TabStop = true;
            goBackLabel.Text = "Go Back";
            // 
            // continueLabel
            // 
            continueLabel.AutoSize = true;
            continueLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            continueLabel.Location = new Point(692, 396);
            continueLabel.Name = "continueLabel";
            continueLabel.Size = new Size(73, 21);
            continueLabel.TabIndex = 4;
            continueLabel.TabStop = true;
            continueLabel.Text = "Continue";
            // 
            // dateTimePickerStarttime
            // 
            dateTimePickerStarttime.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerStarttime.Location = new Point(358, 55);
            dateTimePickerStarttime.Name = "dateTimePickerStarttime";
            dateTimePickerStarttime.Size = new Size(213, 23);
            dateTimePickerStarttime.TabIndex = 5;
            dateTimePickerStarttime.Value = new DateTime(2025, 10, 8, 0, 0, 0, 0);
            // 
            // numericUpDownDuration
            // 
            numericUpDownDuration.Location = new Point(358, 112);
            numericUpDownDuration.Name = "numericUpDownDuration";
            numericUpDownDuration.Size = new Size(213, 23);
            numericUpDownDuration.TabIndex = 6;
            // 
            // reasonVisitBox
            // 
            reasonVisitBox.Location = new Point(358, 161);
            reasonVisitBox.Name = "reasonVisitBox";
            reasonVisitBox.Size = new Size(213, 23);
            reasonVisitBox.TabIndex = 7;
            // 
            // appointmentStatusComboBox
            // 
            appointmentStatusComboBox.FormattingEnabled = true;
            appointmentStatusComboBox.Location = new Point(358, 222);
            appointmentStatusComboBox.Name = "appointmentStatusComboBox";
            appointmentStatusComboBox.Size = new Size(213, 23);
            appointmentStatusComboBox.TabIndex = 8;
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startTimeLabel.Location = new Point(202, 57);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new Size(83, 21);
            startTimeLabel.TabIndex = 9;
            startTimeLabel.Text = "Start Time:";
            startTimeLabel.Click += label1_Click;
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            durationLabel.Location = new Point(202, 112);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(74, 21);
            durationLabel.TabIndex = 13;
            durationLabel.Text = "Duration:";
            durationLabel.Click += label1_Click_1;
            // 
            // reasonVisitTypeLabel
            // 
            reasonVisitTypeLabel.AutoSize = true;
            reasonVisitTypeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reasonVisitTypeLabel.Location = new Point(202, 163);
            reasonVisitTypeLabel.Name = "reasonVisitTypeLabel";
            reasonVisitTypeLabel.Size = new Size(136, 21);
            reasonVisitTypeLabel.TabIndex = 14;
            reasonVisitTypeLabel.Text = "Reason/Visit Type:";
            // 
            // appointmentStatusLabel
            // 
            appointmentStatusLabel.AutoSize = true;
            appointmentStatusLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appointmentStatusLabel.Location = new Point(202, 224);
            appointmentStatusLabel.Name = "appointmentStatusLabel";
            appointmentStatusLabel.Size = new Size(150, 21);
            appointmentStatusLabel.TabIndex = 15;
            appointmentStatusLabel.Text = "Appointment Status:";
            appointmentStatusLabel.Click += label3_Click;
            // 
            // emergencyContactLabel
            // 
            emergencyContactLabel.AutoSize = true;
            emergencyContactLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emergencyContactLabel.Location = new Point(202, 272);
            emergencyContactLabel.Name = "emergencyContactLabel";
            emergencyContactLabel.Size = new Size(147, 21);
            emergencyContactLabel.TabIndex = 17;
            emergencyContactLabel.Text = "Emergency Contact:";
            // 
            // emergencyContactTextBox
            // 
            emergencyContactTextBox.Location = new Point(358, 270);
            emergencyContactTextBox.Name = "emergencyContactTextBox";
            emergencyContactTextBox.Size = new Size(213, 23);
            emergencyContactTextBox.TabIndex = 16;
            // 
            // headsUPLabel
            // 
            headsUPLabel.AutoSize = true;
            headsUPLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headsUPLabel.Location = new Point(202, 326);
            headsUPLabel.Name = "headsUPLabel";
            headsUPLabel.Size = new Size(80, 21);
            headsUPLabel.TabIndex = 19;
            headsUPLabel.Text = "Heads Up:";
            // 
            // headsUPText
            // 
            headsUPText.Location = new Point(358, 324);
            headsUPText.Name = "headsUPText";
            headsUPText.Size = new Size(213, 23);
            headsUPText.TabIndex = 18;
            // 
            // saveButton
            // 
            saveButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveButton.Location = new Point(358, 396);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(105, 39);
            saveButton.TabIndex = 20;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // AppointmentForum
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 440);
            Controls.Add(saveButton);
            Controls.Add(headsUPLabel);
            Controls.Add(headsUPText);
            Controls.Add(emergencyContactLabel);
            Controls.Add(emergencyContactTextBox);
            Controls.Add(appointmentStatusLabel);
            Controls.Add(reasonVisitTypeLabel);
            Controls.Add(durationLabel);
            Controls.Add(startTimeLabel);
            Controls.Add(appointmentStatusComboBox);
            Controls.Add(reasonVisitBox);
            Controls.Add(numericUpDownDuration);
            Controls.Add(dateTimePickerStarttime);
            Controls.Add(continueLabel);
            Controls.Add(goBackLabel);
            Controls.Add(clinicNameLAbel);
            Name = "AppointmentForum";
            Text = "AppointmentForum";
            ((System.ComponentModel.ISupportInitialize)numericUpDownDuration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label clinicNameLAbel;
        private LinkLabel goBackLabel;
        private LinkLabel continueLabel;
        private DateTimePicker dateTimePickerStarttime;
        private NumericUpDown numericUpDownDuration;
        private TextBox reasonVisitBox;
        private ComboBox appointmentStatusComboBox;
        private Label startTimeLabel;
        private Label durationLabel;
        private Label reasonVisitTypeLabel;
        private Label appointmentStatusLabel;
        private Label emergencyContactLabel;
        private TextBox emergencyContactTextBox;
        private Label headsUPLabel;
        private TextBox headsUPText;
        private Button saveButton;
    }
}