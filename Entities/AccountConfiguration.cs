using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Entities
{
    internal class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {        
            builder.HasData
            (
                new Account
                {
                    Id = new Guid("f98e4d74-0f68-4aac-89fd-047f1aaca6b6"),
                    DateCreated = new DateTime(2003, 12, 15),
                    AccountType = "Domestic",
                    OwnerId = new Guid("24fd81f8-d58a-4bcc-9f35-dc6cd5641906")
                },
                new Account
                {
                    Id = new Guid("356a5a9b-64bf-4de0-bc84-5395a1fdc9c4"),
                    DateCreated = new DateTime(1996, 2, 15),
                    AccountType = "Domestic",
                    OwnerId = new Guid("261e1685-cf26-494c-b17c-3546e65f5620")
                },
                new Account
                {
                    Id = new Guid("371b93f2-f8c5-4a32-894a-fc672741aa5b"),
                    DateCreated = new DateTime(1999, 5, 4),
                    AccountType = "Domestic",
                    OwnerId = new Guid("24fd81f8-d58a-4bcc-9f35-dc6cd5641906")
                },
                new Account
                {
                    Id = new Guid("670775db-ecc0-4b90-a9ab-37cd0d8e2801"),
                    DateCreated = new DateTime(1999, 12, 21),
                    AccountType = "Savings",
                    OwnerId = new Guid("24fd81f8-d58a-4bcc-9f35-dc6cd5641906")
                },
                new Account
                {
                    Id = new Guid("a3fbad0b-7f48-4feb-8ac0-6d3bbc997bfc"),
                    DateCreated = new DateTime(2010, 5, 28),
                    AccountType = "Domestic",
                    OwnerId = new Guid("a3c1880c-674c-4d18-8f91-5d3608a2c937")
                }
            );
        }
    }
}