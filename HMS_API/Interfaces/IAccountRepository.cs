namespace HMS_API.Interfaces
{
    public interface IAccountRepository
    {
        Task<T?> GetAsync<T>(string appUserId) where T : class;
    }
}
