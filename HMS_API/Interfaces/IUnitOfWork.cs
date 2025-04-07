using HMS_API.Interfaces;
using System.Threading.Tasks;

namespace HMS_API.Interfaces
{
    public interface IUnitOfWork
    {
        IAccountRepository AccountRepository { get; }
        IDoctorRepository DoctorRepository { get; }
        IPatientRepository PatientRepository { get; }
        IReceptionistRepository ReceptionistRepository { get; }
        IAppointmentRepository AppointmentRepository { get; }
        IPrescriptionRepository PrescriptionRepository { get; }
        IHMSTransactionParRepository HMSTransactionParRepository { get; }
        IInventoryRepository InventoryRepository { get; }
        IMedicalRecordsRepository MedicalRecordsRepository { get; }

        Task<int> SaveAsync();
    }
}
