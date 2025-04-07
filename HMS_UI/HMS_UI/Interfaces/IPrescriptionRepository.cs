using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_API.Dtos;
using HMS_API.HelperFunctions.QueryObjects;

namespace HMS_UI.Interfaces
{
    public interface IPrescriptionRepository
    {
        Task<bool> CreatePrescriptionAsync(object Prescription);

        Task<List<PrescriptionDto>?> GetPrescriptionAsync(PrescriptionQueryObject query);

        Task<bool> UpdatePrescriptionAsync(int PrescriptionId, string status);

        Task<bool> DeletePrescriptionAsync(int PrescriptionId);

    }

}
