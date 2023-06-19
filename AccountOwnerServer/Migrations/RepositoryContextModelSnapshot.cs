﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AccountOwnerServer.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Entities.Models.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AccountId")
                        .HasColumnType("char(36)");

                    b.Property<string>("AccountType")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("OwnerId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("account");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f98e4d74-0f68-4aac-89fd-047f1aaca6b6"),
                            AccountType = "Domestic",
                            DateCreated = new DateTime(2003, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OwnerId = new Guid("24fd81f8-d58a-4bcc-9f35-dc6cd5641906")
                        },
                        new
                        {
                            Id = new Guid("356a5a9b-64bf-4de0-bc84-5395a1fdc9c4"),
                            AccountType = "Domestic",
                            DateCreated = new DateTime(1996, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OwnerId = new Guid("261e1685-cf26-494c-b17c-3546e65f5620")
                        },
                        new
                        {
                            Id = new Guid("371b93f2-f8c5-4a32-894a-fc672741aa5b"),
                            AccountType = "Domestic",
                            DateCreated = new DateTime(1999, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OwnerId = new Guid("24fd81f8-d58a-4bcc-9f35-dc6cd5641906")
                        },
                        new
                        {
                            Id = new Guid("670775db-ecc0-4b90-a9ab-37cd0d8e2801"),
                            AccountType = "Savings",
                            DateCreated = new DateTime(1999, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OwnerId = new Guid("24fd81f8-d58a-4bcc-9f35-dc6cd5641906")
                        },
                        new
                        {
                            Id = new Guid("a3fbad0b-7f48-4feb-8ac0-6d3bbc997bfc"),
                            AccountType = "Domestic",
                            DateCreated = new DateTime(2010, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OwnerId = new Guid("a3c1880c-674c-4d18-8f91-5d3608a2c937")
                        });
                });

            modelBuilder.Entity("Entities.Models.Owner", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("OwnerId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(60) CHARACTER SET utf8mb4")
                        .HasMaxLength(60);

                    b.HasKey("Id");

                    b.ToTable("owner");

                    b.HasData(
                        new
                        {
                            Id = new Guid("24fd81f8-d58a-4bcc-9f35-dc6cd5641906"),
                            Address = "61 Wellfield Road",
                            DateOfBirth = new DateTime(1980, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "John Keen"
                        },
                        new
                        {
                            Id = new Guid("261e1685-cf26-494c-b17c-3546e65f5620"),
                            Address = "27 Rainbow Row",
                            DateOfBirth = new DateTime(1974, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Anna Bosh"
                        },
                        new
                        {
                            Id = new Guid("66774006-2371-4d5b-8518-2177bcf3f73e"),
                            Address = "North Sunny Address 102",
                            DateOfBirth = new DateTime(1998, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Nick Somion"
                        });
                });

            modelBuilder.Entity("Entities.Models.Account", b =>
                {
                    b.HasOne("Entities.Models.Owner", "Owner")
                        .WithMany("Accounts")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
