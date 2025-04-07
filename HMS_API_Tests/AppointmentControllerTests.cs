using AutoMapper;
using HMS_API.Controllers;
using HMS_API.Dtos;
using HMS_API.Interfaces;
using HMS_API.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace HMS_API_Tests
{
    public class AppointmentControllerTests
    {
        private readonly Mock<IUnitOfWork> _mockUnitOfWork;
        private readonly Mock<IMapper> _mockMapper;
        private readonly AppointmentController _controller;

        public AppointmentControllerTests()
        {
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _mockMapper = new Mock<IMapper>();
            _controller = new AppointmentController(_mockMapper.Object, _mockUnitOfWork.Object);
        }

        [Fact]
        public async Task Create_ShouldReturnCreatedAppointment()
        {
            //Arrange
            var createAppointmentDto = new CreateAppointmentDto
            {
                PatientId = 1,
                DoctorId = 2,
                ReceptionistId = 3,
                AppointmentDate = DateTime.Now.AddDays(1),
                Status = "Scheduled"
            };

            var appointment = new Appointment
            {
                EventId = 1,
                PatientId = 1,
                DoctorId = 2,
                ReceptionistId = 3,
                AppointmentDate = DateTime.Now.AddDays(1),
                Status = "Scheduled"
            };

            var appointmentDto = new AppointmentDto
            {
                EventId = 1,
                PatientFullname = "John Doe",
                DoctorFullname = "Dr. Smith",
                AppointmentDate = DateTime.Now.AddDays(1),
                Status = "Scheduled",
                ReceptionistFullname = "Jane Receptionist",
                doctorSpecialization = "General Medicine"
            };

            _mockMapper.Setup(m => m.Map<Appointment>(createAppointmentDto)).Returns(appointment);
            _mockMapper.Setup(m => m.Map<AppointmentDto>(appointment)).Returns(appointmentDto);
            _mockUnitOfWork.Setup(u => u.AppointmentRepository.CreateAsync(appointment))
                .ReturnsAsync(appointment);
            _mockUnitOfWork.Setup(u => u.SaveAsync()).ReturnsAsync(1);

            //Act
            var result = await _controller.Create(createAppointmentDto);

            //Assert
            var createdAtActionResult = Assert.IsType<CreatedAtActionResult>(result);
            Assert.Equal(201, createdAtActionResult.StatusCode);

            var returnedAppointmentDto = Assert.IsType<AppointmentDto>(createdAtActionResult.Value);
            Assert.Equal("John Doe", returnedAppointmentDto.PatientFullname);
            Assert.Equal("Dr. Smith", returnedAppointmentDto.DoctorFullname);
            Assert.Equal("Scheduled", returnedAppointmentDto.Status);
            Assert.Equal("General Medicine", returnedAppointmentDto.doctorSpecialization);
        }

        [Fact]
        public async Task GetById_ShouldReturnAppointment()
        {
            //Arrange
            var appointment = new Appointment
            {
                AppointmentDate = DateTime.Now,
                Status = "Scheduled",
                DoctorId = 1,
                PatientId = 1,
                EventId = 1
            };

            var appointmentDto = new AppointmentDto
            {
                EventId = 1,
                PatientFullname = "John Doe",
                DoctorFullname = "Dr. Smith",
                AppointmentDate = DateTime.Now,
                Status = "Scheduled",
                ReceptionistFullname = "Jane Receptionist",
                doctorSpecialization = "General Medicine"
            };

            _mockMapper.Setup(m => m.Map<AppointmentDto>(It.IsAny<Appointment>())).Returns(appointmentDto);
            _mockUnitOfWork.Setup(u => u.AppointmentRepository.GetByIdAsync(1)).ReturnsAsync(appointment);


            //Act
            var result = await _controller.GetById(1);


            //Assert
            var actionResult = Assert.IsType<OkObjectResult>(result);
            var returnedAppointmentDto = Assert.IsType<AppointmentDto>(actionResult.Value);
            Assert.Equal("John Doe", returnedAppointmentDto.PatientFullname);
            Assert.Equal("Dr. Smith", returnedAppointmentDto.DoctorFullname);
            Assert.Equal("Scheduled", returnedAppointmentDto.Status);
            Assert.Equal("General Medicine", returnedAppointmentDto.doctorSpecialization);
        }


        [Fact]
        public async Task Update_ShouldReturnUpdatedAppointment()
        {
            // Arrange
            var appointment = new Appointment
            {
                AppointmentDate = DateTime.Now,
                Status = "Scheduled",
                DoctorId = 1,
                PatientId = 1,
                EventId = 1
            };

            var updateDto = new UpdateAppointmentDto
            {
                AppointmentDate = DateTime.Now.AddDays(1),
                Status = "Completed"
            };

            var updatedAppointment = new Appointment
            {
                AppointmentDate = DateTime.Now.AddDays(1),
                Status = "Completed",
                EventId = 1
            };

            var appointmentDto = new AppointmentDto
            {
                EventId = 1,
                PatientFullname = "John Doe",
                DoctorFullname = "Dr. Smith",
                AppointmentDate = DateTime.Now.AddDays(1),
                Status = "Completed",
                ReceptionistFullname = "Jane Receptionist",
                doctorSpecialization = "General Medicine"
            };

            _mockUnitOfWork.Setup(u => u.AppointmentRepository.UpdateAsync(1, updateDto))
                .ReturnsAsync(updatedAppointment);
            _mockMapper.Setup(m => m.Map<AppointmentDto>(updatedAppointment)).Returns(appointmentDto);

            // Act
            var result = await _controller.Update(1, updateDto);

            // Assert
            var actionResult = Assert.IsType<OkObjectResult>(result);
            var returnedAppointmentDto = Assert.IsType<AppointmentDto>(actionResult.Value);

            Assert.Equal(updateDto.Status, returnedAppointmentDto.Status);
            Assert.Equal(updateDto.AppointmentDate.ToString("yyyy-MM-dd HH:mm:ss"), returnedAppointmentDto.AppointmentDate.ToString("yyyy-MM-dd HH:mm:ss"));
        }


        [Fact]
        public async Task Delete_ShouldReturnNoContent()
        {
            //Arrange
            var appointment = new Appointment
            {
                AppointmentDate = DateTime.Now,
                Status = "Scheduled",
                DoctorId = 1,
                PatientId = 1,
                EventId = 1
            };

            _mockUnitOfWork.Setup(u => u.AppointmentRepository.DeleteAsync(1)).ReturnsAsync(appointment);
            _mockUnitOfWork.Setup(u => u.SaveAsync()).ReturnsAsync(1);

            //Act
            var result = await _controller.Delete(1);

            //Assert
            var actionResult = Assert.IsType<NoContentResult>(result);
        }


        [Fact]
        public async Task GetDailyReport_ShouldReturnReportContent()
        {
            // Arrange
            var date = DateTime.Now.Date;
            var expectedReport = "Sample Daily Report: 5 appointments scheduled.";

            _mockUnitOfWork.Setup(u => u.AppointmentRepository.GetDailyReportAsync(date)).ReturnsAsync(expectedReport);

            // Act
            var result = await _controller.GetDailyReport(date);

            // Assert
            var contentResult = Assert.IsType<ContentResult>(result);
            Assert.Equal("text/plain", contentResult.ContentType);
            Assert.Equal(expectedReport, contentResult.Content);
        }

        [Fact]
        public async Task UpdateAppointmentStatus_ShouldReturnUpdatedStatus()
        {
            // Arrange
            int appointmentId = 1;
            string newStatus = "Completed";

            _mockUnitOfWork.Setup(uow => uow.AppointmentRepository.UpdateAppointmentStatusAsync(appointmentId, newStatus))
                           .Returns(Task.CompletedTask);

            // Act
            var result = await _controller.UpdateAppointmentStatus(appointmentId, newStatus);

            // Assert
            var actionResult = Assert.IsType<OkObjectResult>(result);


            var response = actionResult.Value as object;
            Assert.NotNull(response);

            var messageProperty = response.GetType().GetProperty("Message");
            var statusProperty = response.GetType().GetProperty("Status");

            Assert.NotNull(messageProperty);
            Assert.NotNull(statusProperty);

            var messageValue = messageProperty.GetValue(response);
            var statusValue = statusProperty.GetValue(response);

            Assert.Equal("Appointment Status Updated", messageValue);
            Assert.Equal(newStatus, statusValue);

            _mockUnitOfWork.Verify(uow => uow.AppointmentRepository.UpdateAppointmentStatusAsync(appointmentId, newStatus), Times.Once);
        }

        [Fact]
        public async Task GetAppointmentSummary_ShouldReturnAppointmentSummary()
        {
            // Arrange
            var appointmentId = 1;
            var appointment = new Appointment
            {
                EventId = 1,
                PatientId = 1,
                DoctorId = 2,
                ReceptionistId = 3,
                AppointmentDate = DateTime.Now.AddDays(1),
                Status = "Scheduled"
            };

            var appointmentDto = new AppointmentDto
            {
                EventId = 1,
                PatientFullname = "John Doe",
                DoctorFullname = "Dr. Smith",
                AppointmentDate = DateTime.Now.AddDays(1),
                Status = "Scheduled",
                ReceptionistFullname = "Jane Receptionist",
                doctorSpecialization = "General Medicine"
            };

            _mockUnitOfWork.Setup(u => u.AppointmentRepository.GetByIdAsync(appointmentId)).ReturnsAsync(appointment);
            _mockMapper.Setup(m => m.Map<AppointmentDto>(appointment)).Returns(appointmentDto);

            // Act
            var result = await _controller.GetAppointmentSummary(appointmentId);

            // Assert
            var contentResult = Assert.IsType<ContentResult>(result);
            Assert.Equal("text/plain", contentResult.ContentType);
            Assert.Contains("Dr. Smith", contentResult.Content);
            Assert.Contains("John Doe", contentResult.Content);
            Assert.Contains("Scheduled", contentResult.Content);
        }
    }
}
