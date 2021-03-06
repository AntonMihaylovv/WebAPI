﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webapi3.Models;

namespace webapi3.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    [Migration("20200115214423_webapi3.Models.EmployeeContextSeed")]
    partial class webapi3ModelsEmployeeContextSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("webapi3.Models.Employee", b =>
                {
                    b.Property<long>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1L,
                            DateOfBirth = new DateTime(1979, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ivan.ivanonv@gmail.com",
                            FirstName = "Ivan",
                            LastName = "Ivanonv",
                            PhoneNumber = "999-888-7777"
                        },
                        new
                        {
                            EmployeeId = 2L,
                            DateOfBirth = new DateTime(1981, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "pesho.p@gmail.com",
                            FirstName = "Pesho",
                            LastName = "Peshev",
                            PhoneNumber = "111-222-3333"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
