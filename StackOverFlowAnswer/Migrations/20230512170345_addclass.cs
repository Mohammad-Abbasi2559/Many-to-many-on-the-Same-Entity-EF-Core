using Microsoft.EntityFrameworkCore.Migrations;

namespace StackOverFlowAnswer.Migrations
{
    public partial class addclass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mapped_Stations_Station_DestinationId",
                table: "Mapped_Stations");

            migrationBuilder.DropForeignKey(
                name: "FK_Mapped_Stations_Station_OriginId",
                table: "Mapped_Stations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Station",
                table: "Station");

            migrationBuilder.RenameTable(
                name: "Station",
                newName: "stations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_stations",
                table: "stations",
                column: "StationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mapped_Stations_stations_DestinationId",
                table: "Mapped_Stations",
                column: "DestinationId",
                principalTable: "stations",
                principalColumn: "StationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mapped_Stations_stations_OriginId",
                table: "Mapped_Stations",
                column: "OriginId",
                principalTable: "stations",
                principalColumn: "StationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mapped_Stations_stations_DestinationId",
                table: "Mapped_Stations");

            migrationBuilder.DropForeignKey(
                name: "FK_Mapped_Stations_stations_OriginId",
                table: "Mapped_Stations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_stations",
                table: "stations");

            migrationBuilder.RenameTable(
                name: "stations",
                newName: "Station");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Station",
                table: "Station",
                column: "StationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mapped_Stations_Station_DestinationId",
                table: "Mapped_Stations",
                column: "DestinationId",
                principalTable: "Station",
                principalColumn: "StationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mapped_Stations_Station_OriginId",
                table: "Mapped_Stations",
                column: "OriginId",
                principalTable: "Station",
                principalColumn: "StationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
