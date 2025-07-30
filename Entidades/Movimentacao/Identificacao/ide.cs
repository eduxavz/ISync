using System;
using System.Collections.Generic;
using ISync.Classes.Core.Enums.Movimentacao;
using System.Linq;
using ISync.Classes.Core.Utils;
using ISync.Entidades.Movimentacao.Cobranca;
using ISync.Entidades.Movimentacao.Destinatario;
using ISync.Entidades.Movimentacao.Detalhe;
using ISync.Entidades.Movimentacao.Emitente;
using ISync.Entidades.Movimentacao.Intermediador;
using ISync.Entidades.Movimentacao.Pagamento;
using ISync.Entidades.Movimentacao.RespTecnico;
using ISync.Entidades.Movimentacao.Total;
using ISync.Entidades.Movimentacao.Transporte;

namespace ISync.Entidades.Movimentacao.Identificacao
{
    public class Ide : Base
    {
        /// <summary>
        /// Relacionamento com o Contrato
        /// </summary>
        public int ContratoId { get; private set; }

        /// <summary>
        /// Relacionamento com a Empresa
        /// </summary>
        public int EmpresaId { get; private set; }

        /// <summary>
        /// Relacionamento com a Sessão
        /// </summary>
        public int? SessaoId { get; private set; }

        /// <summary>
        /// Relacionamento com o Operador
        /// </summary>
        public int OperadorId { get; private set; }

        /// <summary>
        /// Status da Ide
        /// </summary>
        public EnumIdeStatus Status { get; private set; }

        /// <summary>
        ///     A02 - Versão do leiaute da NFe (2.0, 3.1, etc)
        /// </summary>
        public string Versao { get; private set; }

        /// <summary>
        ///     A03 - Identificador da TAG a ser assinada
        ///     <para>informar a chave de acesso da NF-e precedida do literal "NFe", acrescentada a validação do formato (v2.0).</para>
        /// </summary>
        public string IdNFe { get; private set; }

        /// <summary>
        ///     B02 - Código da UF do emitente do Documento Fiscal. Utilizar a Tabela do IBGE.
        /// </summary>
        public int CUF { get; private set; }

        /// <summary>
        ///     B03 - Código numérico que compõe a Chave de Acesso. Número aleatório gerado pelo emitente para cada NF-e.
        /// </summary>
        public string CNF { get; private set; }

        /// <summary>
        ///     B04 - Descrição da Natureza da Operação
        /// </summary>
        public string NatOp { get; private set; }

        /// <summary>
        ///     B05 - Indicador da forma de pagamento
        ///     Versão 3.10
        ///     Versão 4.00 removido
        /// </summary>
        public EnumIndicadorPagamento? IndPag { get; private set; }

        /// <summary>
        ///     B06 - Modelo do Documento Fiscal
        /// </summary>
        public EnumIdeMod Mod { get; private set; }

        /// <summary>
        ///     B07 - Série do Documento Fiscal
        ///     <para>série normal 0-889</para>
        ///     <para>Avulsa Fisco 890-899</para>
        ///     <para>SCAN 900-999</para>
        /// </summary>
        public int Serie { get; private set; }

        /// <summary>
        ///     B08 - Número do Documento Fiscal
        /// </summary>
        public long NNF { get; private set; }

        /// <summary>
        ///     B09 - Data e Hora de emissão do Documento Fiscal
        /// </summary>
        public DateTime DhEmi { get; private set; }

        /// <summary>
        ///     B10 - Data e Hora da saída ou de entrada da mercadoria / produto
        /// </summary>
        public DateTime? DhSaiEnt { get; private set; }

        /// <summary>
        ///     B11 - Tipo do Documento Fiscal
        /// </summary>
        public EnumTipoNFe TpNF { get; private set; }

        /// <summary>
        ///     B11a - Identificador de Local de destino da operação
        /// </summary>
        public EnumDestinoOperacao? IdDest { get; private set; }

        /// <summary>
        ///     B12 - Código do Município de Ocorrência do Fato Gerador (utilizar a tabela do IBGE)
        /// </summary>
        public long CMunFG { get; private set; }

        /// <summary>
        ///     B21 - Formato de impressão do DANFE
        /// </summary>
        public EnumTipoImpressao TpImp { get; private set; }

        /// <summary>
        ///     B22 - Tipo de Emissão da NF-e
        /// </summary>
        public EnumTipoEmissao TpEmis { get; private set; }

