using Microsoft.Extensions.DependencyInjection;

namespace HMS_UI.HelperFunctions
{
    public static class DIContainer
    {
        public static ServiceProvider? _serviceProvider { get; set; }


        public static ServiceProvider ServiceProvider
        {
            get => _serviceProvider ?? throw new InvalidOperationException("ServiceProvider has not been initialized.");
            set => _serviceProvider = value ?? throw new ArgumentNullException(nameof(value), "Cannot set ServiceProvider to null.");
        }

    }

}
