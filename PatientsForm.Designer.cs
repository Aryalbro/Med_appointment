namespace AppointmentUI
{
    partial class PatientsForm
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
            components = new System.ComponentModel.Container();
            clinicNameLAbel = new Label();
            continueLabel = new LinkLabel();
            goBackLabel = new LinkLabel();
            label1 = new Label();
            label3 = new Label();
            itsAllGoodMangroupBox = new GroupBox();
            label4 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            groupBox = new GroupBox();
            label2 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            label7 = new Label();
            appointmentStatusComboBox = new ComboBox();
            dateTimePickerStarttime = new DateTimePicker();
            label8 = new Label();
            headsUPLabel = new Label();
            headsUPText = new TextBox();
            checkBox1 = new CheckBox();
            label9 = new Label();
            passWordText = new TextBox();
            passWordLabel = new Label();
            userNameTextBox = new TextBox();
            userNameLabel = new Label();
            logInButton = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            itsAllGoodMangroupBox.SuspendLayout();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // clinicNameLAbel
            // 
            clinicNameLAbel.AutoSize = true;
            clinicNameLAbel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clinicNameLAbel.Location = new Point(203, 0);
            clinicNameLAbel.Name = "clinicNameLAbel";
            clinicNameLAbel.Size = new Size(284, 30);
            clinicNameLAbel.TabIndex = 2;
            clinicNameLAbel.Text = "ItsAllGoodMan Clinic and Co.";
            // 
            // continueLabel
            // 
            continueLabel.AutoSize = true;
            continueLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            continueLabel.Location = new Point(727, 475);
            continueLabel.Name = "continueLabel";
            continueLabel.Size = new Size(73, 21);
            continueLabel.TabIndex = 5;
            continueLabel.TabStop = true;
            continueLabel.Text = "Continue";
            // 
            // goBackLabel
            // 
            goBackLabel.AutoSize = true;
            goBackLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            goBackLabel.Location = new Point(24, 475);
            goBackLabel.Name = "goBackLabel";
            goBackLabel.Size = new Size(66, 21);
            goBackLabel.TabIndex = 6;
            goBackLabel.TabStop = true;
            goBackLabel.Text = "Go Back";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(1, 97);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 9;
            label1.Text = "Full Name";
            label1.Click += label1_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(204, 97);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 10;
            label3.Text = "Contact";
            // 
            // itsAllGoodMangroupBox
            // 
            itsAllGoodMangroupBox.Controls.Add(headsUPLabel);
            itsAllGoodMangroupBox.Controls.Add(headsUPText);
            itsAllGoodMangroupBox.Controls.Add(label8);
            itsAllGoodMangroupBox.Controls.Add(dateTimePickerStarttime);
            itsAllGoodMangroupBox.Controls.Add(appointmentStatusComboBox);
            itsAllGoodMangroupBox.Controls.Add(label7);
            itsAllGoodMangroupBox.Controls.Add(textBox4);
            itsAllGoodMangroupBox.Controls.Add(label5);
            itsAllGoodMangroupBox.Controls.Add(groupBox);
            itsAllGoodMangroupBox.Controls.Add(comboBox1);
            itsAllGoodMangroupBox.Controls.Add(textBox3);
            itsAllGoodMangroupBox.Controls.Add(textBox2);
            itsAllGoodMangroupBox.Controls.Add(textBox1);
            itsAllGoodMangroupBox.Controls.Add(label6);
            itsAllGoodMangroupBox.Controls.Add(label4);
            itsAllGoodMangroupBox.Controls.Add(label3);
            itsAllGoodMangroupBox.Controls.Add(clinicNameLAbel);
            itsAllGoodMangroupBox.Controls.Add(label1);
            itsAllGoodMangroupBox.Location = new Point(24, 12);
            itsAllGoodMangroupBox.Name = "itsAllGoodMangroupBox";
            itsAllGoodMangroupBox.Size = new Size(776, 444);
            itsAllGoodMangroupBox.TabIndex = 11;
            itsAllGoodMangroupBox.TabStop = false;
            itsAllGoodMangroupBox.Text = "ItsAllGoodMan Clinic Internal";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(658, 97);
            label4.Name = "label4";
            label4.Size = new Size(72, 25);
            label4.TabIndex = 11;
            label4.Text = "Policy#";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(438, 97);
            label6.Name = "label6";
            label6.Size = new Size(94, 25);
            label6.TabIndex = 13;
            label6.Text = "Insurance";
            label6.Click += label6_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(7, 136);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 23);
            textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(189, 136);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 23);
            textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(606, 136);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(165, 23);
            textBox3.TabIndex = 16;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(377, 136);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(223, 23);
            comboBox1.TabIndex = 17;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(logInButton);
            groupBox.Controls.Add(passWordText);
            groupBox.Controls.Add(passWordLabel);
            groupBox.Controls.Add(userNameTextBox);
            groupBox.Controls.Add(userNameLabel);
            groupBox.Controls.Add(label9);
            groupBox.Controls.Add(checkBox1);
            groupBox.Controls.Add(label2);
            groupBox.Location = new Point(7, 276);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(764, 158);
            groupBox.TabIndex = 26;
            groupBox.TabStop = false;
            groupBox.Text = "Edit/Add Patients";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 27);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(7, 214);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(165, 23);
            textBox4.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(0, 175);
            label5.Name = "label5";
            label5.Size = new Size(175, 25);
            label5.TabIndex = 27;
            label5.Text = "Emergency Contact";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(197, 175);
            label7.Name = "label7";
            label7.Size = new Size(168, 25);
            label7.TabIndex = 29;
            label7.Text = "Appointment date:";
            label7.Click += this.label7_Click;
            // 
            // appointmentStatusComboBox
            // 
            appointmentStatusComboBox.FormattingEnabled = true;
            appointmentStatusComboBox.Location = new Point(393, 214);
            appointmentStatusComboBox.Name = "appointmentStatusComboBox";
            appointmentStatusComboBox.Size = new Size(175, 23);
            appointmentStatusComboBox.TabIndex = 30;
            appointmentStatusComboBox.SelectedIndexChanged += appointmentStatusComboBox_SelectedIndexChanged;
            // 
            // dateTimePickerStarttime
            // 
            dateTimePickerStarttime.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerStarttime.Location = new Point(189, 214);
            dateTimePickerStarttime.Name = "dateTimePickerStarttime";
            dateTimePickerStarttime.Size = new Size(192, 23);
            dateTimePickerStarttime.TabIndex = 31;
            dateTimePickerStarttime.Value = new DateTime(2025, 10, 8, 0, 0, 0, 0);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(377, 175);
            label8.Name = "label8";
            label8.Size = new Size(181, 25);
            label8.TabIndex = 30;
            label8.Text = "Appointment Status:";
            // 
            // headsUPLabel
            // 
            headsUPLabel.AutoSize = true;
            headsUPLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headsUPLabel.Location = new Point(628, 179);
            headsUPLabel.Name = "headsUPLabel";
            headsUPLabel.Size = new Size(80, 21);
            headsUPLabel.TabIndex = 33;
            headsUPLabel.Text = "Heads Up:";
            // 
            // headsUPText
            // 
            headsUPText.Location = new Point(581, 214);
            headsUPText.Name = "headsUPText";
            headsUPText.Size = new Size(181, 23);
            headsUPText.TabIndex = 32;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(241, 23);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 1;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(92, 23);
            label9.Name = "label9";
            label9.Size = new Size(130, 15);
            label9.TabIndex = 2;
            label9.Text = "Confirm Appointment?";
            // 
            // passWordText
            // 
            passWordText.Location = new Point(160, 110);
            passWordText.Name = "passWordText";
            passWordText.Size = new Size(142, 23);
            passWordText.TabIndex = 8;
            // 
            // passWordLabel
            // 
            passWordLabel.AutoSize = true;
            passWordLabel.Location = new Point(75, 113);
            passWordLabel.Name = "passWordLabel";
            passWordLabel.Size = new Size(60, 15);
            passWordLabel.TabIndex = 7;
            passWordLabel.Text = "Password:";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(160, 69);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(142, 23);
            userNameTextBox.TabIndex = 6;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(75, 69);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(68, 15);
            userNameLabel.TabIndex = 5;
            userNameLabel.Text = "User Name:";
            // 
            // logInButton
            // 
            logInButton.Location = new Point(375, 89);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(105, 39);
            logInButton.TabIndex = 12;
            logInButton.Text = "Log In and Confirm";
            logInButton.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 26);
            // 
            // PatientsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 505);
            Controls.Add(itsAllGoodMangroupBox);
            Controls.Add(goBackLabel);
            Controls.Add(continueLabel);
            Name = "PatientsForm";
            Text = "PatientsForm";
            itsAllGoodMangroupBox.ResumeLayout(false);
            itsAllGoodMangroupBox.PerformLayout();
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label clinicNameLAbel;
        private LinkLabel continueLabel;
        private LinkLabel goBackLabel;
        private Label label1;
        private Label label3;
        private GroupBox itsAllGoodMangroupBox;
        private Label label6;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private GroupBox groupBox;
        private ComboBox comboBox1;
        private Label label7;
        private TextBox textBox4;
        private Label label5;
        private Label label2;
        private ComboBox appointmentStatusComboBox;
        private DateTimePicker dateTimePickerStarttime;
        private Label label8;
        private Label headsUPLabel;
        private TextBox headsUPText;
        private Label label9;
        private CheckBox checkBox1;
        private TextBox passWordText;
        private Label passWordLabel;
        private TextBox userNameTextBox;
        private Label userNameLabel;
        private Button logInButton;
        private ContextMenuStrip contextMenuStrip1;
    }
}