        /// <summary>
        ///     B23 - Digito Verificador da Chave de Acesso da NF-e
        /// </summary>
        public int CDV { get; private set; }

        /// <summary>
        ///     B24 - Identificação do Ambiente
        /// </summary>
        public EnumTpAmb TpAmb { get; private set; }

        /// <summary>
        ///     B25a - Finalidade da emissão da NF-e
        /// </summary>
        public EnumFinalidadeNFe FinNFe { get; private set; }

        /// <summary>
        ///     B25a - Indica operação com consumidor final
        /// </summary>
        public EnumConsumidorFinal? IndFinal { get; private set; }

        /// <summary>
        ///     B25b - Indicador de presença do comprador no estabelecimento comercial no momento da operação
        /// </summary>
        public EnumPresencaComprador? IndPres { get; private set; }

        /// <summary>
        ///     B25c - Indicador de intermediador/marketplace
        /// </summary>
        public EnumIndicadorIntermediador? IndIntermed { get; private set; }

        /// <summary>
        ///     B26 - Processo de emissão utilizado com a seguinte codificação:
        /// </summary>
        public EnumProcessoEmissao ProcEmi { get; private set; }

        /// <summary>
        ///     B27 - versão do aplicativo utilizado no processo de emissão
        /// </summary>
        public string VerProc { get; private set; }

        /// <summary>
        ///     B28 - Informar apenas para tpEmis diferente de 1
        ///     <para>
        ///         Informar a data e hora de entrada em contingência
        ///     </para>
        /// </summary>
        public DateTime? DhCont { get; private set; }

        /// <summary>
        ///     B29 - Informar a Justificativa da entrada
        /// </summary>
        public string XJust { get; private set; }

        /// <summary>
        ///     BA01 - Informação de Documentos Fiscais referenciados
        /// </summary>
        public virtual ICollection<NFref> NFref { get; private set; }

        /// <summary>
        ///     Z02 - Informações Adicionais de Interesse do Fisco
        /// </summary>
        public string InfAdFisco { get; private set; }

        /// <summary>
        ///     Z03 - Informações Complementares de interesse do Contribuinte
        /// </summary>
        public string InfCpl { get; private set; }

        /// <summary>
        /// Data de competencia desta movimentacao 
        /// </summary>
        public DateTime? DCompetencia { get; private set; }

        /// <summary>
        /// Id de registro do retaguarda.
        /// </summary>
        public int? SysIdEnvio { get; private set; }

        public virtual ICollection<NFref> NFrefs { get; private set; }
        public virtual ICollection<Fat> Fats { get; private set; }
        public virtual ICollection<Emit> Emit { get; private set; }
        public virtual ICollection<Dest> Dest { get; private set; }
        public virtual ICollection<InfIntermed> InfIntermed { get; private set; }
        public virtual ICollection<Prod> Prods { get; private set; }
        public virtual ICollection<DetPag> Pags { get; private set; }
        public virtual ICollection<InfRespTec> InfRespTec { get; private set; }
        public virtual ICollection<ICMSTot> ICMSTot { get; private set; }
        public virtual ICollection<ISSQNtot> ISSQNtot { get; private set; }
        public virtual ICollection<RetTrib> RetTrib { get; private set; }
        public virtual ICollection<Transp> Transps { get; private set; }


        #region Construtores
        protected Ide() { }

