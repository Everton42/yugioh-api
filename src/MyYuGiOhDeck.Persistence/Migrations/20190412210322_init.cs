using Microsoft.EntityFrameworkCore.Migrations;

namespace MyYuGiOhDeck.Persistence.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MonsterCard",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Race = table.Column<string>(nullable: true),
                    Archetype = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    ImageUrlSmall = table.Column<string>(nullable: true),
                    Setcode = table.Column<string>(nullable: true),
                    SetTag = table.Column<string>(nullable: true),
                    Attack = table.Column<int>(nullable: false),
                    Defence = table.Column<int>(nullable: false),
                    Level = table.Column<int>(nullable: false),
                    Attribute = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Linkval = table.Column<int>(nullable: true),
                    Linkmarkers = table.Column<string>(nullable: true),
                    Scale = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterCard", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpellandTrapCard",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Type = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 300, nullable: false),
                    Race = table.Column<string>(maxLength: 200, nullable: false),
                    Archetype = table.Column<string>(maxLength: 200, nullable: false),
                    ImageUrl = table.Column<string>(maxLength: 300, nullable: true),
                    ImageUrlSmall = table.Column<string>(maxLength: 300, nullable: true),
                    Setcode = table.Column<string>(maxLength: 300, nullable: true),
                    SetTag = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellandTrapCard", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MonsterCard");

            migrationBuilder.DropTable(
                name: "SpellandTrapCard");
        }
    }
}
