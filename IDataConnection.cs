using System;

namespace AppointmentUI
{
    public interface IDataConnection
    {
        /// <summary>
        /// Tests database connectivity and initializes schema.
        /// </summary>
        bool TestConnection();

        /// <summary>
        /// Registers a new user.
        /// Returns:
        ///   > 0 : new user_id
        ///   -1  : username already exists
        /// </summary>
        int RegisterUser(string username, string password);

        /// <summary>
        /// Attempts login.
        /// Returns:
        ///   > 0 : user_id
        ///   -1  : invalid username or password
        /// </summary>
        int Login(string username, string password);

        /// <summary>
        /// Adds a new patient and returns patient_id.
        /// </summary>
        int AddPatient(string firstName,
                       string lastName,
                       string phone,
                       string email,
                       DateTime appointmentDate);
    }
}
