using NOTEBOARD.DAL.EntityConfiguration;
using NOTEBOARD.DAL.Strategy;
using NOTEBOARD.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTEBOARD.DAL
{
    public class NoteBoardDbContext : DbContext
    {
        //connString
        public NoteBoardDbContext() : base(@"Server=DESKTOP-DI00GF5\SQLSERVERBILADAM;Database=CalorieModel;Trusted_Connection=True;")
        {
            //strategy
            Database.SetInitializer(new NoteBoardInitializeStrategy());
        }

        //DbSet
        public DbSet<User> Users { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Password> Passwords { get; set; }

        //onmodelCreating
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new NoteConfiguration());
            modelBuilder.Configurations.Add(new PasswordConfiguration());
        }

    }
}
