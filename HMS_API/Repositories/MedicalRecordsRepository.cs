// MedicalRecordsRepository.cs
using HMS_API.DB;
using HMS_API.Dtos;
using HMS_API.Interfaces;
using HMS_API.Models;
using Microsoft.EntityFrameworkCore;

namespace HMS_API.Repositories
{
    public class MedicalRecordsRepository : IMedicalRecordsRepository
    {
        private readonly AppDBContext _context;

        public MedicalRecordsRepository(AppDBContext context)
        {
            _context = context;
        }

        public async Task<List<MedicalRecords>> GetAllAsync()
        {
            return await _context.MedicalRecords.Include(mr => mr.Patient).ThenInclude(a => a.AppUser).ToListAsync();
        }

        public async Task<MedicalRecords?> GetByIdAsync(int id)
        {
            return await _context.MedicalRecords.Include(mr => mr.Patient).ThenInclude(a => a.AppUser).FirstOrDefaultAsync(mr => mr.RecordId == id);
        }

        public async Task<MedicalRecords> CreateAsync(MedicalRecords medicalRecord)
        {
            await _context.MedicalRecords.AddAsync(medicalRecord);
            await _context.SaveChangesAsync();
            return await _context.MedicalRecords.Include(mr => mr.Patient).ThenInclude(a => a.AppUser)
                .FirstOrDefaultAsync(mr => mr.RecordId == medicalRecord.RecordId);
        }

        public async Task<MedicalRecords?> UpdateAsync(int id, UpdateMedicalRecordsDto medicalRecordDto)
        {
            var existingRecord = await _context.MedicalRecords.FirstOrDefaultAsync(mr => mr.RecordId == id);
            if (existingRecord == null) return null;

            existingRecord.RecordType = medicalRecordDto.RecordType;
            existingRecord.RecordData = medicalRecordDto.RecordData;

            await _context.SaveChangesAsync();
            return await _context.MedicalRecords.Include(mr => mr.Patient).ThenInclude(a => a.AppUser)
                .FirstOrDefaultAsync(mr => mr.RecordId == existingRecord.RecordId);

        }

        public async Task<MedicalRecords?> DeleteAsync(int id)
        {
            var medicalRecord = await _context.MedicalRecords.FirstOrDefaultAsync(mr => mr.RecordId == id);
            if (medicalRecord == null) return null;

            _context.MedicalRecords.Remove(medicalRecord);
            await _context.SaveChangesAsync();
            return medicalRecord;
        }
    }
}
