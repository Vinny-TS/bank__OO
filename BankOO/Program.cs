using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoVinicius = new ContaCorrente("Vinicius", 1234, 789, 100.50);
            ContaCorrente contaDoJoao = new ContaCorrente("Joao", 1234, 790, 120);
            ContaCorrente contaDaMaria = new ContaCorrente("Maria", 1234, 791, 150);

            contaDoVinicius.Sacar(50);
            Console.WriteLine("O saldo da conta da Vinicius após o saque é: " + contaDoVinicius.Saldo);

            /* contaDoVinicius.Depositar(100);
            Console.WriteLine("O saldo da conta do Vinicius após o depósito é: " + contaDoVinicius.saldo);

            contaDoVinicius.Transferir(100, contaDaMaria);
            Console.WriteLine("O saldo da conta do Vinicius após a transferência é: " + contaDoVinicius.saldo);
            Console.WriteLine("O saldo da conta da Maria após a transferência é: " + contaDaMaria.saldo); */
        }
    }
}