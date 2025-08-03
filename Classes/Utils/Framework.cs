using ISync.Classes.Core.Enums;
using ISync.Classes.Core.Enums.Movimentacao;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ISync.Classes.Utils
{
    public static class Framework
    {
        public static int ObterNumeroCrt(EnumRegime regime)
        {
            return regime switch
            {
                EnumRegime.MEI => 4,
                EnumRegime.SimplesNacional => 1,
                EnumRegime.SimplesNacionalExcessoSublimite => 2,
                EnumRegime.RegimeNormalPresumido or EnumRegime.RegimeNormalReal => 3,
                EnumRegime.NaoSeAplica => 1,
                _ => 1,
            };
        }
        public static string ObterDescricaoMod(this EnumIdeMod mod)
        {
            return mod switch
            {
                EnumIdeMod.NFCe => "Nota Fiscal Consumidor",
                EnumIdeMod.ECF => "Cupom Fiscal",
                EnumIdeMod.Entrada => "Compra",
                EnumIdeMod.PedidoVenda => "Pedido de Venda",
                EnumIdeMod.PedidoCompra => "Pedido de Compra",
                EnumIdeMod.Troca => "Troca de Mercadoria",
                EnumIdeMod.VendaSimples => "Orçamento (PDV)",
                EnumIdeMod.NFe => "Nota Fiscal Eletrônica",
                EnumIdeMod.SAT => "SAT CFe",
                _ => throw new Exception("Modelo não tratado")
            };
        }
        public static string ObterReferenceAction(this EnumIdeMod mod, EnumTipoNFe tpNFe = EnumTipoNFe.Saida)
        {
            if (tpNFe == EnumTipoNFe.Entrada)
            {
                return "NFeEntradas";
            }

            return mod switch
            {
                EnumIdeMod.NFCe => "NFCes",
                EnumIdeMod.ECF => "Cupom Fiscal",
                EnumIdeMod.Entrada => "Entradas",
                EnumIdeMod.PedidoVenda => "PedidosVendas",
                EnumIdeMod.PedidoCompra => "PedidosCompras",
                EnumIdeMod.Troca => "Troca de Mercadoria",
                EnumIdeMod.VendaSimples => "Orcamentos",
                EnumIdeMod.NFe => "NFeSaidas",
                EnumIdeMod.SAT => "SATs",
                EnumIdeMod.InventarioEstoque => throw new NotImplementedException(),
                EnumIdeMod.InventarioEstoqueReembolso => throw new NotImplementedException(),
                EnumIdeMod.UsoConsumo => throw new NotImplementedException(),
                EnumIdeMod.Bonificacao => throw new NotImplementedException(),
                EnumIdeMod.Imobilizado => throw new NotImplementedException(),
                _ => throw new NotImplementedException()
            };
        }
        public static EnumTpAmb ObterTpAmb(this EnumIdeMod mod)
        {
            return mod switch
            {
                EnumIdeMod.NFe => EnumTpAmb.Producao,
                EnumIdeMod.NFCe => EnumTpAmb.Producao,
                EnumIdeMod.ECF => EnumTpAmb.Producao,
                EnumIdeMod.SAT => EnumTpAmb.Producao,
                EnumIdeMod.Entrada => EnumTpAmb.Producao,
                EnumIdeMod.PedidoVenda => EnumTpAmb.Homologacao,
                EnumIdeMod.PedidoCompra => EnumTpAmb.Homologacao,
                EnumIdeMod.Troca => EnumTpAmb.Homologacao,
                EnumIdeMod.VendaSimples => EnumTpAmb.Homologacao,
                EnumIdeMod.InventarioEstoqueReembolso => EnumTpAmb.Homologacao,
                EnumIdeMod.InventarioEstoque => EnumTpAmb.Homologacao,
                _ => throw new Exception("Modelo não tratado")
            };
        }
        public static string ObterDescricaoCommand(this string tipo)
        {
            return tipo switch
            {
                "AdicionarMovimentacaoCommand" => "Movimentação adicionada",
                "AdicionarPagamentoCommand" => "Pagamento adicionado",
                "AtualizarPagamentoCommand" => "Pagamento atualizado",
                "AdicionarPrePagamentoCommand" => "Pré-pagamento adicionado",
                "AdicionarProdCommand" => "Produto adicionado",
                "AtualizarProdCommand" => "Produto atualizado",
                "AtualizarDestCommand" => "Destinatário atualizado",
                "AtualizarDestReferenciaPessoaIdCommand" => "Destinatário atualizado",
                "AtualizarIdeCommand" => "Cabeçalho atualizado",
                "AtualizarIdeModeloCommand" => "Modelo da movimentação atualizado",
                "AtualizarNumeroSerieCommand" => "Número e série atualizado",
                "CancelarMovimentacaoCommand" => "Cancelar movimentação",
                "FinalizarMovimentacaoCommand" => "Confirmar movimentação",
                "AtualizarTransportadoraCommand" => "Transportadora atualizada",
                _ => "Sem tratamento"
            };
        }
        public static int ObterTpCadastro(this int tpCadastro)
        {
            return tpCadastro switch
            {
                0 => 10,
                1 => 20,
                2 => 30,
                3 => 40,
                4 => 50,
                _ => 10
            };
        }
        public static EnumTpCadastroDados ObterEnumTpCadastroDados(this int tpCadastro)
        {
            return tpCadastro switch
            {
                10 => EnumTpCadastroDados.Funcionario,
                20 => EnumTpCadastroDados.Vendedor,
                30 => EnumTpCadastroDados.Cliente,
                40 => EnumTpCadastroDados.Fornecedor,
                50 => EnumTpCadastroDados.Transportadora,
                _ => EnumTpCadastroDados.Cliente
            };
        }
        public static void Mapear<TDestino, TOrigem>(TDestino objetoDestino, TOrigem objetoOrigem)
            where TDestino : class
            where TOrigem : class
        {
            foreach (var attributo in objetoOrigem.GetType().GetProperties().Where(p => p.CanRead))
            {
                var propertyInfo = objetoDestino.GetType().GetProperty(attributo.Name, BindingFlags.Public | BindingFlags.Instance);

                if (propertyInfo != null && propertyInfo.CanWrite)
                {
                    propertyInfo.SetValue(objetoDestino, attributo.GetValue(objetoOrigem, null), null);
                }
            }
        }
    }
    public static class Reflexao
    {
        /// <summary>
        ///     Copia o valor das propriedades comuns entre dois objetos
        /// </summary>
        /// <typeparam name="TOrigem"></typeparam>
        /// <typeparam name="TDestino"></typeparam>
        /// <param name="objetoOrigem"></param>
        /// <param name="objetoDestino"></param>
        public static void CopiarPropriedades<TDestino, TOrigem>(this TDestino objetoDestino, TOrigem objetoOrigem) where TDestino : class where TOrigem : class
        {
            foreach (var attributo in objetoOrigem.GetType().GetProperties().Where(p => p.CanRead))
            {
                var propertyInfo = objetoDestino.GetType().GetProperty(attributo.Name, BindingFlags.Public | BindingFlags.Instance);
                if (propertyInfo != null && propertyInfo.CanWrite)
                    propertyInfo.SetValue(objetoDestino, attributo.GetValue(objetoOrigem, null), null);
            }
        }
    }
    public static class ValorExtensionsMethods
    {
        public static decimal Arredondar(this decimal valor, int casasDecimais)
        {
            var valorNovo = decimal.Round(valor, casasDecimais, MidpointRounding.AwayFromZero);
            var valorNovoStr = valorNovo.ToString("F" + casasDecimais, CultureInfo.CurrentCulture);
            return decimal.Parse(valorNovoStr);
        }

        public static decimal? Arredondar(this decimal? valor, int casasDecimais)
        {
            if (valor == null) return null;
            return Arredondar(valor.Value, casasDecimais);
        }

        public static decimal ArredondarParaBaixo(this decimal valor, int casasDecimais)
        {
            var divisor = (decimal)Math.Pow(10, casasDecimais);
            var dividendo = (long)Math.Truncate(divisor * valor);
            return dividendo / divisor;
        }
    }
    public static class DataExtensionMethods
    {
        public static string ParaDataString(this DateTimeOffset data)
        {
            return data == DateTimeOffset.MinValue ? null : data.ToString("yyyy-MM-dd");
        }

        public static string ParaDataString(this DateTime data)
        {
            return data == DateTime.MinValue ? null : data.ToString("yyyy-MM-dd");
        }
    }

}
