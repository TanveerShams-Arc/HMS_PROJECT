namespace HMS_UI.Services
{
    public class AuthService
    {
        private static readonly object _lock = new object();
        private static AuthService? _instance;

        public string JwtToken { get; private set; } = string.Empty;

        private AuthService() { }

        public static AuthService Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                            _instance = new AuthService();
                    }
                }
                return _instance;
            }
        }

        public void SetToken(string? token)
        {
            if (!string.IsNullOrWhiteSpace(token))
                JwtToken = token;
        }
    }


    public sealed class HttpClientSingleton
    {
        private static readonly Lazy<HttpClient> _httpClientInstance =
            new Lazy<HttpClient>(() => new HttpClient { BaseAddress = new Uri("https://localhost:7192/") });

        public static HttpClient Instance => _httpClientInstance.Value;

        private HttpClientSingleton() { }
    }
}

