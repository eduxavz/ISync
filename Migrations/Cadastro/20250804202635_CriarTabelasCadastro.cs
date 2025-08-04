using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ISync.Migrations.Cadastro
{
    /// <inheritdoc />
    public partial class CriarTabelasCadastro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbCadastroDados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpresaId = table.Column<int>(type: "int", nullable: true),
                    TpCadastro = table.Column<int>(type: "int", nullable: false),
                    CPFCNPJ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IERG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fantasia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DNasc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InfInterno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InfOperador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IndIEDest = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Limite = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Saldo = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SysDInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysDUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysIsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbCadastroDados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbEmpresaDados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Doc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XNome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XLgr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    XCpl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XBairro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CMun = table.Column<int>(type: "int", nullable: false),
                    XMun = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Uf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Site = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Crt = table.Column<int>(type: "int", nullable: false),
                    SysDInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysDUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysIsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbEmpresaDados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbProdutoDados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImpostoId = table.Column<int>(type: "int", nullable: false),
                    Ncm = table.Column<int>(type: "int", nullable: false),
                    Origem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescProduto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescMedida = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VProd = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InfAdic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CProdANP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescANP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PGLP = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PGNn = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PGNi = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CODIF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IndStatus = table.Column<int>(type: "int", nullable: false),
                    SysDInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysDUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysIsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbProdutoDados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbProdutoImpostos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescImposto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cfop = table.Column<int>(type: "int", nullable: false),
                    CBenef = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IcmsCst = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IcmsModBc = table.Column<int>(type: "int", nullable: false),
                    IcmsPRedBc = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IcmsPIcms = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IcmsModBcSt = table.Column<int>(type: "int", nullable: false),
                    IcmsPMvaVUnidSt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IcmsPredBcSt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IcmsPIcmsSt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IcmsMotDesIcms = table.Column<int>(type: "int", nullable: false),
                    IcmsPBcOp = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IcmsUfSt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IcmsPCredSn = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IcmsPredSn = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PisCst = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PisPercVUnidPis = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CofinsCst = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CofinsPercVUnidCofins = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EcfAliq = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SysDInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysDUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysIsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbProdutoImpostos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParceiroEndereco",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CadastroId = table.Column<int>(type: "int", nullable: false),
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Referencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CMun = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    XMun = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CUF = table.Column<int>(type: "int", nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPais = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IndIEDest = table.Column<int>(type: "int", nullable: true),
                    IERG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SysDInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysDUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysIsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParceiroEndereco", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParceiroEndereco_tbCadastroDados_CadastroId",
                        column: x => x.CadastroId,
                        principalTable: "tbCadastroDados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbNaturezaOperacao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescNatureza = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IndOperacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UfOrigem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UfDest = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImpostoId = table.Column<int>(type: "int", nullable: false),
                    Calcular = table.Column<int>(type: "int", nullable: false),
                    InfAdc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndStatus = table.Column<int>(type: "int", nullable: false),
                    SysDInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysDUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysIsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbNaturezaOperacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbNaturezaOperacao_tbProdutoImpostos_ImpostoId",
                        column: x => x.ImpostoId,
                        principalTable: "tbProdutoImpostos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ParceiroEndereco_CadastroId",
                table: "ParceiroEndereco",
                column: "CadastroId");

            migrationBuilder.CreateIndex(
                name: "IX_tbNaturezaOperacao_ImpostoId",
                table: "tbNaturezaOperacao",
                column: "ImpostoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParceiroEndereco");

            migrationBuilder.DropTable(
                name: "tbEmpresaDados");

            migrationBuilder.DropTable(
                name: "tbNaturezaOperacao");

            migrationBuilder.DropTable(
                name: "tbProdutoDados");

            migrationBuilder.DropTable(
                name: "tbCadastroDados");

            migrationBuilder.DropTable(
                name: "tbProdutoImpostos");
        }
    }
}
