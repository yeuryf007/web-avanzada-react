﻿// <auto-generated />
using System;
using FaceRecognitionServer.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FaceRecognitionServer.API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240318021923_InitialCreation")]
    partial class InitialCreation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FaceRecognitionServer.API.Features.MissingPerson.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("HeightInCentimeters")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReportedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReportedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("WeightInPound")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("FaceRecognitionServer.API.Features.MissingPerson.Models.PersonImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("Image")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("FaceRecognitionServer.API.Features.MissingPerson.Models.PersonImage", b =>
                {
                    b.HasOne("FaceRecognitionServer.API.Features.MissingPerson.Models.Person", "Person")
                        .WithMany("Images")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("FaceRecognitionServer.API.Features.MissingPerson.Models.Person", b =>
                {
                    b.Navigation("Images");
                });
#pragma warning restore 612, 618
        }
    }
}
