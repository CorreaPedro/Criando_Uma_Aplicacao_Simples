using System;

namespace DIO.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta minhaConta = new Conta(TipoConta.PessoaFisica, 400, 200, "Pedro Correa");

            Console.WriteLine(minhaConta.ToString());
        }
    }
}
