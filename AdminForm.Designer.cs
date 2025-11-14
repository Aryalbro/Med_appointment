namespace AppointmentUI
{
    partial class AdminForm
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
            logInButton = new Button();
            userNameLabel = new Label();
            userNameTextBox = new TextBox();
            passWordLabel = new Label();
            passWordText = new TextBox();
            logInGroupBox = new GroupBox();
            goBackLabel = new LinkLabel();
            continueLabel = new LinkLabel();
            logInGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // clinicNameLAbel
            // 
            clinicNameLAbel.AutoSize = true;
            clinicNameLAbel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clinicNameLAbel.Location = new Point(227, 18);
            clinicNameLAbel.Name = "clinicNameLAbel";
            clinicNameLAbel.Size = new Size(284, 30);
            clinicNameLAbel.TabIndex = 1;
            clinicNameLAbel.Text = "ItsAllGoodMan Clinic and Co.";
            // 
            // logInButton
            // 
            logInButton.Location = new Point(71, 143);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(105, 39);
            logInButton.TabIndex = 0;
            logInButton.Text = "Log In";
            logInButton.UseVisualStyleBackColor = true;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(15, 41);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(46, 15);
            userNameLabel.TabIndex = 1;
            userNameLabel.Text = "Admin:";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(100, 41);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(142, 23);
            userNameTextBox.TabIndex = 2;
            // 
            // passWordLabel
            // 
            passWordLabel.AutoSize = true;
            passWordLabel.Location = new Point(15, 85);
            passWordLabel.Name = "passWordLabel";
            passWordLabel.Size = new Size(60, 15);
            passWordLabel.TabIndex = 3;
            passWordLabel.Text = "Password:";
            // 
            // passWordText
            // 
            passWordText.Location = new Point(95, 85);
            passWordText.Name = "passWordText";
            passWordText.Size = new Size(142, 23);
            passWordText.TabIndex = 4;
            // 
            // logInGroupBox
            // 
            logInGroupBox.Controls.Add(passWordText);
            logInGroupBox.Controls.Add(passWordLabel);
            logInGroupBox.Controls.Add(userNameTextBox);
            logInGroupBox.Controls.Add(userNameLabel);
            logInGroupBox.Controls.Add(logInButton);
            logInGroupBox.ForeColor = SystemColors.MenuHighlight;
            logInGroupBox.Location = new Point(274, 104);
            logInGroupBox.Name = "logInGroupBox";
            logInGroupBox.Size = new Size(277, 222);
            logInGroupBox.TabIndex = 2;
            logInGroupBox.TabStop = false;
            logInGroupBox.Text = "Admin page";
            // 
            // goBackLabel
            // 
            goBackLabel.AutoSize = true;
            goBackLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            goBackLabel.Location = new Point(12, 420);
            goBackLabel.Name = "goBackLabel";
            goBackLabel.Size = new Size(66, 21);
            goBackLabel.TabIndex = 8;
            goBackLabel.TabStop = true;
            goBackLabel.Text = "Go Back";
            // 
            // continueLabel
            // 
            continueLabel.AutoSize = true;
            continueLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            continueLabel.Location = new Point(715, 420);
            continueLabel.Name = "continueLabel";
            continueLabel.Size = new Size(73, 21);
            continueLabel.TabIndex = 7;
            continueLabel.TabStop = true;
            continueLabel.Text = "Continue";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(goBackLabel);
            Controls.Add(continueLabel);
            Controls.Add(logInGroupBox);
            Controls.Add(clinicNameLAbel);
            Name = "AdminForm";
            Text = "AdminForm";
            logInGroupBox.ResumeLayout(false);
            logInGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label clinicNameLAbel;
        private Button logInButton;
        private Label userNameLabel;
        private TextBox userNameTextBox;
        private Label passWordLabel;
        private TextBox passWordText;
        private GroupBox logInGroupBox;
        private LinkLabel goBackLabel;
        private LinkLabel continueLabel;
    }
}