﻿// <auto-generated />
using BlazorCRUD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazorCRUD.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220315185652_AddScheduleData")]
    partial class AddScheduleData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlazorCRUD.Data.Medic", b =>
                {
                    b.Property<int>("MedicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("RatePerHour")
                        .HasColumnType("real");

                    b.Property<string>("Specialty")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MedicId");

                    b.ToTable("Medics");
                });
#pragma warning restore 612, 618
        }
    }
}