using System.Security.Claims;
using HMS_API.DB;
using HMS_API.Interfaces;
using HMS_API.Models;
using HMS_API.Models.Persons;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

public class DbSeeder
{
    private readonly UserManager<AppUser> _userManager;
    private readonly IDoctorRepository _doctorRepository;
    private readonly IPatientRepository _patientRepository;
    private readonly IReceptionistRepository _receptionistRepository;
    private readonly AppDBContext _context;

    public DbSeeder(UserManager<AppUser> userManager, IDoctorRepository doctorRepository, IPatientRepository patientRepository,
        IReceptionistRepository receptionistRepository, AppDBContext context)
    {
        _userManager = userManager;
        _doctorRepository = doctorRepository;
        _patientRepository = patientRepository;
        _receptionistRepository = receptionistRepository;
        _context = context;
    }


    public async Task SeedDataAsync()
    {
        if (await _context.Users.AnyAsync())
            return;

        await SeedUserDataAsync();
        await SeedAppointmentDataAsync();
        await SeedHMSTransactionDataAsync();
        await SeedInventoryDataAsync();
        await SeedMedicalRecordsDataAsync();
        await SeedPrescriptionDataAsync();
    }

    private async Task SeedUserDataAsync()
    {
        if (await _context.Users.AnyAsync())
            return;


        for (int i = 1; i <= 2; i++)
        {
            var admin = new AppUser
            {
                UserName = $"admin{i}",
                Email = $"admin{i}@hms.com",
                FullName = $"Admin User {i}",
                PhoneNumber = $"12345678{i}"
            };

            var createAdminResult = await _userManager.CreateAsync(admin, $"151351Ad{i}min@123(){i}@!@#");
            if (createAdminResult.Succeeded)
            {
                await _userManager.AddToRoleAsync(admin, "admin");
                await AddClaimsAsync(admin, "admin");
            }
        }

        for (int i = 1; i <= 10; i++)
        {
            var doctor = new AppUser
            {
                UserName = $"doctor{i}",
                Email = $"doctor.doc{i}@hms.com",
                FullName = $"Dr. Seed Doc {i}",
                PhoneNumber = $"198765432{i - 1}"
            };

            var createDoctorResult = await _userManager.CreateAsync(doctor, "aDoctor@123)(ft");
            if (createDoctorResult.Succeeded)
            {
                await _userManager.AddToRoleAsync(doctor, "doctor");


                var doctorDetails = new Doctor
                {
                    AppUserId = doctor.Id,
                    DoctorSpecialization = $"Specialization lvl-{i}",
                    DoctorExperience = 10 + i
                };

                await _doctorRepository.CreateAsync(doctorDetails);


                await AddClaimsAsync(doctor, "doctor", new List<Claim>
                {
                    new Claim("DoctorSpecialization", $"Specialization {i}")
                });
            }
        }


        for (int i = 1; i <= 10; i++)
        {
            var patient = new AppUser
            {
                UserName = $"patient{i}",
                Email = $"patient{i}@hms.com",
                FullName = $"Jane Doe {i}",
                PhoneNumber = $"545678912{i - 1}"
            };

            var createPatientResult = await _userManager.CreateAsync(patient, "Patient@123()45");
            if (createPatientResult.Succeeded)
            {
                await _userManager.AddToRoleAsync(patient, "patient");

                var patientDetails = new Patient
                {
                    AppUserId = patient.Id,
                    PatientDOB = new DateOnly(1990, 5, 10),
                    PatientBloodGroup = i % 2 == 0 ? "O+" : "A+",
                    PatientAddress = $"Address {i + 1}"
                };

                await _patientRepository.CreateAsync(patientDetails);


                await AddClaimsAsync(patient, "patient", new List<Claim>
                {
                    new Claim("PatientBloodGroup", i % 2 == 0 ? "O+" : "A-")
                });
            }
        }


        for (int i = 1; i <= 10; i++)
        {
            var receptionist = new AppUser
            {
                UserName = $"receptionist{i}",
                Email = $"receptionist{i}@hms.com",
                FullName = $"Samantha Green {i}",
                PhoneNumber = $"724185296{i + 2}"
            };

            var createReceptionistResult = await _userManager.CreateAsync(receptionist, "Receptionist@123(){}");
            if (createReceptionistResult.Succeeded)
            {
                await _userManager.AddToRoleAsync(receptionist, "receptionist");

                var receptionistDetail = new Receptionist
                {
                    AppUserId = receptionist.Id,
                };

                await _receptionistRepository.CreateAsync(receptionistDetail);


                await AddClaimsAsync(receptionist, "receptionist");
            }
        }
    }


    private async Task SeedAppointmentDataAsync()
    {
        for (int i = 1; i <= 10; i++)
        {
            var doctorId = i;
            var patientId = i;
            var receptionistId = i;

            var appointment = new Appointment
            {
                DoctorId = doctorId,
                PatientId = patientId,
                ReceptionistId = receptionistId,
                AppointmentDate = DateTime.Now.AddDays(i),
                Status = "Scheduled"
            };

            await _context.Appointments.AddAsync(appointment);
        }

        await _context.SaveChangesAsync();
    }


    private async Task SeedHMSTransactionDataAsync()
    {
        for (int i = 1; i <= 10; i++)
        {
            var patientId = i;

            var transaction = new HMSTransactionPar
            {
                PatientId = patientId,
                Amount = 100 + i,
                PaidAmount = 50 + i,
                Status = "Completed",
                TransactionDate = DateTime.Now.AddDays(i)
            };

            await _context.HMSTransactionPar.AddAsync(transaction);
        }

        await _context.SaveChangesAsync();
    }


    private async Task SeedInventoryDataAsync()
    {
        for (int i = 1; i <= 10; i++)
        {
            var inventoryItem = new Inventory
            {
                Medicine = $"Medicine {i}",
                MedicineQuantity = 100 + i,
                Manufacturer = $"Manufacturer {i}",
                ExpiryDate = DateTime.Now.AddYears(1),
                LastUpdatedOn = DateTime.Now
            };

            await _context.Inventory.AddAsync(inventoryItem);
        }

        await _context.SaveChangesAsync();
    }


    private async Task SeedMedicalRecordsDataAsync()
    {
        for (int i = 1; i <= 10; i++)
        {
            var patientId = i;

            var medicalRecord = new MedicalRecords
            {
                PatientId = patientId,
                RecordType = "General Checkup",
                RecordData = $"Record data for Patient {i}",
                RecordCreatedOn = DateTime.Now.AddDays(i)
            };

            await _context.MedicalRecords.AddAsync(medicalRecord);
        }

        await _context.SaveChangesAsync();
    }


    private async Task SeedPrescriptionDataAsync()
    {
        for (int i = 1; i <= 10; i++)
        {
            var patientId = i;
            var doctorId = i;

            var prescription = new Prescription
            {
                PatientId = patientId,
                DoctorId = doctorId,
                MedicineDetails = $"Medicine details for Patient {i}",
                Notes = $"Prescription notes for Patient {i}",
                PrescribedOn = DateTime.Now.AddDays(i)
            };

            await _context.Prescription.AddAsync(prescription);
        }

        await _context.SaveChangesAsync();
    }



    private async Task AddClaimsAsync(AppUser user, string role, List<Claim> additionalClaims = null)
    {
        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id),
            new Claim(ClaimTypes.Name, user.FullName),
            new Claim(ClaimTypes.Email, user.Email),
            new Claim("UserType", role)
        };

        if (additionalClaims != null)
        {
            claims.AddRange(additionalClaims);
        }

        await _userManager.AddClaimsAsync(user, claims);
    }
}
