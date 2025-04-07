using HMS_API.DB;
using HMS_API.Dtos;
using HMS_API.Interfaces;
using HMS_API.Models;
using Microsoft.EntityFrameworkCore;

namespace HMS_API.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly AppDBContext _context;

        public AppointmentRepository(AppDBContext context)
        {
            _context = context;
        }

        public async Task<string> GetDailyReportAsync(DateTime date)
        {
            try
            {
                var appointments = await _context.Appointments
                    .Where(a => a.AppointmentDate.Date == date.Date)
                    .ToListAsync();

                return Appointment.GenerateDailyReport(appointments, date);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while generating the daily report", ex);
            }
        }

        public async Task UpdateAppointmentStatusAsync(int appointmentId, string newStatus)
        {
            try
            {
                var appointment = await _context.Appointments.FindAsync(appointmentId);

                if (appointment == null)
                    throw new Exception("Appointment not found");

                appointment.OnAppointmentStatusChanged += (sender, e) =>
                {
                    Console.WriteLine($"|--------------->> Appointment {e.ProcessedAppointment.EventId} status changed to: {e.ProcessedAppointment.Status}");
                };

                appointment.UpdateStatus(newStatus);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while updating the appointment status", ex);
            }
        }

        public async Task<List<Appointment>> GetAllAsync()
        {
            try
            {
                return await _context.Appointments
                    .Include(a => a.Patient).ThenInclude(p => p.AppUser)
                    .Include(a => a.Doctor).ThenInclude(p => p.AppUser)
                    .Include(a => a.Receptionist).ThenInclude(p => p.AppUser)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching all appointments", ex);
            }
        }

        public async Task<Appointment?> GetByIdAsync(int id)
        {
            try
            {
                return await _context.Appointments
                    .Include(a => a.Patient).ThenInclude(p => p.AppUser)
                    .Include(a => a.Doctor).ThenInclude(p => p.AppUser)
                    .Include(a => a.Receptionist).ThenInclude(p => p.AppUser)
                    .FirstOrDefaultAsync(a => a.EventId == id);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving the appointment", ex);
            }
        }

        public async Task<Appointment> CreateAsync(Appointment appointment)
        {
            try
            {
                await _context.Appointments.AddAsync(appointment);
                return appointment;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while creating the appointment", ex);
            }
        }

        public async Task<Appointment?> UpdateAsync(int id, UpdateAppointmentDto appointmentDto)
        {
            try
            {
                var existingAppointment = await _context.Appointments.FirstOrDefaultAsync(a => a.EventId == id);
                if (existingAppointment == null) return null;

                existingAppointment.AppointmentDate = appointmentDto.AppointmentDate;
                existingAppointment.Status = appointmentDto.Status;

                return existingAppointment;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while updating the appointment", ex);
            }
        }

        public async Task<Appointment?> DeleteAsync(int id)
        {
            try
            {
                var appointment = await _context.Appointments.FirstOrDefaultAsync(a => a.EventId == id);
                if (appointment == null) return null;

                _context.Appointments.Remove(appointment);
                return appointment;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while deleting the appointment", ex);
            }
        }

        public async Task<List<Appointment>> GetCompletedAppointmentsAsync(DateTime currentDateTime)
        {
            try
            {
                return await _context.Appointments
                    .Where(a => a.AppointmentDate < currentDateTime &&
                                a.Status != "Completed" &&
                                a.Status != "Cancelled" &&
                                a.Status != "Past Appointment")
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching past due appointments", ex);
            }
        }

    }
}
