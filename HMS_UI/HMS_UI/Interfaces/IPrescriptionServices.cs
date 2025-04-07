using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_API.Dtos;
using HMS_API.HelperFunctions.QueryObjects;

namespace HMS_UI.Interfaces
{
    public interface IPrescriptionServices
    {
            
        Task<List<PrescriptionDto>?> GetPrescriptionAsync(PrescriptionQueryObject query);

        Task<bool> UpdatePrescriptionAsync(string? PrescriptionId, string? status);

        Task<bool> CreatePrescriptionAsync(string? pID, string? dID, DateTime prescribedOn, string? medicineDetails, string notes);

        Task<bool> DeletePrescriptionAsync(int eventID);
    }
}
    
