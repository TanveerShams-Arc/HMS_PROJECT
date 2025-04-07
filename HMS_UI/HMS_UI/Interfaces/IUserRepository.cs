using HMS_API.Dtos;

namespace HMS_UI.Interfaces
{
    interface IUserRepository
    {
        Task<HttpResponseMessage> LoginAsync(string username, string password);

        Task<ReceptionistDto> GetUserDataAsync();

        Task<HttpResponseMessage> RegisterUserAsync(object registrationDto);
    }
}
