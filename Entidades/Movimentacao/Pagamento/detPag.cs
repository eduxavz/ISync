using ISync.Classes.Core.Enums;
using ISync.Classes.Core.Utils;
using ISync.Entidades.Movimentacao.Identificacao;
using System;
using System.Text.Json.Serialization;

namespace ISync.Entidades.Movimentacao.Pagamento
{
    public class DetPag : Base
    {
        /// <summary>
        /// Relacionamento Ide
        /// </summary>
        public int? IdeId { get; private set; }

        /// <summary>
        /// Status do pagamento
        /// </summary>
        public EnumStatusPagamento Status { get; private set; }

        /// <summary>
        /// Tipo de transacao solicitado
        /// </summary>
        public EnumTpTransacaoSolicitado TpSolicitado { get; private set; }

        /// <summary>
        /// YA09 - Valor do troco
        /// Versão 4.00
        /// </summary>
        public decimal? VTroco { get; private set; }

        public EnumIndicadorPagamentoDetalhePagamento? IndPag { get; private set; }

        /// <summary>
        /// YA02 - Forma de pagamento
        /// </summary>
        public EnumTpMod TPag { get; private set; }

        /// <summary>
        /// Valor pago
        /// </summary>
        public decimal VPag { get; private set; }

        /// <summary>
        /// Valor de desconto
        /// </summary>
        public decimal? VDesc { get; private set; }

        /// <summary>
        /// Outros valores, como acréscimo
        /// </summary>
        public decimal? VOutro { get; private set; }

        /// <summary>
        /// Tipo da transação
        /// </summary>
        public EnumTpTransacao TpTransacao { get; private set; }

        /// <summary>
        /// Id da forma de pagamento
        /// </summary>
        public int PagamentoId { get; private set; }

        /// <summary>
        /// Descricao da forma de pagamento
        /// </summary>
        public string Descricao { get; private set; }

        /// <summary>
        /// Pagamento cancelado
        /// </summary>
        public bool Cancelado { get; private set; }

        /// <summary>
        /// Data de vencimento do pagamento
        /// </summary>
        public DateTime? DVenc { get; private set; }

        //EF Relacionamento
        [JsonIgnore]
        public virtual Ide Ide { get; private set; }

        public virtual Card Card { get; private set; }


        protected DetPag() { }

        public DetPag(int id, int? ideId, EnumStatusPagamento status, EnumTpTransacaoSolicitado tpSolicitado, EnumIndicadorPagamentoDetalhePagamento? indPag, EnumTpMod tPag, decimal vPag, decimal? vTroco, decimal? vDesc, decimal? vOutro, EnumTpTransacao tpTransacao, int pagamentoId, string descricao, bool cancelado, DateTime? dVenc, DateTime sysDUpdate)
        {
            Id = id;
            IdeId = ideId;
            Status = status;
            TpSolicitado = tpSolicitado;
            IndPag = indPag;
            TPag = tPag;
            VPag = vPag;
            VTroco = vTroco;
            VDesc = vDesc;
            VOutro = vOutro;
            TpTransacao = tpTransacao;
            PagamentoId = pagamentoId;
            Descricao = descricao;
            Cancelado = cancelado;
            DVenc = dVenc;

            //if (VPag - VTroco.InfotechToDecimal() < decimal.Zero)
            //{
            //    VPag = vPag + vTroco.InfotechToDecimal();
            //    VTroco = vTroco;
            //}

            //if (VPag - VTroco.InfotechToDecimal() < decimal.Zero) throw new Exception("O valor do pagamento não pode ser menor que R$ 0,00 (zero)");

            SysDInsert = sysDUpdate;
            SysDUpdate = sysDUpdate;
        }

        public void VincularIde(Ide ide) => Ide = ide;

        public void VincularIdeId(int ideId) => IdeId = ideId;

        public void Atualizar(EnumIndicadorPagamentoDetalhePagamento? indPag, EnumTpMod tPag, decimal vPag, decimal? vTroco, EnumTpTransacao tpTransacao, int pagamentoId, string descricao, bool cancelado, DateTime? dVenc)
        {
            IndPag = indPag;
            TPag = tPag;
            VPag = vPag;
            VTroco = vTroco;
            TpTransacao = tpTransacao;
            PagamentoId = pagamentoId;
            Descricao = descricao;
            Cancelado = cancelado;
            DVenc = dVenc;

            if (VPag - VTroco.InfotechToDecimal() < decimal.Zero) throw new Exception("O valor do pagamento não pode ser menor que R$ 0,00 (zero)");
        }

        public void AtualizarIndicador(EnumIndicadorPagamentoDetalhePagamento indicador)
        {
            IndPag = indicador;
        }

        public void Cancelar()
        {
            Cancelado = true;
            Status = EnumStatusPagamento.Ignorado;
        }

        public void Estornar()
        {
            Cancelado = true;
            Status = EnumStatusPagamento.Estornado;
        }

        public void Confirmar()
        {
            if (Cancelado) throw new Exception("Esse pagamento já foi cancelado");
            Status = EnumStatusPagamento.Confirmado;
        }

        public void AdicionarCard(Card card)
        {
            Card = card;
        }
        public void AtualizarDVenc(DateTime? dVenc) => DVenc = dVenc;
    }
}