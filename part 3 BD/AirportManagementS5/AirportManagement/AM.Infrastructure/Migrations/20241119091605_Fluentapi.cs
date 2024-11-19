using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Fluentapi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_Flights_FlightsFlightId",
                table: "FlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_Passes_PassengersPassportNumber",
                table: "FlightPassenger");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlightPassenger",
                table: "FlightPassenger");

            migrationBuilder.RenameTable(
                name: "FlightPassenger",
                newName: "PassengerFlights");

            migrationBuilder.RenameIndex(
                name: "IX_FlightPassenger_PassengersPassportNumber",
                table: "PassengerFlights",
                newName: "IX_PassengerFlights_PassengersPassportNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PassengerFlights",
                table: "PassengerFlights",
                columns: new[] { "FlightsFlightId", "PassengersPassportNumber" });

            migrationBuilder.CreateTable(
                name: "MyPlanes",
                columns: table => new
                {
                    PlaneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyPlanes", x => x.PlaneId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_PassengerFlights_Flights_FlightsFlightId",
                table: "PassengerFlights",
                column: "FlightsFlightId",
                principalTable: "Flights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PassengerFlights_Passes_PassengersPassportNumber",
                table: "PassengerFlights",
                column: "PassengersPassportNumber",
                principalTable: "Passes",
                principalColumn: "PassportNumber",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PassengerFlights_Flights_FlightsFlightId",
                table: "PassengerFlights");

            migrationBuilder.DropForeignKey(
                name: "FK_PassengerFlights_Passes_PassengersPassportNumber",
                table: "PassengerFlights");

            migrationBuilder.DropTable(
                name: "MyPlanes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PassengerFlights",
                table: "PassengerFlights");

            migrationBuilder.RenameTable(
                name: "PassengerFlights",
                newName: "FlightPassenger");

            migrationBuilder.RenameIndex(
                name: "IX_PassengerFlights_PassengersPassportNumber",
                table: "FlightPassenger",
                newName: "IX_FlightPassenger_PassengersPassportNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlightPassenger",
                table: "FlightPassenger",
                columns: new[] { "FlightsFlightId", "PassengersPassportNumber" });

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_Flights_FlightsFlightId",
                table: "FlightPassenger",
                column: "FlightsFlightId",
                principalTable: "Flights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_Passes_PassengersPassportNumber",
                table: "FlightPassenger",
                column: "PassengersPassportNumber",
                principalTable: "Passes",
                principalColumn: "PassportNumber",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
