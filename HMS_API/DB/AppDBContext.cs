using HMS_API.Models;
using HMS_API.Models.Persons;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HMS_API.DB
{
    public class AppDBContext : IdentityDbContext<AppUser>
    {
        public AppDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Receptionist> Receptionist { get; set; }

        public DbSet<Admin> Admin { get; set; }

        public DbSet<Appointment> Appointments { get; set; }

        public DbSet<HMSTransactionPar> HMSTransactionPar { get; set; }
        public DbSet<MedicalRecords> MedicalRecords { get; set; }
        public DbSet<Prescription> Prescription { get; set; }
        public DbSet<Inventory> Inventory { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Patient>()
                .HasOne(p => p.AppUser)
                .WithOne(a => a.Patient)
                .HasForeignKey<Patient>(p => p.AppUserId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.Entity<Doctor>()
                .HasOne(d => d.AppUser)
                .WithOne(a => a.Doctor)
                .HasForeignKey<Doctor>(d => d.AppUserId)
                .OnDelete(DeleteBehavior.Restrict);

            List<IdentityRole> roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Id = "1A2B3C4D-1234-5678-ABCD-1234567890AB",
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Id = "2B3C4D5E-2345-6789-BCDE-2345678901BC",
                    Name = "Doctor",
                    NormalizedName = "DOCTOR"
                },
                new IdentityRole
                {
                    Id = "3C4D5E6F-3456-789A-CDEF-3456789012CD",
                    Name = "Patient",
                    NormalizedName = "PATIENT"
                },
                new IdentityRole
                {
                    Id = "4D5E6F70-4567-89AB-DEFG-4567890123DE",
                    Name = "Pharmacist",
                    NormalizedName = "PHARMACIST"
                },
                new IdentityRole
                {
                    Id = "5E6F7081-5678-9ABC-EFGH-5678901234EF",
                    Name = "Receptionist",
                    NormalizedName = "RECEPTIONIST"
                },
                new IdentityRole
                {
                    Id = "6F708192-6789-ABCD-FGHI-6789012345F0",
                    Name = "LabTechnisian",
                    NormalizedName = "LABTECHNISIAN"
                }
            };

            builder.Entity<IdentityRole>().HasData(roles);
        }





        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);

        //    List<IdentityRole> roles = new List<IdentityRole>
        //    {
        //        new IdentityRole
        //        {
        //            Name = "Admin",
        //            NormalizedName = "ADMIN"
        //        },
        //        new IdentityRole
        //        {
        //            Name = "User",
        //            NormalizedName = "USER"
        //        }
        //    };

        //    builder.Entity<IdentityRole>().HasData(roles);

        //}

    }
}
