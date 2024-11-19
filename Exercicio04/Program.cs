using Exercicio04;
using System;
using System.Globalization;


ContaBancaria conta;

Console.Write("Entre o número da conta: \n");
int numero = int.Parse(Console.ReadLine());
Console.Write("Entre o titular da conta: \n");
string titular = Console.ReadLine();
Console.Write("Haverá depósito inicial (s/n)? \n");
char resp = char.Parse(Console.ReadLine());
if (resp == 's' || resp == 'S')
{
    Console.Write("Entre um valor de depósito inicial: \n" );
    double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    conta = new ContaBancaria(numero, titular, depositoInicial );
}
else
{
    conta = new ContaBancaria(numero, titular);
}
Console.WriteLine();
Console.WriteLine("Dados da conta: ");
Console.WriteLine(conta);

Console.WriteLine();
Console.Write("Entre um valor para depósito: \n");
double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Deposito(quantia);
Console.WriteLine("Dados da conta atualizados:");
Console.WriteLine(conta);

Console.WriteLine();
Console.Write("Entre o valor para saque: \n");
quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Saque(quantia);
Console.WriteLine("Dados da conta atualizados:");
Console.WriteLine(conta);