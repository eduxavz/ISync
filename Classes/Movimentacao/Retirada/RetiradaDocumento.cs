
using ISync.Classes.Core.Enums;
using System;

namespace ISync.Classes.Movimentacao.Movimentacao.Retirada
{
    public class RetiradaDocumento : Base
    {
        public int ContratoId { get; private set; }
        public int EmpresaId { get; private set; }
        public string Mod { get; private set; }
        public string Tipo { get; private set; }
        public DateTime? DInicial { get; private set; }
        public DateTime? DFinal { get; private set; }
        public int QArquivos { get; private set; }
        public EnumStatusRetirada Status { get; private set; }
        public string Url { get; private set; }
        public long? Tamanho { get; private set; }

        public RetiradaDocumento(int id, int contratoId, int empresaId, string mod, string tipo, DateTime? dInicial, DateTime? dFinal, int qArquivos, EnumStatusRetirada status)
        {
            Id = id;
            ContratoId = contratoId;
            EmpresaId = empresaId;
            Mod = mod;
            Tipo = tipo;
            DInicial = dInicial;
            DFinal = dFinal;
            QArquivos = qArquivos;
            Status = status;
            Url = string.Empty;
            Tamanho = null;
        }

        public void Concluido() => Status = EnumStatusRetirada.Concluido;
        public bool Disponivel() => Status == EnumStatusRetirada.Concluido;
        public void Atualizar(int qArquivos, string url, long tamanho)
        {
            QArquivos = qArquivos;
            Url = url;
            Tamanho = tamanho;
        }
    }
}
