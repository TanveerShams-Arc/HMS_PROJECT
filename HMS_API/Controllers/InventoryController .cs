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
    [Route("api/inventory")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryRepository _inventoryRepository;
        private readonly IMapper _mapper;

        public InventoryController(IMapper mapper, IInventoryRepository inventoryRepository)
        {
            _mapper = mapper;
            _inventoryRepository = inventoryRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] InventoryQueryObject query)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var inventoryItems = await _inventoryRepository.GetAllAsync();
                var inventoryDto = _mapper.Map<List<InventoryDto>>(inventoryItems);

                if (!string.IsNullOrEmpty(query.medicine))
                    inventoryDto = FilterHelper.Filter(inventoryDto, i => Regex.IsMatch(i.Medicine, Regex.Escape(query.medicine), RegexOptions.IgnoreCase));
                if (!string.IsNullOrEmpty(query.manufacturer))
                    inventoryDto = FilterHelper.Filter(inventoryDto, i => Regex.IsMatch(i.Manufacturer, Regex.Escape(query.manufacturer), RegexOptions.IgnoreCase));
                if (query.expiryDate != null)
                    inventoryDto = FilterHelper.Filter(inventoryDto, i => DateOnly.FromDateTime(i.ExpiryDate) > query.expiryDate);

                var skipNumber = (query.PageNumber - 1) * query.PageSize;
                return Ok(inventoryDto.Skip(skipNumber).Take(query.PageSize));
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

            try
            {
                var inventory = await _inventoryRepository.GetByIdAsync(id);
                if (inventory == null) return NotFound();
                return Ok(_mapper.Map<InventoryDto>(inventory));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while retrieving the inventory item", error = ex.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateInventoryDto inventoryDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var inventory = _mapper.Map<Inventory>(inventoryDto);
                await _inventoryRepository.CreateAsync(inventory);
                return CreatedAtAction(nameof(GetById), new { id = inventory.ItemId }, _mapper.Map<InventoryDto>(inventory));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while creating the inventory item", error = ex.Message });
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateInventoryDto updateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var updatedInventory = await _inventoryRepository.UpdateAsync(id, updateDto);
                if (updatedInventory == null) return NotFound();
                return Ok(_mapper.Map<InventoryDto>(updatedInventory));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while updating the inventory item", error = ex.Message });
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var deletedInventory = await _inventoryRepository.DeleteAsync(id);
                if (deletedInventory == null) return NotFound();
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while deleting the inventory item", error = ex.Message });
            }
        }
    }
}
