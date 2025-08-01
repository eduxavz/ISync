using ISync.Classes;
using ISync.Classes.Core.Enums.Movimentacao;
using ISync.Entidades.Movimentacao.Detalhe;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ISync.Entidades.Movimentacao.Detalhe.Tributacao.Estadual
{
    public class ICMS : Base
    {
        /// <summary>
        /// Relacionamento do Produto
        /// </summary>
        public int ProdId { get; private set; }

        /// <summary>
        /// NA03 - Valor da BC do ICMS na UF de destino
        /// </summary>
        public decimal VBCUFDest { get; private set; }

        /// <summary>
        /// NA04 - Valor da BC FCP na UF de destino
        /// Versão 4.00
        /// </summary>
        public decimal? VBCFCPUFDest { get; private set; }

        /// <summary>
        /// NA05 - Percentual do ICMS relativo ao Fundo de Combate à Pobreza (FCP) na UF de destino
        /// </summary>
        public decimal? PFCPUFDest { get; private set; }

        /// <summary>
        /// NA07 - Alíquota interna da UF de destino
        /// </summary>
        public decimal PICMSUFDest { get; private set; }

        /// <summary>
        /// NA09 - Alíquota interestadual das UF envolvidas
        /// </summary>
        public decimal PICMSInter { get; private set; }

        /// <summary>
        /// NA11 - Percentual provisório de partilha do ICMS Interestadual
        /// </summary>
        public decimal PICMSInterPart { get; private set; }

        /// <summary>
        ///     N11 - Origem da Mercadoria
        /// </summary>
        public OrigemMercadoria Orig { get; private set; }

        /// <summary>
        ///     N12- Situação Tributária
        /// </summary>
        public CstCsosnIcms CST { get; private set; }

        /// <summary>
        ///     N12a - Código de Situação da Operação – Simples Nacional
        /// </summary>
        public Csosnicms CSOSN { get; private set; }

        /// <summary>
        /// NA13 - Valor do ICMS relativo ao Fundo de Combate à Pobreza(FCP) da UF de destino
        /// </summary>
        public decimal? VFCPUFDest { get; private set; }


        /// <summary>
        /// NA15 - Valor do ICMS Interestadual para a UF de destino
        /// </summary>
        public decimal VICMSUFDest { get; private set; }

        /// <summary>
        /// NA17 - Valor do ICMS Interestadual para a UF do remetente
        /// </summary>
        public decimal VICMSUFRemet { get; private set; }

        /// <summary>
        ///     N13 - Modalidade de determinação da BC do ICMS
        /// </summary>
        public DeterminacaoBaseIcms ModBC { get; private set; }

        /// <summary>
        ///     N14 - Percentual de redução da BC
        /// </summary>
        public decimal PRedBC { get; private set; }

        /// <summary>
        ///     N15 - Valor da BC do ICMS
        /// </summary>
        public decimal VBC { get; private set; }

        /// <summary>
        ///     N16 - Alíquota do imposto
        /// </summary>
        public decimal PICMS { get; private set; }

        /// <summary>
        ///     N16a - Valor do ICMS da Operação
        /// </summary>
        public decimal? VICMSOp { get; private set; }

        /// <summary>
        ///     N16b - Percentual do diferimento
        /// </summary>
        public decimal? PDif { get; private set; }

        /// <summary>
        ///     N16c - Valor do ICMS diferido
        /// </summary>
        public decimal? VICMSDif { get; private set; }

        /// <summary>
        ///     N17 - Valor do ICMS
        /// </summary>
        public decimal VICMS { get; private set; }

        /// <summary>
        /// N17b - Percentual do Fundo de Combate à Pobreza (FCP)
        /// Versão 4.00
        /// </summary>
        public decimal? PFCP { get; private set; }

        /// <summary>
        /// N17c - Valor do Fundo de Combate à Pobreza (FCP)
        /// Versão 4.00
        /// </summary>
        public decimal? VFCP { get; private set; }

        /// <summary>
        /// N17a - Valor da Base de Cálculo do FCP
        /// Versão 4.00
        /// </summary>
        public decimal? VBCFCP { get; private set; }

        /// <summary>
        ///     N18 - Modalidade de determinação da BC do ICMS ST
        /// </summary>
        public DeterminacaoBaseIcmsSt ModBCST { get; private set; }

        /// <summary>
        ///     N19 - Percentual da margem de valor Adicionado do ICMS ST
        /// </summary>
        public decimal? PMVAST { get; private set; }

        /// <summary>
        ///     N20 - Percentual da Redução de BC do ICMS ST
        /// </summary>
        public decimal? PRedBCST { get; private set; }

        /// <summary>
        ///     N21 - Valor da BC do ICMS ST
        /// </summary>
        public decimal VBCST { get; private set; }

        /// <summary>
        ///     N22 - Alíquota do imposto do ICMS ST
        /// </summary>
        public decimal PICMSST { get; private set; }

        /// <summary>
        ///     N23 - Valor do ICMS ST
        /// </summary>
        public decimal VICMSST { get; private set; }

        /// <summary>
        /// N23a - Valor da Base de Cálculo do FCP retido por Substituição Tributária
        /// Versão 4.00
        /// </summary>
        public decimal? VBCFCPST { get; private set; }


        /// <summary>
        /// N23b - Percentual do FCP retido por Substituição Tributária
        /// Versão 4.00
        /// </summary>
        public decimal? PFCPST { get; private set; }

        /// <summary>
        /// N23d - Valor do FCP retido por Substituição Tributária
        /// Versão 4.00
        /// </summary>
        public decimal? VFCPST { get; private set; }


        /// <summary>
        ///     N24 - UF para qual é devido o ICMS ST
        /// </summary>
        public string UFST { get; private set; }

        /// <summary>
        ///     N25 - Percentual da BC operação própria
        /// </summary>
        public decimal PBCOp { get; private set; }


        /// <summary>
        ///     N26 - Valor da BC do ICMS ST retido
        /// </summary>
        public decimal? VBCSTRet { get; private set; }

        /// <summary>
        ///     N26a - Alíquota suportada pelo Consumidor Final
        /// </summary>
        public decimal? PST { get; private set; }

        /// <summary>
        ///     N27a - Valor do ICMS desonerado
        /// </summary>
        public decimal? VICMSDeson { get; private set; }

        /// <summary>
        ///     N28 - Motivo da desoneração do ICMS
        /// </summary>
        public MotivoDesoneracaoIcms? MotDesICMS { get; private set; }

        public decimal? VICMSSubstituto { get; private set; }

        /// <summary>
        ///     N27 - Valor do ICMS ST retido
        /// </summary>
        public decimal? VICMSSTRet { get; private set; }


        /// <summary>
        /// N27a - Valor da Base de Cálculo do FCP retido anteriormente por ST 
        /// Versão 4.00
        /// </summary>
        public decimal? VBCFCPSTRet { get; private set; }


        /// <summary>
        /// N27b - Percentual do FCP retido anteriormente por Substituição Tributária
        /// Versão 4.00
        /// </summary>
        public decimal? PFCPSTRet { get; private set; }

        /// <summary>
        /// N27d - Valor do FCP retido por Substituição Tributária
        /// Versão 4.00
        /// </summary>
        public decimal? VFCPSTRet { get; private set; }

        /// <summary>
        ///     N29 - pCredSN - Alíquota aplicável de cálculo do crédito (Simples Nacional).
        /// </summary>
        public decimal PCredSN { get; private set; }

        /// <summary>
        ///     N30 - Valor crédito do ICMS que pode ser aproveitado nos termos do art. 23 da LC 123 (Simples Nacional)
        /// </summary>
        public decimal VCredICMSSN { get; private set; }


        /// <summary>
        ///     N31 - Valor da BC do ICMS ST da UF destino
        /// </summary>
        public decimal VBCSTDest { get; private set; }

        /// <summary>
        ///     N32 - Valor do ICMS ST da UF destino
        /// </summary>
        public decimal VICMSSTDest { get; private set; }

        /// <summary>
        ///     N34 - Percentual de redução da base de cálculo efetiva 
        /// </summary>
        public decimal? PRedBCEfet { get; private set; }


        /// <summary>
        ///     N35 - Valor da base de cálculo efetiva 
        /// </summary>
        public decimal? VBCEfet { get; private set; }


        /// <summary>
        ///     N36 - Alíquota do ICMS efetiva 
        /// </summary>
        public decimal? PICMSEfet { get; private set; }


        /// <summary>
        ///     N37 - Valor do ICMS efetivo 
        /// </summary>
        public decimal? VICMSEfet { get; private set; }

        [JsonIgnore]
        [NotMapped]
        private decimal VProd { get; set; }

        [JsonIgnore]
        [NotMapped]
        private decimal VIPI { get; set; }

        [JsonIgnore]
        [NotMapped]

        private decimal VII { get; set; }

        [JsonIgnore]
        [NotMapped]
        private decimal PRedSN { get; set; }

        [JsonIgnore]
        [NotMapped]
        private decimal VProdSt { get { return VProd + VIPI; } }

        //EF Relacionamento
        [JsonIgnore]
        public virtual Prod Prod { get; private set; }

        protected ICMS() { }

        public ICMS(int id, int prodId, decimal vProd, decimal vIpi, decimal vII, CstCsosnIcms cst, OrigemMercadoria orig, DeterminacaoBaseIcms modBC, decimal pRedBC, decimal pICMS, DeterminacaoBaseIcmsSt modBCST, decimal? pMVAST, decimal? pRedBCST, decimal pICMSST, decimal pCredSN, decimal? pFCP, decimal? pFCPST, decimal? pRedBCEfet, decimal? pICMSEfet, decimal pRedSn, string uFST)
        {
            Id = id;

            VProd = vProd;
            VBC = decimal.Zero;

            VIPI = vIpi;
            VII = vII;
            PRedSN = pRedSn;

            ProdId = prodId;
            Orig = orig;
            CST = cst;
            ModBC = modBC;
            PRedBC = pRedBC;
            PICMS = pICMS;
            PFCP = pFCP;
            UFST = uFST;
            ModBCST = modBCST;
            PMVAST = pMVAST;
            PRedBCST = pRedBCST;
            PICMSST = pICMSST;
            PFCPST = pFCPST;
            PCredSN = pCredSN;
            PRedBCEfet = pRedBCEfet;
            PICMSEfet = pICMSEfet;

            CalcularIcms(CST);

            VBCFCP = VBC;
            VBCFCPST = VBCST;

            VFCP = PFCP / 100 * VBCFCP;
            VFCPST = PFCPST / 100 * VBCFCPST;
        }

        public ICMS(int id, int prodId, decimal vBCUFDest, decimal? vBCFCPUFDest, decimal? pFCPUFDest, decimal pICMSUFDest, decimal pICMSInter, decimal pICMSInterPart, OrigemMercadoria orig, CstCsosnIcms cst, decimal? vFCPUFDest, decimal vICMSUFDest, decimal vICMSUFRemet, DeterminacaoBaseIcms modBC, decimal pRedBC, decimal vBC, decimal pICMS, decimal? vICMSOp, decimal? pDif, decimal? vICMSDif, decimal vICMS, decimal? pFCP, decimal? vFCP, decimal? vBCFCP, DeterminacaoBaseIcmsSt modBCST, decimal? pMVAST, decimal? pRedBCST, decimal vBCST, decimal pICMSST, decimal vICMSST, decimal? vBCFCPST, decimal? pFCPST, decimal? vFCPST, string uFST, decimal pBCOp, decimal? vBCSTRet, decimal? pST, decimal? vICMSDeson, MotivoDesoneracaoIcms? motDesICMS, decimal? vICMSSubstituto, decimal? vICMSSTRet, decimal? vBCFCPSTRet, decimal? pFCPSTRet, decimal? vFCPSTRet, decimal pCredSN, decimal vCredICMSSN, decimal vBCSTDest, decimal vICMSSTDest, decimal? pRedBCEfet, decimal? vBCEfet, decimal? pICMSEfet, decimal? vICMSEfet)
        {
            Id = id;
            ProdId = prodId;
            VBCUFDest = vBCUFDest;
            VBCFCPUFDest = vBCFCPUFDest;
            PFCPUFDest = pFCPUFDest;
            PICMSUFDest = pICMSUFDest;
            PICMSInter = pICMSInter;
            PICMSInterPart = pICMSInterPart;
            Orig = orig;
            CST = cst;
            VFCPUFDest = vFCPUFDest;
            VICMSUFDest = vICMSUFDest;
            VICMSUFRemet = vICMSUFRemet;
            ModBC = modBC;
            PRedBC = pRedBC;
            VBC = vBC;
            PICMS = pICMS;
            VICMSOp = vICMSOp;
            PDif = pDif;
            VICMSDif = vICMSDif;
            VICMS = vICMS;
            PFCP = pFCP;
            VFCP = vFCP;
            VBCFCP = vBCFCP;
            ModBCST = modBCST;
            PMVAST = pMVAST;
            PRedBCST = pRedBCST;
            VBCST = vBCST;
            PICMSST = pICMSST;
            VICMSST = vICMSST;
            VBCFCPST = vBCFCPST;
            PFCPST = pFCPST;
            VFCPST = vFCPST;
            UFST = uFST;
            PBCOp = pBCOp;
            VBCSTRet = vBCSTRet;
            PST = pST;
            VICMSDeson = vICMSDeson;
            MotDesICMS = motDesICMS;
            VICMSSubstituto = vICMSSubstituto;
            VICMSSTRet = vICMSSTRet;
            VBCFCPSTRet = vBCFCPSTRet;
            PFCPSTRet = pFCPSTRet;
            VFCPSTRet = vFCPSTRet;
            PCredSN = pCredSN;
            VCredICMSSN = vCredICMSSN;
            VBCSTDest = vBCSTDest;
            VICMSSTDest = vICMSSTDest;
            PRedBCEfet = pRedBCEfet;
            VBCEfet = vBCEfet;
            PICMSEfet = pICMSEfet;
            VICMSEfet = vICMSEfet;
        }

        public void Atualizar(decimal vProd, decimal vIpi, decimal vII)
        {
            VProd = vProd;
            VIPI = vIpi;
            VII = vII;
            VBC = decimal.Zero;

            CalcularIcms(CST);

            VBCFCP = VBC;
            VBCFCPST = VBCST;

            VFCP = PFCP / 100 * VBCFCP;
            VFCPST = PFCPST / 100 * VBCFCPST;
        }

        private void CalcularIcms(CstCsosnIcms cst)
        {
            switch (cst)
            {
                case CstCsosnIcms.Cst00:
                    CalcularCst00();
                    break;
                case CstCsosnIcms.Cst10:
                    CalcularCst10();
                    break;
                case CstCsosnIcms.Cst20:
                case CstCsosnIcms.Cst51:
                    CalcularCst20E51();
                    break;
                case CstCsosnIcms.Cst30:
                    CalcularCst30();
                    break;
                case CstCsosnIcms.Cst40:
                case CstCsosnIcms.Cst41:
                case CstCsosnIcms.Cst50:
                    CalcularCst40E41E50();
                    break;
                case CstCsosnIcms.Cst60:
                    CalcularCst60ECsosn500();
                    break;
                case CstCsosnIcms.Cst70:
                    CalcularCst70();
                    break;
                case CstCsosnIcms.Cst90:
                    CalcularCst90();
                    break;

                case CstCsosnIcms.Csosn101:
                    CalcularCsosn101();
                    break;
                case CstCsosnIcms.Csosn102:
                case CstCsosnIcms.Csosn103:
                case CstCsosnIcms.Csosn300:
                case CstCsosnIcms.Csosn400:
                    CalcularCsosn102E103E300E400();
                    break;
                case CstCsosnIcms.Csosn201:
                    CalcularCsosn201();
                    break;
                case CstCsosnIcms.Csosn202:
                case CstCsosnIcms.Csosn203:
                    CalcularCsosn202E203();
                    break;
                case CstCsosnIcms.Csosn500:
                    CalcularCst60ECsosn500();
                    break;
                case CstCsosnIcms.Csosn900:
                    CalcularCsosn900();
                    break;
            }

        }


        #region Regime normal
        private void CalcularCst00()
        {
            if (ModBC == DeterminacaoBaseIcms.DbiPrecoTabelado)
            {
                VBC = VProd;
                VICMS = VBC / 100 * PICMS;
            }
        }
        private void CalcularCst10()
        {
            if (ModBC == DeterminacaoBaseIcms.DbiPrecoTabelado)
            {
                VBC = VProd;
                VICMS = VBC / 100 * PICMS;
            }

            if (ModBC == DeterminacaoBaseIcms.DbiValorOperacao)
            {
                if (!PMVAST.HasValue) PMVAST = 1;

                VBCST = VProdSt + VProdSt / 100 * PMVAST.Value;
                VICMSST = VBCST / 100 * PICMSST - VICMS;
            }
        }
        private void CalcularCst20E51()
        {
            if (ModBC == DeterminacaoBaseIcms.DbiPrecoTabelado)
            {
                if (PRedBC > decimal.Zero)
                {
                    VBC = VProd - VProd / 100 * PRedBC;
                }
                else
                {
                    VBC = VProd;
                }
            }

            VICMS = VBC / 100 * PICMS;
            VICMSDeson = VProd * (1 - PICMS / 100 * (1 - PRedBC / 100)) / (1 - PICMS / 100) - VProd;
        }
        private void CalcularCst30()
        {
            if (ModBC == DeterminacaoBaseIcms.DbiPrecoTabelado)
            {
                VBC = VProd;
                VICMS = VBC / 100 * PRedSN;
            }

            if (ModBC == DeterminacaoBaseIcms.DbiValorOperacao)
            {
                if (PRedBCST > decimal.Zero)
                {
                    VBCST = VProdSt - VProdSt / 100 * PRedBCST.Value;
                    VBCST = VBCST - VBCST / 100 * PMVAST.Value;
                }
                else
                {
                    VBCST = VProdSt + VProdSt / 100 * PMVAST.Value;
                }

                VICMSST = VBCST / 100 * PICMSST - VICMS;
            }

            VBC = decimal.Zero;
            VICMS = decimal.Zero;
            VICMSDeson = VProd / 100 * PICMS;
        }
        private void CalcularCst40E41E50()
        {
            VICMSDeson = VProd / 100 * PICMS;
        }
        private void CalcularCst60ECsosn500()
        {
            if (PICMSEfet > decimal.Zero)
            {
                VBCEfet = VProd - VProd * PRedBCEfet / 100;
                VICMSEfet = VBCEfet * PICMSEfet / 100;
            }
        }
        private void CalcularCst70()
        {
            if (ModBC == DeterminacaoBaseIcms.DbiPrecoTabelado)
            {
                if (PRedBC > decimal.Zero)
                {
                    VBC = VProd - VProd / 100 * PRedBC;
                }
                else
                {
                    VBC = VProd;
                }

                VICMS = VBC / 100 * PICMS;
            }

            if (ModBC == DeterminacaoBaseIcms.DbiValorOperacao)
            {
                if (PRedBCST > decimal.Zero)
                {
                    VBCST = VProdSt - VProdSt / 100 * PRedBCST.Value;
                    VBCST = VBCST + VBCST / 100 * PMVAST.Value;
                }
                else
                {
                    VBCST = VProdSt + VProdSt / 100 * PMVAST.Value;
                }

                VICMSST = VBCST / 100 * PICMSST * VICMS;
            }
        }
        private void CalcularCst90()
        {
            if (ModBC == DeterminacaoBaseIcms.DbiPrecoTabelado)
            {
                if (PRedBC > decimal.Zero)
                {
                    VBC = VProd - VProd / 100 * PRedBC;
                }
                else
                {
                    if (PICMS > decimal.Zero)
                    {
                        VBC = VProd;
                    }
                }

                if (PICMS > decimal.Zero)
                {
                    VICMS = VBC / 100 * PICMS;
                }
            }

            if (ModBC == DeterminacaoBaseIcms.DbiValorOperacao)
            {
                if (PRedBCST > decimal.Zero)
                {
                    VBCST = VProdSt - VProdSt / 100 * PRedBCST.Value;
                    VBCST = VBCST + VBCST / 100 * PMVAST.Value;
                }
                else
                {
                    if (PICMSST > decimal.Zero)
                    {
                        VBCST = VProd + VProd / 100 * PMVAST.Value;
                    }
                    else
                    {
                        VICMSST = VBCST / 100 * PICMSST - VICMS;
                    }
                }
            }
        }
        #endregion

        #region Simples Nacional
        private void CalcularCsosn101()
        {
            VCredICMSSN = VProd / 100 * PCredSN;
        }
        private void CalcularCsosn102E103E300E400()
        {
            VCredICMSSN = decimal.Zero;
            PCredSN = decimal.Zero;
        }
        private void CalcularCsosn201()
        {
            if (ModBC == DeterminacaoBaseIcms.DbiPrecoTabelado)
            {
                VBC = VProd;
                VICMS = VProd / 100 * PRedSN;
            }

            if (ModBC == DeterminacaoBaseIcms.DbiValorOperacao)
            {
                if (PRedBCST > decimal.Zero)
                {
                    VBCST = VProdSt - VProdSt / 100 * PRedBCST.Value;
                    VBCST = VBCST + VBCST / 100 * PMVAST.Value;
                }
                else
                {
                    VBCST = VProdSt + VProdSt / 100 * PMVAST.Value;
                }

                VICMSST = VBCST / 100 * PICMSST - VICMS;
            }

            VBC = decimal.Zero;
            VICMS = decimal.Zero;
            VCredICMSSN = VProd / 100 * PCredSN;
        }
        private void CalcularCsosn202E203()
        {
            if (ModBC == DeterminacaoBaseIcms.DbiPrecoTabelado)
            {
                VBC = VProd;
                VICMS = VProd / 100 * PRedSN;
            }

            if (ModBC == DeterminacaoBaseIcms.DbiValorOperacao)
            {
                if (PRedBCST > decimal.Zero)
                {
                    VBCST = VProdSt - VProdSt / 100 * PRedBCST.Value;
                    VBCST = VBCST + VBCST / 100 * PMVAST.Value;
                }
                else
                {
                    VBCST = VProdSt + VProdSt / 100 * PMVAST.Value;
                }

                VICMSST = VBCST / 100 * PICMSST - VICMS;
            }

            VBC = decimal.Zero;
            VICMS = decimal.Zero;
            VCredICMSSN = decimal.Zero;
            PCredSN = decimal.Zero;
        }
        private void CalcularCsosn900()
        {
            if (ModBC == DeterminacaoBaseIcms.DbiPrecoTabelado)
            {
                if (PRedBC > decimal.Zero)
                {
                    VBC = VProd - VProd / 100 * PRedBC;
                }
                else
                {
                    if (PICMS > decimal.Zero)
                    {
                        VBC = VProd;
                    }
                }

                if (PICMS > decimal.Zero)
                {
                    VICMS = VBC / 100 * PICMS;
                }

                if (ModBCST == DeterminacaoBaseIcmsSt.DbisMargemValorAgregado)
                {
                    if (PRedBCST > decimal.Zero)
                    {
                        VBCST = VProdSt - VProdSt / 100 * PRedBCST.Value;
                        VBCST = VBCST + VBCST / 100 * PMVAST.Value;
                    }
                    else
                    {
                        if (PICMSST > decimal.Zero)
                        {
                            VBCST = VProdSt + VProdSt / 100 * PMVAST.Value;
                        }
                    }

                    if (PICMSST > decimal.Zero)
                    {
                        VICMSST = VBCST / 100 * PICMSST - VICMS;
                    }
                }

                VCredICMSSN = VBC / 100 * PCredSN;
            }
        }
        #endregion
    }
}
