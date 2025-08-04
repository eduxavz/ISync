using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ISync.Migrations
{
    /// <inheritdoc />
    public partial class CriarTabelasMovimentacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbMovDados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContratoId = table.Column<int>(type: "int", nullable: false),
                    EmpresaId = table.Column<int>(type: "int", nullable: false),
                    SessaoId = table.Column<int>(type: "int", nullable: true),
                    OperadorId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Versao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdNFe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CUF = table.Column<int>(type: "int", nullable: false),
                    CNF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NatOp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IndPag = table.Column<int>(type: "int", nullable: true),
                    Mod = table.Column<int>(type: "int", nullable: false),
                    Serie = table.Column<int>(type: "int", nullable: false),
                    NNF = table.Column<long>(type: "bigint", nullable: false),
                    DhEmi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DhSaiEnt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TpNF = table.Column<int>(type: "int", nullable: false),
                    IdDest = table.Column<int>(type: "int", nullable: true),
                    CMunFG = table.Column<long>(type: "bigint", nullable: false),
                    TpImp = table.Column<int>(type: "int", nullable: false),
                    TpEmis = table.Column<int>(type: "int", nullable: false),
                    CDV = table.Column<int>(type: "int", nullable: false),
                    TpAmb = table.Column<int>(type: "int", nullable: false),
                    FinNFe = table.Column<int>(type: "int", nullable: false),
                    IndFinal = table.Column<int>(type: "int", nullable: true),
                    IndPres = table.Column<int>(type: "int", nullable: true),
                    IndIntermed = table.Column<int>(type: "int", nullable: true),
                    ProcEmi = table.Column<int>(type: "int", nullable: false),
                    VerProc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DhCont = table.Column<DateTime>(type: "datetime2", nullable: true),
                    XJust = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InfAdFisco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InfCpl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DCompetencia = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SysIdEnvio = table.Column<int>(type: "int", nullable: true),
                    SysDInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysDUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysIsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbMovDados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbRetiradaDocumentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContratoId = table.Column<int>(type: "int", nullable: false),
                    EmpresaId = table.Column<int>(type: "int", nullable: false),
                    Mod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DInicial = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DFinal = table.Column<DateTime>(type: "datetime2", nullable: true),
                    QArquivos = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tamanho = table.Column<long>(type: "bigint", nullable: true),
                    SysDInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysDUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysIsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbRetiradaDocumentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbMovDests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CadastroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Documento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdEstrangeiro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    XNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    XLgr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    XCpl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    XBairro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CMun = table.Column<long>(type: "bigint", nullable: false),
                    XMun = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPais = table.Column<int>(type: "int", nullable: true),
                    XPais = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fone = table.Column<long>(type: "bigint", nullable: true),
                    IndIEDest = table.Column<int>(type: "int", nullable: true),
                    IE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISUF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdeId1 = table.Column<int>(type: "int", nullable: false),
                    SysDInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysDUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysIsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbMovDests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbMovDests_tbMovDados_IdeId1",
                        column: x => x.IdeId1,
                        principalTable: "tbMovDados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbMovEmits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdeId = table.Column<int>(type: "int", nullable: false),
                    EmpresaId = table.Column<int>(type: "int", nullable: false),
                    Doc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    XNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    XFant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    XLgr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    XCpl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    XBairro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CMun = table.Column<long>(type: "bigint", nullable: false),
                    XMun = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPais = table.Column<int>(type: "int", nullable: true),
                    XPais = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fone = table.Column<long>(type: "bigint", nullable: true),
                    IE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IEST = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CNAE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CRT = table.Column<int>(type: "int", nullable: false),
                    SysDInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysDUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysIsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbMovEmits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbMovEmits_tbMovDados_IdeId",
                        column: x => x.IdeId,
                        principalTable: "tbMovDados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbMovFats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NFat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VOrig = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VDesc = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VLiq = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IdeId1 = table.Column<int>(type: "int", nullable: false),
                    SysDInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysDUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysIsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbMovFats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbMovFats_tbMovDados_IdeId1",
                        column: x => x.IdeId1,
                        principalTable: "tbMovDados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbMovICMSTotais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdeId = table.Column<int>(type: "int", nullable: false),
                    VBC = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VICMS = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VICMSDeson = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VFCPUFDest = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VICMSUFDest = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VICMSUFRemet = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VFCP = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VBCST = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VST = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VFCPST = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VFCPSTRet = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VProd = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VFrete = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VSeg = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VDesc = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VII = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VIPI = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VIPIDevol = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VPIS = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VCOFINS = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VOutro = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VNF = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VTotTrib = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SysDInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysDUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysIsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbMovICMSTotais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbMovICMSTotais_tbMovDados_IdeId",
                        column: x => x.IdeId,
                        principalTable: "tbMovDados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbMovInfIntermed",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdeId = table.Column<int>(type: "int", nullable: false),
                    CNPJ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdCadIntTran = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SysDInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysDUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysIsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbMovInfIntermed", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbMovInfIntermed_tbMovDados_IdeId",
                        column: x => x.IdeId,
                        principalTable: "tbMovDados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbMovInfRespTecs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdeId = table.Column<int>(type: "int", nullable: false),
                    CNPJ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    XContato = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdCSRT = table.Column<int>(type: "int", nullable: true),
                    HashCSRT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SysDInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysDUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysIsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbMovInfRespTecs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbMovInfRespTecs_tbMovDados_IdeId",
                        column: x => x.IdeId,
                        principalTable: "tbMovDados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbMovISSQNTotais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdeId = table.Column<int>(type: "int", nullable: false),
                    VServ = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VBC = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VISS = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VPIS = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VCOFINS = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DCompet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VDeducao = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VOutro = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VDescIncond = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VDescCond = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VISSRet = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CRegTrib = table.Column<int>(type: "int", nullable: true),
                    SysDInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysDUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysIsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbMovISSQNTotais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbMovISSQNTotais_tbMovDados_IdeId",
                        column: x => x.IdeId,
                        principalTable: "tbMovDados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbMovNFRefs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdeId = table.Column<int>(type: "int", nullable: false),
                    RefNFe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NECF = table.Column<int>(type: "int", nullable: false),
                    NCOO = table.Column<int>(type: "int", nullable: false),
                    CUF = table.Column<int>(type: "int", nullable: false),
                    AAMM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CNPJ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Serie = table.Column<int>(type: "int", nullable: false),
                    NNF = table.Column<int>(type: "int", nullable: false),
                    IE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdeId1 = table.Column<int>(type: "int", nullable: true),
                    SysDInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysDUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysIsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbMovNFRefs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbMovNFRefs_tbMovDados_IdeId",
                        column: x => x.IdeId,
                        principalTable: "tbMovDados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbMovNFRefs_tbMovDados_IdeId1",
                        column: x => x.IdeId1,
                        principalTable: "tbMovDados",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbMovPagDets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdeId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TpSolicitado = table.Column<int>(type: "int", nullable: false),
                    VTroco = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IndPag = table.Column<int>(type: "int", nullable: true),
                    TPag = table.Column<int>(type: "int", nullable: false),
                    VPag = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VDesc = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VOutro = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TpTransacao = table.Column<int>(type: "int", nullable: false),
                    PagamentoId = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cancelado = table.Column<bool>(type: "bit", nullable: false),
                    DVenc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SysDInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysDUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysIsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbMovPagDets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbMovPagDets_tbMovDados_IdeId",
                        column: x => x.IdeId,
                        principalTable: "tbMovDados",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbMovProds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendedorId = table.Column<int>(type: "int", nullable: false),
                    ProdutoGradeId = table.Column<int>(type: "int", nullable: false),
                    IdeId = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: true),
                    CategoriaNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NItem = table.Column<int>(type: "int", nullable: false),
                    CProd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CEAN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    XProd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NCM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NVE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CEST = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IndEscala = table.Column<int>(type: "int", nullable: true),
                    CNPJFab = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CBenef = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EXTIPI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CFOP = table.Column<int>(type: "int", nullable: false),
                    UCom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QCom = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VUnCom = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VProd = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CEANTrib = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UTrib = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QTrib = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VUnTrib = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VFrete = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VSeg = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VDesc = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VOutro = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IndTot = table.Column<int>(type: "int", nullable: false),
                    XPed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NItemPed = table.Column<int>(type: "int", nullable: true),
                    NFCI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NRECOPI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InfAdProd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VTotTrib = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Cancelado = table.Column<bool>(type: "bit", nullable: false),
                    VCusto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PTribFed = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PTribEst = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PTribMun = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SysDInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysDUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysIsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbMovProds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbMovProds_tbMovDados_IdeId",
                        column: x => x.IdeId,
                        principalTable: "tbMovDados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbMovRetTribs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdeId = table.Column<int>(type: "int", nullable: false),
                    VRetPIS = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VRetCOFINS = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VRetCSLL = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VBCIRRF = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VIRRF = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VBCRetPrev = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VRetPrev = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SysDInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysDUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysIsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbMovRetTribs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbMovRetTribs_tbMovDados_IdeId",
                        column: x => x.IdeId,
                        principalTable: "tbMovDados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbMovTransps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdeId = table.Column<int>(type: "int", nullable: false),
                    ModFrete = table.Column<int>(type: "int", nullable: false),
                    SysDInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysDUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysIsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbMovTransps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbMovTransps_tbMovDados_IdeId",
                        column: x => x.IdeId,
                        principalTable: "tbMovDados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FatPagProd",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FatId = table.Column<int>(type: "int", nullable: false),
                    ProdId = table.Column<int>(type: "int", nullable: false),
                    VDesc = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VAcresc = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SysDInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysDUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysIsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FatPagProd", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FatPagProd_tbMovFats_FatId",
                        column: x => x.FatId,
                        principalTable: "tbMovFats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbMovDups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FatId = table.Column<int>(type: "int", nullable: false),
                    DetPagId = table.Column<int>(type: "int", nullable: true),
                    NDup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DVenc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VDup = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SysDInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysDUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysIsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbMovDups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbMovDups_tbMovFats_FatId",
                        column: x => x.FatId,
                        principalTable: "tbMovFats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbMovDups_tbMovPagDets_DetPagId",
                        column: x => x.DetPagId,
                        principalTable: "tbMovPagDets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbMovPagDetCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DetPagId = table.Column<int>(type: "int", nullable: false),
                    TpIntegra = table.Column<int>(type: "int", nullable: true),
                    CNPJ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TBand = table.Column<int>(type: "int", nullable: true),
                    CAut = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CNSU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mensagem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ViaConsumidor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ViaEstabelecimento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NroCartao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SysIdEnvio = table.Column<int>(type: "int", nullable: true),
                    SysDInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysDUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysIsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbMovPagDetCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbMovPagDetCards_tbMovPagDets_DetPagId",
                        column: x => x.DetPagId,
                        principalTable: "tbMovPagDets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbMovProdCofins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdId = table.Column<int>(type: "int", nullable: false),
                    CST = table.Column<int>(type: "int", nullable: false),
                    VBC = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PCOFINS = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    QBCProd = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VAliqProd = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VCOFINS = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SysDInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysDUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysIsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbMovProdCofins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbMovProdCofins_tbMovProds_ProdId",
                        column: x => x.ProdId,
                        principalTable: "tbMovProds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbMovProdCombs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdId = table.Column<int>(type: "int", nullable: false),
                    CProdANP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PMixGN = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DescANP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PGLP = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PGNn = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PGNi = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VPart = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CODIF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QTemp = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    UFCons = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SysDInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysDUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysIsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbMovProdCombs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbMovProdCombs_tbMovProds_ProdId",
                        column: x => x.ProdId,
                        principalTable: "tbMovProds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbMovProdDetExports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdId = table.Column<int>(type: "int", nullable: false),
                    NDraw = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SysDInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysDUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysIsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbMovProdDetExports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbMovProdDetExports_tbMovProds_ProdId",
                        column: x => x.ProdId,
                        principalTable: "tbMovProds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbMovProdDIs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdId = table.Column<int>(type: "int", nullable: false),
                    NDI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DDI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    XLocDesemb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UFDesemb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DDesemb = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TpViaTransp = table.Column<int>(type: "int", nullable: false),
                    VAFRMM = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TpIntermedio = table.Column<int>(type: "int", nullable: false),
                    CNPJ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UFTerceiro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CExportador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SysDInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysDUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysIsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbMovProdDIs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbMovProdDIs_tbMovProds_ProdId",
                        column: x => x.ProdId,
                        principalTable: "tbMovProds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbMovProdIcms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdId = table.Column<int>(type: "int", nullable: false),
                    VBCUFDest = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VBCFCPUFDest = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PFCPUFDest = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PICMSUFDest = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PICMSInter = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PICMSInterPart = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Orig = table.Column<int>(type: "int", nullable: false),
                    CST = table.Column<int>(type: "int", nullable: false),
                    CSOSN = table.Column<int>(type: "int", nullable: false),
                    VFCPUFDest = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VICMSUFDest = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VICMSUFRemet = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ModBC = table.Column<int>(type: "int", nullable: false),
                    PRedBC = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VBC = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PICMS = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VICMSOp = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PDif = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VICMSDif = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VICMS = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PFCP = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VFCP = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VBCFCP = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ModBCST = table.Column<int>(type: "int", nullable: false),
                    PMVAST = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PRedBCST = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VBCST = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PICMSST = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VICMSST = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VBCFCPST = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PFCPST = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VFCPST = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    UFST = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PBCOp = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VBCSTRet = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PST = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VICMSDeson = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MotDesICMS = table.Column<int>(type: "int", nullable: true),
                    VICMSSubstituto = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VICMSSTRet = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VBCFCPSTRet = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PFCPSTRet = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VFCPSTRet = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PCredSN = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VCredICMSSN = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VBCSTDest = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VICMSSTDest = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PRedBCEfet = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VBCEfet = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PICMSEfet = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VICMSEfet = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SysDInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysDUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysIsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbMovProdIcms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbMovProdIcms_tbMovProds_ProdId",
                        column: x => x.ProdId,
                        principalTable: "tbMovProds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbMovProdIis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdId = table.Column<int>(type: "int", nullable: false),
                    VBC = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VDespAdu = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VII = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VIOF = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SysDInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysDUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysIsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbMovProdIis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbMovProdIis_tbMovProds_ProdId",
                        column: x => x.ProdId,
                        principalTable: "tbMovProds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbMovProdIpis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdId = table.Column<int>(type: "int", nullable: false),
                    ClEnq = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CNPJProd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CSelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QSelo = table.Column<int>(type: "int", nullable: true),
                    CEnq = table.Column<int>(type: "int", nullable: false),
                    CST = table.Column<int>(type: "int", nullable: false),
                    VBC = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    QUnid = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VUnid = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PIPI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VIPI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SysDInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysDUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysIsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbMovProdIpis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbMovProdIpis_tbMovProds_ProdId",
                        column: x => x.ProdId,
                        principalTable: "tbMovProds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbMovProdISSQNs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdId = table.Column<int>(type: "int", nullable: false),
                    VBC = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VAliq = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VISSQN = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CMunFG = table.Column<long>(type: "bigint", nullable: false),
                    CListServ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VDeducao = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VOutro = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VDescIncond = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VDescCond = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VISSRet = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IndISS = table.Column<int>(type: "int", nullable: true),
                    CServico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CMun = table.Column<long>(type: "bigint", nullable: true),
                    CPais = table.Column<int>(type: "int", nullable: true),
                    NProcesso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IndIncentivo = table.Column<int>(type: "int", nullable: true),
                    SysDInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysDUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysIsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbMovProdISSQNs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbMovProdISSQNs_tbMovProds_ProdId",
                        column: x => x.ProdId,
                        principalTable: "tbMovProds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbMovProdPis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdId = table.Column<int>(type: "int", nullable: false),
                    CST = table.Column<int>(type: "int", nullable: false),
                    VBC = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PPIS = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VPIS = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QBCProd = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VAliqProd = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SysDInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysDUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysIsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbMovProdPis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbMovProdPis_tbMovProds_ProdId",
                        column: x => x.ProdId,
                        principalTable: "tbMovProds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbMovTransportas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TranspId = table.Column<int>(type: "int", nullable: false),
                    CadastroId = table.Column<int>(type: "int", nullable: false),
                    Doc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    XNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    XEnder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    XMun = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SysDInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysDUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysIsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbMovTransportas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbMovTransportas_tbMovTransps_TranspId",
                        column: x => x.TranspId,
                        principalTable: "tbMovTransps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbMovTranspReboques",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TranspId = table.Column<int>(type: "int", nullable: false),
                    Placa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RNTC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vagao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Balsa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SysDInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysDUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysIsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbMovTranspReboques", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbMovTranspReboques_tbMovTransps_TranspId",
                        column: x => x.TranspId,
                        principalTable: "tbMovTransps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbMovTranspRets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TranspId = table.Column<int>(type: "int", nullable: false),
                    VServ = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VBCRet = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PICMSRet = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VICMSRet = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CFOP = table.Column<int>(type: "int", nullable: false),
                    CMunFG = table.Column<long>(type: "bigint", nullable: false),
                    SysDInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysDUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysIsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbMovTranspRets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbMovTranspRets_tbMovTransps_TranspId",
                        column: x => x.TranspId,
                        principalTable: "tbMovTransps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbMovTranspVols",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TranspId = table.Column<int>(type: "int", nullable: false),
                    QVol = table.Column<int>(type: "int", nullable: true),
                    Esp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NVol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PesoL = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PesoB = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SysDInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysDUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysIsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbMovTranspVols", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbMovTranspVols_tbMovTransps_TranspId",
                        column: x => x.TranspId,
                        principalTable: "tbMovTransps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovProdCombOrigCombs",
                columns: table => new
                {
                    CombId = table.Column<int>(type: "int", nullable: false),
                    OrigComb_IndImport = table.Column<int>(type: "int", nullable: false),
                    OrigComb_CUFOrig = table.Column<int>(type: "int", nullable: true),
                    OrigComb_POrig = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovProdCombOrigCombs", x => x.CombId);
                    table.ForeignKey(
                        name: "FK_MovProdCombOrigCombs_tbMovProdCombs_CombId",
                        column: x => x.CombId,
                        principalTable: "tbMovProdCombs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbMovProdCombEncerrantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CombId = table.Column<int>(type: "int", nullable: false),
                    NBico = table.Column<int>(type: "int", nullable: false),
                    NBomba = table.Column<int>(type: "int", nullable: true),
                    NTanque = table.Column<int>(type: "int", nullable: false),
                    VEncIni = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VEncFin = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SysDInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysDUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysIsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbMovProdCombEncerrantes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbMovProdCombEncerrantes_tbMovProdCombs_CombId",
                        column: x => x.CombId,
                        principalTable: "tbMovProdCombs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbMovProdDetExportInds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DetExportId = table.Column<int>(type: "int", nullable: false),
                    NRE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChNFe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QExport = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SysDInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysDUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysIsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbMovProdDetExportInds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbMovProdDetExportInds_tbMovProdDetExports_DetExportId",
                        column: x => x.DetExportId,
                        principalTable: "tbMovProdDetExports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbMovProdDIAdis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DIId = table.Column<int>(type: "int", nullable: false),
                    NAdicao = table.Column<int>(type: "int", nullable: false),
                    NSeqAdic = table.Column<int>(type: "int", nullable: false),
                    CFabricante = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VDescDI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NDraw = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SysDInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysDUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysIsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbMovProdDIAdis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbMovProdDIAdis_tbMovProdDIs_DIId",
                        column: x => x.DIId,
                        principalTable: "tbMovProdDIs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbMovTranspVeics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TranspId = table.Column<int>(type: "int", nullable: false),
                    Placa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RNTC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransportaId = table.Column<int>(type: "int", nullable: false),
                    SysDInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysDUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysIsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbMovTranspVeics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbMovTranspVeics_tbMovTransportas_TransportaId",
                        column: x => x.TransportaId,
                        principalTable: "tbMovTransportas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbMovTranspVolLacres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VolId = table.Column<int>(type: "int", nullable: false),
                    NLacre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SysDInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysDUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SysIsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbMovTranspVolLacres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbMovTranspVolLacres_tbMovTranspVols_VolId",
                        column: x => x.VolId,
                        principalTable: "tbMovTranspVols",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FatPagProd_FatId",
                table: "FatPagProd",
                column: "FatId");

            migrationBuilder.CreateIndex(
                name: "IX_tbMovDests_IdeId1",
                table: "tbMovDests",
                column: "IdeId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbMovDups_DetPagId",
                table: "tbMovDups",
                column: "DetPagId");

            migrationBuilder.CreateIndex(
                name: "IX_tbMovDups_FatId",
                table: "tbMovDups",
                column: "FatId");

            migrationBuilder.CreateIndex(
                name: "IX_tbMovEmits_IdeId",
                table: "tbMovEmits",
                column: "IdeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbMovFats_IdeId1",
                table: "tbMovFats",
                column: "IdeId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbMovICMSTotais_IdeId",
                table: "tbMovICMSTotais",
                column: "IdeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbMovInfIntermed_IdeId",
                table: "tbMovInfIntermed",
                column: "IdeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbMovInfRespTecs_IdeId",
                table: "tbMovInfRespTecs",
                column: "IdeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbMovISSQNTotais_IdeId",
                table: "tbMovISSQNTotais",
                column: "IdeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbMovNFRefs_IdeId",
                table: "tbMovNFRefs",
                column: "IdeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbMovNFRefs_IdeId1",
                table: "tbMovNFRefs",
                column: "IdeId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbMovPagDetCards_DetPagId",
                table: "tbMovPagDetCards",
                column: "DetPagId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbMovPagDets_IdeId",
                table: "tbMovPagDets",
                column: "IdeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbMovProdCofins_ProdId",
                table: "tbMovProdCofins",
                column: "ProdId");

            migrationBuilder.CreateIndex(
                name: "IX_tbMovProdCombEncerrantes_CombId",
                table: "tbMovProdCombEncerrantes",
                column: "CombId");

            migrationBuilder.CreateIndex(
                name: "IX_tbMovProdCombs_ProdId",
                table: "tbMovProdCombs",
                column: "ProdId");

            migrationBuilder.CreateIndex(
                name: "IX_tbMovProdDetExportInds_DetExportId",
                table: "tbMovProdDetExportInds",
                column: "DetExportId");

            migrationBuilder.CreateIndex(
                name: "IX_tbMovProdDetExports_ProdId",
                table: "tbMovProdDetExports",
                column: "ProdId");

            migrationBuilder.CreateIndex(
                name: "IX_tbMovProdDIAdis_DIId",
                table: "tbMovProdDIAdis",
                column: "DIId");

            migrationBuilder.CreateIndex(
                name: "IX_tbMovProdDIs_ProdId",
                table: "tbMovProdDIs",
                column: "ProdId");

            migrationBuilder.CreateIndex(
                name: "IX_tbMovProdIcms_ProdId",
                table: "tbMovProdIcms",
                column: "ProdId");

            migrationBuilder.CreateIndex(
                name: "IX_tbMovProdIis_ProdId",
                table: "tbMovProdIis",
                column: "ProdId");

            migrationBuilder.CreateIndex(
                name: "IX_tbMovProdIpis_ProdId",
                table: "tbMovProdIpis",
                column: "ProdId");

            migrationBuilder.CreateIndex(
                name: "IX_tbMovProdISSQNs_ProdId",
                table: "tbMovProdISSQNs",
                column: "ProdId");

            migrationBuilder.CreateIndex(
                name: "IX_tbMovProdPis_ProdId",
                table: "tbMovProdPis",
                column: "ProdId");

            migrationBuilder.CreateIndex(
                name: "IX_tbMovProds_IdeId",
                table: "tbMovProds",
                column: "IdeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbMovRetTribs_IdeId",
                table: "tbMovRetTribs",
                column: "IdeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbMovTransportas_TranspId",
                table: "tbMovTransportas",
                column: "TranspId");

            migrationBuilder.CreateIndex(
                name: "IX_tbMovTranspReboques_TranspId",
                table: "tbMovTranspReboques",
                column: "TranspId");

            migrationBuilder.CreateIndex(
                name: "IX_tbMovTranspRets_TranspId",
                table: "tbMovTranspRets",
                column: "TranspId");

            migrationBuilder.CreateIndex(
                name: "IX_tbMovTransps_IdeId",
                table: "tbMovTransps",
                column: "IdeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbMovTranspVeics_TransportaId",
                table: "tbMovTranspVeics",
                column: "TransportaId");

            migrationBuilder.CreateIndex(
                name: "IX_tbMovTranspVolLacres_VolId",
                table: "tbMovTranspVolLacres",
                column: "VolId");

            migrationBuilder.CreateIndex(
                name: "IX_tbMovTranspVols_TranspId",
                table: "tbMovTranspVols",
                column: "TranspId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FatPagProd");

            migrationBuilder.DropTable(
                name: "MovProdCombOrigCombs");

            migrationBuilder.DropTable(
                name: "tbMovDests");

            migrationBuilder.DropTable(
                name: "tbMovDups");

            migrationBuilder.DropTable(
                name: "tbMovEmits");

            migrationBuilder.DropTable(
                name: "tbMovICMSTotais");

            migrationBuilder.DropTable(
                name: "tbMovInfIntermed");

            migrationBuilder.DropTable(
                name: "tbMovInfRespTecs");

            migrationBuilder.DropTable(
                name: "tbMovISSQNTotais");

            migrationBuilder.DropTable(
                name: "tbMovNFRefs");

            migrationBuilder.DropTable(
                name: "tbMovPagDetCards");

            migrationBuilder.DropTable(
                name: "tbMovProdCofins");

            migrationBuilder.DropTable(
                name: "tbMovProdCombEncerrantes");

            migrationBuilder.DropTable(
                name: "tbMovProdDetExportInds");

            migrationBuilder.DropTable(
                name: "tbMovProdDIAdis");

            migrationBuilder.DropTable(
                name: "tbMovProdIcms");

            migrationBuilder.DropTable(
                name: "tbMovProdIis");

            migrationBuilder.DropTable(
                name: "tbMovProdIpis");

            migrationBuilder.DropTable(
                name: "tbMovProdISSQNs");

            migrationBuilder.DropTable(
                name: "tbMovProdPis");

            migrationBuilder.DropTable(
                name: "tbMovRetTribs");

            migrationBuilder.DropTable(
                name: "tbMovTranspReboques");

            migrationBuilder.DropTable(
                name: "tbMovTranspRets");

            migrationBuilder.DropTable(
                name: "tbMovTranspVeics");

            migrationBuilder.DropTable(
                name: "tbMovTranspVolLacres");

            migrationBuilder.DropTable(
                name: "tbRetiradaDocumentos");

            migrationBuilder.DropTable(
                name: "tbMovFats");

            migrationBuilder.DropTable(
                name: "tbMovPagDets");

            migrationBuilder.DropTable(
                name: "tbMovProdCombs");

            migrationBuilder.DropTable(
                name: "tbMovProdDetExports");

            migrationBuilder.DropTable(
                name: "tbMovProdDIs");

            migrationBuilder.DropTable(
                name: "tbMovTransportas");

            migrationBuilder.DropTable(
                name: "tbMovTranspVols");

            migrationBuilder.DropTable(
                name: "tbMovProds");

            migrationBuilder.DropTable(
                name: "tbMovTransps");

            migrationBuilder.DropTable(
                name: "tbMovDados");
        }
    }
}
