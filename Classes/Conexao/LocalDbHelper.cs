using Microsoft.Data.SqlClient;
using System.Diagnostics;

public static class LocalDbHelper
{
    private const string Instancia = "ISyncBD";
    private const string NomeBanco = "db_isync";
    private const string StringMaster = $"Server=(localdb)\\{Instancia};Integrated Security=true;Database=master;";
    private const string StringFinal = $"Server=(localdb)\\{Instancia};Integrated Security=true;Database={NomeBanco};";

    public static void Inicializar()
    {
        CriarInstanciaLocalDb();
        IniciarInstancia();
        CriarBancoSeNaoExistir();
    }

    private static void CriarInstanciaLocalDb()
    {
        var psi = new ProcessStartInfo("sqllocaldb", $"create {Instancia}")
        {
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        try { Process.Start(psi)?.WaitForExit(); }
        catch { /* ignora se já existir */ }
    }

    private static void IniciarInstancia()
    {
        var psi = new ProcessStartInfo("sqllocaldb", $"start {Instancia}")
        {
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        Process.Start(psi)?.WaitForExit();
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

    public static SqlConnection ObterConexao()
    {
        var conexao = new SqlConnection(StringFinal);
        conexao.Open();
        return conexao;
    }
}
