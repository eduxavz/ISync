using Infotech.PDV.Movimentacao.Domain.Entities.Detalhe;
using ISync.Classes.Core.Enums;
using ISync.Classes.Core.Utils;
using ISync.Classes.Movimentacao.Movimentacao.Detalhe.Exportacao;
using ISync.Classes.Movimentacao.Movimentacao.Detalhe.ProdEspecifico;
using ISync.Classes.Movimentacao.Movimentacao.Detalhe.Tributacao.Estadual;
using ISync.Classes.Movimentacao.Movimentacao.Detalhe.Tributacao.Federal;
using ISync.Classes.Movimentacao.Movimentacao.Detalhe.Tributacao.Municipal;
using ISync.Classes.Movimentacao.Movimentacao.Identificacao;
using System.Collections.Generic;
using System.Linq;

namespace ISync.Classes.Movimentacao.Movimentacao.Detalhe
{
    public class Prod : Base 
    {
        /// <summary>
        /// Relaciomento Vendedor
        /// </summary>
        public int VendedorId { get; private set; }

        /// <summary>
        /// Relacionamento ProdutoGrades
        /// </summary>
        public int ProdutoGradeId { get; private set; }

        /// <summary>
        /// Relacionamento Identificacao
        /// </summary>
        public int IdeId { get; private set; }

        /// <summary>
        /// Categoria do produto
        /// </summary>
        public int? CategoriaId { get; private set; }

        /// <summary>
        /// Descricao da categoria do produto
        /// </summary>
        public string CategoriaNome { get; private set; }

        /// <summary>
        /// Nro do items na NFe
        /// </summary>
        public int NItem { get; private set; }

        /// <summary>
        ///     I02 - Código do produto ou serviço
        /// </summary>
        public string CProd { get; private set; }

        /// <summary>
        ///     I03 - GTIN (Global Trade Item Number) do produto, antigo código EAN ou código de barras
        /// </summary>
        public string CEAN { get; private set; }

        /// <summary>
        ///     I04 - Descrição do produto ou serviço
        /// </summary>
        public string XProd { get; private set; }

        /// <summary>
        ///     I05 - Código NCM (8 posições). Em caso de item de serviço ou item que não tenham produto (Ex. transferência de
        ///     crédito, crédito do ativo imobilizado, etc.), informar o código 00 (zeros) (v2.0)
        /// </summary>
        public string NCM { get; private set; }

        /// <summary>
        ///     105a - Nomenclatura de Valor aduaneio e Estatístico
        ///     <para>Ocorrência: 0-8</para>
        /// </summary>
        public string NVE { get; private set; }

        /// <summary>
        /// I05c - Código CEST
        /// </summary>
        public string CEST { get; private set; }

        /// <summary>
        /// Versão 4.00
        /// Indicador de Produção em escala relevante, conforme Cláusula 23 do Convenio ICMS 52/2017 ||||
        /// Nota: preenchimento obrigatório para produtos com NCM
        /// relacionado no Anexo XXVII do Convenio 52/2017
        /// </summary>
        public EnumIndEscala? IndEscala { get; private set; }

        /// <summary>
        /// Versão 4.00
        /// CNPJ do Fabricante da Mercadoria, obrigatório para produto em escala NÃO relevante.
        /// </summary>
        public string CNPJFab { get; private set; }

        /// <summary>
        /// Versão 4.00
        /// Código de Benefício fiscal utilizado pela UF, aplicado ao item. Obs: Deve ser utilizado o mesmo código adotado na EFD e outras
        /// declarações, nas UF que o exigem.
        /// </summary>
        public string CBenef { get; private set; }

        /// <summary>
        ///     I06 - Código EX TIPI (3 posições)
        /// </summary>
        public string EXTIPI { get; private set; }

        /// <summary>
        ///     I08 - Código Fiscal de Operações e Prestações
        /// </summary>
        public int CFOP { get; private set; }

        /// <summary>
        ///     I09 - Unidade comercial
        /// </summary>
        public string UCom { get; private set; }

        /// <summary>
        ///     I10 - Quantidade Comercial  do produto, alterado para aceitar de 0 a 4 casas decimais e 11 inteiros.
        /// </summary>
        public decimal QCom { get; private set; }

        /// <summary>
        ///     I10a - Valor Unitário de Comercialização
        /// </summary>
        public decimal VUnCom { get; private set; }

        /// <summary>
        ///     I11 - Valor Total Bruto dos Produtos ou Serviços
        /// </summary>
        public decimal VProd { get; private set; }

