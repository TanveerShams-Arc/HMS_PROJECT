using AutoMapper;
using HMS_API.DB;
using HMS_API.Dtos;
using HMS_API.Interfaces;
using HMS_API.Models;
using Microsoft.EntityFrameworkCore;

namespace HMS_API.Repositories
{
    public class PrescriptionRepository : IPrescriptionRepository
    {
        private readonly AppDBContext _context;

        public PrescriptionRepository(AppDBContext context)
        {
            _context = context;
        }

        public async Task<List<Prescription>> GetAllAsync()
        {
            return await _context.Prescription
                .Include(p => p.Patient).ThenInclude(a => a.AppUser)
                .Include(p => p.Doctor).ThenInclude(a => a.AppUser)
                .ToListAsync();
        }

        public async Task<Prescription?> GetByIdAsync(int id)
        {
            return await _context.Prescription
                .Include(p => p.Patient).ThenInclude(a => a.AppUser)
                .Include(p => p.Doctor).ThenInclude(a => a.AppUser)
                .FirstOrDefaultAsync(p => p.PrescriptionId == id);
        }

        public async Task<Prescription> CreateAsync(Prescription prescription)
        {
            await _context.Prescription.AddAsync(prescription);
            await _context.SaveChangesAsync();
            return await _context.Prescription
                .Include(p => p.Patient).ThenInclude(a => a.AppUser)
                .Include(p => p.Doctor).ThenInclude(a => a.AppUser)
                .FirstOrDefaultAsync(p => p.PrescriptionId == prescription.PrescriptionId);
        }

        public async Task<Prescription?> UpdateAsync(int id, UpdatePrescriptionDto prescriptionDto)
        {
            var existingPrescription = await _context.Prescription.FirstOrDefaultAsync(p => p.PrescriptionId == id);
            if (existingPrescription == null) return null;

            existingPrescription.MedicineDetails = prescriptionDto.MedicineDetails;
            existingPrescription.Notes = prescriptionDto.Notes;
            existingPrescription.PrescribedOn = prescriptionDto.PrescribedOn;

            await _context.SaveChangesAsync();

            return await _context.Prescription
                            .Include(p => p.Patient).ThenInclude(a => a.AppUser)
                            .Include(p => p.Doctor).ThenInclude(a => a.AppUser)
                            .FirstOrDefaultAsync(p => p.PrescriptionId == existingPrescription.PrescriptionId);
        }

        public async Task<Prescription?> DeleteAsync(int id)
        {
            var prescription = await _context.Prescription.FirstOrDefaultAsync(p => p.PrescriptionId == id);
            if (prescription == null) return null;

            _context.Prescription.Remove(prescription);
            await _context.SaveChangesAsync();
            return prescription;
        }
    }
}
