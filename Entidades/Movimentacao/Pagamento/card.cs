using ISync.Classes;
using ISync.Classes.Core.Enums;
using System;
using System.Text.Json.Serialization;

namespace ISync.Entidades.Movimentacao.Pagamento
{
    public class Card : Base
    {
        public int DetPagId { get; private set; }

        /// <summary>
        ///     YA04a - Tipo de Integração para pagamento
        /// </summary>
        public EnumTpIntegracaoPagamento? TpIntegra { get; private set; }

        /// <summary>
        ///     YA05 - CNPJ da Credenciadora de cartão de crédito e/ou débito
        /// </summary>
        public string CNPJ { get; private set; }

        /// <summary>
        ///     YA06 - Bandeira da operadora de cartão de crédito e/ou débito
        /// </summary>
        public EnumTpBandeira? TBand { get; private set; }

        /// <summary>
        ///     YA07 - Número de autorização da operação cartão de crédito e/ou débito
        /// </summary>
        public string CAut { get; private set; }

        /// <summary>
        /// Número de autorização NSU
        /// </summary>
        public string CNSU { get; private set; }

        /// <summary>
        /// Mensagem do operador retornado pela integração
        /// </summary>
        public string Mensagem { get; private set; }

        /// <summary>
        /// Via Consumidor
        /// </summary>
        public string ViaConsumidor { get; private set; }

        /// <summary>
        /// Via Estabelecimento
        /// </summary>
        public string ViaEstabelecimento { get; private set; }

        /// <summary>
        /// Número do cartão retornado pela aplicação
        /// </summary>
        public string NroCartao { get; private set; }

        /// <summary>
        /// Id de registro do retaguarda.
        /// </summary>
        public int? SysIdEnvio { get; private set; }

        //EF Relacional
        [JsonIgnore]
        public virtual DetPag DetPag { get; private set; }

        public Card(int id, int detPagId, EnumTpIntegracaoPagamento? tpIntegra, string cNPJ, EnumTpBandeira? tBand, string cAut, string cNSU, string mensagem, string viaConsumidor, string viaEstabelecimento, string nroCartao)
        {
            Id = id;
            DetPagId = detPagId;
            TpIntegra = tpIntegra;
            CNPJ = cNPJ;
            TBand = tBand;
            CAut = cAut;
            CNSU = cNSU;
            Mensagem = mensagem;
            ViaConsumidor = viaConsumidor;
            ViaEstabelecimento = viaEstabelecimento;
            NroCartao = nroCartao;
        }

        public void Atualizar(EnumTpIntegracaoPagamento? tpIntegra, string cNPJ, EnumTpBandeira? tBand, string cAut)
        {
            TpIntegra = tpIntegra;
            CNPJ = cNPJ;
            TBand = tBand;
            CAut = cAut;
        }

        public void RegistrarEnvio(int? idRecepcao)
        {
            SysIdEnvio = idRecepcao;
        }

        public void AtualizarCupomFidelidade(string cupom, string mensagem, string cAut)
        {
            ViaConsumidor = cupom;
            ViaEstabelecimento = cupom;
            Mensagem = mensagem;
            CAut = cAut;
        }
    }
}