        /// <summary>
        ///     I12 - GTIN (Global Trade Item Number) do produto, antigo código EAN ou código de barras
        /// </summary>
        public string CEANTrib { get; private set; }

        /// <summary>
        ///     I13 - Unidade Tributável
        /// </summary>
        public string UTrib { get; private set; }

        /// <summary>
        ///     I14 - Quantidade Tributável
        /// </summary>
        public decimal QTrib { get; private set; }

        /// <summary>
        ///     I14a - Valor Unitário de tributação
        /// </summary>
        public decimal VUnTrib { get; private set; }

        /// <summary>
        ///     I15 - Valor Total do Frete
        /// </summary>
        public decimal? VFrete { get; private set; }

        /// <summary>
        ///     I16 - Valor Total do Seguro
        /// </summary>
        public decimal? VSeg { get; private set; }

        /// <summary>
        ///     I17 - Valor do Desconto
        /// </summary>
        public decimal? VDesc { get; private set; }

        /// <summary>
        ///     I17a - Outras despesas acessórias
        /// </summary>
        public decimal? VOutro { get; private set; }

        /// <summary>
        ///     I17b - Indica se valor do Item (vProd) entra no valor total da NF-e (vProd)
        /// </summary>
        public IndicadorTotal IndTot { get; private set; }

        /// <summary>
        ///     I60 - Número do Pedido de Compra
        /// </summary>
        public string XPed { get; private set; }

        /// <summary>
        ///     I61 - Item do Pedido de Compra
        /// </summary>
        public int? NItemPed { get; private set; }

        /// <summary>
        ///     I70 - Número de controle da FCI - Ficha de Conteúdo de Importação
        /// </summary>
        public string NFCI { get; private set; }

        /// <summary>
        ///     LB01 - Número do RECOPI
        /// </summary>
        public string NRECOPI { get; private set; }

        /// <summary>
        ///     V01 - Informações Adicionais do Produto
        /// </summary>
        public string InfAdProd { get; private set; }

        /// <summary>
        ///     M02 - Valor estimado total de impostos federais, estaduais e municipais
        /// </summary>
        public decimal? VTotTrib { get; private set; }

        /// <summary>
        /// Produto cancelado na venda
        /// </summary>
        public bool Cancelado { get; private set; }

        /// <summary>
        /// Valor de custo do produto
        /// </summary>
        public decimal VCusto { get; private set; }

        /// <summary>
        /// Aliquota IBPT Federal
        /// </summary>
        public decimal? PTribFed { get; private set; }

        /// <summary>
        /// Aliquota IBPT Estadual
        /// </summary>
        public decimal? PTribEst { get; private set; }

        /// <summary>
        /// Aliquota IBPT Municipal
        /// </summary>
        public decimal? PTribMun { get; private set; }

        public virtual Ide Ide { get; private set; }
        public virtual ICollection<ICMS> ICMS { get; private set; }
        public virtual ICollection<PIS> PIS { get; private set; }
        public virtual ICollection<IPI> IPI { get; private set; }
        public virtual ICollection<II> II { get; private set; }
        public virtual ICollection<COFINS> COFINS { get; private set; }
        public virtual ICollection<ISSQN> ISSQN { get; private set; }
        public virtual ICollection<Comb> Combs { get; private set; }
        public virtual ICollection<DetExport> DetExports { get; private set; }


        protected Prod() { }

