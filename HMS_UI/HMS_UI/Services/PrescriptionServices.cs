using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_API.Dtos;
using HMS_API.HelperFunctions.QueryObjects;
using HMS_API.Models;
using HMS_UI.Interfaces;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace HMS_UI.Services
{
    internal class PrescriptionServices(IPrescriptionRepository prescriptionRepository) : IPrescriptionServices
    {
        private readonly IPrescriptionRepository _prescriptionRepository = prescriptionRepository;
        public async Task<bool> CreatePrescriptionAsync(string? pID, string? dID, DateTime prescribedOn, string? medicineDetails, string notes)
        {
            if (string.IsNullOrEmpty(pID) || string.IsNullOrEmpty(dID))
                throw new NoNullAllowedException("Value cannot be null!");

            int patientId = int.Parse(pID);
            int doctorId = int.Parse(dID);


            var prescriptionDto = new
            {
                patientId,
                doctorId,
                medicineDetails,
                notes,
                prescribedOn
            };

            return await _prescriptionRepository.CreatePrescriptionAsync(prescriptionDto); 
        }


        public async Task<bool> DeletePrescriptionAsync(int eventID)
        {
            if (eventID <= 0)
                throw new ArgumentException("Invalid Event ID.");

            return await _prescriptionRepository.DeletePrescriptionAsync(eventID);
        }


        public async Task<List<PrescriptionDto>?> GetPrescriptionAsync(PrescriptionQueryObject query)
        {
            ArgumentNullException.ThrowIfNull(query);

            return await _prescriptionRepository.GetPrescriptionAsync(query);
        }

        public async Task<bool> UpdatePrescriptionAsync(string? PrescriptionId, string? status)
        {
            if (string.IsNullOrEmpty(PrescriptionId) || (!int.TryParse(PrescriptionId, out int prID)) || prID < 0)
            {
                MessageBox.Show("Invalid prescription ID.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(status))
            {
                MessageBox.Show("Status cannot be empty.");
                return false;
            }

            return await _prescriptionRepository.UpdatePrescriptionAsync(prID, status);
        }
    }
}
