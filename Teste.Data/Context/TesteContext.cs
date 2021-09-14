using Microsoft.EntityFrameworkCore;
using System;
using Teste.Data.Extensions;
using Teste.Data.Mappings;
using Teste.Domain;
using Teste.Domain.Entities;

namespace Teste.Data
{
    public class TesteContext : DbContext
    {
        public TesteContext(DbContextOptions<TesteContext> options)
            :base(options)
        {
        }

        #region DBSets
            public DbSet<User> Users { get; set; }
            public DbSet<Client> Clients { get; set; }
            public DbSet<ClientsTelephone> Telephones { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());

            modelBuilder.ApplyConfiguration(new ClientMap());

            modelBuilder.ApplyConfiguration(new TelephoneMap());

            modelBuilder.ApplyGlobalConfiguration();

            modelBuilder.SeedData();

            base.OnModelCreating(modelBuilder);
        }
    }
}
