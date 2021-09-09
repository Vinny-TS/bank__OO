using System;

namespace BankOO
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoVinicius = new ContaCorrente("Vinícius", 863, 863146, 100);

            ContaCorrente contaDoJoao = new ContaCorrente("João", 357, 357135, 120);

            Console.WriteLine("O titular da conta é: " +contaDoVinicius.titular);
            Console.WriteLine("O titular da conta é: " +contaDoJoao.titular);
        }
    }
}
