using HMS_UI.Forms;
using HMS_UI.HelperFunctions;
using HMS_UI.Interfaces;
using HMS_UI.Repositories;
using HMS_UI.Services;
using Microsoft.Extensions.DependencyInjection;
using Inventory = HMS_UI.Forms.Inventory;

namespace HMS_UI
{
    internal static class Program
    {
        private static ServiceProvider _serviceProvider;

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var services = new ServiceCollection();
            ConfigureServices(services);

            DIContainer.ServiceProvider = services.BuildServiceProvider();

            _serviceProvider = DIContainer.ServiceProvider;

            Application.Run(new MainApplicationContext(_serviceProvider));
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IAppointmentServices, AppointmentServices>();
            services.AddScoped<IDoctorServices, DoctorServices>();
            services.AddScoped<IPatientServices, PatientServices>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRecordServices, RecordServices>();
            services.AddScoped<IInventoryServices, InventoryServices>();
            services.AddScoped<IHMSTransactionServices, HMSTransactionServices>();


            services.AddScoped<IAppointmentRepository, AppointmentRepository>();
            services.AddScoped<IDoctorRepository, DoctorRepository>();
            services.AddScoped<IPatientRepository, PatientRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IRecordRepository, RecordRepository>();
            services.AddScoped<IInventoryRepository, InventoryRepository>();
            services.AddScoped<IHMSTransactionRepository, HMSTransactionRepository>();




            services.AddTransient<Login>();
            services.AddTransient<Appointment>();
            services.AddTransient<Registration>();
            services.AddTransient<CreateAppointment>();
            services.AddTransient<CreateTransaction>();
            services.AddTransient<CreatePatient>();
            services.AddTransient<CreateDoctor>();
            services.AddTransient<Dashboard>();
            services.AddTransient<Doctors>();
            services.AddTransient<MedicalRecords>();
            services.AddTransient<CreateRecord>();
            services.AddTransient<Inventory>();
            services.AddTransient<CreateInventory>();
            services.AddTransient<HMSTransactions>();

        }
    }

    public class MainApplicationContext : ApplicationContext
    {
        private readonly ServiceProvider _serviceProvider;
        public MainApplicationContext(ServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            Login loginForm = DIContainer.ServiceProvider.GetRequiredService<Login>();
            loginForm.FormClosed += OnLoginFormClosed;
            loginForm.Show();
        }

        private void OnLoginFormClosed(object sender, FormClosedEventArgs e)
        {
            Login loginForm = sender as Login;

            //MessageBox.Show($"DEBUG: Login form closed. IsNavigatingToRegistration: {Login.IsNavigatingToRegistration}");

            if (loginForm.isLoggedIn)
            {
                Dashboard dash = DIContainer.ServiceProvider.GetRequiredService<Dashboard>();
                dash.Show();
            }
            else if (Login.IsNavigatingToRegistration)
            {
                //MessageBox.Show("DEBUG: Opening Registration Form");
                Login.IsNavigatingToRegistration = false;
                Registration regForm = DIContainer.ServiceProvider.GetRequiredService<Registration>();
                regForm.Show();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
