
using ISync.Core.Contexto;
using Microsoft.EntityFrameworkCore;

namespace ISetup.Data
{
    public static class BancoInitializer
    {
        private const string LogPath = "log_erro_banco.txt";

        public static async Task InicializarBancoAsync(Action<string> log)
        {
            try
            {
                log("Verificando LocalDB...");
                LocalDbHelper.Inicializar();

                log("Aplicando migrations (Movimentação)...");
                using (var mov = new MovimentacaoContext())
                {
                    await mov.Database.MigrateAsync();
                    log("Movimentação OK");
                }

                log("Aplicando migrations (Cadastro)...");
                using (var cad = new CadastroContext())
                {
                    await cad.Database.MigrateAsync();
                    log("Cadastro OK");
                }

                log("Banco de dados inicializado com sucesso!");
            }
            catch (Exception ex)
            {
                var mensagem = $"[{DateTime.Now}] ERRO: {ex}\n";
                File.AppendAllText(LogPath, mensagem);
                log("Erro. Verifique o log:\n" + Path.GetFullPath(LogPath));
            }
        }
    }
}
