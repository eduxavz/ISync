using ISync.Entidades.Cadastros;
using ISync.Entidades.Cadastros.Parceiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISync.Infra.Repositorios
{
    public interface ICadastroRepository
    {
        // Parceiro
        Task<List<Parceiro>> ObterTodosParceirosAsync();
        Task<Parceiro> ObterParceiroPorIdAsync(int id);
        Task AdicionarParceiroAsync(Parceiro parceiro);

        // Produto
        Task<List<ProdutoDado>> ObterTodosProdutosAsync();
        Task<ProdutoDado> ObterProdutoPorIdAsync(int id);
        Task AdicionarProdutoAsync(ProdutoDado produto);

        // Imposto
        Task<List<Imposto>> ObterTodosImpostosAsync();
        Task<Imposto> ObterImpostoPorIdAsync(int id);
        Task AdicionarImpostoAsync(Imposto imposto);

        // Empresa
        Task<EmpresaDado> ObterEmpresaAsync();
        Task AtualizarEmpresaAsync(EmpresaDado empresa);

        // Natureza de Operação
        Task<List<NaturezaOperacao>> ObterNaturezasOperacaoAsync();

        Task SalvarAsync();
    }
}
