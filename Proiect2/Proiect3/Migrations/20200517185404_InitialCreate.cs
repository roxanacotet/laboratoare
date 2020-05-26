using Microsoft.EntityFrameworkCore.Migrations;

namespace MyPhotosManagerWeb.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DetailDTO",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPhoto = table.Column<int>(nullable: false),
                    DetailKey = table.Column<string>(nullable: true),
                    DetailValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailDTO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EventDTO",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPhoto = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventDTO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PeopleDTO",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPhoto = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeopleDTO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhotoDTO",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true),
                    CreationDate = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsVideo = table.Column<bool>(nullable: false),
                    EventId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotoDTO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhotoDTO_EventDTO_EventId",
                        column: x => x.EventId,
                        principalTable: "EventDTO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhotoDTO_EventId",
                table: "PhotoDTO",
                column: "EventId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetailDTO");

            migrationBuilder.DropTable(
                name: "PeopleDTO");

            migrationBuilder.DropTable(
                name: "PhotoDTO");

            migrationBuilder.DropTable(
                name: "EventDTO");
        }
    }
}
