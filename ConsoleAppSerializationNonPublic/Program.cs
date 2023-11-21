using System.Runtime.InteropServices;
using System.Text.Json;
using ConsoleAppSerializationNonPublic.Models;

Console.WriteLine("***** Testes com .NET 8 | Serializacao de membros nao-publicos *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName} - Kernel: {Environment
    .OSVersion.VersionString}");

var coordenadasSerializadas = new List<string>();
var coordenadasIniciais = new Coordenada3D[] { new(3, 0, 5), new(-5, -5, 7) };

Console.WriteLine();
Console.WriteLine("**** Iniciando serializacao...");
foreach (var coordenada in coordenadasIniciais)
{
    Console.WriteLine();
    coordenada.Show();
    var json = JsonSerializer.Serialize(coordenada);
    coordenadasSerializadas.Add(json);
    Console.WriteLine($"Resultado da serializacao: {json}");
}

Console.WriteLine();
Console.WriteLine("**** Iniciando desserializacao...");
foreach (var json in coordenadasSerializadas)
{
    Console.WriteLine();
    Console.WriteLine($"String para desserializacao: {json}");
    var coordenada = JsonSerializer.Deserialize<Coordenada3D>(json)!;
    coordenada.Show();
}