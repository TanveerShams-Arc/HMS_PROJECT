using HMS_API.DB;
using HMS_API.Interfaces;
using HMS_API.Models.Persons;
using Microsoft.AspNetCore.Identity;

namespace HMS_API.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDBContext _context;
        private readonly ITokenService _tokenService;
        private readonly UserManager<AppUser> _userManager;

        public UnitOfWork(AppDBContext context, ITokenService tokenService, UserManager<AppUser> userManager)
        {
            _context = context;
            _tokenService = tokenService;
            _userManager = userManager;
        }

        private IAccountRepository _accountRepository;
        private IDoctorRepository _doctorRepository;
        private IPatientRepository _patientRepository;
        private IReceptionistRepository _receptionistRepository;
        private IAppointmentRepository _appointmentRepository;
        private IPrescriptionRepository _prescriptionRepository;
        private IHMSTransactionParRepository _hmsTransactionParRepository;
        private IInventoryRepository _inventoryRepository;
        private IMedicalRecordsRepository _medicalRecordsRepository;

        public IAccountRepository AccountRepository =>
            _accountRepository ??= new AccountRepository(_context);

        public IDoctorRepository DoctorRepository =>
            _doctorRepository ??= new DoctorRepository(_context, _tokenService, _userManager);

        public IPatientRepository PatientRepository =>
            _patientRepository ??= new PatientRepository(_context, _tokenService, _userManager);

        public IReceptionistRepository ReceptionistRepository =>
            _receptionistRepository ??= new ReceptionistRepository(_context, _tokenService, _userManager);

        public IAppointmentRepository AppointmentRepository =>
            _appointmentRepository ??= new AppointmentRepository(_context);

        public IPrescriptionRepository PrescriptionRepository =>
            _prescriptionRepository ??= new PrescriptionRepository(_context);

        public IHMSTransactionParRepository HMSTransactionParRepository =>
            _hmsTransactionParRepository ??= new HMSTransactionParRepository(_context);

        public IInventoryRepository InventoryRepository =>
            _inventoryRepository ??= new InventoryRepository(_context);

        public IMedicalRecordsRepository MedicalRecordsRepository =>
            _medicalRecordsRepository ??= new MedicalRecordsRepository(_context);

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
