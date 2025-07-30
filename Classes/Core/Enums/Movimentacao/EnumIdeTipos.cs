using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace ISync.Classes.Core.Enums.Movimentacao
{
    public enum EnumIdeStatus
    {
        [Description("Em digitação")]
        [Display(Name = "Em digitação")]
        EmDigitacao = 10,

        [Description("Pendente")]
        [Display(Name = "Pendente")]
        Pendente = 20,

        [Description("Finalizado")]
        [Display(Name = "Finalizado")]
        Finalizado = 30,

        [Description("Cancelado")]
        [Display(Name = "Cancelado")]
        Cancelado = 40
    }

    public enum EnumTpAmb
    {
        [XmlEnum("1")]
        [Description("Produção")]
        [Display(Name = "Produção")]
        Producao = 1,

        [XmlEnum("2")]
        [Description("Homologação")]
        [Display(Name = "Homologação")]
        Homologacao = 2
    }

    public enum EnumIdeMod
    {
        [Description("Venda simples")]
        [Display(Name = "Venda simples")]
        [XmlEnum("40")]
        VendaSimples = 40,

        [Description("Pedido venda")]
        [Display(Name = "Pedido venda")]
        [XmlEnum("11")]
        PedidoVenda = 11,

        [Description("NFe")]
        [Display(Name = "NFe")]
        [XmlEnum("55")]
        NFe = 55,

        [Description("SAT")]
        [Display(Name = "SAT")]
        [XmlEnum("59")]
        SAT = 59,

        [Description("ECF")]
        [Display(Name = "ECF")]
        [XmlEnum("60")]
        ECF = 60,

        [Description("NFCe")]
        [Display(Name = "NFCe")]
        [XmlEnum("65")]
        NFCe = 65,

        [Description("Entrada")]
        [Display(Name = "Entrada")]
        [XmlEnum("80")]
        Entrada = 80,

        [Description("Pedido compra")]
        [Display(Name = "Pedido compra")]
        [XmlEnum("81")]
        PedidoCompra = 81,

        [Description("Inventário estoque")]
        [Display(Name = "Inventário estoque")]
        [XmlEnum("82")]
        InventarioEstoque = 82,

        [Description("Inventário estoque com reembolso")]
        [Display(Name = "Inventário estoque com reembolso")]
        [XmlEnum("83")]
        InventarioEstoqueReembolso = 83,

        /// <summary>
        /// Estoque, Financeiro, PrecoMedio
        /// </summary>
        [Description("Uso e Consumo")]
        [Display(Name = "Uso e Consumo")]
        [XmlEnum("84")]
        UsoConsumo = 84,

        /// <summary>
        /// Estoque, PrecoMedio
        /// </summary>
        [Description("Bonificação")]
        [Display(Name = "Bonificação")]
        [XmlEnum("85")]
        Bonificacao = 85,

        /// <summary>
        /// Estoque, com categoria
        /// </summary>
        [Description("Imobilizado")]
        [Display(Name = "Imobilizado")]
        [XmlEnum("86")]
        Imobilizado = 86,

        [Description("Troca")]
        [Display(Name = "Troca de mercadoria")]
        [XmlEnum("90")]
        Troca = 90,
    }

    /// <summary>
    ///     Indicador da forma de pagamento
    ///     <para>0 – Pagamento à vista;</para>
    ///     <para>1 – Pagamento à prazo;</para>
    ///     <para>2 - Outros.</para>
    /// </summary>
    public enum EnumIndicadorPagamento
    {
        /// <summary>
        /// 0 – Pagamento à vista
        /// </summary>
        [Description("Pagamento à vista")]
        [Display(Name = "Pagamento à vista")]
        [XmlEnum("0")]
        Vista = 0,

        /// <summary>
        /// 1 – Pagamento à prazo
        /// </summary>
        [Description("Pagamento à prazo")]
        [Display(Name = "Pagamento à prazo")]
        [XmlEnum("1")]
        Prazo = 1,

        /// <summary>
        /// 2 - Outros
        /// </summary>
        [Description("Outros")]
        [Display(Name = "Outros")]
        [XmlEnum("2")]
        Outras = 2
    }



    /// <summary>
    ///     Tipo do Documento Fiscal
    ///     <para>0 - Entrada;</para>
    ///     <para>1 - Saída</para>
    /// </summary>
    public enum EnumTipoNFe
    {
        /// <summary>
        /// 0 - Entrada
        /// </summary>
        [Description("Entrada")]
        [Display(Name = "Entrada")]
        [XmlEnum("0")]
        Entrada = 0,

        /// <summary>
        /// 1 - Saída
        /// </summary>
        [Description("Saída")]
        [Display(Name = "Saída")]
        [XmlEnum("1")]
        Saida = 1
    }

    /// <summary>
    ///     Identificador de Local de destino da operação
    ///     <para>1 - Operação interna;</para>
    ///     <para>2 - Operação interestadual;</para>
    ///     <para>3 - Operação com exterior.</para>
    /// </summary>
    public enum EnumDestinoOperacao
    {
        /// <summary>
        /// 1 - Operação interna
        /// </summary>
        [Description("Operação interna")]
        [Display(Name = "Operação interna")]
        [XmlEnum("1")]
        Interna = 1,

        /// <summary>
        /// 2 - Operação interestadual
        /// </summary>
        [Description("Operação interestadual")]
        [Display(Name = "Operação interestadual")]
        [XmlEnum("2")]
        Interestadual = 2,

        /// <summary>
        /// 3 - Operação com exterior
        /// </summary>
        [Description("Operação com exterior")]
        [Display(Name = "Operação com exterior")]
        [XmlEnum("3")]
        Exterior = 3
    }

    /// <summary>
    ///     Formato de impressão do DANFE
    ///     <para>0 - Sem DANFE;</para>
    ///     <para>1 - DANFe Retrato;</para>
    ///     <para>2 - DANFe Paisagem;</para>
    ///     <para>3 - DANFe Simplificado;</para>
    ///     <para>4 - DANFe NFC-e;</para>
    ///     <para>5 - DANFe NFC-e em mensagem eletrônica</para>
    /// </summary>
    public enum EnumTipoImpressao
    {
        /// <summary>
        /// 0 - Sem DANFE
        /// </summary>
        [Description("Sem DANFE")]
        [Display(Name = "Sem DANFE")]
        [XmlEnum("0")]
        SemGeracao = 0,

        /// <summary>
        /// >1 - DANFe Retrato
        /// </summary>
        [Description("DANFe Retrato")]
        [Display(Name = "DANFe Retrato")]
        [XmlEnum("1")]
        Retrato = 1,

        /// <summary>
        /// 2 - DANFe Paisagem
        /// </summary>
        [Description("DANFe Paisagem")]
        [Display(Name = "DANFe Paisagem")]
        [XmlEnum("2")]
        Paisagem = 2,

        /// <summary>
        /// 3 - DANFe Simplificado
        /// </summary>
        [Description("DANFe Simplificado")]
        [Display(Name = "DANFe Simplificado")]
        [XmlEnum("3")]
        Simplificado = 3,

        /// <summary>
        /// 4 - DANFe NFC-e
        /// </summary>
        [Description("DANFe NFC-e")]
        [Display(Name = "DANFe NFC-e")]
        [XmlEnum("4")]
        NFCe = 4,

        /// <summary>
        /// 5 - DANFe NFC-e em mensagem eletrônica
        /// </summary>
        [Description("DANFe NFC-e em mensagem eletrônica")]
        [Display(Name = "DANFe NFC-e em mensagem eletrônica")]
        [XmlEnum("5")]
        MsgEletronica = 5
    }

    /// <summary>
    ///     Forma de emissão da NF-e
    ///     <para>1 - Emissão normal (não em contingência)</para>
    ///     <para>2 - Contingência FS-IA, com impressão do DANFE em formulário de segurança</para>
    ///     <para>3 - Contingência SCAN (Sistema de Contingência do Ambiente Nacional)</para>
    ///     <para>4 - Contingência DPEC (Declaração Prévia da Emissão em Contingência)</para>
    ///     <para>5 - Contingência FS-DA, com impressão do DANFE em formulário de segurança</para>
    ///     <para>6 - Contingência SVC-AN (SEFAZ Virtual de Contingência do AN)</para>
    ///     <para>7 - Contingência SVC-RS (SEFAZ Virtual de Contingência do RS)</para>
    ///     <para>9 - Contingência off-line da NFC-e</para>
    ///     <para>Nota: Para a NFC-e somente estão disponíveis e são válidas as opções de contingência 5 e 9</para>
    /// </summary>
    public enum EnumTipoEmissao
    {
        /// <summary>
        /// 1 - Emissão normal (não em contingência)
        /// </summary>
        [Description("Normal")]
        [Display(Name = "Normal")]
        [XmlEnum("1")]
        Normal = 1,

        /// <summary>
        /// 2 - Contingência FS-IA, com impressão do DANFE em formulário de segurança
        /// </summary>
        [Description("Contingência FS-IA")]
        [Display(Name = "Contingência FS-IA")]
        [XmlEnum("2")]
        FSIA = 2,

        /// <summary>
        /// 3 - Contingência SCAN (Sistema de Contingência do Ambiente Nacional)
        /// </summary>
        [Description("Contingência SCAN")]
        [Display(Name = "Contingência SCAN")]
        [XmlEnum("3")]
        SCAN = 3,

        /// <summary>
        /// 4 - Contingência DPEC (Declaração Prévia da Emissão em Contingência)
        /// </summary>
        [Description("Contingência DPEC")]
        [Display(Name = "Contingência DPEC")]
        [XmlEnum("4")]
        EPEC = 4,

        /// <summary>
        /// 5 - Contingência FS-DA, com impressão do DANFE em formulário de segurança
        /// </summary>
        [Description("Contingência FS-DA")]
        [Display(Name = "Contingência FS-DA")]
        [XmlEnum("5")]
        FSDA = 5,

        /// <summary>
        /// 6 - Contingência SVC-AN (SEFAZ Virtual de Contingência do AN)
        /// </summary>
        [Description("Contingência SVC-AN")]
        [Display(Name = "Contingência SVC-AN")]
        [XmlEnum("6")]
        SVCAN = 6,

        /// <summary>
        /// 7 - Contingência SVC-RS (SEFAZ Virtual de Contingência do RS)
        /// </summary>
        [Description("Contingência SVC-RS")]
        [Display(Name = "Contingência SVC-RS")]
        [XmlEnum("7")]
        SVCRS = 7,

        /// <summary>
        /// 9 - Contingência off-line da NFC-e
        /// </summary>
        [Description("Contingência off-line")]
        [Display(Name = "Contingência off-line")]
        [XmlEnum("9")]
        OffLine = 9
    }

    /// <summary>
    ///     Finalidade da emissão da NF-e
    ///     <para>1 - NFe normal</para>
    ///     <para>2 - NFe complementar</para>
    ///     <para>3 - NFe de ajuste</para>
    ///     <para>4 - Devolução de mercadoria</para>
    /// </summary>
    public enum EnumFinalidadeNFe
    {
        /// <summary>
        /// 1 - NFe normal
        /// </summary>
        [Description("NFe normal")]
        [Display(Name = "NFe normal")]
        [XmlEnum("1")]
        Normal = 1,

        /// <summary>
        /// 2 - NFe complementar
        /// </summary>
        [Description("NFe complementar")]
        [Display(Name = "NFe complementar")]
        [XmlEnum("2")]
        Complementar = 2,

        /// <summary>
        /// 3 - NFe de ajuste
        /// </summary>
        [Description("NFe de ajuste")]
        [Display(Name = "NFe de ajuste")]
        [XmlEnum("3")]
        Ajuste = 3,

        /// <summary>
        /// 4 - Devolução de mercadoria
        /// </summary>
        [Description("Devolução de mercadoria")]
        [Display(Name = "Devolução de mercadoria")]
        [XmlEnum("4")]
        Devolucao = 4
    }

    /// <summary>
    ///     Processo de emissão utilizado com a seguinte codificação:
    ///     <para>0 - Emissão de NF-e com aplicativo do contribuinte;</para>
    ///     <para>1 - Emissão de NF-e avulsa pelo Fisco;</para>
    ///     <para>2 - Emissão de NF-e avulsa, pelo contribuinte com seu certificado digital, através do site do Fisco;</para>
    ///     <para>3 - Emissão de NF-e pelo contribuinte com aplicativo fornecido pelo Fisco.</para>
    /// </summary>
    public enum EnumProcessoEmissao
    {
        /// <summary>
        /// 0 - Emissão de NF-e com aplicativo do contribuinte
        /// </summary>
        [Description("Emissão de NF-e com aplicativo do contribuinte")]
        [Display(Name = "Emissão de NF-e com aplicativo do contribuinte")]
        [XmlEnum("0")]
        AplicativoContribuinte = 0,

        /// <summary>
        /// 1 - Emissão de NF-e avulsa pelo Fisco
        /// </summary>
        [Description("Emissão de NF-e avulsa pelo Fisco")]
        [Display(Name = "Emissão de NF-e avulsa pelo Fisco")]
        [XmlEnum("1")]
        AvulsaFisco = 1,

        /// <summary>
        /// 2 - Emissão de NF-e avulsa, pelo contribuinte com seu certificado digital, através do site do Fisco
        /// </summary>
        [Description("Emissão de NF-e avulsa, pelo contribuinte com seu certificado digital, através do site do Fisco")]
        [Display(Name = "Emissão de NF-e avulsa, pelo contribuinte com seu certificado digital, através do site do Fisco")]
        [XmlEnum("2")]
        AvulsaContribuinte = 2,

        /// <summary>
        /// 3 - Emissão de NF-e pelo contribuinte com aplicativo fornecido pelo Fisco
        /// </summary>
        [Description("Emissão de NF-e pelo contribuinte com aplicativo fornecido pelo Fisco")]
        [Display(Name = "Emissão de NF-e pelo contribuinte com aplicativo fornecido pelo Fisco")]
        [XmlEnum("3")]
        ContribuinteAplicativoFisco = 3
    }

    /// <summary>
    ///     Indica operação com Consumidor final
    ///     <para>0 - Normal;</para>
    ///     <para>1 - Consumidor final;</para>
    /// </summary>
    public enum EnumConsumidorFinal
    {
        /// <summary>
        /// 0 - Normal
        /// </summary>
        [Description("Normal")]
        [Display(Name = "Normal")]
        [XmlEnum("0")]
        Nao = 0,

        /// <summary>
        /// 1 - Consumidor final
        /// </summary>
        [Description("Consumidor final")]
        [Display(Name = "Consumidor final")]
        [XmlEnum("1")]
        ConsumidorFinal = 1
    }

    /// <summary>
    ///     Indicador de presença do comprador no estabelecimento comercial no momento da operação
    ///     <para>0 - Não se aplica</para>
    ///     <para>1 - Operação presencial;</para>
    ///     <para>2 - Operação não presencial, pela Internet;</para>
    ///     <para>3 - Operação não presencial, Teleatendimento;</para>
    ///     <para>4 - NFC-e em operação com entrega a domicílio;</para>
    ///     <para>5 - Operação presencial, fora do estabelecimento;</para>
    ///     <para>9 - Operação não presencial, outros.</para>
    /// </summary>
    public enum EnumPresencaComprador
    {
        /// <summary>
        /// 0 - Não se aplica
        /// </summary>
        [Description("Não se aplica")]
        [Display(Name = "Não se aplica")]
        [XmlEnum("0")]
        Nao = 0,

        /// <summary>
        /// 1 - Operação presencial
        /// </summary>
        [Description("Operação presencial")]
        [Display(Name = "Operação presencial")]
        [XmlEnum("1")]
        Presencial = 1,

        /// <summary>
        /// 2 - Operação não presencial, pela Internet
        /// </summary>
        [Description("Operação não presencial, pela Internet")]
        [Display(Name = "Operação não presencial, pela Internet")]
        [XmlEnum("2")]
        Internet = 2,

        /// <summary>
        /// 3 - Operação não presencial, Teleatendimento
        /// </summary>
        [Description("Operação não presencial, Teleatendimento")]
        [Display(Name = "Operação não presencial, Teleatendimento")]
        [XmlEnum("3")]
        Teleatendimento = 3,

        /// <summary>
        /// 4 - NFC-e em operação com entrega a domicílio
        /// </summary>
        [Description("NFC-e em operação com entrega a domicílio")]
        [Display(Name = "NFC-e em operação com entrega a domicílio")]
        [XmlEnum("4")]
        EntregaDomicilio = 4,

        /// <summary>
        /// 5 - Operação presencial, fora do estabelecimento
        /// </summary>
        [Description("Operação presencial, fora do estabelecimento")]
        [Display(Name = "Operação presencial, fora do estabelecimento")]
        [XmlEnum("5")]
        PresencialForaEstabelecimento = 5,

        /// <summary>
        /// 9 - Operação não presencial, outros
        /// </summary>
        [Description("Operação não presencial, outros")]
        [Display(Name = "Operação não presencial, outros")]
        [XmlEnum("9")]
        Outros = 9
    }

    /// <summary>
    ///     Indicador de intermediador/marketplace
    ///     <para>0 - Operação sem intermediador (em site ou plataforma própria)</para>
    ///     <para>1 - Operação em site ou plataforma de terceiros (intermediadores / marketplace)</para>
    /// </summary>
    public enum EnumIndicadorIntermediador
    {
        /// <summary>
        /// 0 - Operação sem intermediador (em site ou plataforma própria)
        /// </summary>
        [Description("Operação sem intermediador (em site ou plataforma própria)")]
        [Display(Name = "Operação sem intermediador (em site ou plataforma própria)")]
        [XmlEnum("0")]
        SemIntermediador = 0,

        /// <summary>
        ///  1 - Operação em site ou plataforma de terceiros (intermediadores / marketplace)
        /// </summary>
        [Description("Operação em site ou plataforma de terceiros (intermediadores / marketplace)")]
        [Display(Name = "Operação em site ou plataforma de terceiros (intermediadores / marketplace)")]
        [XmlEnum("1")]
        SitePlataformaTerceiros = 1
    }

    /// <summary>
    ///     Indicador do tipo de Operação do CSC
    ///     <para>1 - Consulta CSC Ativos;</para>
    ///     <para>2 - Solicita novo CSC;</para>
    ///     <para>3 - Revoga CSC Ativo</para>
    /// </summary>
    public enum EnumIdentificadorOperacaoCsc
    {
        /// <summary>
        /// 1 - Consulta CSC Ativos
        /// </summary>
        [Description("Consulta CSC Ativos")]
        [Display(Name = "Consulta CSC Ativos")]
        [XmlEnum("1")]
        ConsultaCscAtivos = 1,

        /// <summary>
        /// 2 - Solicita novo CSC
        /// </summary>
        [Description("Solicita novo CSC")]
        [Display(Name = "Solicita novo CSC")]
        [XmlEnum("2")]
        SolicitaNovoCsc = 2,

        /// <summary>
        /// 3 - Revoga CSC Ativo
        /// </summary>
        [Description("Revoga CSC Ativo")]
        [Display(Name = "Revoga CSC Ativo")]
        [XmlEnum("3")]
        RevogaCscAtivo = 3
    }

    /// <summary>
    ///     Modelo do Documento Fiscal
    ///     <para>01 - Modelo 01</para>
    ///     <para>02 - Modelo 02</para>
    /// </summary>
    public enum refMod
    {
        /// <summary>
        /// 01 - Modelo 01
        /// </summary>
        [Description("Modelo 01")]
        [Display(Name = "Modelo 01")]
        [XmlEnum("01")]
        modelo = 1,

        /// <summary>
        /// 02 - Modelo 02
        /// </summary>
        [Description("Modelo 02")]
        [Display(Name = "Modelo 02")]
        [XmlEnum("02")]
        modelo2 = 2
    }
}

