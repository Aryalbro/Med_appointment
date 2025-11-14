using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace AppointmentUI
{
    /// <summary>
    /// Handles all database operations against SQL Server.
    /// Auto-creates tables and stored procedures on first use.
    /// </summary>
    public class PostgresDataConnection : IDataConnection
    {
        // 👉 Adjust ONLY this line if your instance name is different.
        // If you are using SQLEXPRESS, use:
        // "Server=localhost\\SQLEXPRESS;Database=MedicalAppointment;Trusted_Connection=True;TrustServerCertificate=True;";
        private readonly string _connectionString =
            "Server=localhost;Database=MedicalAppointment;Trusted_Connection=True;TrustServerCertificate=True;";

        private bool _isInitialized = false;

        /// <summary>
        /// Ensure that required tables and stored procedures exist.
        /// This runs once per application lifetime.
        /// </summary>
        private void EnsureDatabaseSetup()
        {
            if (_isInitialized)
                return;

            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();

                // 1) Create tables in ONE batch (no procedures here)
                string tableSql = @"
IF OBJECT_ID('dbo.Users', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Users (
        UserId   INT IDENTITY(1,1) PRIMARY KEY,
        Username NVARCHAR(100) NOT NULL UNIQUE,
        [Password] NVARCHAR(100) NOT NULL
    );
END;

IF OBJECT_ID('dbo.Patients', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Patients (
        PatientId       INT IDENTITY(1,1) PRIMARY KEY,
        FirstName       NVARCHAR(200) NOT NULL,
        LastName        NVARCHAR(200) NOT NULL,
        Phone           NVARCHAR(50) NULL,
        Email           NVARCHAR(200) NULL,
        AppointmentDate DATE NULL
    );
END;

IF OBJECT_ID('dbo.Appointments', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Appointments (
        AppointmentId INT IDENTITY(1,1) PRIMARY KEY,
        PatientId     INT NOT NULL FOREIGN KEY REFERENCES dbo.Patients(PatientId),
        DoctorName    NVARCHAR(200) NULL,
        Status        NVARCHAR(50) NULL,
        Notes         NVARCHAR(MAX) NULL
    );
END;
";
                using (var tableCmd = new SqlCommand(tableSql, conn))
                {
                    tableCmd.ExecuteNonQuery();
                }

                // 2) Create/alter stored procedures in SEPARATE commands

                string spRegisterSql = @"
CREATE OR ALTER PROCEDURE dbo.sp_register_user
    @p_username NVARCHAR(100),
    @p_password NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM dbo.Users WHERE Username = @p_username)
    BEGIN
        -- Username already exists
        SELECT CAST(-1 AS INT);
        RETURN;
    END

    INSERT INTO dbo.Users (Username, [Password])
    VALUES (@p_username, @p_password);

    SELECT CAST(SCOPE_IDENTITY() AS INT);
END;
";
                using (var spRegCmd = new SqlCommand(spRegisterSql, conn))
                {
                    spRegCmd.ExecuteNonQuery();
                }

                string spLoginSql = @"
CREATE OR ALTER PROCEDURE dbo.sp_login
    @p_username NVARCHAR(100),
    @p_password NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @uid INT;

    SELECT @uid = UserId
    FROM dbo.Users
    WHERE Username = @p_username
      AND [Password] = @p_password;

    IF @uid IS NULL
        SELECT CAST(-1 AS INT);
    ELSE
        SELECT @uid;
END;
";
                using (var spLoginCmd = new SqlCommand(spLoginSql, conn))
                {
                    spLoginCmd.ExecuteNonQuery();
                }

                string spAddPatientSql = @"
CREATE OR ALTER PROCEDURE dbo.sp_add_patient
    @p_first_name       NVARCHAR(200),
    @p_last_name        NVARCHAR(200),
    @p_phone            NVARCHAR(50),
    @p_email            NVARCHAR(200),
    @p_appointment_date DATE
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO dbo.Patients (FirstName, LastName, Phone, Email, AppointmentDate)
    VALUES (@p_first_name, @p_last_name, @p_phone, @p_email, @p_appointment_date);

    SELECT CAST(SCOPE_IDENTITY() AS INT);
END;
";
                using (var spAddPatCmd = new SqlCommand(spAddPatientSql, conn))
                {
                    spAddPatCmd.ExecuteNonQuery();
                }

                _isInitialized = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error initializing database schema:\n{ex.Message}",
                    "Database Init Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                throw;
            }
        }

        // -------- Public methods used by your forms --------

        public bool TestConnection()
        {
            try
            {
                EnsureDatabaseSetup();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Registers a new user.
        /// Returns:
        ///   > 0 : new UserId
        ///   -1  : username already exists
        /// </summary>
        public int RegisterUser(string username, string password)
        {
            EnsureDatabaseSetup();

            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();

                using var cmd = new SqlCommand("dbo.sp_register_user", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_username", username);
                cmd.Parameters.AddWithValue("@p_password", password);

                var result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error while registering user:\n{ex.Message}",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>
        /// Attempts login.
        /// Returns:
        ///   > 0 : UserId
        ///   -1  : invalid username or password
        /// </summary>
        public int Login(string username, string password)
        {
            EnsureDatabaseSetup();

            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();

                using var cmd = new SqlCommand("dbo.sp_login", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_username", username);
                cmd.Parameters.AddWithValue("@p_password", password);

                var result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error while logging in:\n{ex.Message}",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>
        /// Adds a patient and returns PatientId.
        /// </summary>
        public int AddPatient(string firstName,
                              string lastName,
                              string phone,
                              string email,
                              DateTime appointmentDate)
        {
            EnsureDatabaseSetup();

            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();

                using var cmd = new SqlCommand("dbo.sp_add_patient", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_first_name", firstName);
                cmd.Parameters.AddWithValue("@p_last_name", lastName);
                cmd.Parameters.AddWithValue("@p_phone", phone);
                cmd.Parameters.AddWithValue("@p_email", email);
                cmd.Parameters.Add("@p_appointment_date", SqlDbType.Date).Value = appointmentDate.Date;

                var result = cmd.ExecuteScalar();
                int newId = Convert.ToInt32(result);

                return newId;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error while saving patient:\n{ex.Message}",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
