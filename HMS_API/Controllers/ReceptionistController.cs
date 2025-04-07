using AutoMapper;
using HMS_API.Dtos;
using HMS_API.HelperFunctions.QueryObjects;
using HMS_API.Interfaces;
using HMS_API.Models;
using HMS_API.Models.Persons;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceptionistController : ControllerBase
    {
        private readonly IReceptionistRepository _receptionistRepository;
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;

        public ReceptionistController(IReceptionistRepository receptionistRepository, IMapper mapper, UserManager<AppUser> userManager)
        {
            _receptionistRepository = receptionistRepository;
            _mapper = mapper;
            _userManager = userManager;
        }

        [HttpGet]
        //[Authorize(Policy = "ReceptionistOnly")]
        public async Task<IActionResult> GetAll([FromQuery] ReceptionistQueryObject query)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var receptionists = await _receptionistRepository.GetAllAsync(query);
            var receptionistDtos = _mapper.Map<List<ReceptionistDto>>(receptionists);
            return Ok(receptionistDtos);
        }



        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var receptionist = await _receptionistRepository.GetByIdAsync(id);
            if (receptionist == null) return NotFound();

            return Ok(_mapper.Map<ReceptionistDto>(receptionist));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateReceptionistDto receptionistDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var appUser = await _userManager.FindByIdAsync(receptionistDto.AppUserId);
            if (appUser == null)
                return BadRequest("Invalid User ID");


            var receptionistModel = _mapper.Map<Receptionist>(receptionistDto);
            receptionistModel.AppUserId = appUser.Id;
            await _receptionistRepository.CreateAsync(receptionistModel);
            return CreatedAtAction(nameof(GetById), new { id = receptionistModel.ReceptionistId }, _mapper.Map<ReceptionistDto>(receptionistModel));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateReceptionistDto updateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var (updatedReception, newToken) = await _receptionistRepository.UpdateAsync(id, updateDto);
            if (updatedReception == null) return NotFound();

            return Ok(new
            {
                receptionist = _mapper.Map<DoctorDto>(updatedReception),
                message = "Receptionist updated successfully",
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

            var deletedReceptionist = await _receptionistRepository.DeleteAsync(id);
            if (deletedReceptionist == null) return NotFound("Doctor or associated user not found.");

            return NoContent();
        }
    }
}
