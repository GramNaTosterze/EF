﻿// <auto-generated />
using System;
using EF.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF.Infrastructure.Migrations
{
    [DbContext(typeof(EFContext))]
    partial class EFContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("EF.Domain.Models.Employment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Contract")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Pay")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Employments");
                });

            modelBuilder.Entity("EF.Domain.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Discriminator")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<int>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int?>("PartnerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("PartnerId")
                        .IsUnique();

                    b.ToTable("Person");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("PersonPerson", b =>
                {
                    b.Property<int>("ChildrenId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ParentsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ChildrenId", "ParentsId");

                    b.HasIndex("ParentsId");

                    b.ToTable("PersonPerson");
                });

            modelBuilder.Entity("PersonPerson1", b =>
                {
                    b.Property<int>("SiblingToId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SiblingsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("SiblingToId", "SiblingsId");

                    b.HasIndex("SiblingsId");

                    b.ToTable("PersonPerson1");
                });

            modelBuilder.Entity("EF.Domain.Models.PublicFigure", b =>
                {
                    b.HasBaseType("EF.Domain.Models.Person");

                    b.Property<int>("Capital")
                        .HasColumnType("INTEGER");

                    b.ToTable("PublicFigure");
                });

            modelBuilder.Entity("EF.Domain.Models.Employment", b =>
                {
                    b.HasOne("EF.Domain.Models.Person", "Employee")
                        .WithMany("Employments")
                        .HasForeignKey("EmployeeId");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("EF.Domain.Models.Person", b =>
                {
                    b.HasOne("EF.Domain.Models.Person", "Partner")
                        .WithOne("PartnerTo")
                        .HasForeignKey("EF.Domain.Models.Person", "PartnerId");

                    b.Navigation("Partner");
                });

            modelBuilder.Entity("PersonPerson", b =>
                {
                    b.HasOne("EF.Domain.Models.Person", null)
                        .WithMany()
                        .HasForeignKey("ChildrenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF.Domain.Models.Person", null)
                        .WithMany()
                        .HasForeignKey("ParentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PersonPerson1", b =>
                {
                    b.HasOne("EF.Domain.Models.Person", null)
                        .WithMany()
                        .HasForeignKey("SiblingToId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF.Domain.Models.Person", null)
                        .WithMany()
                        .HasForeignKey("SiblingsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EF.Domain.Models.PublicFigure", b =>
                {
                    b.HasOne("EF.Domain.Models.Person", null)
                        .WithOne()
                        .HasForeignKey("EF.Domain.Models.PublicFigure", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EF.Domain.Models.Person", b =>
                {
                    b.Navigation("Employments");

                    b.Navigation("PartnerTo");
                });
#pragma warning restore 612, 618
        }
    }
}