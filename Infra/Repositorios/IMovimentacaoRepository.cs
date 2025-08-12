using ISync.Entidades.Movimentacao.Detalhe;
using ISync.Entidades.Movimentacao.Identificacao;


namespace ISync.Infra.Repositorios
{
    public interface IMovimentacaoRepository
    {
        Task<List<Ide>> ObterIdentificacoesAsync();

        Task<Ide?> ObterIdentificacaoPorIdAsync(int id);

        Task<List<Prod>> ObterProdutosAsync();

        Task<Prod?> ObterProdutoPorIdAsync(int id);

        Task AdicionarIdentificacaoAsync(Ide ide);

        Task AdicionarProdutoAsync(Prod produto);

        Task SalvarAsync();
    }
}
