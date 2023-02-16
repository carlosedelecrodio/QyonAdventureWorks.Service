using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AdventureWorks.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Competitors",
                columns: table => new
                {
                    IdCompetitor = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Gender = table.Column<char>(type: "character(1)", nullable: false),
                    AverageTemperature = table.Column<double>(type: "double precision", nullable: false),
                    Weight = table.Column<double>(type: "double precision", nullable: false),
                    Height = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competitors", x => x.IdCompetitor);
                });

            migrationBuilder.CreateTable(
                name: "RaceHistory",
                columns: table => new
                {
                    IdRaceHistory = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdCompetitor = table.Column<int>(type: "integer", nullable: false),
                    IdRaceTrack = table.Column<int>(type: "integer", nullable: false),
                    RaceDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    TimeSpent = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaceHistory", x => x.IdRaceHistory);
                });

            migrationBuilder.CreateTable(
                name: "RaceTrack",
                columns: table => new
                {
                    IdRaceTrack = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaceTrack", x => x.IdRaceTrack);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Competitors");

            migrationBuilder.DropTable(
                name: "RaceHistory");

            migrationBuilder.DropTable(
                name: "RaceTrack");
        }
    }
}
