//using HMS_API.Dtos;
//using HMS_API.Interfaces;
//using Microsoft.Azure.Functions.Worker;

//namespace HMS_API.Functions
//{
//    public class AppointmentStatusUpdater
//    {
//        private readonly IAppointmentRepository _appointmentRepository;
//        private readonly ILogger<AppointmentStatusUpdater> _logger;
//        public AppointmentStatusUpdater(ILogger<AppointmentStatusUpdater> logger, IAppointmentRepository appointmentRepository)
//        {
//            _logger = logger;
//            _appointmentRepository = appointmentRepository;
//        }

//        [Function("AppointmentStatusUpdater")]
//        public async Task Run(
//        [TimerTrigger("*/10 * * * * *")] TimerInfo timerInfo)
//        {
//            _logger.LogInformation($"Function executed at: {DateTime.Now}");

//            var appointments = await _appointmentRepository.GetAllAsync();

//            foreach (var appointment in appointments)
//            {
//                if (appointment.Status == "Scheduled" && appointment.AppointmentDate < DateTime.Now)
//                {
//                    appointment.Status = "Completed";
//                    await _appointmentRepository.UpdateAsync(appointment.EventId, new UpdateAppointmentDto { Status = "Completed" });

//                    Console.WriteLine($"Appointment {appointment.EventId} status updated to 'Completed'.");
//                }
//            }
//        }
//    }
//}
