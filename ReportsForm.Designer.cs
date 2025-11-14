namespace AppointmentUI
{
    partial class ReportsForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dateTimePickerStarttime = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            comboBox1 = new ComboBox();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkLabel4 = new LinkLabel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 28);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 0;
            label1.Text = "Reports/Daily Summary";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 58);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Date from:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(165, 89);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 2;
            label3.Text = "to";
            // 
            // dateTimePickerStarttime
            // 
            dateTimePickerStarttime.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerStarttime.Location = new Point(108, 52);
            dateTimePickerStarttime.Name = "dateTimePickerStarttime";
            dateTimePickerStarttime.Size = new Size(192, 23);
            dateTimePickerStarttime.TabIndex = 32;
            dateTimePickerStarttime.Value = new DateTime(2025, 10, 8, 0, 0, 0, 0);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(108, 121);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(192, 23);
            dateTimePicker1.TabIndex = 33;
            dateTimePicker1.Value = new DateTime(2025, 10, 8, 0, 0, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(368, 121);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 34;
            label4.Text = "Provider";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 36);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 35;
            label5.Text = "Total";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(277, 36);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 36;
            label6.Text = "Arrived";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker3);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(30, 170);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(744, 126);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            groupBox1.Text = "Metrics (Today)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 71);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 38;
            label7.Text = "Completed";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(271, 71);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 39;
            label8.Text = "No-Show";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(500, 36);
            label9.Name = "label9";
            label9.Size = new Size(61, 15);
            label9.TabIndex = 40;
            label9.Text = "Room No.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(493, 74);
            label10.Name = "label10";
            label10.Size = new Size(58, 15);
            label10.TabIndex = 41;
            label10.Text = "Avg Time";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(77, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(157, 23);
            textBox1.TabIndex = 42;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(78, 67);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(156, 23);
            textBox2.TabIndex = 43;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(338, 71);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(149, 23);
            textBox4.TabIndex = 45;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(564, 33);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(166, 23);
            textBox5.TabIndex = 46;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker2.Location = new Point(564, 71);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(174, 23);
            dateTimePicker2.TabIndex = 47;
            dateTimePicker2.Value = new DateTime(2025, 10, 8, 0, 0, 0, 0);
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker3.Location = new Point(341, 33);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(146, 23);
            dateTimePicker3.TabIndex = 48;
            dateTimePicker3.Value = new DateTime(2025, 10, 8, 0, 0, 0, 0);
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(449, 121);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(223, 23);
            comboBox1.TabIndex = 38;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(12, 412);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(58, 15);
            linkLabel1.TabIndex = 39;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "First Page";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(708, 412);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(32, 15);
            linkLabel2.TabIndex = 40;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Back";
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(708, 28);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(53, 15);
            linkLabel3.TabIndex = 41;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "lLog Out";
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.Location = new Point(714, 89);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(64, 15);
            linkLabel4.TabIndex = 42;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "Export CSV";
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel4);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(comboBox1);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(dateTimePickerStarttime);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ReportsForm";
            Text = "ReportsForm";
            Load += ReportsForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePickerStarttime;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private Label label7;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label10;
        private Label label9;
        private Label label8;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker2;
        private ComboBox comboBox1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel4;
    }
}