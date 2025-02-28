﻿// <auto-generated />
using JobApplicationSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JobApplicationSystem.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250227093400_Baglama")]
    partial class Baglama
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JobApplicationSystem.Models.Certificate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Company")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonalIdId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonalIdId");

                    b.ToTable("Certificate");
                });

            modelBuilder.Entity("JobApplicationSystem.Models.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Degree")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EndDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonalIdId")
                        .HasColumnType("int");

                    b.Property<string>("School")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PersonalIdId");

                    b.ToTable("Education");
                });

            modelBuilder.Entity("JobApplicationSystem.Models.Experience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EndDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonalIdId")
                        .HasColumnType("int");

                    b.Property<string>("StartDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PersonalIdId");

                    b.ToTable("Experience");
                });

            modelBuilder.Entity("JobApplicationSystem.Models.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonalIdId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonalIdId");

                    b.ToTable("Language");
                });

            modelBuilder.Entity("JobApplicationSystem.Models.Link", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PersonalIdId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PersonalIdId");

                    b.ToTable("Link");
                });

            modelBuilder.Entity("JobApplicationSystem.Models.Personal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("About")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Personal");
                });

            modelBuilder.Entity("JobApplicationSystem.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonalIdId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonalIdId");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("JobApplicationSystem.Models.Referance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonalIdId")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PersonalIdId");

                    b.ToTable("Referance");
                });

            modelBuilder.Entity("JobApplicationSystem.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonalIdId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonalIdId");

                    b.ToTable("Skill");
                });

            modelBuilder.Entity("JobApplicationSystem.Models.WorkCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("WorkDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WorkCategory");
                });

            modelBuilder.Entity("JobApplicationSystem.Models.Certificate", b =>
                {
                    b.HasOne("JobApplicationSystem.Models.Personal", "PersonalId")
                        .WithMany("Certificates")
                        .HasForeignKey("PersonalIdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PersonalId");
                });

            modelBuilder.Entity("JobApplicationSystem.Models.Education", b =>
                {
                    b.HasOne("JobApplicationSystem.Models.Personal", "PersonalId")
                        .WithMany("Educations")
                        .HasForeignKey("PersonalIdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PersonalId");
                });

            modelBuilder.Entity("JobApplicationSystem.Models.Experience", b =>
                {
                    b.HasOne("JobApplicationSystem.Models.Personal", "PersonalId")
                        .WithMany("Experiences")
                        .HasForeignKey("PersonalIdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PersonalId");
                });

            modelBuilder.Entity("JobApplicationSystem.Models.Language", b =>
                {
                    b.HasOne("JobApplicationSystem.Models.Personal", "PersonalId")
                        .WithMany("Languages")
                        .HasForeignKey("PersonalIdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PersonalId");
                });

            modelBuilder.Entity("JobApplicationSystem.Models.Link", b =>
                {
                    b.HasOne("JobApplicationSystem.Models.Personal", "PersonalId")
                        .WithMany("Links")
                        .HasForeignKey("PersonalIdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PersonalId");
                });

            modelBuilder.Entity("JobApplicationSystem.Models.Project", b =>
                {
                    b.HasOne("JobApplicationSystem.Models.Personal", "PersonalId")
                        .WithMany("Projects")
                        .HasForeignKey("PersonalIdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PersonalId");
                });

            modelBuilder.Entity("JobApplicationSystem.Models.Referance", b =>
                {
                    b.HasOne("JobApplicationSystem.Models.Personal", "PersonalId")
                        .WithMany("Referances")
                        .HasForeignKey("PersonalIdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PersonalId");
                });

            modelBuilder.Entity("JobApplicationSystem.Models.Skill", b =>
                {
                    b.HasOne("JobApplicationSystem.Models.Personal", "PersonalId")
                        .WithMany("Skills")
                        .HasForeignKey("PersonalIdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PersonalId");
                });

            modelBuilder.Entity("JobApplicationSystem.Models.Personal", b =>
                {
                    b.Navigation("Certificates");

                    b.Navigation("Educations");

                    b.Navigation("Experiences");

                    b.Navigation("Languages");

                    b.Navigation("Links");

                    b.Navigation("Projects");

                    b.Navigation("Referances");

                    b.Navigation("Skills");
                });
#pragma warning restore 612, 618
        }
    }
}
