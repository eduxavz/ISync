using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace ISync.Core.Enums
{
    public enum EnumTpMod
    {
        /// <summary>
        /// 01 - Dinheiro
        /// </summary>
        [Description("Dinheiro")]
        [Display(Name = "Dinheiro")]
        Dinheiro = 01,

        /// <summary>
        /// 02 - Cheque
        /// </summary>
        [Description("Cheque")]
        [Display(Name = "Cheque")]
        Cheque = 02,

        /// <summary>
        /// 03 - Cartão de Crédito
        /// </summary>
        [Description("Cartão de Crédito")]
        [Display(Name = "Cartão de Crédito")]
        CartaoCredito = 03,

        /// <summary>
        /// 04 - Cartão de Débito
        /// </summary>
        [Description("Cartão de Débito")]
        [Display(Name = "Cartão de Débito")]
        CartaoDebito = 04,

        /// <summary>
        /// 05 - Crédito Loja
        /// </summary>
        [Description("Crédito Loja")]
        [Display(Name = "Crédito Loja")]
        CreditoLoja = 05,

        /// <summary>
        /// 10 - Vale Alimentação
        /// </summary>
        [Description("Vale Alimentação")]
        [Display(Name = "Vale Alimentação")]
        ValeAlimentacao = 10,

        /// <summary>
        /// 11 - Vale Refeição
        /// </summary>
        [Description("Vale Refeição")]
        [Display(Name = "Vale Refeição")]
        ValeRefeicao = 11,

        /// <summary>
        /// 12  -Vale Presente
        /// </summary>
        [Description("Vale Presente")]
        [Display(Name = "Vale Presente")]
        ValePresente = 12,

        /// <summary>
        /// 13 - Vale Combustível
        /// </summary>
        [Description("Vale Combustível")]
        [Display(Name = "Vale Combustível")]
        ValeCombustivel = 13,

        /// <summary>
        /// 14 - Duplicata Mercantil      
        /// <para>Na NT2016.002 (v1.50), foi excluída esta forma de pagamento na emissão de NFC-e (modelo 65), 
        /// porém para NFe (modelo 55) a SEFAZ, até o momento, ainda permite o seu uso.</para>
        /// <see langword="https://github.com/ZeusAutomacao/DFe.NET/issues/790"></see>
        /// </summary>
        [Description("Duplicata Mercantil")]
        [Display(Name = "Duplicata Mercantil")]
        DuplicataMercantil = 14,

        /// <summary>
        /// 15 - Boleto Bancário
        /// </summary>
        [Description("Boleto Bancário")]
        [Display(Name = "Boleto Bancário")]
        BoletoBancario = 15,

        /// <summary>
        /// 16 - Depósito Bancário
        /// </summary>
        [Description("Depósito Bancário")]
        [Display(Name = "Depósito Bancário")]
        DepositoBancario = 16,

        /// <summary>
        /// 17 - Pagamento Instantâneo (PIX)
        /// </summary>
        [Description("Pagamento Instantâneo (PIX)")]
        [Display(Name = "Pagamento Instantâneo (PIX)")]
        PagamentoInstantaneo = 17,
        /// <summary>
        /// 18 - Transferência bancária, Carteira Digital
        /// </summary>
        [Description("Transferência bancária, Carteira Digital")]
        [Display(Name = "Transferência bancária, Carteira Digital")]
        TransferenciaBancaria = 18,

        /// <summary>
        /// 19 - Programa de fidelidade, Cashback, Crédito Virtual
        /// </summary>
        [Description("Programa de fidelidade, Cashback, Crédito Virtual")]
        [Display(Name = "Programa de fidelidade, Cashback, Crédito Virtual")]
        ProgramaFidelidade = 19,

        /// <summary>
        /// 90 - Sem pagamento
        /// </summary>
        [Description("Sem pagamento")]
        [Display(Name = "Sem pagamento")]
        SemPagamento = 90,

        /// <summary>
        /// 99 - Outros
        /// </summary>
        [Description("Outros")]
        [Display(Name = "Outros")]
        Outro = 99
    }

    public enum EnumTpBandeira
    {
        /// <summary>
        /// >01 - Visa
        /// </summary>
        [Description("Visa")]
        [Display(Name = "Visa")]
        Visa = 01,

        /// <summary>
        /// 02 - Mastercard
        /// </summary>
        [Description("Mastercard")]
        [Display(Name = "Mastercard")]
        MasterCard = 02,

        /// <summary>
        /// 03 - American Express
        /// </summary>
        [Description("American Express")]
        [Display(Name = "American Express")]
        AmericanExpress = 03,

        /// <summary>
        /// 04 - Sorocred
        /// </summary>
        [Description("Sorocred")]
        [Display(Name = "Sorocred")]
        Sorocred = 04,

        /// <summary>
        /// 05 - Diners Club (versão 4.00)
        /// </summary>
        [Description("Diners Club")]
        [Display(Name = "Diners Club")]
        DinersClub = 05,

        /// <summary>
        /// 06 - Elo (versão 4.00)
        /// </summary>
        [Description("Elo")]
        [Display(Name = "Elo")]
        Elo = 06,

        /// <summary>
        /// 07 - Hipercard (versão 4.00)
        /// </summary>
        [Description("Hipercard")]
        [Display(Name = "Hipercard")]
        Hipercard = 07,

        /// <summary>
        /// 08 - Aura (versão 4.00)
        /// </summary>
        [Description("Aura")]
        [Display(Name = "Aura")]
        Aura = 08,

        /// <summary>
        /// 09 - Cabal (versão 4.00)
        /// </summary>
        [Description("Cabal")]
        [Display(Name = "Cabal")]
        Cabal = 09,

        /// <summary>
        /// 99 - Outros
        /// </summary>
        [Description("Outros")]
        [Display(Name = "Outros")]
        Outros = 99
    }

    public enum EnumTpTransacao
    {
        [Display(Name = "Normal")]
        Normal = 0,

        [Display(Name = "TEF")]
        TEF = 1,

        [Display(Name = "Fidelidade")]
        Fidelidade = 2,

        [Display(Name = "Mercado Pago")]
        MercadoPago = 3,

        [Display(Name = "S2Pay")]
        S2Pay = 4,

        [Display(Name = "Saurus Vale")]
        Vale = 5,

        [Display(Name = "Mamba")]
        Mamba = 6,

        [Display(Name = "PicPay")]
        PicPay = 7,

        [Display(Name = "GrynCash")]
        GrynCash = 8,

        [Display(Name = "My credit")]
        MyCredit = 9,

        [Display(Name = "Mercado Pago - PIX")]
        MercadoPagoPIX = 10
    }

    public enum EnumTpIntegracaoPagamento
    {
        /// <summary>
        /// 1 - Pagamento integrado com o sistema de automação da empresa(Ex.: equipamento TEF, Comércio Eletrônico)
        /// </summary>
        [Description("Pagamento integrado com o sistema de automação da empresa(Ex.: equipamento TEF, Comércio Eletrônico)")]
        [XmlEnum("1")]
        TipIntegradoAutomacao = 1,

        /// <summary>
        /// 2 - Pagamento não integrado com o sistema de automação da empresa(Ex.: equipamento POS)
        /// </summary>
        [Description("Pagamento não integrado com o sistema de automação da empresa(Ex.: equipamento POS)")]
        [XmlEnum("2")]
        TipNaoIntegrado = 2
    }


    public enum EnumTpPagamento
    {
        [Display(Name = "Ambos")]
        Ambos = 0,

        [Display(Name = "Conta a pagar")]
        Pagar = 1,

        [Display(Name = "Conta a receber")]
        Receber = 2,
    }

    public enum EnumIndicadorPagamentoDetalhePagamento
    {
        /// <summary>
        /// 0 – Pagamento à vista
        /// </summary>
        [Description("Pagamento à vista")]
        [XmlEnum("0")]
        DetPgVista = 0,

        /// <summary>
        /// 1 – Pagamento à prazo
        /// </summary>
        [Description("Pagamento à prazo")]
        [XmlEnum("1")]
        DetPgPrazo = 1,
    }

    public enum EnumStatusPagamento
    {
        /// <summary>
        /// 0 - Pagamento em andamento
        /// </summary>
        EmAndamento = 0,

        /// <summary>
        /// 100 - Pagamento confirmado
        /// </summary>
        Confirmado = 100,

        /// <summary>
        /// 200 - Pagamento estornado
        /// </summary>
        Estornado = 200,

        /// <summary>
        /// 900 - Ignorado pela aplicação
        /// </summary>
        Ignorado = 900
    }

    public enum EnumTpTransacaoSolicitado
    {
        /// <summary>
        /// 100 - Transacao de pagamento
        /// </summary>
        Pagamento = 100,

        /// <summary>
        /// 200 - Tranascao de estorno
        /// </summary>
        Estorno = 200
    }
}
