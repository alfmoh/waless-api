using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Waless.API.Migrations
{
    public partial class AddedUserEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Birthday = table.Column<DateTime>(nullable: false),
                    InscriptionDate = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    Link = table.Column<string>(nullable: true),
                    Picture = table.Column<string>(nullable: true),
                    Picture_Small = table.Column<string>(nullable: true),
                    Picture_Medium = table.Column<string>(nullable: true),
                    Picture_Big = table.Column<string>(nullable: true),
                    Picture_Xl = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Lang = table.Column<string>(nullable: true),
                    Is_Kid = table.Column<bool>(nullable: false),
                    Tracklist = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