        public Ide(int id, int contratoId, int empresaId, int? sessaoId, int operadorId, EnumIdeStatus status, string versao, string idNFe, int cUF, string cNF, string natOp, EnumIndicadorPagamento? indPag, EnumIdeMod mod, int serie, long nNF, DateTime dhEmi, DateTime? dhSaiEnt, EnumTipoNFe tpNF, EnumDestinoOperacao? idDest, long cMunFG, EnumTipoImpressao tpImp, EnumTipoEmissao tpEmis, int cDV, EnumTpAmb tpAmb, EnumFinalidadeNFe finNFe, EnumConsumidorFinal? indFinal, EnumPresencaComprador? indPres, EnumIndicadorIntermediador? indIntermed, EnumProcessoEmissao procEmi, string verProc, DateTime dhCont, string xJust, ICollection<NFref> nFref, string infAdFisco, string infCpl)
        {
            Id = id;
            ContratoId = contratoId;
            EmpresaId = empresaId;
            SessaoId = sessaoId;
            OperadorId = operadorId;
            Status = status;
            Versao = versao;
            IdNFe = idNFe;
            CUF = cUF;
            CNF = cNF;
            NatOp = natOp;
            IndPag = indPag;
            Mod = mod;
            Serie = serie;
            NNF = nNF;
            DhEmi = dhEmi;
            DhSaiEnt = dhSaiEnt;
            TpNF = tpNF;
            IdDest = idDest;
            CMunFG = cMunFG;
            TpEmis = tpEmis;
            CDV = cDV;
            TpAmb = tpAmb;
            FinNFe = finNFe;
            IndFinal = indFinal;
            IndPres = indPres;
            IndIntermed = indIntermed;
            ProcEmi = procEmi;
            VerProc = verProc;
            DhCont = dhCont;
            XJust = xJust;
            NFref = nFref;
            InfAdFisco = infAdFisco;
            InfCpl = infCpl;

            AtualizarTipoImpressao();
        }
        public Ide(int id, int contratoId, int empresaId, int? sessaoId, int operadorId, EnumIdeStatus status, int serie, long nNF, EnumTpAmb tpAmb, EnumIdeMod mod, DateTime dEmi, EnumTipoNFe tpNF)
        {
            Id = id;
            ContratoId = contratoId;
            EmpresaId = empresaId;
            SessaoId = sessaoId;
            OperadorId = operadorId;
            Status = status;
            Versao = "4.00";
            IdNFe = id.ToString();
            IndPag = EnumIndicadorPagamento.Vista;
            Serie = serie;
            NNF = nNF;
            DhEmi = dEmi;
            TpNF = tpNF;
            Mod = mod;
            IdDest = EnumDestinoOperacao.Interna;
            TpEmis = EnumTipoEmissao.Normal;
            TpAmb = tpAmb;
            FinNFe = EnumFinalidadeNFe.Normal;
            IndFinal = EnumConsumidorFinal.ConsumidorFinal;
            IndPres = EnumPresencaComprador.Presencial;
            IndIntermed = EnumIndicadorIntermediador.SemIntermediador;
            ProcEmi = EnumProcessoEmissao.AplicativoContribuinte;
            VerProc = "4.00";

            // Adicionados temporariamente para resolver as exceções.
            CNF = string.Empty;
            InfAdFisco = string.Empty;
            InfCpl = "Tributos: R$ 0,00 - Fed: 0,00 (0,00%)/Est: 0,00 (0,00%)/Mun: 0,00 (0,00%)-Fonte IBPT-(Conforme Lei Fed 12.741/2012) ";
            NatOp = "VENDAS";
            XJust = string.Empty;
            AtualizarTipoImpressao();
            AdicionarTransp(new Transp(Id, Id, EnumModFrete.SemFrete));
        }

        #endregion

