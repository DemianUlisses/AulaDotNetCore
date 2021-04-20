using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPagesMovie.Migrations
{
    public partial class s : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Movie",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Genre",
                table: "Movie",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DiretorID",
                table: "Movie",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Diretor",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 60, nullable: false),
                    BirthDay = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diretor", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movie_DiretorID",
                table: "Movie",
                column: "DiretorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Diretor_DiretorID",
                table: "Movie",
                column: "DiretorID",
                principalTable: "Diretor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Diretor_DiretorID",
                table: "Movie");

            migrationBuilder.DropTable(
                name: "Diretor");

            migrationBuilder.DropIndex(
                name: "IX_Movie_DiretorID",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "DiretorID",
                table: "Movie");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "Genre",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30);
        }
    }
}
