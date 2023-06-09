﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProAgricaTest.Data;

#nullable disable

namespace ProAgricaTest.Migrations
{
    [DbContext(typeof(UKVisitorsDBContext))]
    partial class UKVisitorsDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProAgricaTest.Models.UKVisitor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BiometricNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryOfNationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("EntryApproved")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("EntryDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ExitDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NoOfUKEntries")
                        .HasColumnType("int");

                    b.Property<string>("PassportNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PassportValidFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PassportValidTo")
                        .HasColumnType("datetime2");

                    b.Property<string>("VisaNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("VisaValidFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("VisaValidTo")
                        .HasColumnType("datetime2");

                    b.Property<int>("VisitorCategory")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UKVisitors");
                });
#pragma warning restore 612, 618
        }
    }
}
