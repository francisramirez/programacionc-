using System;

namespace Clase
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaCorriente cuentaCorriente = new CuentaCorriente();

            cuentaCorriente.NumeroCuenta = "78945612";
            cuentaCorriente.Nombre = "Mi cuenta cuenta corriente";
            cuentaCorriente.Saldo = 500;

            cuentaCorriente.Depositar();
            cuentaCorriente.Girar();

            var saldo = cuentaCorriente.ContultarSaldo();

            Console.WriteLine($"Mi numero de cuenta {cuentaCorriente.NumeroCuenta}");
            Console.WriteLine($"Nombre de la cuenta {cuentaCorriente.Nombre} ");
            Console.WriteLine($"Saldo de la cuenta {cuentaCorriente.Saldo}");



            Console.ReadLine();
        }
    }
}
