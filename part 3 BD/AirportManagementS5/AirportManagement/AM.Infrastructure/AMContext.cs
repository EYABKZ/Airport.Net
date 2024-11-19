using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domain;
using AM.Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;


namespace AM.Infrastructure
{
     class AMContext :DbContext 
    {
        // Redéfinir la méthode OnConfiguring
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            object value= optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
           Initial Catalog=AirportManagementDB;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            // Configure toutes les propriétés de type DateTime
            configurationBuilder.Properties<DateTime>()
                                .HaveColumnType("date");

            base.ConfigureConventions(configurationBuilder);
        }

        public DbSet <Flight> Flights { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Passenger> Passes { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet <Traveller> Travellers { get; set; }
        public DbSet    <PlaneConfiguration> MyPlanes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuration de la relation many-to-many
            modelBuilder.Entity<Passenger>()
                .HasMany(p => p.Flights)
                .WithMany(f => f.Passengers)
                .UsingEntity(j => j.ToTable("PassengerFlights"));

            base.OnModelCreating(modelBuilder);
    
        
            // Configurer l’héritage TPH
            modelBuilder.Entity<Passenger>()
                .HasDiscriminator<int>("IsTraveller") // Nom de la colonne discriminante
                .HasValue<Passenger>(0)              // Valeur par défaut pour Passenger
                .HasValue<Traveller>(1)              // Valeur pour Traveller
                .HasValue<Staff>(2);                 // Valeur pour Staff


            base.OnModelCreating(modelBuilder);
            // Configurer la stratégie TPT
            modelBuilder.Entity<Passenger>().ToTable("Passengers"); // Table de base
            modelBuilder.Entity<Traveller>().ToTable("Travellers"); // Table pour Traveller
            modelBuilder.Entity<Staff>().ToTable("Staffs");         // Table pour Staff



        }



    }
}



