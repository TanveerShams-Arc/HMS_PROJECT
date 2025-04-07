using System.Text.RegularExpressions;
using AutoMapper;
using HMS_API.Dtos;
using HMS_API.HelperFunctions.QueryObjects;
using HMS_API.Interfaces;
using HMS_API.Models;
using Microsoft.AspNetCore.Mvc;
using static HMS_API.HelperFunctions.UtilitiesAndExtensions;

namespace HMS_API.Controllers
{
    [Route("api/prescriptions")]
    [ApiController]
    public class PrescriptionController : ControllerBase
    {
        private readonly IPrescriptionRepository _prescriptionRepository;
        private readonly IMapper _mapper;

        public PrescriptionController(IMapper mapper, IPrescriptionRepository prescriptionRepository)
        {
            _mapper = mapper;
            _prescriptionRepository = prescriptionRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] PrescriptionQueryObject query)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                //if (!User.Identity!.IsAuthenticated)
                //    return Unauthorized(new { message = "User is not authenticated" });

                var prescriptions = await _prescriptionRepository.GetAllAsync();
                var prescriptionsDto = _mapper.Map<List<PrescriptionDto>>(prescriptions);

                // Filtering logic
                if (!string.IsNullOrEmpty(query.DoctorName))
                    prescriptionsDto = FilterHelper.Filter(prescriptionsDto, p => Regex.IsMatch(p.DoctorName, Regex.Escape(query.DoctorName), RegexOptions.IgnoreCase));
                if (!string.IsNullOrEmpty(query.PatientName))
                    prescriptionsDto = FilterHelper.Filter(prescriptionsDto, p => Regex.IsMatch(p.PatientName, Regex.Escape(query.PatientName), RegexOptions.IgnoreCase));
                if (query.prescribedDate != null)
                    prescriptionsDto = FilterHelper.Filter(prescriptionsDto, p => p.PrescribedOn.Date == query.prescribedDate.Value.ToDateTime(TimeOnly.MinValue).Date);

                var skipNumber = (query.PageNumber - 1) * query.PageSize;
                return Ok(prescriptionsDto.Skip(skipNumber).Take(query.PageSize));
            }
            catch (UnauthorizedAccessException)
            {
                return Forbid();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while processing your request", error = ex.Message });
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var prescription = await _prescriptionRepository.GetByIdAsync(id);
            if (prescription == null) return NotFound();


            var prescriptionDto = _mapper.Map<PrescriptionDto>(prescription);
            string formattedPrescription = PrescriptionFormatter.Format(prescriptionDto);

            return Content(formattedPrescription, "text/plain");

            //return Ok(_mapper.Map<PrescriptionDto>(_mapper.Map<PrescriptionDto>(prescription)));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreatePrescriptionDto prescriptionDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var prescription = _mapper.Map<Prescription>(prescriptionDto);
            await _prescriptionRepository.CreateAsync(prescription);
            return CreatedAtAction(nameof(GetById), new { id = prescription.PrescriptionId }, _mapper.Map<PrescriptionDto>(prescription));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdatePrescriptionDto updateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var updatedPrescription = await _prescriptionRepository.UpdateAsync(id, updateDto);
            if (updatedPrescription == null) return NotFound();
            return Ok(_mapper.Map<PrescriptionDto>(updatedPrescription));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var deletedPrescription = await _prescriptionRepository.DeleteAsync(id);
            if (deletedPrescription == null) return NotFound();
            return NoContent();
        }
    }
}
