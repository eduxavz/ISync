using System.ComponentModel;

namespace ISync.Classes.Core.Enums.Movimentacao
{
    public enum EnumLevelStatus
    {
        Erro = 10,
        Documentacao = 20,
        Rejeicao = 30,

        //Autorizacao
        AutorizacaoUrl = 100,
        AutorizacaoDigestValue = 101,
        AutorizacaoMensagem = 102,
        AutorizacaoProtocolo = 103,
        AutorizacaoArquivo = 104,
        AutorizacaoQrCode = 105,
        AutorizacaoUrlChave = 106,
        AutorizacaoDhRecbto = 107,

        //Cancelamento
        CancelamentoUrl = 200,
        CancelamentoMensagem = 201,
        CancelamentoProtocolo = 202,
        CancelamentoArquivo = 203,
        CancelamentoDhRecbto = 204,
        CancelamentoMensagemOperador = 205
    }

    public enum MovimentacaoStatus
    {

        /// <summary>
        /// STATUS MOV NFCE
        /// </summary>
        [Description("NFC-e em Digitacao")]
        NFCeEmDigitacao = 2010,
        [Description("Em Contingencia")]
        NFCeEmContingencia = 2020,
        [Description("Solicitando Autorizacao")]
        NFCeSolicitandoAutorizacao = 2021,
        [Description("NFC-e Transmitida")]
        NFCeTransmitida = 2022,
        [Description("Arquivo Assinado")]
        NFCeArquivoAssinado = 2023,
        [Description("Verificando Situacao")]
        NFCeVerificandoSituacao = 2031,
        [Description("NFC-e Autorizada")]
        NFCeAutorizada = 2032,
        [Description("NFC-e Rejeitada")]
        NFCeRejeitada = 2033,
        [Description("NFC-e Denegada")]
        NFCeDenegada = 2034,
        [Description("Contingência Autorizada")]
        ContingenciaAutorizada = 2035,
        [Description("Contingência Rejeitada")]
        ContingenciaRejeitada = 2036,
        [Description("Contingência Manual Autorizada")]
        ContingenciaManualAutorizada = 2037,
        [Description("Solicitando Cancelamento")]
        SolicitandoCancelamento = 2040,
        [Description("NFC-e Cancelada")]
        NFCCancelada = 2041,
        [Description("Cancelamento em Contingência")]
        CancelamentoEmContingencia = 2042,
        [Description("NFC-e Cancelamento Rejeitado")]
        NFCCancelamentoRejeitado = 2043,
        [Description("Cancelamento Contingência Rejeitada")]
        CancelamentoContingenciaRejeitada = 2044,
        [Description("Solicitando Inutilização")]
        SolicitandoInutilizacao = 2051,
        [Description("NFC-e Inutilizada")]
        NFCInutilizada = 2052,
        [Description("Inutilização em Contingência")]
        InutilizacaoEmContingencia = 2053,
        [Description("CCe Transmitido")]
        CCeTransmitido = 2060,
        [Description("CCe Registrada")]
        CCeRegistrada = 2061,
        [Description("CCe Negada")]
        CCeNegada = 2062,
        [Description("CCe Erro")]
        CCeErro = 2063,
        [Description("CCe Duplicidade")]
        CCeDuplicidade = 2064,
        [Description("Documentação")]
        Documentacao = 2098,
        [Description("Erro (Bloqueado)")]
        ErroBloqueado = 2099,

        /// <summary>
        /// STATUS MOV ORCAMENTOS 
        /// </summary>
        /// 
        [Description("Venda em Digitacao")]
        VendaEmAberto = 4010,
        [Description("Venda Aprovada")]
        VendaAprovada = 4011,
        [Description("Venda Cancelada")]
        VendaCancelada = 4012,

        /// <summary>
        /// STATUS MOV PEDIDOS 
        /// </summary>
        /// 
        [Description("Conferencia")]
        Conferencia = 4013,
        [Description("Em Conferencia")]
        EmConferencia = 4021,
        [Description("Aguardando Material")]
        AguardandoMaterial = 4022,
        [Description("Disponível para Emissao Fiscal")]
        DisponivelParaEmissaoFiscal = 4023,
        [Description("Em Transporte")]
        EmTransporte = 4024,
        [Description("Entregue")]
        Entregue = 4025,

        /// <summary>
        /// STATUS MOV SAT 
        /// </summary>
        /// 
        [Description("Venda Sat em Digitacao")]
        SatEmDigitacao = 7010,
        [Description("Solicitando Autorizacao")]
        SatSolicitandoAutorizacao = 7021,
        [Description("Comunicando com SAT")]
        ComunicandoComSAT = 7031,
        [Description("SAT CF-e Autorizado")]
        SATCFeAutorizado = 7032,
        [Description("SAT CF-e Rejeitado")]
        SATCFeRejeitado = 7033,
        [Description("Solicitando Cancelamento")]
        SATCFeSolicitandoCancelamento = 7040,
        [Description("SAT CF-e Cancelado")]
        SATCFeCancelado = 7041,
        [Description("SAT CF-e Ignorado")]
        SATCFeIgnorado = 7042,
        [Description("Consultando Sessao")]
        SATCFeConsultandoSessao = 7050,
        [Description("Cupom Inconsistente")]
        CupomInconsistente = 7096,
        [Description("Reimprimindo")]
        Reimprimindo = 7097,
    }

}
