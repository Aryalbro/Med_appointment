using System;

namespace AppointmentUI.Models
{
    // Patient (person coming to the hospital/clinic)
    public class Patient
    {
        public int PatientId { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Phone { get; set; } = "";
        public string? Email { get; set; }
        public string? Address { get; set; }

        public override string ToString() => $"{FirstName} {LastName}";
    }

    // Doctor or provider taking the appointment
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string FullName { get; set; } = "";
        public string Department { get; set; } = "";
        public override string ToString() => $"{FullName} - {Department}";
    }

    // Appointment record
    public class Appointment
    {
        public int AppointmentId { get; set; }

        public int PatientId { get; set; }
        public Patient? Patient { get; set; }

        public int DoctorId { get; set; }
        public Doctor? Doctor { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public string Reason { get; set; } = "";
        public string Status { get; set; } = "Booked"; // Booked | Cancelled | Completed
        public string? Notes { get; set; }
    }
}
