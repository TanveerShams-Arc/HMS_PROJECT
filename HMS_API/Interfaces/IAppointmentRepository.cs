using HMS_API.Dtos;
using HMS_API.Models;

namespace HMS_API.Interfaces
{
    public interface IAppointmentRepository
    {
        Task<List<Appointment>> GetAllAsync();
        Task<Appointment?> GetByIdAsync(int id);
        Task<Appointment> CreateAsync(Appointment appointment);
        Task<Appointment?> UpdateAsync(int id, UpdateAppointmentDto appointmentDto);
        Task<Appointment?> DeleteAsync(int id);
        Task<string> GetDailyReportAsync(DateTime date);
        Task UpdateAppointmentStatusAsync(int appointmentId, string newStatus);
        Task<List<Appointment>> GetCompletedAppointmentsAsync(DateTime currentDateTime);

    }
}