        public Prod(int id, int vendedorId, int produtoGradeId, int ideId, int? categoriaId, string categoriaNome, string cProd, string cEAN, string xProd, string nCM, string nVE, string cEST, EnumIndEscala? indEscala, string cNPJFab, string eXTIPI, int cFOP, string uCom, decimal qCom, decimal vUnCom, decimal vProd, string cEANTrib, string uTrib, decimal qTrib, decimal vUnTrib, decimal? vFrete, decimal? vSeg, decimal? vDesc, decimal? vOutro, IndicadorTotal indTot, string xPed, int? nItemPed, string nFCI, string nRECOPI, string infAdProd, decimal vCusto, bool cancelado, decimal pTribFed, decimal pTribEst, decimal pTribMun,int nItem, string cBenef = "")
        {
            Id = id;
            VendedorId = vendedorId;
            ProdutoGradeId = produtoGradeId;
            IdeId = ideId;
            CategoriaId = categoriaId;
            CategoriaNome = categoriaNome;
            NItem = nItem;

            //if (string.IsNullOrEmpty(cEAN) && string.IsNullOrEmpty(cProd)) throw new Exception("Produto sem código interno e EAN");

            if (string.IsNullOrEmpty(cEAN) && string.IsNullOrEmpty(cProd))
            {
                CProd = produtoGradeId.ToString();
                CEAN = "SEM GTIN";
            }
            else
            {
                CProd = string.IsNullOrEmpty(cProd) ? cEAN : cProd;
                CEAN = string.IsNullOrEmpty(cEAN) ? "SEM GTIN" : cEAN;
            }

            XProd = xProd;

            if (string.IsNullOrEmpty(nCM))
            {
                NCM = nCM;
            }
            else
            {
                NCM = nCM.Length > 8 ? "00" : nCM;
            }

            NVE = nVE;
            CEST = cEST;
            IndEscala = indEscala;
            CNPJFab = cNPJFab;
            CBenef = string.Empty;
            EXTIPI = eXTIPI;
            CFOP = cFOP == 0 ? 9999 : cFOP;
            UCom = uCom;
            QCom = qCom;
            VUnCom = vUnCom;
            VProd = vProd;
            CEANTrib = string.IsNullOrEmpty(cEANTrib) ? "SEM GTIN" : cEANTrib;
            UTrib = uTrib;
            QTrib = qTrib;
            VUnTrib = vUnTrib;
            VFrete = vFrete;
            VSeg = vSeg;
            VDesc = vDesc;
            VOutro = vOutro;
            IndTot = indTot;
            XPed = xPed;
            NItemPed = nItemPed;
            NFCI = nFCI;
            NRECOPI = nRECOPI;
            InfAdProd = infAdProd;
            VCusto = vCusto;
            Cancelado = cancelado;
            PTribFed = pTribFed;
            PTribEst = pTribEst;
            PTribMun = pTribMun;

            CBenef = cBenef;
        }

        public Prod(int nItem, int vendedorId, string cProd, string xProd, string uCom, decimal qCom, decimal vUnCom, decimal vProd)
        {
            NItem = nItem;
            VendedorId = vendedorId;
            CProd = cProd;
            XProd = xProd;
            UCom = uCom;
            QCom = qCom;
            VUnCom = vUnCom;
            VProd = vProd;
        }

        public void Atualizar(int vendedorId, int produtoGradeId, int ideId, int? categoriaId, string categoriaNome, string cProd, string cEAN, string xProd, string nCM, string nVE, string cEST, EnumIndEscala? indEscala, string cNPJFab, string eXTIPI, int cFOP, string uCom, decimal qCom, decimal vUnCom, decimal vProd, string cEANTrib, string uTrib, decimal qTrib, decimal vUnTrib, decimal? vFrete, decimal? vSeg, decimal? vDesc, decimal? vOutro, IndicadorTotal indTot, string xPed, int? nItemPed, string nFCI, string nRECOPI, string infAdProd, decimal vCusto, bool cancelado, string cBenef = "")
        {
            VendedorId = vendedorId;
            ProdutoGradeId = produtoGradeId;
            IdeId = ideId;
            CategoriaId = categoriaId;
            CategoriaNome = categoriaNome;

            if (string.IsNullOrEmpty(cEAN) && string.IsNullOrEmpty(cProd))
            {
                CProd = produtoGradeId.ToString();
                CEAN = "SEM GTIN";
            }
            else
            {
                CProd = string.IsNullOrEmpty(cProd) ? cEAN : cProd;
                CEAN = string.IsNullOrEmpty(cEAN) ? "SEM GTIN" : cEAN;
            }

            XProd = xProd;

            if (string.IsNullOrEmpty(nCM))
            {
                NCM = nCM;
            }
            else
            {
                NCM = nCM.Length > 8 ? "00" : nCM;
            }

            NVE = nVE;
            CEST = cEST;
            IndEscala = indEscala;
            CNPJFab = cNPJFab;
            CBenef = string.Empty;
            EXTIPI = eXTIPI;
            CFOP = cFOP == 0 ? 9999 : cFOP;
            UCom = uCom;
            QCom = qCom;
            VUnCom = vUnCom;
            VProd = vProd;
            CEANTrib = string.IsNullOrEmpty(cEANTrib) ? "SEM GTIN" : cEANTrib;
            UTrib = uTrib;
            QTrib = qTrib;
            VUnTrib = vUnTrib;
            VFrete = vFrete;
            VSeg = vSeg;
            VDesc = vDesc;
            VOutro = vOutro;
            IndTot = indTot;
            XPed = xPed;
            NItemPed = nItemPed;
            NFCI = nFCI;
            NRECOPI = nRECOPI;
            InfAdProd = infAdProd;
            VCusto = vCusto;
            Cancelado = cancelado;
            CBenef = cBenef;

            if (ICMS != null && ICMS.Any()) ICMS.First().Atualizar(vProd, decimal.Zero, decimal.Zero);
            if (PIS != null && PIS.Any()) PIS.First().Atualizar(vProd);
            if (COFINS != null && COFINS.Any()) COFINS.First().Atualizar(vProd);
            if (IPI != null && IPI.Any()) IPI.First().Atualizar(vProd);

        }
        public void Atualizar(int vendedorId, decimal qCom, decimal vUnCom, decimal vProd, decimal? vFrete, decimal? vSeg, decimal? vOutro, string infAdic)
        {
            VendedorId = vendedorId;
            QCom = qCom;
            VUnCom = vUnCom;
            VProd = vProd;
            VFrete = vFrete;
            VSeg = vSeg;
            VOutro = vOutro;
            InfAdProd = infAdic;

            if (ICMS != null && ICMS.Any()) ICMS.First().Atualizar(vProd, decimal.Zero, decimal.Zero);
            if (PIS != null && PIS.Any()) PIS.First().Atualizar(vProd);
            if (COFINS != null && COFINS.Any()) COFINS.First().Atualizar(vProd);
            if (IPI != null && IPI.Any()) IPI.First().Atualizar(vProd);
        }
        public void SetarNItem(int nItem) => NItem = nItem;

