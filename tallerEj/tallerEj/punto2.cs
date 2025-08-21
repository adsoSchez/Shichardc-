using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tallerEj
{
    public class punto2
    {
        public class CuentaBancaria
        {
            private string titular;
            private decimal saldo;
            private string numeroCuenta;

            public string Titular
            {
                get { return titular; }
                set { titular = value; }
            }

            public decimal Saldo
            {
                get { return saldo; }
                private set { saldo = value; }
            }

            public string NumeroCuenta
            {
                get { return numeroCuenta; }
                set { numeroCuenta = value; }
            }
            public CuentaBancaria(string titular, string numeroCuenta)
            {
                Titular = titular;
                NumeroCuenta = numeroCuenta;
                Saldo = 0;
            }

            public void Depositar(decimal cantidad)
            {
                if (cantidad > 0)
                    Saldo += cantidad;
            }

            public void Retirar(decimal cantidad)
            {
                if (cantidad > 0 && Saldo - cantidad >= 0)
                    Saldo -= cantidad;
                else
                    Console.WriteLine("Fondos insuficientes.");
            }

            public void MostrarSaldo()
            {
                Console.WriteLine($"Saldo actual: {Saldo}");
            }
        }
    }
}
