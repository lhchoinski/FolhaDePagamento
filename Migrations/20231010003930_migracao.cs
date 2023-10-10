using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FolhaDePagamento.Migrations
{
    public partial class migracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Folhas_Funcionarios_funcionarioIdId",
                table: "Folhas");

            migrationBuilder.RenameColumn(
                name: "funcionarioIdId",
                table: "Folhas",
                newName: "FuncionarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Folhas_funcionarioIdId",
                table: "Folhas",
                newName: "IX_Folhas_FuncionarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Folhas_Funcionarios_FuncionarioId",
                table: "Folhas",
                column: "FuncionarioId",
                principalTable: "Funcionarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Folhas_Funcionarios_FuncionarioId",
                table: "Folhas");

            migrationBuilder.RenameColumn(
                name: "FuncionarioId",
                table: "Folhas",
                newName: "funcionarioIdId");

            migrationBuilder.RenameIndex(
                name: "IX_Folhas_FuncionarioId",
                table: "Folhas",
                newName: "IX_Folhas_funcionarioIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Folhas_Funcionarios_funcionarioIdId",
                table: "Folhas",
                column: "funcionarioIdId",
                principalTable: "Funcionarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
