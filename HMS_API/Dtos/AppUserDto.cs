namespace HMS_API.Dtos
{
    public class AppUserDto
    {
        //public string Id { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
    }


    public class UserWithProfileDto<T> where T : class
    {
        public AppUserDto AppUser { get; set; } = null!;
        public T Profile { get; set; } = null!;
    }
}
