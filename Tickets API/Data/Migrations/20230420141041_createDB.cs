using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketsAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class createDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Segments",
                columns: table => new
                {
                    serialnumber = table.Column<int>(name: "serial_number", type: "integer", nullable: false),
                    ticketnumber = table.Column<string>(name: "ticket_number", type: "text", nullable: false),
                    operationtype = table.Column<string>(name: "operation_type", type: "text", nullable: false),
                    operationtime = table.Column<DateTime>(name: "operation_time", type: "timestamp with time zone", nullable: false),
                    operationtimetimezone = table.Column<short>(name: "operation_time_timezone", type: "smallint", nullable: false),
                    operationplace = table.Column<string>(name: "operation_place", type: "text", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    surname = table.Column<string>(type: "text", nullable: false),
                    patronymic = table.Column<string>(type: "text", nullable: false),
                    doctype = table.Column<string>(name: "doc_type", type: "text", nullable: false),
                    docnumber = table.Column<string>(name: "doc_number", type: "text", nullable: false),
                    birthdate = table.Column<DateOnly>(type: "date", nullable: false),
                    gender = table.Column<string>(type: "text", nullable: false),
                    passengertype = table.Column<string>(name: "passenger_type", type: "text", nullable: false),
                    tickettype = table.Column<int>(name: "ticket_type", type: "integer", nullable: false),
                    airlinecode = table.Column<string>(name: "airline_code", type: "text", nullable: false),
                    flightnum = table.Column<int>(name: "flight_num", type: "integer", nullable: false),
                    departplace = table.Column<string>(name: "depart_place", type: "text", nullable: false),
                    departdatetime = table.Column<DateTime>(name: "depart_datetime", type: "timestamp with time zone", nullable: false),
                    departdatetimetimezone = table.Column<short>(name: "depart_datetime_timezone", type: "smallint", nullable: false),
                    arriveplace = table.Column<string>(name: "arrive_place", type: "text", nullable: false),
                    arrivedatetime = table.Column<DateTime>(name: "arrive_datetime", type: "timestamp with time zone", nullable: false),
                    arrivedatetimetimezone = table.Column<short>(name: "arrive_datetime_timezone", type: "smallint", nullable: false),
                    pnrid = table.Column<string>(name: "pnr_id", type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Segments", x => new { x.ticketnumber, x.serialnumber });
                });

            migrationBuilder.CreateIndex(
                name: "IX_Segments_ticket_number_serial_number",
                table: "Segments",
                columns: new[] { "ticket_number", "serial_number" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Segments");
        }
    }
}
