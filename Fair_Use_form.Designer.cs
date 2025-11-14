namespace AppointmentUI
{
    partial class Fair_Use_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fair_Use_form));
            complianceHIPPA = new RichTextBox();
            acknowledgeCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // complianceHIPPA
            // 
            complianceHIPPA.Dock = DockStyle.Fill;
            complianceHIPPA.Location = new Point(0, 0);
            complianceHIPPA.Name = "complianceHIPPA";
            complianceHIPPA.ReadOnly = true;
            complianceHIPPA.Size = new Size(800, 450);
            complianceHIPPA.TabIndex = 0;
            complianceHIPPA.Text = resources.GetString("complianceHIPPA.Text");
            complianceHIPPA.TextChanged += richTextBox1_TextChanged;
            // 
            // acknowledgeCheckBox
            // 
            acknowledgeCheckBox.AutoSize = true;
            acknowledgeCheckBox.Location = new Point(303, 344);
            acknowledgeCheckBox.Name = "acknowledgeCheckBox";
            acknowledgeCheckBox.Size = new Size(154, 19);
            acknowledgeCheckBox.TabIndex = 1;
            acknowledgeCheckBox.Text = "I read and acknowledge.";
            acknowledgeCheckBox.UseVisualStyleBackColor = true;
            acknowledgeCheckBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Fair_Use_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(acknowledgeCheckBox);
            Controls.Add(complianceHIPPA);
            Name = "Fair_Use_form";
            Text = "Fair_Use_form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox complianceHIPPA;
        private CheckBox acknowledgeCheckBox;
    }
}