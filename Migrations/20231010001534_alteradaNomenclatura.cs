using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FolhaDePagamento.Migrations
{
    public partial class alteradaNomenclatura : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Folhas_Funcionarios_IdFuncionarioId",
                table: "Folhas");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Funcionarios",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Cpf",
                table: "Funcionarios",
                newName: "cpf");

            migrationBuilder.RenameColumn(
                name: "Valor",
                table: "Folhas",
                newName: "valor");

            migrationBuilder.RenameColumn(
                name: "Quantidade",
                table: "Folhas",
                newName: "quantidade");

            migrationBuilder.RenameColumn(
                name: "Mes",
                table: "Folhas",
                newName: "mes");

            migrationBuilder.RenameColumn(
                name: "Ano",
                table: "Folhas",
                newName: "ano");

            migrationBuilder.RenameColumn(
                name: "IdFuncionarioId",
                table: "Folhas",
                newName: "funcionarioIdId");

            migrationBuilder.RenameIndex(
                name: "IX_Folhas_IdFuncionarioId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Folhas_Funcionarios_funcionarioIdId",
                table: "Folhas");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Funcionarios",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "cpf",
                table: "Funcionarios",
                newName: "Cpf");

            migrationBuilder.RenameColumn(
                name: "valor",
                table: "Folhas",
                newName: "Valor");

            migrationBuilder.RenameColumn(
                name: "quantidade",
                table: "Folhas",
                newName: "Quantidade");

            migrationBuilder.RenameColumn(
                name: "mes",
                table: "Folhas",
                newName: "Mes");

            migrationBuilder.RenameColumn(
                name: "ano",
                table: "Folhas",
                newName: "Ano");

            migrationBuilder.RenameColumn(
                name: "funcionarioIdId",
                table: "Folhas",
                newName: "IdFuncionarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Folhas_funcionarioIdId",
                table: "Folhas",
                newName: "IX_Folhas_IdFuncionarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Folhas_Funcionarios_IdFuncionarioId",
                table: "Folhas",
                column: "IdFuncionarioId",
                principalTable: "Funcionarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
