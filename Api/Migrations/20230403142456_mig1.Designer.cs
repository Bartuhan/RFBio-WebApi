﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositories.EF_Core;

#nullable disable

namespace Api.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20230403142456_mig1")]
    partial class mig1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<DateTime>("BeginDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BiometricId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("ContactId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeJobId")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeLocationId")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeMiddleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("EmployeePhoto")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("EmployeePositionId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeStaffId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeTypeId")
                        .HasColumnType("int");

                    b.Property<string>("GenderId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsActive")
                        .HasColumnType("int");

                    b.Property<DateTime>("LeaveDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MaritalStatusId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalIdNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<bool>("SalariedFlag")
                        .HasColumnType("bit");

                    b.Property<DateTime>("TerminationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isTransfered")
                        .HasColumnType("bit");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            BeginDate = new DateTime(2007, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BiometricId = "ASD",
                            BirthDate = new DateTime(2007, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CompanyId = 1,
                            ContactId = "ASD",
                            Deleted = false,
                            DepartmentId = 1,
                            EmployeeFirstName = "ASD",
                            EmployeeJobId = 1,
                            EmployeeLastName = "ASD",
                            EmployeeLocationId = 1,
                            EmployeeMiddleName = "ASD",
                            EmployeePhoto = new byte[] { 65, 83, 68 },
                            EmployeePositionId = 1,
                            EmployeeStaffId = 1,
                            EmployeeTypeId = 1,
                            GenderId = "ASD",
                            HireDate = new DateTime(2007, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = 1,
                            LeaveDate = new DateTime(2007, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MaritalStatusId = "ASD",
                            NationalIdNumber = "ASD",
                            ParentId = 1,
                            SalariedFlag = true,
                            TerminationDate = new DateTime(2007, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            isTransfered = false
                        });
                });

            modelBuilder.Entity("Entities.Models.EmployeeCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CancelDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CancelReason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CancelUserId")
                        .HasColumnType("int");

                    b.Property<bool>("Cancelled")
                        .HasColumnType("bit");

                    b.Property<bool>("CardActive")
                        .HasColumnType("bit");

                    b.Property<string>("CardId4Byte")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardId4ByteHex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardId4ByteReverse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardId4ByteReverseHex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardId7Byte")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardId7ByteHex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardId7ByteReverse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardId7ByteReverseHex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardIdRaw")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CardIdReverse")
                        .HasColumnType("bit");

                    b.Property<bool>("CardNew")
                        .HasColumnType("bit");

                    b.Property<string>("CardStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("CardType")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("DefineDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DefineUserId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FinishDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsPrimary")
                        .HasColumnType("bit");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Update_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("EmployeeCards");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CancelDate = new DateTime(2007, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CancelReason = "ASD",
                            CancelUserId = 1,
                            Cancelled = false,
                            CardActive = true,
                            CardId4Byte = "ASD",
                            CardId4ByteHex = "ASD",
                            CardId4ByteReverse = "ASD",
                            CardId4ByteReverseHex = "ASD",
                            CardId7Byte = "ASD",
                            CardId7ByteHex = "ASD",
                            CardId7ByteReverse = "ASD",
                            CardId7ByteReverseHex = "ASD",
                            CardIdRaw = "ASD",
                            CardIdReverse = true,
                            CardNew = true,
                            CardStatus = "ASD",
                            CardType = (byte)1,
                            DefineDate = new DateTime(2007, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DefineUserId = 1,
                            EmployeeId = 1,
                            FinishDate = new DateTime(2007, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsPrimary = true,
                            StartDate = new DateTime(2007, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Update_Date = new DateTime(2007, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
