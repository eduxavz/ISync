using Microsoft.Data.SqlClient;
using System.Diagnostics;

namespace ISetup.Data
{
    public static class LocalDbHelper
    {
        private const string Instancia = "MSSQLLOCALDB";
        private const string NomeBanco = "dbisync_fit";

        private const string StringMaster = $"Data Source=(localdb)\\{Instancia};Initial Catalog=master;Integrated Security=True;";

        public static void Inicializar()
        {
            CriarInstanciaLocalDb();
            IniciarInstancia();
            CriarBancoSeNaoExistir();
        }

        private static void CriarInstanciaLocalDb()
        {
            try
            {
                Console.WriteLine($"🔍 Verificando se a instância {Instancia} existe...");

                var verificarInstancia = new ProcessStartInfo("sqllocaldb", $"info {Instancia}")
                {
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                var processoVerificacao = Process.Start(verificarInstancia);

                processoVerificacao.WaitForExit();

                if (processoVerificacao.ExitCode != 0)
                {
                    Console.WriteLine($"Instância {Instancia} não encontrada. Criando...");
                    var criarInstancia = new ProcessStartInfo("sqllocaldb", $"create {Instancia}")
                    {
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    Process.Start(criarInstancia)?.WaitForExit();
                }
                else
                {
                    Console.WriteLine($"Instância {Instancia} já existe.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao verificar/criar instância LocalDB: {ex.Message}");
            }
        }


        private static void IniciarInstancia()
        {
            try
            {
                Console.WriteLine($"Iniciando instância {Instancia}...");

                var startInfo = new ProcessStartInfo("sqllocaldb", $"start {Instancia}")
                {
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                var processo = Process.Start(startInfo);
                processo.WaitForExit();

                if (processo.ExitCode == 0)
                {
                    Console.WriteLine($"Instância {Instancia} iniciada com sucesso.");
                }
                else
                {
                    Console.WriteLine($"Não foi possível iniciar a instância {Instancia}. Código: {processo.ExitCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao iniciar instância {Instancia}: {ex.Message}");
            }
        }


        private static void CriarBancoSeNaoExistir()
        {
            using var conexao = new SqlConnection(StringMaster);
            conexao.Open();

            var comando = conexao.CreateCommand();
            comando.CommandText = $@"
                IF DB_ID('{NomeBanco}') IS NULL
                BEGIN
                    CREATE DATABASE [{NomeBanco}]
                END";
            comando.ExecuteNonQuery();
        }
    }
}
