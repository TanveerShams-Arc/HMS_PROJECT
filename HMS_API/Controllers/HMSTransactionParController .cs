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
    [Route("api/[controller]")]
    [ApiController]
    public class HMSTransactionParController : ControllerBase
    {
        private readonly IHMSTransactionParRepository _transactionRepository;
        private readonly IMapper _mapper;

        public HMSTransactionParController(IMapper mapper, IHMSTransactionParRepository transactionRepository)
        {
            _mapper = mapper;
            _transactionRepository = transactionRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] TransactionQueryObject query)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var transactions = await _transactionRepository.GetAllAsync();
                var transactionDto = _mapper.Map<List<HMSTransactionParDto>>(transactions);

                if (!string.IsNullOrEmpty(query.PatientName))
                    transactionDto = FilterHelper.Filter(transactionDto, t => Regex.IsMatch(t.PatientName, Regex.Escape(query.PatientName), RegexOptions.IgnoreCase));
                if (query.TransactionDate != null)
                    transactionDto = FilterHelper.Filter(transactionDto, t => t.TransactionDate.Date == query.TransactionDate.Value.Date);
                if (query.Status != null)
                    transactionDto = FilterHelper.Filter(transactionDto, t => t.Status.ToLower().Contains(query.Status.ToLower()));
                if (query.Amount != null)
                    transactionDto = FilterHelper.Filter(transactionDto, t => t.Amount == query.Amount);
                if (query.PaidAmount != null)
                    transactionDto = FilterHelper.Filter(transactionDto, t => t.PaidAmount == query.PaidAmount);

                var skipNumber = (query.PageNumber - 1) * query.PageSize;
                return Ok(transactionDto.Skip(skipNumber).Take(query.PageSize));
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
                var transaction = await _transactionRepository.GetByIdAsync(id);
                if (transaction == null) return NotFound();
                return Ok(_mapper.Map<HMSTransactionParDto>(transaction));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while retrieving the transaction", error = ex.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateHMSTransactionParDto transactionDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var transaction = _mapper.Map<HMSTransactionPar>(transactionDto);
                await _transactionRepository.CreateAsync(transaction);
                return CreatedAtAction(nameof(GetById), new { id = transaction.TransactionId }, _mapper.Map<HMSTransactionParDto>(transaction));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while creating the transaction", error = ex.Message });
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateHMSTransactionParDto updateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var updatedTransaction = await _transactionRepository.UpdateAsync(id, updateDto);
                if (updatedTransaction == null) return NotFound();
                return Ok(_mapper.Map<HMSTransactionParDto>(updatedTransaction));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while updating the transaction", error = ex.Message });
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
                var deletedTransaction = await _transactionRepository.DeleteAsync(id);
                if (deletedTransaction == null) return NotFound();
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while deleting the transaction", error = ex.Message });
            }
        }
    }
}
