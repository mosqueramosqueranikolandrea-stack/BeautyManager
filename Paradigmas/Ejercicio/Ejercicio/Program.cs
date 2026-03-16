using System;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria cuenta = new CuentaBancaria("Juan Pérez", "12345", 500);

            cuenta.MostrarInfo();

            Console.WriteLine("\nDepositando 200...");
            cuenta.Depositar(200);

            Console.WriteLine("Saldo: " + cuenta.ConsultarSaldo());

            Console.WriteLine("\nRetirando 100...");
            cuenta.Retirar(100);

            Console.WriteLine("Saldo: " + cuenta.ConsultarSaldo());

            Console.WriteLine("\nIntentando retirar 1000...");
            cuenta.Retirar(1000);

            Console.WriteLine("\nSaldo final:");
            cuenta.MostrarInfo();

            Console.ReadKey();
        }
    }
}


