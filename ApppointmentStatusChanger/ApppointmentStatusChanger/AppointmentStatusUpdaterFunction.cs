using HMS_API.Interfaces;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace ApppointmentStatusChanger
{
    public class AppointmentStatusUpdaterFunction
    {
        private readonly ILogger _logger;
        private readonly IUnitOfWork _unitOfWork;

        public AppointmentStatusUpdaterFunction(ILoggerFactory loggerFactory, IUnitOfWork unitOfWork)
        {
            _logger = loggerFactory.CreateLogger<AppointmentStatusUpdaterFunction>();
            _unitOfWork = unitOfWork;
        }

        [Function("AppointmentStatusUpdaterFunction")]
        public async Task Run([TimerTrigger("0 */1 * * * *")] TimerInfo myTimer, FunctionContext context)
        {
            _logger.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");

            try
            {
                var currentDateTime = DateTime.Now;

                var appointments = await _unitOfWork.AppointmentRepository.GetCompletedAppointmentsAsync(currentDateTime);

                if (!appointments.Any())
                {
                    _logger.LogInformation("No past due appointments found.");
                    return;
                }

                foreach (var appointment in appointments)
                {
                    if (appointment.Status != "Completed" && appointment.Status != "Cancelled")
                    {
                        appointment.Status = "Completed";
                        await _unitOfWork.AppointmentRepository.UpdateAppointmentStatusAsync(appointment.EventId, appointment.Status);
                    }
                }
                await _unitOfWork.SaveAsync();

                _logger.LogInformation($"Successfully updated {appointments.Count} appointments.");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error updating appointment statuses: {ex.Message}");
            }

            if (myTimer.ScheduleStatus is not null)
            {
                _logger.LogInformation($"Next timer schedule at: {myTimer.ScheduleStatus.Next}");
            }
        }
    }
}
