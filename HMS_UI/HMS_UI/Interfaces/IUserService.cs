using HMS_API.Dtos;

namespace HMS_UI.Interfaces
{
    public interface IUserService
    {
        Task<ReceptionistDto> GetUserDataAsync();

        Task<string> LoginAsync(string username, string password);

        Task<string> RegisterUserAsync(string username, string fullname, string email, string phone, string password,
        string role, string? doctorSpecialization, string? doctorExperience, DateOnly? patientDOB, string? patientBloodGroup, string? patientAddress);

    }
}
