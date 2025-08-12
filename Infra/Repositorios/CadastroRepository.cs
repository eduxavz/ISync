using ISync.Core.Contexto;
using ISync.Entidades.Cadastros;
using ISync.Entidades.Cadastros.Parceiro;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISync.Infra.Repositorios
{
    public class CadastroRepository : ICadastroRepository
    {
        private readonly CadastroContext _context;

        public CadastroRepository(CadastroContext context)
        {
            _context = context;
        }

        // Parceiro
        public async Task<List<Parceiro>> ObterTodosParceirosAsync()
        {
            return await _context.CadastroDados.ToListAsync();
        }

        public async Task<Parceiro> ObterParceiroPorIdAsync(int id)
        {
            return await _context.CadastroDados.FindAsync(id);
        }

        public async Task AdicionarParceiroAsync(Parceiro parceiro)
        {
            await _context.CadastroDados.AddAsync(parceiro);
        }

        // Produto
        public async Task<List<ProdutoDado>> ObterTodosProdutosAsync()
        {
            return await _context.ProdutoDados.ToListAsync();
        }

        public async Task<ProdutoDado> ObterProdutoPorIdAsync(int id)
        {
            return await _context.ProdutoDados.FindAsync(id);
        }

        public async Task AdicionarProdutoAsync(ProdutoDado produto)
        {
            await _context.ProdutoDados.AddAsync(produto);
        }

        // Imposto
        public async Task<List<Imposto>> ObterTodosImpostosAsync()
        {
            return await _context.ProdutoImpostos.ToListAsync();
        }

        public async Task<Imposto> ObterImpostoPorIdAsync(int id)
        {
            return await _context.ProdutoImpostos.FindAsync(id);
        }

        public async Task AdicionarImpostoAsync(Imposto imposto)
        {
            await _context.ProdutoImpostos.AddAsync(imposto);
        }

        // Empresa
        public async Task<EmpresaDado> ObterEmpresaAsync()
        {
            return await _context.EmpresaDados.FirstOrDefaultAsync();
        }

        public Task AtualizarEmpresaAsync(EmpresaDado empresa)
        {
            _context.EmpresaDados.Update(empresa);
            return Task.CompletedTask;
        }

        // Natureza de operação
        public async Task<List<NaturezaOperacao>> ObterNaturezasOperacaoAsync()
        {
            return await _context.NaturezaOperacao.ToListAsync();
        }

        public async Task SalvarAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
