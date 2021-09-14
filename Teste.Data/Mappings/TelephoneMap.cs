using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Teste.Domain.Entities;

namespace Teste.Data.Mappings
{
    public class TelephoneMap : IEntityTypeConfiguration<ClientsTelephone>
    {
        public void Configure(EntityTypeBuilder<ClientsTelephone> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.IdClient).IsRequired();

            builder.Property(x => x.DDD).HasMaxLength(3).IsRequired();

            builder.Property(x => x.TelephoneNumber).IsRequired();
        }
    }
}
