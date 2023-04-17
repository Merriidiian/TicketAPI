﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Tickets_API.Data;

#nullable disable

namespace TicketsAPI.Data.Migrations
{
    [DbContext(typeof(TicketContext))]
    [Migration("20230414110906_createDB")]
    partial class createDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Tickets_API.Models.Ticket", b =>
                {
                    b.Property<string>("ticket_number")
                        .HasColumnType("text");

                    b.Property<int>("flight_num")
                        .HasColumnType("integer");

                    b.Property<string>("airline_code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("arrive_datetime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<short>("arrive_datetime_timezone")
                        .HasColumnType("smallint");

                    b.Property<string>("arrive_place")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateOnly>("birthdate")
                        .HasColumnType("date");

                    b.Property<DateTime>("depart_datetime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<short>("depart_datetime_timezone")
                        .HasColumnType("smallint");

                    b.Property<string>("depart_place")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("doc_number")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("doc_type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("operation_place")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("operation_time")
                        .HasColumnType("timestamp with time zone");

                    b.Property<short>("operation_time_timezone")
                        .HasColumnType("smallint");

                    b.Property<string>("operation_type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("passenger_type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("patronymic")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("pnr_id")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ticket_type")
                        .HasColumnType("integer");

                    b.HasKey("ticket_number", "flight_num");

                    b.ToTable("Segments");
                });
#pragma warning restore 612, 618
        }
    }
}