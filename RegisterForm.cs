using System;
using System.Windows.Forms;

namespace AppointmentUI
{
    public partial class RegisterForm : Form
    {
        private readonly PostgresDataConnection _db = new PostgresDataConnection();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirm  = txtConfirm.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirm))
            {
                MessageBox.Show(
                    "All fields are required.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show(
                    "Passwords do not match.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int result = _db.RegisterUser(username, password);

                if (result == -1)
                {
                    MessageBox.Show(
                        "This username is already taken. Please choose another.",
                        "Registration Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "Registration successful! You can now log in.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch
            {
                // DB layer already shows detailed error.
            }
        }
    }
}
