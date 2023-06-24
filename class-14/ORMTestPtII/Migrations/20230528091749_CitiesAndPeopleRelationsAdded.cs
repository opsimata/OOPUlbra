using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ORMtest.Migrations
{
    /// <inheritdoc />
    public partial class CitiesAndPeopleRelationsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonCityId",
                table: "People",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_People_PersonCityId",
                table: "People",
                column: "PersonCityId");

            migrationBuilder.AddForeignKey(
                name: "FK_People_Cities_PersonCityId",
                table: "People",
                column: "PersonCityId",
                principalTable: "Cities",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Cities_PersonCityId",
                table: "People");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropIndex(
                name: "IX_People_PersonCityId",
                table: "People");

            migrationBuilder.DropColumn(
                name: "PersonCityId",
                table: "People");
        }
    }
}
