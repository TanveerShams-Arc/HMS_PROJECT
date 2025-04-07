using System.Text.RegularExpressions;
using AutoMapper;
using HMS_API.Dtos;
using HMS_API.HelperFunctions.QueryObjects;
using HMS_API.Interfaces;
using HMS_API.Models;
using HMS_API.Models.Persons;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using static HMS_API.HelperFunctions.UtilitiesAndExtensions;

namespace HMS_API.Controllers
{
    [Route("api/doctor")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorRepository _doctorRepository;
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;

        public DoctorController(IDoctorRepository doctorRepository, IMapper mapper, UserManager<AppUser> userManager)
        {
            _doctorRepository = doctorRepository;
            _mapper = mapper;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] DoctorQueryObject query)
        {
            throw new Exception("Test exception for logging");

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            try
            {
                var doctors = await _doctorRepository.GetAllAsync(query);
                var doctorDto = _mapper.Map<List<DoctorDto>>(doctors);

                if (query.DoctorSpecialization != null)
                    doctorDto = FilterHelper.Filter(doctorDto, a => a.DoctorSpecialization == query.DoctorSpecialization);
                if (query.DoctortName != null)
                    doctorDto = FilterHelper.Filter(doctorDto, a => Regex.IsMatch(a.FullName, Regex.Escape(query.DoctortName!), RegexOptions.IgnoreCase));
                if (query.DoctorExperience != null)
                    doctorDto = FilterHelper.Filter(doctorDto, a => a.DoctorExperience == query.DoctorExperience);

                var skipNumber = (query.PageNumber - 1) * query.PageSize;
                return Ok(doctorDto.Skip(skipNumber).Take(query.PageSize));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while processing your request", error = ex.Message });
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var doctor = await _doctorRepository.GetByIdAsync(id);
                if (doctor == null) return NotFound();

                return Ok(_mapper.Map<DoctorDto>(doctor));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while retrieving the doctor", error = ex.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateDoctorDto doctorDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var appUser = await _userManager.FindByIdAsync(doctorDto.AppUserId);
                if (appUser == null)
                    return BadRequest("Invalid User ID");

                var doctorModel = _mapper.Map<Doctor>(doctorDto);
                doctorModel.AppUserId = appUser.Id;
                await _doctorRepository.CreateAsync(doctorModel);
                return CreatedAtAction(nameof(GetById), new { id = doctorModel.DoctorId }, _mapper.Map<DoctorDto>(doctorModel));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while creating the doctor", error = ex.Message });
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateDoctorDto updateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var (updatedDoctor, newToken) = await _doctorRepository.UpdateAsync(id, updateDto);
                if (updatedDoctor == null) return NotFound();

                return Ok(new
                {
                    doctor = _mapper.Map<DoctorDto>(updatedDoctor),
                    message = "Doctor updated successfully",
                    token = newToken
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while updating the doctor", error = ex.Message });
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var deletedDoctor = await _doctorRepository.DeleteAsync(id);
                if (deletedDoctor == null) return NotFound("Doctor or associated user not found.");

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while deleting the doctor", error = ex.Message });
            }
        }
    }
}
