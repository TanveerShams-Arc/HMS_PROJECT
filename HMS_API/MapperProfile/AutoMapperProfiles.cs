using AutoMapper;
using HMS_API.Dtos;
using HMS_API.Dtos.DumpsForNow;
using HMS_API.Models;


namespace HMS_API.MapperProfile
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Doctor, DoctorDto>()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.AppUser.FullName))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.AppUser.Email))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.AppUser.PhoneNumber)).ReverseMap();
            CreateMap<Doctor, CreateDoctorDto>().ReverseMap();
            CreateMap<Doctor, UpdateDoctorDto>().ReverseMap();


            CreateMap<Patient, PatientDto>()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.AppUser.FullName))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.AppUser.Email))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.AppUser.PhoneNumber)).ReverseMap();
            CreateMap<Patient, CreatePatientDto>().ReverseMap();
            CreateMap<Patient, UpdatePatientDto>().ReverseMap();


            CreateMap<Receptionist, ReceptionistDto>()
            .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.AppUser.FullName))
            .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.AppUser.Email))
            .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.AppUser.PhoneNumber)).ReverseMap();
            CreateMap<Receptionist, CreateReceptionistDto>().ReverseMap();
            CreateMap<Receptionist, UpdateReceptionistDto>().ReverseMap();


            CreateMap<Admin, AdminDto>().ReverseMap();


            CreateMap<Appointment, AppointmentDto>()
                .ForMember(dest => dest.PatientFullname, opt => opt.MapFrom(src => src.Patient.AppUser.FullName))
                .ForMember(dest => dest.DoctorFullname, opt => opt.MapFrom(src => src.Doctor.AppUser.FullName))
                .ForMember(dest => dest.ReceptionistFullname, opt => opt.MapFrom(src => src.Receptionist.AppUser.FullName))
                .ForMember(dest => dest.doctorSpecialization, opt => opt.MapFrom(src => src.Doctor.DoctorSpecialization));
            CreateMap<Appointment, CreateAppointmentDto>().ReverseMap();
            CreateMap<Appointment, UpdateAppointmentDto>().ReverseMap();


            CreateMap<MedicalRecords, MedicalRecordsDto>()
                .ForMember(dest => dest.PatientName, opt => opt.MapFrom(src => src.Patient.AppUser.FullName));
            CreateMap<MedicalRecords, CreateMedicalRecordsDto>().ReverseMap();
            CreateMap<MedicalRecords, UpdateMedicalRecordsDto>().ReverseMap();



            CreateMap<Prescription, PrescriptionDto>()
                .ForMember(dest => dest.PatientName, opt => opt.MapFrom(src => src.Patient.AppUser.FullName))
                .ForMember(dest => dest.DoctorName, opt => opt.MapFrom(src => src.Doctor.AppUser.FullName));
            CreateMap<Prescription, CreatePrescriptionDto>().ReverseMap();
            CreateMap<Prescription, UpdatePrescriptionDto>().ReverseMap();


            CreateMap<HMSTransactionPar, HMSTransactionParDto>()
                .ForMember(dest => dest.PatientName, opt => opt.MapFrom(src => src.Patient.AppUser.FullName));
            CreateMap<HMSTransactionPar, CreateHMSTransactionParDto>().ReverseMap();
            CreateMap<HMSTransactionPar, UpdateHMSTransactionParDto>().ReverseMap();

            CreateMap<Inventory, InventoryDto>().ReverseMap();
            CreateMap<Inventory, CreateInventoryDto>().ReverseMap();
            CreateMap<Inventory, UpdateInventoryDto>().ReverseMap();
        }
    }
}
