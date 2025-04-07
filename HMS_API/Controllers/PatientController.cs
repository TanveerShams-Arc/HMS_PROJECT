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

    [Route("api/patient")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientRepository _patientRepository;
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;

        public PatientController(IMapper mapper, UserManager<AppUser> userManager, IPatientRepository patientRepository)
        {
            _mapper = mapper;
            _userManager = userManager;
            _patientRepository = patientRepository;
        }


        [HttpGet]
        //[Authorize(Policy = "PatientOnly")]
        public async Task<IActionResult> GetAll([FromQuery] PatientQueryObject query)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var patients = await _patientRepository.GetAllAsync(query);
            var patientDto = _mapper.Map<List<PatientDto>>(patients);



            if (query.PatientDOB != null)
                patientDto = FilterHelper.Filter(patientDto, a => a.PatientDOB == query.PatientDOB);
            if (query.PatientName != null)
                patientDto = FilterHelper.Filter(patientDto, a => Regex.IsMatch(a.FullName, Regex.Escape(query.PatientName!), RegexOptions.IgnoreCase));
            if (query.PatientBloodGroup != null)
                patientDto = FilterHelper.Filter(patientDto, a => a.PatientBloodGroup.ToLower().Contains(query.PatientBloodGroup.ToLower()));
            if (query.phoneNumber != null)
                patientDto = FilterHelper.Filter(patientDto, a => a.PhoneNumber.Contains(query.phoneNumber.ToLower()));
            if (query.PatientAddress != null)
                patientDto = FilterHelper.Filter(patientDto, a => a.PatientAddress == query.PatientAddress);

            var skipNumber = (query.PageNumber - 1) * query.PageSize;


            return Ok(patientDto.Skip(skipNumber).Take(query.PageSize));

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var patient = await _patientRepository.GetByIdAsync(id);
            if (patient == null) return NotFound();

            return Ok(_mapper.Map<PatientDto>(patient));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreatePatientDto patientDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var appUser = await _userManager.FindByIdAsync(patientDto.AppUserId);
            if (appUser == null)
                return BadRequest("Invalid User ID");


            var patientModel = _mapper.Map<Patient>(patientDto);
            patientModel.AppUserId = appUser.Id;
            await _patientRepository.CreateAsync(patientModel);
            return CreatedAtAction(nameof(GetById), new { id = patientModel.PatientId }, _mapper.Map<PatientDto>(patientModel));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdatePatientDto updateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var (updatedpatient, newToken) = await _patientRepository.UpdateAsync(id, updateDto);
            if (updatedpatient == null) return NotFound();

            return Ok(new
            {
                patient = _mapper.Map<PatientDto>(updatedpatient),
                message = "patient updated successfully",
                token = newToken
            });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var deletedpatient = await _patientRepository.DeleteAsync(id);
            if (deletedpatient == null) return NotFound("patient or associated user not found.");

            return NoContent();
        }

    }
}