        public void Cancelar(int aprovador)
        {
            Cancelado = true;
            IndTot = IndicadorTotal.ValorDoItemNaoCompoeTotalNF;
        }

        public void CalcularVTotTrib(decimal pTribFed, decimal pTribEst, decimal pTribMun, decimal? pTribManual)
        {
            PTribFed = pTribManual.HasValue ? pTribManual : pTribFed;
            PTribEst = pTribEst;
            PTribMun = pTribMun;

            if (pTribManual.HasValue && pTribManual > decimal.Zero)
            {
                VTotTrib = (pTribManual * VProd / 100).InfotechArredondar(2);
                return;
            }

            var pTotTrib = decimal.Zero;

            if (pTribFed > decimal.Zero) pTotTrib += pTribFed;
            if (pTribEst > decimal.Zero) pTotTrib += pTribEst;
            if (pTribMun > decimal.Zero) pTotTrib += pTribMun;

            VTotTrib = (pTotTrib * VProd / 100).InfotechArredondar(2);
        }

        public void AtualizarDesconto(decimal valor)
        {
            VDesc = valor;
        }

        public void AtualizarAcrescimo(decimal valor)
        {
            VOutro = valor;
        }

        public void AtualizarQuantidade(decimal quantidade)
        {
            QCom = quantidade;
            VProd = VUnCom * QCom;
        }

        public void AtualizarVendedor(int id)
        {
            VendedorId = id;
        }
        #region Filhos
        public void AdicionarIcms(ICMS icms, string cBenef)
        {
            if (ICMS == null) ICMS = new List<ICMS>();

            CBenef = cBenef;

            ICMS.Add(icms);
        }
        public void AdicionarPis(PIS pis)
        {
            if (PIS == null) PIS = new List<PIS>();

            PIS.Add(pis);
        }
        public void AdicionarIpi(IPI ipi)
        {
            if (IPI == null) IPI = new List<IPI>();

            IPI.Add(ipi);
        }
        public void AdicionarII(II ii)
        {
            if (II == null) II = new List<II>();

            II.Add(ii);
        }
        public void AdicionarCofins(COFINS cofins)
        {
            if (COFINS == null) COFINS = new List<COFINS>();

            COFINS.Add(cofins);
        }
        public void AdicionarIssqn(ISSQN issqn)
        {
            if (ISSQN == null) ISSQN = new List<ISSQN>();

            ISSQN.Add(issqn);
        }
        public void AdicionarComb(Comb comb)
        {
            if (Combs == null) Combs = new List<Comb>();

            Combs.Add(comb);
        }
        public void AdicionarDetExport(DetExport detExport)
        {
            if (DetExports == null) DetExports = new List<DetExport>();

            DetExports.Add(detExport);
        }


        #endregion
    }
}