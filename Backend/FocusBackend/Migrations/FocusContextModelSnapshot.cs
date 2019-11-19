﻿// <auto-generated />
using System;
using FocusBackend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FocusBackend.Migrations
{
    [DbContext(typeof(FocusContext))]
    partial class FocusContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FocusBackend.Models.Activity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID");

                    b.Property<DateTime>("Completion");

                    b.Property<DateTime>("Creation");

                    b.Property<string>("Description");

                    b.Property<int>("Importance");

                    b.Property<string>("Name");

                    b.Property<int>("Urgency");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Activities");

                    b.HasData(
                        new { ID = 1, CategoryID = 2, Completion = new DateTime(2019, 11, 19, 11, 12, 6, 557, DateTimeKind.Local), Creation = new DateTime(2019, 11, 19, 11, 12, 6, 555, DateTimeKind.Local), Description = "Outsourced From Temp Agency", Importance = 9, Name = "Pay Workers", Urgency = 9 },
                        new { ID = 2, CategoryID = 6, Completion = new DateTime(2019, 11, 19, 11, 12, 6, 558, DateTimeKind.Local), Creation = new DateTime(2019, 11, 19, 11, 12, 6, 558, DateTimeKind.Local), Description = "Follow Up With Prospects", Importance = 10, Name = "Sales Planning", Urgency = 3 },
                        new { ID = 3, CategoryID = 8, Completion = new DateTime(2019, 11, 19, 11, 12, 6, 558, DateTimeKind.Local), Creation = new DateTime(2019, 11, 19, 11, 12, 6, 558, DateTimeKind.Local), Description = "Get More Stamps For Pay Checks", Importance = 4, Name = "Buy Stamps", Urgency = 6 }
                    );
                });

            modelBuilder.Entity("FocusBackend.Models.Business", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image");

                    b.Property<string>("Industry");

                    b.Property<string>("Name");

                    b.Property<int>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Businesses");

                    b.HasData(
                        new { ID = 1, Image = "Image", Industry = "Retail", Name = "Small Business", UserID = 1 },
                        new { ID = 2, Image = "Image", Industry = "Retail", Name = "Fish Shop", UserID = 2 }
                    );
                });

            modelBuilder.Entity("FocusBackend.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BusinessID");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.HasIndex("BusinessID");

                    b.ToTable("Categories");

                    b.HasData(
                        new { ID = 1, BusinessID = 1, Description = "Marketing And Promotion Activities", Name = "Marketing" },
                        new { ID = 2, BusinessID = 1, Description = "Payroll Activities", Name = "Payroll" },
                        new { ID = 3, BusinessID = 1, Description = "Accounting and Auditing Activities", Name = "Accounting/Auditing" },
                        new { ID = 4, BusinessID = 1, Description = "How You Help Your Customers", Name = "Customer Service" },
                        new { ID = 5, BusinessID = 1, Description = "Managing Your Budget And Looking To The Future", Name = "Budgeting" },
                        new { ID = 6, BusinessID = 1, Description = "Give Your Sales A Boost", Name = "Sales" },
                        new { ID = 7, BusinessID = 1, Description = "Operational Activities", Name = "Operations" },
                        new { ID = 8, BusinessID = 1, Description = "Small Activities That Must Be Done", Name = "Small Tasks" }
                    );
                });

            modelBuilder.Entity("FocusBackend.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.HasKey("ID");

                    b.ToTable("Users");

                    b.HasData(
                        new { ID = 1, Email = "JSmith@MyEmail.com", Image = "Image", Name = "John Smith", Phone = "14404541980" },
                        new { ID = 2, Email = "BJones@MyEmail.com", Image = "Image", Name = "Brad Jones", Phone = "15554541812" }
                    );
                });

            modelBuilder.Entity("FocusBackend.Models.Activity", b =>
                {
                    b.HasOne("FocusBackend.Models.Category", "Category")
                        .WithMany("Activities")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FocusBackend.Models.Business", b =>
                {
                    b.HasOne("FocusBackend.Models.User", "User")
                        .WithMany("Businesses")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FocusBackend.Models.Category", b =>
                {
                    b.HasOne("FocusBackend.Models.Business", "Business")
                        .WithMany("Categories")
                        .HasForeignKey("BusinessID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
