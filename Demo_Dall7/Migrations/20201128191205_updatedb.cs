using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo_Dall7.Migrations
{
    public partial class updatedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "likes",
                columns: table => new
                {
                    BooksLikeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LikeTime = table.Column<DateTime>(nullable: false),
                    IsLike = table.Column<bool>(nullable: false),
                    BookId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_likes", x => x.BooksLikeId);
                    table.ForeignKey(
                        name: "FK_likes_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_likes_BookId",
                table: "likes",
                column: "BookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "likes");
        }
    }
}
