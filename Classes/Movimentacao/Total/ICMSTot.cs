using ISync.Classes.Core.Utils;
using ISync.Classes.Movimentacao.Movimentacao.Identificacao;

namespace ISync.Classes.Movimentacao.Movimentacao.Total
{
    public class ICMSTot : Base
    {
        public int IdeId { get; private set; }

        /// <summary>
        ///     W03 - Base de Cálculo do ICMS
        /// </summary>
        public decimal VBC { get; private set; }

        /// <summary>
        ///     W04 - Valor Total do ICMS
        /// </summary>
        public decimal VICMS { get; private set; }

        /// <summary>
        ///     W04a - Valor Total do ICMS desonerado
        /// </summary>
        public decimal? VICMSDeson { get; private set; }

        /// <summary>
        /// W04c - Valor total do ICMS relativo Fundo de Combate à Pobreza(FCP) da UF de destino
        /// </summary>
        public decimal? VFCPUFDest { get; private set; }

        /// <summary>
        /// W04e - Valor total do ICMS Interestadual para a UF de destino
        /// </summary>
        public decimal? VICMSUFDest { get; private set; }

        /// <summary>
        /// W04g - Valor total do ICMS Interestadual para a UF do remetente
        /// </summary>
        public decimal? VICMSUFRemet { get; private set; }

        /// <summary>
        /// W04h - Valor Total do FCP (Fundo de Combate à Pobreza)
        /// Versão 4.00
        /// </summary>
        public decimal? VFCP { get; private set; }

        /// <summary>
        ///     W05 - Base de Cálculo do ICMS ST
        /// </summary>
        public decimal VBCST { get; private set; }

        /// <summary>
        ///     W06 - Valor Total do ICMS ST
        /// </summary>
        public decimal VST { get; private set; }

        /// <summary>
        /// W06a - Valor Total do FCP (Vundo de Combate à Pobreza) retido por substituição tributária
        /// Versão 4.00
        /// </summary>
        public decimal? VFCPST { get; private set; }

        /// <summary>
        /// W06b - Valor Total do FCP retido anteriormente por Substituição Tributária
        /// Versão 4.00
        /// </summary>
        public decimal? VFCPSTRet { get; private set; }

        /// <summary>
        ///     W07 - Valor Total dos produtos e serviços
        /// </summary>
        public decimal VProd { get; private set; }

        /// <summary>
        ///     W08 - Valor Total do Frete
        /// </summary>
        public decimal VFrete { get; private set; }

        /// <summary>
        ///     W09 - Valor Total do Seguro
        /// </summary>
        public decimal VSeg { get; private set; }

        /// <summary>
        ///     W10 - Valor Total do Desconto
        /// </summary>
        public decimal VDesc { get; private set; }

        /// <summary>
        ///     W11 - Valor Total do II
        /// </summary>
        public decimal VII { get; private set; }

        /// <summary>
        ///     W12 - Valor Total do IPI
        /// </summary>
        public decimal VIPI { get; private set; }

        /// <summary>
        /// W12a - Valor Total do IPI devolvido
        /// Versão 4.00
        /// </summary>
        public decimal? VIPIDevol { get; private set; }

        /// <summary>
        ///     W13 - Valor do PIS
        /// </summary>
        public decimal VPIS { get; private set; }

        /// <summary>
        ///     W14 - Valor da COFINS
        /// </summary>
        public decimal VCOFINS { get; private set; }

        /// <summary>
        ///     W15 - Outras Despesas acessórias
        /// </summary>
        public decimal VOutro { get; private set; }

        /// <summary>
        ///     w16 - Valor Total da NF-e
        /// </summary>
        public decimal VNF { get; private set; }

        /// <summary>
        ///     W16a - Valor aproximado total de tributos federais, estaduais e municipais.
        /// </summary>
        public decimal VTotTrib { get; private set; }


        public virtual Ide Ide { get; private set; }

        protected ICMSTot() { }

        public ICMSTot(int id, int ideId, decimal vBC, decimal vICMS, decimal? vICMSDeson, decimal? vFCPUFDest, decimal? vICMSUFDest, decimal? vICMSUFRemet, decimal? vFCP, decimal vBCST, decimal vST, decimal? vFCPST, decimal? vFCPSTRet, decimal vProd, decimal vFrete, decimal vSeg, decimal vDesc, decimal vII, decimal vIPI, decimal? vIPIDevol, decimal vPIS, decimal vCOFINS, decimal vOutro, decimal? vTotTrib)
        {
            Id = id;
            IdeId = ideId;
            VBC = vBC;
            VICMS = vICMS;
            VICMSDeson = vICMSDeson;
            VFCPUFDest = vFCPUFDest;
            VICMSUFDest = vICMSUFDest;
            VICMSUFRemet = vICMSUFRemet;
            VFCP = vFCP;
            VBCST = vBCST;
            VST = vST;
            VFCPST = vFCPST;
            VFCPSTRet = vFCPSTRet;
            VProd = vProd;
            VFrete = vFrete;
            VSeg = vSeg;
            VDesc = vDesc;
            VII = vII;
            VIPI = vIPI;
            VIPIDevol = vIPIDevol;
            VPIS = vPIS;
            VCOFINS = vCOFINS;
            VOutro = vOutro;
            VTotTrib = (decimal)vTotTrib;

            CalcularTotalNF();
        }

        public void Atualizar(decimal vBC, decimal vICMS, decimal? vICMSDeson, decimal? vFCPUFDest, decimal? vICMSUFDest, decimal? vICMSUFRemet, decimal? vFCP, decimal vBCST, decimal vST, decimal? vFCPST, decimal? vFCPSTRet, decimal vProd, decimal vFrete, decimal vSeg, decimal vDesc, decimal vII, decimal vIPI, decimal? vIPIDevol, decimal vPIS, decimal vCOFINS, decimal vOutro, decimal? vTotTrib)
        {
            VBC = vBC;
            VICMS = vICMS;
            VICMSDeson = vICMSDeson;
            VFCPUFDest = vFCPUFDest;
            VICMSUFDest = vICMSUFDest;
            VICMSUFRemet = vICMSUFRemet;
            VFCP = vFCP;
            VBCST = vBCST;
            VST = vST;
            VFCPST = vFCPST;
            VFCPSTRet = vFCPSTRet;
            VProd = vProd;
            VFrete = vFrete;
            VSeg = vSeg;
            VDesc = vDesc;
            VII = vII;
            VIPI = vIPI;
            VIPIDevol = vIPIDevol;
            VPIS = vPIS;
            VCOFINS = vCOFINS;
            VOutro = vOutro;
            VTotTrib = vTotTrib.InfotechToDecimal();

            CalcularTotalNF();
        }

        private void CalcularTotalNF()
        {
            VNF = VProd - VDesc - VICMSDeson ?? 0 + VST + VFrete + VSeg + VOutro + VII + VIPI;
        }

        public void AcumularDesconto(decimal vDesc)
        {
            VDesc += vDesc;
        }

        public void AcumularAcrescimo(decimal vAcresc)
        {
            VOutro += vAcresc;
        }
    }
}