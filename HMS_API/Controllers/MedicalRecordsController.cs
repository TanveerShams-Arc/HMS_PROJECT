// MedicalRecordController.cs
using System.Text.RegularExpressions;
using AutoMapper;
using HMS_API.Dtos;
using HMS_API.HelperFunctions.QueryObjects;
using HMS_API.Interfaces;
using HMS_API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static HMS_API.HelperFunctions.UtilitiesAndExtensions;

namespace HMS_API.Controllers
{
    [Route("api/medicalrecords")]
    [ApiController]
    public class MedicalRecordsController : ControllerBase
    {
        private readonly IMedicalRecordsRepository _medicalRecordRepository;
        private readonly IMapper _mapper;

        public MedicalRecordsController(IMapper mapper, IMedicalRecordsRepository medicalRecordRepository)
        {
            _mapper = mapper;
            _medicalRecordRepository = medicalRecordRepository;
        }

        [HttpGet]
        //[Authorize(Policy = "ReceptionistOnly")]
        public async Task<IActionResult> GetAll([FromQuery] MedicalRecordsQueryObject query)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                //if (!User.Identity!.IsAuthenticated)
                //    return Unauthorized(new { message = "User is not authenticated" });

                var medicalRecords = await _medicalRecordRepository.GetAllAsync();
                var medicalRecordsDto = _mapper.Map<List<MedicalRecordsDto>>(medicalRecords);

                if (!string.IsNullOrEmpty(query.RecordType))
                    medicalRecordsDto = FilterHelper.Filter(medicalRecordsDto, mr => Regex.IsMatch(mr.RecordType, Regex.Escape(query.RecordType), RegexOptions.IgnoreCase));
                if (!string.IsNullOrEmpty(query.PatientName))
                    medicalRecordsDto = FilterHelper.Filter(medicalRecordsDto, mr => Regex.IsMatch(mr.PatientName, Regex.Escape(query.PatientName), RegexOptions.IgnoreCase));

                var skipNumber = (query.PageNumber - 1) * query.PageSize;
                return Ok(medicalRecordsDto.Skip(skipNumber).Take(query.PageSize));
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

            var medicalRecord = await _medicalRecordRepository.GetByIdAsync(id);
            if (medicalRecord == null) return NotFound();

            var medicalRecordDto = _mapper.Map<MedicalRecordsDto>(medicalRecord);

            string formattedRecord = RecordFormatter.Format(medicalRecordDto);

            return Content(formattedRecord, "text/plain");
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateMedicalRecordsDto medicalRecordDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var medicalRecord = _mapper.Map<MedicalRecords>(medicalRecordDto);
            await _medicalRecordRepository.CreateAsync(medicalRecord);
            return CreatedAtAction(nameof(GetById), new { id = medicalRecord.RecordId }, _mapper.Map<MedicalRecordsDto>(medicalRecord));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateMedicalRecordsDto updateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var updatedRecord = await _medicalRecordRepository.UpdateAsync(id, updateDto);
            if (updatedRecord == null) return NotFound();
            return Ok(_mapper.Map<MedicalRecordsDto>(updatedRecord));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var deletedRecord = await _medicalRecordRepository.DeleteAsync(id);
            if (deletedRecord == null) return NotFound();
            return NoContent();
        }
    }
}
