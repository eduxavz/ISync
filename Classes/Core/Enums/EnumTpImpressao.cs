
namespace ISync.Classes.Core.Enums
{
    public enum TipoImpressao
    {
        NFCE,
        VendaSimples,
        SAT,
        CancelamentoNFCE,
        CancelamentoSAT,
        CancelamentoVendaSimples,
        CancelamentoDigitacao,
        TicketConsumacao,
        Valores,
        Gaveta,
        Fidelidade,
        PagamentoFidelidade,
        QRCodePIX,
        Fechamento
    }

    public enum EnumEquipamentoImpressao
    {
        Principal,
        Secundario
    }
    public enum EnumModeloImpressao
    {
        Mini,
        Mini_UmaLinha,
        Mini_DuasLinhas,
        Mini_SemDet,
        Mini_SemCliente,
        Mini_SemEmitente,
        Mini_Orcamento
    }
}
