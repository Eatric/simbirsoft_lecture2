﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SimbirSoft.API.Database.Contexts;

namespace SimbirSoft.API.Database.Migrations
{
    [DbContext(typeof(CinemaContext))]
    partial class CinemaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("SimbirSoft.API.Database.Domain.Cinema", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<byte>("NumberOfHalls")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("Cinemas");
                });

            modelBuilder.Entity("SimbirSoft.API.Database.Domain.Movie", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Producer")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<double>("Rating")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("SimbirSoft.API.Database.Domain.Schedule", b =>
                {
                    b.Property<long>("Entity1Id")
                        .HasColumnType("bigint")
                        .HasColumnName("IdCinema");

                    b.Property<long>("Entity2Id")
                        .HasColumnType("bigint")
                        .HasColumnName("IdMovie");

                    b.Property<long>("HallNumber")
                        .HasColumnType("bigint");

                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityByDefaultColumn();

                    b.Property<DateTime>("TimeEnd")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("TimeStart")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Entity1Id", "Entity2Id");

                    b.HasIndex("Entity2Id");

                    b.ToTable("Schedule");
                });

            modelBuilder.Entity("SimbirSoft.API.Database.Domain.Ticket", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityByDefaultColumn();

                    b.Property<double>("Cost")
                        .HasColumnType("double precision");

                    b.Property<long?>("ScheduleEntity1Id")
                        .HasColumnType("bigint");

                    b.Property<long?>("ScheduleEntity2Id")
                        .HasColumnType("bigint");

                    b.Property<int>("SeatNumber")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ScheduleEntity1Id", "ScheduleEntity2Id");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("SimbirSoft.API.Database.Domain.Schedule", b =>
                {
                    b.HasOne("SimbirSoft.API.Database.Domain.Cinema", "Entity1")
                        .WithMany("Schedules")
                        .HasForeignKey("Entity1Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SimbirSoft.API.Database.Domain.Movie", "Entity2")
                        .WithMany("Schedules")
                        .HasForeignKey("Entity2Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entity1");

                    b.Navigation("Entity2");
                });

            modelBuilder.Entity("SimbirSoft.API.Database.Domain.Ticket", b =>
                {
                    b.HasOne("SimbirSoft.API.Database.Domain.Schedule", "Schedule")
                        .WithMany()
                        .HasForeignKey("ScheduleEntity1Id", "ScheduleEntity2Id");

                    b.Navigation("Schedule");
                });

            modelBuilder.Entity("SimbirSoft.API.Database.Domain.Cinema", b =>
                {
                    b.Navigation("Schedules");
                });

            modelBuilder.Entity("SimbirSoft.API.Database.Domain.Movie", b =>
                {
                    b.Navigation("Schedules");
                });
#pragma warning restore 612, 618
        }
    }
}
