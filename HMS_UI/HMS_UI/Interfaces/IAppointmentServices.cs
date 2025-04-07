using HMS_API.Dtos;
using HMS_UI.HelperFunctions;

namespace HMS_UI.Interfaces
{
    public interface IAppointmentServices
    {
        Task<List<AppointmentDto>?> GetData(AppointmentQueryObject query);

        Task<bool> UpdateAppointmentStatusAsync(string? appointmentId, string? status);

        Task<bool> CreateAppointmentAsync(string? pID, string? dID, DateTime appointmentDate, string? status, int receptionistId);

        Task<bool> DeleteAppointmentAsync(int eventID);
    }
}
