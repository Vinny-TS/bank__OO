using System;

namespace BankOO
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoVinicius = new ContaCorrente();

            contaDoVinicius.titular = "Vinicius";
            contaDoVinicius.agencia = 863;
            contaDoVinicius.conta = 863146;
            contaDoVinicius.saldo = 100;

            ContaCorrente contaDoJoao = new ContaCorrente();

            contaDoJoao.titular = "João";
            contaDoJoao.agencia = 357;
            contaDoJoao.conta = 357135;
            contaDoJoao.saldo = 120;

            Console.WriteLine("O titular da conta é: " +contaDoVinicius.titular);
            Console.WriteLine("O titular da conta é: " +contaDoJoao.titular);
        }
    }
}
