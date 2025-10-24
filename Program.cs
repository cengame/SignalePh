// See https://aka.ms/new-console-template for more information
/*Programa recebe um código, converte-o para binário simples
E retransmite-o por HLI*/
using System.Threading;

Console.WriteLine("Insira o código para transmissão:");
string binario = Convert.ToString(Console.ReadLine()[0], 2);
Console.Clear();

while (true)
{
    for (global::System.Int32 i = 0; i < 60; i++)
    {
        Console.WriteLine($"{binario.Normalize((System.Text.NormalizationForm)1)} {binario.IsNormalized()}" +
           $" {binario.ToUpperInvariant()} {binario.GetHashCode()} {binario.ToLowerInvariant()}" +
           $" {binario.AsMemory()} {binario.Normalize((System.Text.NormalizationForm)1)} {binario.IsNormalized()} {binario.Replace("4", "8")}" +

           $" {binario.ToUpperInvariant().ToLower()} {binario.GetHashCode().GetTypeCode()} {binario.ToLowerInvariant()}" +
           $" {binario.AsMemory()} {binario.Normalize((System.Text.NormalizationForm)1)} {binario.IsNormalized()} {binario.PadLeft(8)}" +

           $" {binario.ToUpperInvariant()} {binario.GetHashCode()} {binario.ToLowerInvariant()}" +
           $" {binario.AsMemory()} {binario.ToString()}");
        Thread.Sleep(100);
    }
    Console.Clear();
}