        #region Alteracao Ide
        public void Atualizar(int? sessaoId, int operadorId, EnumIdeStatus status, string versao, string idNFe, int cUF, string cNF, string natOp, EnumIndicadorPagamento? indPag, EnumIdeMod mod, int serie, long nNF, DateTime dhEmi, DateTime? dhSaiEnt, EnumTipoNFe tpNF, EnumDestinoOperacao? idDest, long cMunFG, EnumTipoImpressao tpImp, EnumTipoEmissao tpEmis, int cDV, EnumTpAmb tpAmb, EnumFinalidadeNFe finNFe, EnumConsumidorFinal? indFinal, EnumPresencaComprador? indPres, EnumIndicadorIntermediador? indIntermed, EnumProcessoEmissao procEmi, string verProc, DateTime? dhCont, string xJust, string infAdFisco, string infCpl)
        {
            SessaoId = sessaoId;
            OperadorId = operadorId;
            Status = status;
            Versao = versao;
            IdNFe = idNFe;
            CUF = cUF;
            CNF = cNF;
            NatOp = natOp;
            IndPag = indPag;
            Mod = mod;
            Serie = serie;
            NNF = nNF;
            DhEmi = dhEmi;
            DhSaiEnt = dhSaiEnt;
            TpNF = tpNF;
            IdDest = idDest;
            CMunFG = cMunFG;
            TpImp = tpImp;
            TpEmis = tpEmis;
            CDV = cDV;
            TpAmb = tpAmb;
            FinNFe = finNFe;
            IndFinal = indFinal;
            IndPres = indPres;
            IndIntermed = indIntermed;
            ProcEmi = procEmi;
            VerProc = verProc;
            DhCont = dhCont;
            XJust = xJust;
            InfAdFisco = infAdFisco;
            InfCpl = infCpl;
            DCompetencia = null;
        }
        public void AtualizarInformacaoComplementar(string infAdFisco, string infCpl)
        {
            InfAdFisco = infAdFisco;
            InfCpl = infCpl;
        }
        public void AtualizarTpAmb(EnumTpAmb tpAmb)
        {
            TpAmb = tpAmb;
        }
        public void AtualizarTpEmis(EnumTipoEmissao tpEmis)
        {
            TpEmis = tpEmis;
        }
        public void AtualizarModelo(EnumIdeMod mod)
        {
            Mod = mod;

            switch (Mod)
            {
                case EnumIdeMod.VendaSimples:
                case EnumIdeMod.PedidoVenda:
                case EnumIdeMod.SAT:
                case EnumIdeMod.ECF:
                case EnumIdeMod.NFCe:
                    TpNF = EnumTipoNFe.Saida;
                    break;
                case EnumIdeMod.Entrada:
                case EnumIdeMod.PedidoCompra:
                case EnumIdeMod.InventarioEstoque:
                case EnumIdeMod.InventarioEstoqueReembolso:
                    TpNF = EnumTipoNFe.Entrada;
                    break;
            }

            TpImp = Mod == EnumIdeMod.NFe ? EnumTipoImpressao.Retrato : EnumTipoImpressao.NFCe;

            ProcessarInformacaoComplementar();
        }
        public void ProcessarInformacaoComplementar()
        {
            if (Prods is null) return;

            var prods = Prods.Where(x => !x.SysIsDeleted && !x.Cancelado);

            var pTotFed = prods.Sum(s => s.PTribFed.InfotechToDecimal() * s.VProd / 100 * 100 / prods.Sum(x => x.VProd));
            var vTotFed = prods.Sum(s => s.PTribFed.InfotechToDecimal() * s.VProd / 100);

            var pTotEst = prods.Sum(s => s.PTribEst.InfotechToDecimal() * s.VProd / 100 * 100 / prods.Sum(x => x.VProd));
            var vTotEst = prods.Sum(s => s.PTribEst.InfotechToDecimal() * s.VProd / 100);

            var pTotMun = prods.Sum(s => s.PTribMun.InfotechToDecimal() * s.VProd / 100 * 100 / prods.Sum(x => x.VProd));
            var vTotMun = prods.Sum(s => s.PTribMun.InfotechToDecimal() * s.VProd / 100);

            var vTotTrib = prods.Sum(s => s.VTotTrib);

            InfCpl = $"Tributos: R$ {vTotTrib.InfotechArredondar(2)} - Fed: {vTotFed.InfotechArredondar(2)} ({pTotFed.InfotechArredondar(2)}%) " +
                     $"/ Est: {vTotEst.InfotechArredondar(2)} ({pTotEst.InfotechArredondar(2)}%) " +
                     $"/ Mun: {vTotMun.InfotechArredondar(2)} ({pTotMun.InfotechArredondar(2)}%) - Fonte IBPT";
        }
        public void AtualizarSerie(int serie) => Serie = serie;
        public void AtualizarNNF(long nnf) => NNF = nnf;
        public void AtualizarCNF(string codigoNumerico)
        {
            if (!string.IsNullOrEmpty(codigoNumerico))
            {
                var cod = codigoNumerico.InfotechSetMascara("########");
                CNF = cod.PadLeft(8, '0');
            }
            else
            {
                var random = new Random();
                CNF = random.Next(10000000, 99999999).ToString();
            }
        }

        public void Cancelado(int aprovador)
        {
            Status = EnumIdeStatus.Cancelado;
        }

        public void Pendente() => Status = EnumIdeStatus.Pendente;
        
        public void Finalizado()
        {
            Status = EnumIdeStatus.Finalizado;
            DhEmi = DateTime.Now;
        }

