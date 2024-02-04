﻿// <auto-generated />
using System;
using HrApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HrApi.Migrations
{
    [DbContext(typeof(HrContext))]
    [Migration("20231225170847_v3")]
    partial class v3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HrApi.Data.City", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("country_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("country_id");

                    b.ToTable("cities");
                });

            modelBuilder.Entity("HrApi.Data.Country", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("countries");
                });

            modelBuilder.Entity("HrApi.Data.Departemnt", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("departemnts");
                });

            modelBuilder.Entity("HrApi.Data.Employee", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("Bod")
                        .HasColumnType("datetime2");

                    b.Property<int>("Dept_id")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("city_id")
                        .HasColumnType("int");

                    b.Property<int>("country_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Dept_id");

                    b.HasIndex("city_id");

                    b.HasIndex("country_id");

                    b.ToTable("employees");
                });

            modelBuilder.Entity("HrApi.Data.City", b =>
                {
                    b.HasOne("HrApi.Data.Country", "country")
                        .WithMany("cities")
                        .HasForeignKey("country_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("country");
                });

            modelBuilder.Entity("HrApi.Data.Employee", b =>
                {
                    b.HasOne("HrApi.Data.Departemnt", "departemnt")
                        .WithMany("employees")
                        .HasForeignKey("Dept_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HrApi.Data.City", "city")
                        .WithMany("employees")
                        .HasForeignKey("city_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HrApi.Data.Country", "country")
                        .WithMany("employees")
                        .HasForeignKey("country_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("city");

                    b.Navigation("country");

                    b.Navigation("departemnt");
                });

            modelBuilder.Entity("HrApi.Data.City", b =>
                {
                    b.Navigation("employees");
                });

            modelBuilder.Entity("HrApi.Data.Country", b =>
                {
                    b.Navigation("cities");

                    b.Navigation("employees");
                });

            modelBuilder.Entity("HrApi.Data.Departemnt", b =>
                {
                    b.Navigation("employees");
                });
#pragma warning restore 612, 618
        }
    }
}