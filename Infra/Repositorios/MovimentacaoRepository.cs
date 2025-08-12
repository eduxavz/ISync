using ISync.Core.Contexto;
using ISync.Entidades.Movimentacao.Detalhe;
using ISync.Entidades.Movimentacao.Identificacao;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISync.Infra.Repositorios
{
    public class MovimentacaoRepository : IMovimentacaoRepository
    {
        private readonly MovimentacaoContext _context;

        public MovimentacaoRepository(MovimentacaoContext context)
        {
            _context = context;
        }

        public async Task<List<Ide>> ObterIdentificacoesAsync()
        {
            return await _context.MovIdes
                .Include(i => i.NFref)
                .ToListAsync();
        }

        public async Task<Ide?> ObterIdentificacaoPorIdAsync(int id)
        {
            return await _context.MovIdes
                .Include(i => i.NFref)
                .FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<List<Prod>> ObterProdutosAsync()
        {
            return await _context.MovProds.ToListAsync();
        }

        public async Task<Prod?> ObterProdutoPorIdAsync(int id)
        {
            return await _context.MovProds.FindAsync(id);
        }

        public async Task AdicionarIdentificacaoAsync(Ide ide)
        {
            await _context.MovIdes.AddAsync(ide);
        }

        public async Task AdicionarProdutoAsync(Prod produto)
        {
            await _context.MovProds.AddAsync(produto);
        }

        public async Task SalvarAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
