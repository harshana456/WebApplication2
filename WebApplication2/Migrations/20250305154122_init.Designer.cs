﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication2.Data;

#nullable disable

namespace WebApplication2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250305154122_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApplication2.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDefault")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDefault = true,
                            Name = "Company A"
                        },
                        new
                        {
                            Id = 2,
                            IsDefault = false,
                            Name = "Company B"
                        },
                        new
                        {
                            Id = 3,
                            IsDefault = false,
                            Name = "Company C"
                        },
                        new
                        {
                            Id = 4,
                            IsDefault = false,
                            Name = "Company D"
                        },
                        new
                        {
                            Id = 5,
                            IsDefault = false,
                            Name = "Company E"
                        });
                });

            modelBuilder.Entity("WebApplication2.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyId = 1,
                            Name = "John Doe"
                        },
                        new
                        {
                            Id = 2,
                            CompanyId = 2,
                            Name = "Jane Smith"
                        },
                        new
                        {
                            Id = 3,
                            CompanyId = 2,
                            Name = "Michael Johnson"
                        },
                        new
                        {
                            Id = 4,
                            CompanyId = 4,
                            Name = "Emily Davis"
                        },
                        new
                        {
                            Id = 5,
                            CompanyId = 5,
                            Name = "David Wilson"
                        },
                        new
                        {
                            Id = 6,
                            CompanyId = 1,
                            Name = "Sarah Brown"
                        },
                        new
                        {
                            Id = 7,
                            CompanyId = 3,
                            Name = "James Anderson"
                        },
                        new
                        {
                            Id = 8,
                            CompanyId = 4,
                            Name = "Jessica Thomas"
                        },
                        new
                        {
                            Id = 9,
                            CompanyId = 5,
                            Name = "Daniel Martinez"
                        },
                        new
                        {
                            Id = 10,
                            CompanyId = 1,
                            Name = "Sophia Garcia"
                        },
                        new
                        {
                            Id = 11,
                            CompanyId = 2,
                            Name = "William Rodriguez"
                        },
                        new
                        {
                            Id = 12,
                            CompanyId = 3,
                            Name = "Olivia Lee"
                        },
                        new
                        {
                            Id = 13,
                            CompanyId = 4,
                            Name = "Ethan Harris"
                        },
                        new
                        {
                            Id = 14,
                            CompanyId = 5,
                            Name = "Mia White"
                        },
                        new
                        {
                            Id = 15,
                            CompanyId = 3,
                            Name = "Alexander Clark"
                        });
                });

            modelBuilder.Entity("WebApplication2.Models.Employee", b =>
                {
                    b.HasOne("WebApplication2.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });
#pragma warning restore 612, 618
        }
    }
}
