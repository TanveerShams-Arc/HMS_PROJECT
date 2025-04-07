namespace HMS_API.Models
{
    public partial class Appointment
    {

        public delegate void AppointmentProcessedEventHandler(object sender, AppointmentEventArgs e);
        public event AppointmentProcessedEventHandler? OnAppointmentProcessed;

        public void ProcessAppointment(string newStatus)
        {
            Status = newStatus;
            OnAppointmentProcessed?.Invoke(this, new AppointmentEventArgs(this));
        }
    }


    public class AppointmentEventArgs : EventArgs
    {
        public Appointment ProcessedAppointment { get; }

        public AppointmentEventArgs(Appointment appointment)
        {
            ProcessedAppointment = appointment;
        }
    }






    public partial class Appointment
    {
        public static string GenerateDailyReport(List<Appointment> appointments, DateTime date)
        {
            var dailyAppointments = appointments
                .Where(a => a.AppointmentDate.Date == date.Date)
                .ToArray();

            if (dailyAppointments.Length == 0)
                return $"📅 No appointments found for {date:yyyy-MM-dd}.";

            string report = $"📅 Daily Report for {date:yyyy-MM-dd}\n";
            report += "----------------------------------\n";

            foreach (var appointment in dailyAppointments)
            {
                report += $"🆔 ID: {appointment.EventId} | " +
                          $"👤 Patient: {appointment.PatientId} | " +
                          $"👨‍⚕️ Doctor: {appointment.DoctorId} | " +
                          $"📌 Status: {appointment.Status}\n";
            }
            return report;
        }
    }



    public partial class Appointment
    {
        public delegate void AppointmentStatusChangedEventHandler(object sender, AppointmentEventArgs e);
        public event AppointmentStatusChangedEventHandler? OnAppointmentStatusChanged;
        public void UpdateStatus(string newStatus)
        {
            if (Status == newStatus) return;

            Status = newStatus;
            OnAppointmentStatusChanged?.Invoke(this, new AppointmentEventArgs(this));
        }
    }
}




