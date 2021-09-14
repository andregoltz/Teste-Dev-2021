using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Text;
using Teste.Domain;
using Teste.Domain.Entities;
using Teste.Domain.Models;

namespace Teste.Data.Extensions
{
    public static class ModelBuilderExtension
    {
        public static ModelBuilder ApplyGlobalConfiguration(this ModelBuilder builder)
        {
            foreach (IMutableEntityType entityType in builder.Model.GetEntityTypes())
            {
                foreach (IMutableProperty property in entityType.GetProperties())
                {
                    switch (property.Name)
                    {
                        case nameof(Person.Id):
                            property.IsKey();
                            break;
                        case nameof(Person.DateUpdated):
                            property.IsNullable = true;
                            break;
                        case nameof(Person.DateCreated):
                            property.IsNullable = false;
                            property.SetDefaultValue(DateTime.Now);
                            break;
                        case nameof(Person.IsDeleted):
                            property.IsNullable = false;
                            property.SetDefaultValue(false);
                            break;
                        default:
                            break;
                    }
                }
            }

            return builder;
        }

        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasData(
                new User
                {
                    Id = Guid.Parse("c7dce21b-d207-4869-bf5f-08eb138bb919"),
                    Name = "Admin",
                    Email = "admin@admin.com",
                    DateCreated = new DateTime(2021, 9, 11),
                    IsDeleted = false,
                    DateUpdated = null
                });

            builder.Entity<Client>()
                .HasData(
                new Client 
                {
                        Id = Guid.Parse("198770ac-2cea-4b6e-a272-82c6816939f7"),
                        Name = "Client Default",
                        DateCreated = new DateTime(2021, 9, 11),
                        IsDeleted = false,
                        DateUpdated = null,
                        BirthDate = new DateTime(1997, 1, 1),
                        CPF = "78607633031"

                });

            builder.Entity<ClientsTelephone>()
                .HasData(
                new ClientsTelephone
                {
                    Id = 1,
                    IdClient = Guid.Parse("198770ac-2cea-4b6e-a272-82c6816939f7"),
                    DDD = "041",
                    TelephoneNumber = "999999999",
                    IsDeleted = false
                });

            return builder;
        }
    }
}
