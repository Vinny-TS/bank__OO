using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionarioVinicius = new Funcionario("Vinicius Telles", "123.123.123-45", "Diretor", 1200, 1);
            Funcionario funcionarioCarlos = new Funcionario("Carlos", "123.456.789-10", "Vendedor", 1200, 1);
            Funcionario funcionarioDaniel = new Funcionario("Daniel", "321.654.987-01", "Vendedor", 1200, 1);


            ContaCorrente contaDoCharles = new ContaCorrente("Charles", 1234, 789, 100, funcionarioVinicius);
            ContaCorrente contaDoGeorge = new ContaCorrente("George", 1234, 790, 120, funcionarioDaniel);
            ContaCorrente contaDoValtteri = new ContaCorrente("Valtteri", 1234, 791, 150, funcionarioCarlos);


            funcionarioCarlos.Bonificacao = funcionarioCarlos.Salario;
            funcionarioDaniel.Bonificacao = funcionarioDaniel.Salario;
            funcionarioVinicius.Bonificacao = funcionarioVinicius.Salario;

            Console.WriteLine("Bonificação: R$" + funcionarioVinicius.Bonificacao);
            Console.WriteLine("O total de contas criadas é de: " + ContaCorrente.TotalDeContasCriadas + " conta(s).");
            Console.WriteLine("Saldo inicial: Charles R$" + contaDoCharles.Saldo + "; conta vendida pelo vendedor: " + funcionarioVinicius.Nome + ", que recebeu uma comissão de: R$" + funcionarioVinicius.Comissao);
            Console.WriteLine("Saldo inicial: George R$" + contaDoGeorge.Saldo + "; conta vendida pelo vendedor: " + funcionarioDaniel.Nome + ", que recebeu uma comissão de: R$" + funcionarioDaniel.Comissao);
            Console.WriteLine("Saldo inicial: Valtteri R$" + contaDoValtteri.Saldo + "; conta vendida pelo vendedor: " + funcionarioCarlos.Nome + ", que recebeu uma comissão de: R$" + funcionarioCarlos.Comissao);

            contaDoCharles.Sacar(10);
            contaDoGeorge.Depositar(50);
            contaDoValtteri.Transferir(30, contaDoCharles);

            Console.WriteLine("Saldo após saque: Charles R$" + contaDoCharles.Saldo);
            Console.WriteLine("Saldo após depósito: George R$" + contaDoGeorge.Saldo);
            Console.WriteLine("Saldo após transferência: Valtteri R$" + contaDoValtteri.Saldo + "; Saldo após transferência: Charles R$" + contaDoCharles.Saldo);
        }
    }
}