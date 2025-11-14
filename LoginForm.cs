using System;
using System.Windows.Forms;

namespace AppointmentUI
{
    public partial class LoginForm : Form
    {
        private readonly PostgresDataConnection _db = new PostgresDataConnection();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Test DB and initialize schema
            if (_db.TestConnection())
            {
                lblStatus.Text = "Database connected.";
            }
            else
            {
                lblStatus.Text = "Database connection failed.";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Username and password are required.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int userId = _db.Login(username, password);

                if (userId > 0)
                {
                    MessageBox.Show(
                        "Login successful!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // Open main patients form after login
                    var pf = new PatientsForm();
                    pf.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(
                        "Invalid username or password.",
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch
            {
                // Error messages are already shown by DB layer.
            }
        }

        private void btnOpenRegister_Click(object sender, EventArgs e)
        {
            using (var reg = new RegisterForm())
            {
                if (reg.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show(
                        "Registration successful. You can now log in.",
                        "Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }
    }
}
