using ISync.Classes;
using ISync.Classes.Core.Enums;
using ISync.Classes.Core.Enums.Movimentacao;
using ISync.Classes.Core.Utils;
using System;
using System.Xml.Serialization;

namespace ISync.Entidades.Cadastros.Parceiro
{
        public class Parceiro : Base
    {
 
        public int? EmpresaId { get; private set; }
        public EnumTpCadastroDados TpCadastro { get; private set; }
        public string CPFCNPJ { get; private set; }
        public string IERG { get; private set; }
        public string IM { get; private set; }
        public string Nome { get; private set; }
        public string Fantasia { get; private set; }
        public DateTime? DNasc { get; private set; }
        public string InfInterno { get; private set; }
        public string InfOperador { get; private set; }
        public EnumIndIEDest IndIEDest { get; private set; }
        public EnumStatusCadastro Status { get; private set; }
        public decimal? Limite { get; private set; }
        public decimal? Saldo { get; private set; }

        //EF 
        public virtual ICollection<ParceiroEndereco> Enderecos { get; private set; }


        protected Parceiro() { }

        public Parceiro(int id, int? empresaId, EnumTpCadastroDados tpCadastro, string cPFCNPJ, string iERG, string iM, string nome, string fantasia, DateTime? dNasc, string infInterno, string infOperador, EnumIndIEDest indIEDest, EnumStatusCadastro status, decimal? limite)
        {
            Id = id;
            EmpresaId = empresaId;
            TpCadastro = tpCadastro;
            CPFCNPJ = cPFCNPJ;
            IERG = iERG;
            IM = iM;
            Nome = nome;
            Fantasia = fantasia;
            DNasc = dNasc;
            InfInterno = infInterno;
            InfOperador = infOperador;
            IndIEDest = indIEDest;
            Status = status;
            Limite = limite;
            Saldo = limite;
        }

        public void Atualizar(int? empresaId, EnumTpCadastroDados tpCadastro, string cPFCNPJ, string iERG, string iM, string nome, string fantasia, DateTime? dNasc, string infInterno, string infOperador, EnumIndIEDest indIEDest, EnumStatusCadastro status)
        {
            EmpresaId = empresaId;
            TpCadastro = tpCadastro;
            CPFCNPJ = cPFCNPJ;
            IERG = iERG;
            IM = iM;
            Nome = nome;
            Fantasia = fantasia;
            DNasc = dNasc;
            InfInterno = infInterno;
            InfOperador = infOperador;
            IndIEDest = indIEDest;
            Status = status;
        }
        public void AdicionarEndereco(ParceiroEndereco endereco)
        {
            Enderecos ??= [];

            Enderecos.Add(endereco);
        }
        public void RemoverEndereco(ParceiroEndereco endereco)
        {
            Enderecos.Remove(endereco);
        }

        public void AtualizarLimite(decimal? limite)
        {
            if (limite.HasValue)
            {
                var saldoConsumidoAnterior = Limite.InfotechToDecimal() - Saldo;

                Limite = limite;
                Saldo = Limite - saldoConsumidoAnterior;
            }
            else
            {
                if (Saldo.HasValue)
                {
                    if (Limite > 0)
                    {
                        Saldo = Limite - Saldo;
                    }

                    Limite = limite;
                }
            }
        }
        public void Debitar(decimal debito)
        {
            Limite ??= decimal.Zero;
            Saldo ??= Limite;

            Saldo -= debito;

            if (Saldo < Decimal.Zero) Saldo = Decimal.Zero;
        }
        public void Creditar(decimal credito)
        {
            Limite ??= decimal.Zero;
            Saldo ??= Limite;

            Saldo += credito;

            if (Saldo > Limite) Saldo = Limite;
        }
    }
}
