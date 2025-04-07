using HMS_API.Dtos;
using HMS_UI.HelperFunctions;

namespace HMS_UI.Interfaces
{
    public interface IAppointmentRepository
    {
        Task<bool> CreateAppointmentAsync(object appointment);

        Task<List<AppointmentDto>?> GetAppointmentsAsync(AppointmentQueryObject query);

        Task<bool> UpdateAppointmentStatusAsync(int appointmentId, string status);

        Task<bool> DeleteAppointmentAsync(int appointmentId);

    }

}