        public void VendaSimples() => Mod = EnumIdeMod.VendaSimples;
        public bool PermiteAlteracao()
        {
            switch (Status)
            {
                case EnumIdeStatus.Finalizado:
                case EnumIdeStatus.Cancelado:
                    return false;
                default:
                    return true;

            }
        }
        public bool EhFiscal()
        {
            if (TpAmb == EnumTpAmb.Homologacao) return false;

            switch (Mod)
            {
                case EnumIdeMod.NFCe:
                case EnumIdeMod.NFe:
                case EnumIdeMod.SAT:
                    return true;
                default:
                    return false;
            }
        }
        public bool EhVenda()
        {
            if (Mod == EnumIdeMod.NFe && TpNF == EnumTipoNFe.Entrada) return false;

            switch (Mod)
            {
                case EnumIdeMod.NFCe:
                case EnumIdeMod.NFe:
                case EnumIdeMod.SAT:
                case EnumIdeMod.ECF:
                case EnumIdeMod.VendaSimples:
                case EnumIdeMod.PedidoVenda:
                    return true;
                default:
                    return false;
            }
        }
        public bool EhCancelamento()
        {
            return Status == EnumIdeStatus.Cancelado;
        }
        public decimal ObterValorTotal()
        {
            return Pags.Sum(i => i.VPag - i.VTroco.InfotechToDecimal());
        }
        public decimal ObterTrocoTotal()
        {
            return Pags.Sum(i => i.VTroco.InfotechToDecimal());
        }
        public decimal ObterValorTotalPagamentos()
        {
            if (Pags == null) throw new Exception("Pagamentos não localizado");

            return Pags.Where(x => !x.Cancelado).Sum(i => i.VPag - i.VTroco.InfotechToDecimal());
        }
        public void AtualizarChave(string chaveNFe)
        {
            if (string.IsNullOrEmpty(chaveNFe)) return;

            IdNFe = chaveNFe;
        }
        public bool TemProdutos() => Prods.Any();
        public bool TemPagamentos()
        {
            if (Mod == EnumIdeMod.InventarioEstoque) return true;

            return Pags.Any();
        }
        public bool TemDestinatario() => Dest.Any();
        private void AtualizarTipoImpressao()
        {
            switch (Mod)
            {
                case EnumIdeMod.NFe:
                    TpImp = EnumTipoImpressao.Retrato;
                    break;
                default:
                    TpImp = EnumTipoImpressao.NFCe;
                    break;
            }
        }
        #endregion

        #region Entidades relacionadas
        public void AdicionarNFRef(NFref nfeRef)
        {
            if (NFrefs == null) NFrefs = new List<NFref>();

            NFrefs.Add(nfeRef);
        }
        public void AdicionarInfIntermed(InfIntermed infIntermed)
        {
            if (InfIntermed == null) InfIntermed = new List<InfIntermed>();

            InfIntermed.Add(infIntermed);
        }
        public void AdicionarFat(Fat fat)
        {
            if (Fats == null) Fats = new List<Fat>();

            Fats.Add(fat);
        }
        public void AdicionarEmit(Emit emit)
        {
            if (Emit == null) Emit = new List<Emit>();

            if (Emit.Count > 0) Emit.Clear();

            try
            {
                CUF = emit.CMun.InfotechToStringSafe().Substring(0, 2).InfotechToInt();
                CMunFG = emit.CMun;
            }
            catch
            {
                if (EhFiscal()) throw new Exception("Código do município da empresa não localizado");

                CUF = 99;
                CMunFG = 9999999;
            }

            Emit.Add(emit);
        }
        public void AdicionarDest(Dest dest)
        {
            if (Dest == null) Dest = new List<Dest>();

            Dest.Add(dest);
        }
        public void AdicionarProd(Prod prod)
        {
            if (Prods == null) Prods = new List<Prod>();

            prod.SetarNItem(Prods.Count + 1);
            Prods.Add(prod);

            
            CalcularICMSTot();
        }
        public void InicializarProds()
        {
            if (Prods is null) Prods = new List<Prod>();

            CalcularICMSTot();
        }
        public void AdicionarProdFinal(Prod prod)
        {
            if (Prods == null) Prods = new List<Prod>();

            Prods.Add(prod);
        }
        public void AdicionarPag(DetPag detPag)
        {
            if (Pags == null) Pags = new List<DetPag>();

            Pags.Add(detPag);
        }
        public void AdicionarInfRespTec(InfRespTec infRespTec)
        {
            if (InfRespTec == null) InfRespTec = new List<InfRespTec>();

            InfRespTec.Add(infRespTec);
        }

