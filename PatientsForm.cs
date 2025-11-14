using System;
using System.Windows.Forms;

namespace AppointmentUI
{
    public partial class PatientsForm : Form
    {
        private readonly PostgresDataConnection _db = new PostgresDataConnection();

        public PatientsForm()
        {
            InitializeComponent();

            // Wire up the click handler for the button defined in the Designer
            logInButton.Click += logInButton_Click;

            // ✅ Populate appointment status dropdown
            appointmentStatusComboBox.Items.Clear();
            appointmentStatusComboBox.Items.AddRange(new object[]
            {
                "Scheduled",
                "Confirmed",
                "Completed",
                "Cancelled"
            });
            if (appointmentStatusComboBox.Items.Count > 0)
            {
                appointmentStatusComboBox.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Saves the patient + appointment info to the database using sp_add_patient.
        /// Note: textBox1–4 map to your UI fields (Full Name, Contact, Insurance, Policy#).
        /// </summary>
        private void logInButton_Click(object? sender, EventArgs e)
        {
            string fullName = textBox1.Text.Trim();      // Full Name
            string contact  = textBox2.Text.Trim();      // Contact
            string insurance = textBox3.Text.Trim();     // Insurance
            string policy    = textBox4.Text.Trim();     // Policy#
            DateTime appointmentDate = dateTimePickerStarttime.Value;

            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show(
                    "Full name is required.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // We just pass four strings; DB doesn't care what they semantically mean.
                int newId = _db.AddPatient(fullName, contact, insurance, policy, appointmentDate);

                MessageBox.Show(
                    $"Patient saved successfully with ID: {newId}",
                    "Saved",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch
            {
                // The database layer already shows an error dialog,
                // so we don't need to do anything else here.
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            // No action needed.
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            // No action needed for now.
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // No action needed for now.
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Could add validation for Insurance if you want.
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            // Not used.
        }

        private void appointmentStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // You can later save this status into a separate table/column if needed.
        }
    }
}
