using System.Data;
using HMS_API.Dtos;
using HMS_UI.Enums;
using HMS_UI.HelperFunctions;
using HMS_UI.Interfaces;

namespace HMS_UI.Services
{
    class AppointmentServices(IAppointmentRepository appointmentRepository) : IAppointmentServices
    {

        private readonly IAppointmentRepository _appointmentRepository = appointmentRepository;

        public async Task<bool> CreateAppointmentAsync(string? pID, string? dID, DateTime appointmentDate, string? status, int receptionistId)
        {
            if (string.IsNullOrEmpty(pID) || string.IsNullOrEmpty(dID) || string.IsNullOrEmpty(status))
                throw new NoNullAllowedException("Value cannot be null!");

            if (receptionistId < 0)
                throw new InvalidOperationException("Invalid Receptionist Detected!");

            int patientId = int.Parse(pID);
            int doctorId = int.Parse(dID);

            if (status == apStatus.Cancelled.ToString())
                throw new InvalidOperationException("New appointment status cannot be 'Cancelled'.");

            var appointmentDto = new
            {
                patientId,
                doctorId,
                appointmentDate,
                status,
                receptionistId
            };

            return await _appointmentRepository.CreateAppointmentAsync(appointmentDto);
        }

        public async Task<bool> DeleteAppointmentAsync(int eventID)
        {
            if (eventID <= 0)
                throw new ArgumentException("Invalid Event ID.");

            return await _appointmentRepository.DeleteAppointmentAsync(eventID);
        }

        public async Task<List<AppointmentDto>?> GetData(AppointmentQueryObject queryObject)
        {
            ArgumentNullException.ThrowIfNull(queryObject);

            if (!string.IsNullOrWhiteSpace(queryObject.Status) && !Enum.TryParse(typeof(apStatus), queryObject.Status, out _))
                throw new ArgumentException("Invalid appointment status.");

            return await _appointmentRepository.GetAppointmentsAsync(queryObject);
        }


        public async Task<bool> UpdateAppointmentStatusAsync(string? appointmentId, string? status)
        {
            if (string.IsNullOrEmpty(appointmentId) || (!int.TryParse(appointmentId, out int apID)) || apID < 0)
            {
                MessageBox.Show("Invalid appointment ID.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(status))
            {
                MessageBox.Show("Status cannot be empty.");
                return false;
            }

            if (!Enum.TryParse(typeof(apStatus), status, out _))
            {
                MessageBox.Show("Invalid appointment status.");
                return false;
            }

            return await _appointmentRepository.UpdateAppointmentStatusAsync(apID, status);
        }
    }
}
