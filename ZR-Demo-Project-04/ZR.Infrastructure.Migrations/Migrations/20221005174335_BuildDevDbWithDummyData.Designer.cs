﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZR.Infrastructure.Entities;

#nullable disable

namespace ZR.Infrastructure.Migrations.Migrations
{
    [DbContext(typeof(DbEntities))]
    [Migration("20221005174335_BuildDevDbWithDummyData")]
    partial class BuildDevDbWithDummyData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ZR.Infrastructure.Models.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id")
                        .HasColumnOrder(0);

                    b.Property<int?>("Age")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnOrder(7)
                        .HasComment("Customer Age");

                    b.Property<Guid>("CustomerTitleId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnOrder(1);

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(5)
                        .HasComment("Customer Email Address");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(2)
                        .HasComment("Customer First Name");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsHardDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSoftDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(4)
                        .HasComment("Customer Last Name");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(3)
                        .HasComment("Customer Middle Name");

                    b.Property<string>("Telpehone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(6)
                        .HasComment("Customer Telpehone Number");

                    b.HasKey("Id");

                    b.HasIndex("CustomerTitleId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b5c7ab75-c2f6-4e7a-bfa2-2888f0e29b66"),
                            Age = 40,
                            CustomerTitleId = new Guid("958cda47-5346-455d-b3a0-91151802887a"),
                            EmailAddress = "Kenneth.Beckley@BackleyScaffoldingLtd.com",
                            FirstName = "Kenneth",
                            IsActive = true,
                            IsHardDeleted = false,
                            IsSoftDeleted = false,
                            LastName = "Beckley",
                            MiddleName = "Xena",
                            Telpehone = "0121-123-4567"
                        },
                        new
                        {
                            Id = new Guid("35a146db-fdf6-4c1e-89ae-04716fad097b"),
                            Age = 67,
                            CustomerTitleId = new Guid("958cda47-5346-455d-b3a0-91151802887a"),
                            EmailAddress = "Clifford.Dickinson@DickinsonOfficeSupplies.co.uk",
                            FirstName = "Clifford",
                            IsActive = true,
                            IsHardDeleted = false,
                            IsSoftDeleted = false,
                            LastName = "Dickinson",
                            MiddleName = "",
                            Telpehone = "0121-496-0643"
                        },
                        new
                        {
                            Id = new Guid("1f498795-4092-4490-919c-1a26d29df1c4"),
                            Age = 28,
                            CustomerTitleId = new Guid("daf16987-9661-486f-88b3-c2a1ed095ab2"),
                            EmailAddress = "Cheryl.Nixon@NixonNursingSupplies.co.uk",
                            FirstName = "Cheryl",
                            IsActive = true,
                            IsHardDeleted = false,
                            IsSoftDeleted = false,
                            LastName = "Nixon",
                            MiddleName = "",
                            Telpehone = "0121-496-0602"
                        });
                });

            modelBuilder.Entity("ZR.Infrastructure.Models.CustomerAddress", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id")
                        .HasColumnOrder(0);

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(2);

                    b.Property<string>("AddressLine2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(3);

                    b.Property<string>("AddressLine3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(4);

                    b.Property<string>("AddressLine4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(5);

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnOrder(1);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsHardDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSoftDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("PostCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(6);

                    b.HasKey("Id");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.ToTable("CustomerAddress");

                    b.HasData(
                        new
                        {
                            Id = new Guid("718020a0-076c-49c3-aeef-5455df2cf468"),
                            AddressLine1 = "N End Way",
                            AddressLine2 = "Golders Green",
                            AddressLine3 = "London",
                            AddressLine4 = "United Kingdom",
                            CustomerId = new Guid("b5c7ab75-c2f6-4e7a-bfa2-2888f0e29b66"),
                            IsActive = true,
                            IsHardDeleted = false,
                            IsSoftDeleted = false,
                            PostCode = "NW3 7HE"
                        },
                        new
                        {
                            Id = new Guid("898fcbd3-9dba-4602-b19f-8efdca8f7ffb"),
                            AddressLine1 = "115 Fallows Road",
                            AddressLine2 = "Hall Green",
                            AddressLine3 = "Birmingham",
                            AddressLine4 = "United Kingdom",
                            CustomerId = new Guid("35a146db-fdf6-4c1e-89ae-04716fad097b"),
                            IsActive = true,
                            IsHardDeleted = false,
                            IsSoftDeleted = false,
                            PostCode = "B11 1PH"
                        },
                        new
                        {
                            Id = new Guid("1fa88489-b68f-4d48-8ad2-9c99686e3a6a"),
                            AddressLine1 = "20 Stone Street",
                            AddressLine2 = "Oldbury",
                            AddressLine3 = "Birmingham",
                            AddressLine4 = "United Kingdom",
                            CustomerId = new Guid("1f498795-4092-4490-919c-1a26d29df1c4"),
                            IsActive = true,
                            IsHardDeleted = false,
                            IsSoftDeleted = false,
                            PostCode = "B69 4JL"
                        });
                });

            modelBuilder.Entity("ZR.Infrastructure.Models.CustomerTitle", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id")
                        .HasColumnOrder(0);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsHardDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSoftDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(1);

                    b.HasKey("Id");

                    b.ToTable("CustomerTitles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3c9608a9-92d0-4e79-99fd-3ebed82a950f"),
                            IsActive = true,
                            IsHardDeleted = false,
                            IsSoftDeleted = false,
                            Name = "Master"
                        },
                        new
                        {
                            Id = new Guid("958cda47-5346-455d-b3a0-91151802887a"),
                            IsActive = true,
                            IsHardDeleted = false,
                            IsSoftDeleted = false,
                            Name = "Mr"
                        },
                        new
                        {
                            Id = new Guid("2fb65fb4-77b2-4db6-b838-ba366865aa44"),
                            IsActive = true,
                            IsHardDeleted = false,
                            IsSoftDeleted = false,
                            Name = "Miss"
                        },
                        new
                        {
                            Id = new Guid("58e08f27-e651-431a-b474-151e12b7d4c3"),
                            IsActive = true,
                            IsHardDeleted = false,
                            IsSoftDeleted = false,
                            Name = "Mrs"
                        },
                        new
                        {
                            Id = new Guid("daf16987-9661-486f-88b3-c2a1ed095ab2"),
                            IsActive = true,
                            IsHardDeleted = false,
                            IsSoftDeleted = false,
                            Name = "Ms"
                        },
                        new
                        {
                            Id = new Guid("88ed2dca-1bdc-485c-a571-d22dbb42abd7"),
                            IsActive = true,
                            IsHardDeleted = false,
                            IsSoftDeleted = false,
                            Name = "Sir"
                        },
                        new
                        {
                            Id = new Guid("e3a2005d-0121-4d0c-8a9c-ed8a82a2fe3e"),
                            IsActive = true,
                            IsHardDeleted = false,
                            IsSoftDeleted = false,
                            Name = "Dr"
                        },
                        new
                        {
                            Id = new Guid("fb1136d0-5c32-4c97-b0c3-f2ff78f1e7fb"),
                            IsActive = true,
                            IsHardDeleted = false,
                            IsSoftDeleted = false,
                            Name = "Prof"
                        },
                        new
                        {
                            Id = new Guid("270285a4-a176-4cd7-aeb7-d1004a18e7e7"),
                            IsActive = true,
                            IsHardDeleted = false,
                            IsSoftDeleted = false,
                            Name = "Lord"
                        });
                });

            modelBuilder.Entity("ZR.Infrastructure.Models.Customer", b =>
                {
                    b.HasOne("ZR.Infrastructure.Models.CustomerTitle", "CustomerTile")
                        .WithMany("Customers")
                        .HasForeignKey("CustomerTitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustomerTile");
                });

            modelBuilder.Entity("ZR.Infrastructure.Models.CustomerAddress", b =>
                {
                    b.HasOne("ZR.Infrastructure.Models.Customer", "Customer")
                        .WithOne("CustomerAddress")
                        .HasForeignKey("ZR.Infrastructure.Models.CustomerAddress", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("ZR.Infrastructure.Models.Customer", b =>
                {
                    b.Navigation("CustomerAddress");
                });

            modelBuilder.Entity("ZR.Infrastructure.Models.CustomerTitle", b =>
                {
                    b.Navigation("Customers");
                });
#pragma warning restore 612, 618
        }
    }
}
