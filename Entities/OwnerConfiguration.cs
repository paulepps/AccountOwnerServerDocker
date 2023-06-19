using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Entities
{
    internal class OwnerConfiguration : IEntityTypeConfiguration<Owner>
    {
        public void Configure(EntityTypeBuilder<Owner> builder)
        {
            builder.HasData
            (
            new Owner
            {
                Id = new Guid("24fd81f8-d58a-4bcc-9f35-dc6cd5641906"),
                Name = "John Keen",
                DateOfBirth = new DateTime(1980,12,5),
                Address = "61 Wellfield Road"
            },
            new Owner
            {
                Id = new Guid("261e1685-cf26-494c-b17c-3546e65f5620"),
                Name = "Anna Bosh",
                DateOfBirth = new DateTime(1974,11,15),
                Address = "27 Rainbow Row"
            },
            new Owner
            {
                Id = new Guid("66774006-2371-4d5b-8518-2177bcf3f73e"),
                Name = "Nick Somion",
                DateOfBirth = new DateTime(1998,12,15),
                Address = "North Sunny Address 102"
            }
            );
        }

    }
}