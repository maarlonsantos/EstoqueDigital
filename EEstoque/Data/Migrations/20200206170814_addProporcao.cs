using Microsoft.EntityFrameworkCore.Migrations;

namespace EEstoque.Data.Migrations
{
    public partial class addProporcao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estoque_Proporcao_ProporcaoId",
                table: "Estoque");

            migrationBuilder.DropTable(
                name: "Proporcao");

            migrationBuilder.DropIndex(
                name: "IX_Estoque_ProporcaoId",
                table: "Estoque");

            migrationBuilder.DropColumn(
                name: "ProporcaoId",
                table: "Estoque");

            migrationBuilder.AddColumn<int>(
                name: "Proporcao",
                table: "Estoque",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Proporcao",
                table: "Estoque");

            migrationBuilder.AddColumn<int>(
                name: "ProporcaoId",
                table: "Estoque",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Proporcao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Proporcaos = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proporcao", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estoque_ProporcaoId",
                table: "Estoque",
                column: "ProporcaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Estoque_Proporcao_ProporcaoId",
                table: "Estoque",
                column: "ProporcaoId",
                principalTable: "Proporcao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
