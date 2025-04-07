using HMS_API.DB;
using HMS_API.Dtos;
using HMS_API.Models;
using HMS_API.Models.Persons;
using HMS_API.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HMS_API_Tests
{
    public class AppointmentRepositoryTests
    {
        private readonly AppDBContext _context;
        private readonly AppointmentRepository _repository;

        public AppointmentRepositoryTests()
        {
            var options = new DbContextOptionsBuilder<AppDBContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            _context = new AppDBContext(options);
            _repository = new AppointmentRepository(_context);
        }


        [Fact]
        public async Task GetDailyReportAsync_ShouldReturnCorrectReport()
        {
            // Arrange
            var date = DateTime.Now.Date;
            var appointments = new List<Appointment>
            {
                new Appointment
                {
                    EventId = 1,
                    AppointmentDate = date,
                    Status = "Scheduled",
                    PatientId = 1,
                    DoctorId = 1,
                    ReceptionistId = 1
                }
            };

            await _context.Appointments.AddRangeAsync(appointments);
            await _context.SaveChangesAsync();

            // Act
            var report = await _repository.GetDailyReportAsync(date);

            // Assert
            Assert.Contains($"📅 Daily Report for {date:yyyy-MM-dd}\n", report);
        }


        [Fact]
        public async Task UpdateAppointmentStatusAsync_ShouldUpdateStatus()
        {
            // Arrange
            var appointment = new Appointment
            {
                EventId = 11355,
                AppointmentDate = DateTime.Now,
                Status = "Scheduled",
                PatientId = 1,
                DoctorId = 1,
                ReceptionistId = 1
            };

            await _context.Appointments.AddAsync(appointment);
            await _context.SaveChangesAsync();

            var newStatus = "Completed";

            // Act
            await _repository.UpdateAppointmentStatusAsync(appointment.EventId, newStatus);
            var updatedAppointment = await _context.Appointments.FindAsync(appointment.EventId);

            // Assert
            Assert.Equal(newStatus, updatedAppointment.Status);
        }

        private void CleanupDb()
        {
            _context.Database.EnsureDeleted();
            _context.Database.EnsureCreated();
        }

        [Fact]
        public async Task GetAllAsync_ShouldReturnAllAppointments()
        {
            // Arrange
            CleanupDb();

            var appointments = new List<Appointment>
            {
                new Appointment
                {
                    EventId = 1246,
                    AppointmentDate = DateTime.Now,
                    Status = "Scheduled",
                    DoctorId = 1246,
                    PatientId = 1246,
                    Patient = new Patient { AppUser = new AppUser { FullName = "Patient 1" } },
                    Doctor = new Doctor { AppUser = new AppUser { FullName = "Doctor 1" } },
                    Receptionist = new Receptionist { AppUser = new AppUser { FullName = "Receptionist 1" } }
                },
                new Appointment
                {
                    EventId = 2246,
                    AppointmentDate = DateTime.Now,
                    Status = "Scheduled",
                    DoctorId = 2264,
                    PatientId = 2246,
                    Patient = new Patient { AppUser = new AppUser { FullName = "Patient 2" } },
                    Doctor = new Doctor { AppUser = new AppUser { FullName = "Doctor 2" } },
                    Receptionist = new Receptionist { AppUser = new AppUser { FullName = "Receptionist 2" } }
                }
            };

            await _context.Appointments.AddRangeAsync(appointments);
            await _context.SaveChangesAsync();

            // Act
            var result = await _repository.GetAllAsync();

            // Assert
            Assert.Equal(2, result.Count);
            Assert.Equal("Patient 1", result[0].Patient.AppUser.FullName);
            Assert.Equal("Doctor 1", result[0].Doctor.AppUser.FullName);
            Assert.Equal("Scheduled", result[0].Status);

            Assert.Equal("Patient 2", result[1].Patient.AppUser.FullName);
            Assert.Equal("Doctor 2", result[1].Doctor.AppUser.FullName);
            Assert.Equal("Scheduled", result[1].Status);
        }


        [Fact]
        public async Task UpdateAsync_ShouldUpdateAppointment()
        {
            // Arrange
            CleanupDb();

            var appointment = new Appointment
            {
                EventId = 15313,
                AppointmentDate = DateTime.Now,
                Status = "Scheduled",
                DoctorId = 6735,
                PatientId = 3571,
                Patient = new Patient { AppUser = new AppUser { FullName = "Patient 1" } },
                Doctor = new Doctor { AppUser = new AppUser { FullName = "Doctor 1" } },
                Receptionist = new Receptionist { AppUser = new AppUser { FullName = "Receptionist 1" } }
            };

            await _context.Appointments.AddAsync(appointment);
            await _context.SaveChangesAsync();

            var updateDto = new UpdateAppointmentDto
            {
                AppointmentDate = DateTime.Now.AddDays(1),
                Status = "Completed"
            };

            // Act
            var updatedAppointment = await _repository.UpdateAsync(appointment.EventId, updateDto);

            // Assert
            Assert.NotNull(updatedAppointment);
            Assert.Equal(updateDto.AppointmentDate.Date, updatedAppointment?.AppointmentDate.Date);
            Assert.Equal(updateDto.Status, updatedAppointment?.Status);
        }

        [Fact]
        public async Task UpdateAsync_ShouldReturnNull_WhenAppointmentNotFound()
        {
            // Arrange
            CleanupDb();

            var updateDto = new UpdateAppointmentDto
            {
                AppointmentDate = DateTime.Now.AddDays(1),
                Status = "Completed"
            };

            // Act
            var result = await _repository.UpdateAsync(999, updateDto);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public async Task DeleteAsync_ShouldDeleteAppointment_WhenAppointmentExists()
        {
            // Arrange
            CleanupDb();

            var appointment = new Appointment
            {
                EventId = 1,
                AppointmentDate = DateTime.Now,
                Status = "Scheduled",
                DoctorId = 1,
                PatientId = 1,
                Patient = new Patient { AppUser = new AppUser { FullName = "Patient 1" } },
                Doctor = new Doctor { AppUser = new AppUser { FullName = "Doctor 1" } },
                Receptionist = new Receptionist { AppUser = new AppUser { FullName = "Receptionist 1" } }
            };

            await _context.Appointments.AddAsync(appointment);
            await _context.SaveChangesAsync();

            // Act
            var deletedAppointment = await _repository.DeleteAsync(appointment.EventId);

            // Assert
            Assert.NotNull(deletedAppointment);
            Assert.Equal(appointment.EventId, deletedAppointment?.EventId);
            Assert.Equal("Scheduled", deletedAppointment?.Status);
        }

        [Fact]
        public async Task DeleteAsync_ShouldReturnNull_WhenAppointmentNotFound()
        {
            // Arrange
            CleanupDb();

            // Act
            var result = await _repository.DeleteAsync(999);

            // Assert
            Assert.Null(result);
        }

    }
}
