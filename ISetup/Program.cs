using ISetup.Data;

Console.WriteLine("🔧 Inicializando banco de dados...");

await BancoInitializer.InicializarBancoAsync(msg =>
{
    Console.WriteLine(msg);
});

Console.WriteLine("✅ Processo concluído.");