        public void CalcularICMSTot()
        {
            var prods = Prods.Where(x => !x.Cancelado && !x.SysIsDeleted);

            var vBC = prods.Where(x => x.ICMS != null).SelectMany(s => s.ICMS).Sum(s => s.VBC.InfotechArredondar(2));
            var vFCP = prods.Where(x => x.ICMS != null).SelectMany(s => s.ICMS).Sum(s => s.VFCP.InfotechArredondar(2));
            var vST = prods.Where(x => x.ICMS != null).SelectMany(s => s.ICMS).Sum(s => s.VICMSST.InfotechArredondar(2));
            var vICMS = prods.Where(x => x.ICMS != null).SelectMany(s => s.ICMS).Sum(s => s.VICMS.InfotechArredondar(2));
            var vBCST = prods.Where(x => x.ICMS != null).SelectMany(s => s.ICMS).Sum(s => s.VBCST.InfotechArredondar(2));
            var vFCPST = prods.Where(x => x.ICMS != null).SelectMany(s => s.ICMS).Sum(s => s.VFCPST.InfotechArredondar(2));
            var vFCPSTRet = prods.Where(x => x.ICMS != null).SelectMany(s => s.ICMS).Sum(s => s.VFCPSTRet.InfotechArredondar(2));
            var vICMSDeson = prods.Where(x => x.ICMS != null).SelectMany(s => s.ICMS).Sum(s => s.VICMSDeson.InfotechArredondar(2));
            var vFCPUFDest = prods.Where(x => x.ICMS != null).SelectMany(s => s.ICMS).Sum(s => s.VFCPUFDest.InfotechArredondar(2));
            var vICMSUFDest = prods.Where(x => x.ICMS != null).SelectMany(s => s.ICMS).Sum(s => s.VICMSUFDest.InfotechArredondar(2));
            var vICMSUFRemet = prods.Where(x => x.ICMS != null).SelectMany(s => s.ICMS).Sum(s => s.VICMSUFRemet.InfotechArredondar(2));

            var vProd = prods.Sum(s => s.VProd);
            var vSeg = prods.Sum(s => s.VSeg.InfotechArredondar(2)) ?? decimal.Zero;
            var vDesc = prods.Sum(s => s.VDesc.InfotechArredondar(2)) ?? decimal.Zero;
            var vFrete = prods.Sum(s => s.VFrete.InfotechArredondar(2)) ?? decimal.Zero;
            var vOutro = prods.Sum(s => s.VOutro.InfotechArredondar(2)) ?? decimal.Zero;

            var vII = prods.Where(x => x.II != null).SelectMany(s => s.II).Sum(s => s.VII.InfotechArredondar(2));
            var vIPI = prods.Where(x => x.IPI != null).SelectMany(s => s.IPI).Sum(s => s.VIPI.InfotechArredondar(2)) ?? decimal.Zero;
            var vPIS = prods.Where(x => x.PIS != null).SelectMany(s => s.PIS).Sum(s => s.VPIS.InfotechArredondar(2));
            var vCOFINS = prods.Where(x => x.COFINS != null).SelectMany(s => s.COFINS).Sum(s => s.VCOFINS.InfotechArredondar(2)) ?? decimal.Zero;

            var vTotTrib = prods.Sum(s => s.VTotTrib.InfotechArredondar(2));

            if (ICMSTot == null)
            {
                ICMSTot = new List<ICMSTot>();

                ICMSTot.Add(new ICMSTot(Id, Id, vBC, vICMS, vICMSDeson, vFCPUFDest, vICMSUFDest, vICMSUFRemet, vFCP, vBCST, vST, vFCPST, vFCPSTRet, vProd, vFrete, vSeg, vDesc, vII, vIPI, decimal.Zero, vPIS, vCOFINS, vOutro, vTotTrib));
            }
            else
            {
                var icms = ICMSTot.First();

                icms.Atualizar(vBC, vICMS, vICMSDeson, vFCPUFDest, vICMSUFDest, vICMSUFRemet, vFCP, vBCST, vST, vFCPST, vFCPSTRet, vProd, vFrete, vSeg, vDesc, vII, vIPI, decimal.Zero, vPIS, vCOFINS, vOutro, vTotTrib);
            }
        }
        public void AdicionarICMSTot(ICMSTot icmsTot)
        {
            if (ICMSTot == null) ICMSTot = new List<ICMSTot>();

            ICMSTot.Add(icmsTot);
        }
        public void AdicionarISSQNtot(ISSQNtot issqntot)
        {
            if (ISSQNtot == null) ISSQNtot = new List<ISSQNtot>();

            ISSQNtot.Add(issqntot);
        }
        public void AdicionarRetTrib(RetTrib retTrib)
        {
            if (RetTrib == null) RetTrib = new List<RetTrib>();

            RetTrib.Add(retTrib);
        }
        public void AdicionarTransp(Transp transp)
        {
            if (Transps == null) Transps = new List<Transp>();

            Transps.Clear();

            Transps.Add(transp);
        }
        #endregion

        public void RegistrarEnvio(int? idRecepcao)
        {
            SysIdEnvio = idRecepcao;
        }
    }
}