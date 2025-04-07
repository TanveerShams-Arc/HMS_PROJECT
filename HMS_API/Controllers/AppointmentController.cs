using System.Text.RegularExpressions;
using AutoMapper;
using HMS_API.Dtos;
using HMS_API.HelperFunctions;
using HMS_API.HelperFunctions.QueryObjects;
using HMS_API.Interfaces;
using HMS_API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static HMS_API.HelperFunctions.UtilitiesAndExtensions;

namespace HMS_API.Controllers
{
    [Route("api/appointments")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public AppointmentController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        //[Authorize(Policy = "ReceptionistOnly")]
        public async Task<IActionResult> GetAll([FromQuery] AppointmentQueryObject query)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var appointments = await _unitOfWork.AppointmentRepository.GetAllAsync();
                var appointmentsDto = _mapper.Map<List<AppointmentDto>>(appointments);

                if (query.AppointmentDate != null)
                    appointmentsDto = FilterHelper.Filter(appointmentsDto, a => DateOnly.FromDateTime(a.AppointmentDate) == query.AppointmentDate);
                if (query.DoctorName != null)
                    appointmentsDto = FilterHelper.Filter(appointmentsDto, a => Regex.IsMatch(a.DoctorFullname, Regex.Escape(query.DoctorName), RegexOptions.IgnoreCase));
                if (query.PatientName != null)
                    appointmentsDto = FilterHelper.Filter(appointmentsDto, a => a.PatientFullname.ToLower().Contains(query.PatientName.ToLower()));
                if (query.ReceptionistName != null)
                    appointmentsDto = FilterHelper.Filter(appointmentsDto, a => a.ReceptionistFullname.ToLower().Contains(query.ReceptionistName.ToLower()));
                if (query.Status != null)
                    appointmentsDto = FilterHelper.Filter(appointmentsDto, a => a.Status == query.Status);

                var skipNumber = (query.PageNumber - 1) * query.PageSize;

                return Ok(appointmentsDto.Skip(skipNumber).Take(query.PageSize));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while processing your request", error = ex.Message });
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var appointment = await _unitOfWork.AppointmentRepository.GetByIdAsync(id);
                if (appointment == null) return NotFound();

                return Ok(_mapper.Map<AppointmentDto>(appointment));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while retrieving the appointment", error = ex.Message });
            }
        }

        [HttpGet("getSummary{id}")]
        public async Task<IActionResult> GetAppointmentSummary(int id)
        {
            try
            {
                var appointment = await _unitOfWork.AppointmentRepository.GetByIdAsync(id);
                if (appointment == null)
                    return NotFound("Appointment not found");

                var appointmentDto = _mapper.Map<AppointmentDto>(appointment);
                string summary = appointmentDto.GetSummary();

                return Content(summary, "text/plain");
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while fetching the appointment summary", error = ex.Message });
            }
        }

        [HttpPost]
        [Authorize(Policy = "ReceptionistOnly")]
        public async Task<IActionResult> Create([FromBody] CreateAppointmentDto appointmentDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var appointment = _mapper.Map<Appointment>(appointmentDto);
                await _unitOfWork.AppointmentRepository.CreateAsync(appointment);
                await _unitOfWork.SaveAsync();

                return CreatedAtAction(nameof(GetById), new { id = appointment.EventId }, _mapper.Map<AppointmentDto>(appointment));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while creating the appointment", error = ex.Message });
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateAppointmentDto updateDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var updatedAppointment = await _unitOfWork.AppointmentRepository.UpdateAsync(id, updateDto);
                if (updatedAppointment == null) return NotFound();

                await _unitOfWork.SaveAsync();

                return Ok(_mapper.Map<AppointmentDto>(updatedAppointment));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while updating the appointment", error = ex.Message });
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var deletedAppointment = await _unitOfWork.AppointmentRepository.DeleteAsync(id);
                if (deletedAppointment == null) return NotFound();

                await _unitOfWork.SaveAsync();

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while deleting the appointment", error = ex.Message });
            }
        }

        [HttpGet("daily-report/{date}")]
        public async Task<IActionResult> GetDailyReport(DateTime date)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                string report = await _unitOfWork.AppointmentRepository.GetDailyReportAsync(date);
                return Content(report, "text/plain");
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while generating the daily report", error = ex.Message });
            }
        }

        [HttpPut("update-status/{id}")]
        public async Task<IActionResult> UpdateAppointmentStatus(int id, [FromBody] string newStatus)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                await _unitOfWork.AppointmentRepository.UpdateAppointmentStatusAsync(id, newStatus);
                await _unitOfWork.SaveAsync();

                return Ok(new { Message = "Appointment Status Updated", Status = newStatus });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while updating the appointment status", error = ex.Message });
            }
        }
    }
}
