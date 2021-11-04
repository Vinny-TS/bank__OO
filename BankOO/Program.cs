using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente gerenteCarlosDaniel = new Gerente(){
                Nome = "Carlos Daniel",
                CPF = "567.123.789-11",
                Salario = 2000,
                NumeroDeAgencias = 5,
            };

            Vendedor vendedorGabriel = new Vendedor(){
                Nome = "Gabriel",
                CPF = "123.456.789-00",
                Salario = 1000,
                NumeroClientesAtendidos = 5,
            };
                    
            Vendedor vendedorFelipe = new Vendedor(){
                Nome = "Felipe",
                CPF = "098.765.432-10",
                Salario = 1000,
                NumeroClientesAtendidos = 3,
            };

            vendedorFelipe.Bonificacao = vendedorFelipe.Salario;

            ContaCorrente contaDaVirginiaLeticiaAfonso = new ContaCorrente("Virginia Leticia Afonso", 1234, 1000, vendedorFelipe);
            contaDaVirginiaLeticiaAfonso.Conta = 789;
            ContaCorrente contaDoMateus = new ContaCorrente("Mateus", 1234, 120, vendedorFelipe);
            contaDoMateus.Conta = 789;
            ContaCorrente contaDoJonatan = new ContaCorrente("Jonatan", 5678, 15000, vendedorGabriel);
            contaDoJonatan.Conta = 123;

            Console.WriteLine("As contas são:");
            Console.WriteLine("Conta 1:\nNome: "+contaDaVirginiaLeticiaAfonso.Titular+
            "\nAgência: "+contaDaVirginiaLeticiaAfonso.Agencia+
            "\nSaldo: "+contaDaVirginiaLeticiaAfonso.Saldo);

            Console.WriteLine("\nConta 2:\nNome: "+contaDoMateus.Titular+
            "\nAgência: "+contaDoMateus.Agencia+
            "\nSaldo: "+contaDoMateus.Saldo);

            Console.WriteLine("\nConta 3:\nNome: "+contaDoJonatan.Titular+
            "\nAgência: "+contaDoJonatan.Agencia+
            "\nSaldo: "+contaDoJonatan.Saldo);

            Console.WriteLine("\nOs funcinários são:");
            Console.WriteLine("Funcionario 1:\nNome: "+vendedorGabriel.Nome+
            "\nCPF: "+vendedorGabriel.CPF+"\nSalário: "+vendedorGabriel.Salario+
            "\nComissão: "+vendedorGabriel.Comissao+"\nBonificação: "+vendedorGabriel.Bonificacao+
            "\nDias de férias: "+vendedorGabriel.CalcularFerias()+
            "\nRemuneração total: "+vendedorGabriel.RemuneracaoTotal(vendedorGabriel.Salario));

            Console.WriteLine("\nFuncionario 2:\nNome: "+vendedorFelipe.Nome+
            "\nCPF: "+vendedorFelipe.CPF+"\nSalário: "+vendedorFelipe.Salario+
            "\nComissão: "+vendedorFelipe.Comissao+"\nBonificação: "+vendedorFelipe.Bonificacao+
            "\nDias de férias: "+vendedorFelipe.CalcularFerias()+
            "\nRemuneração total: "+vendedorFelipe.RemuneracaoTotal(vendedorFelipe.Salario, vendedorFelipe.Bonificacao));

            Console.WriteLine("\nGerente:\nNome: "+gerenteCarlosDaniel.Nome+
            "\nCPF: "+gerenteCarlosDaniel.CPF+"\nSalário: "+gerenteCarlosDaniel.Salario+
            "\nComissão: "+gerenteCarlosDaniel.Comissao+"\nBonificação: "+gerenteCarlosDaniel.Bonificacao+
            "\nDias de férias: "+gerenteCarlosDaniel.CalcularFerias()+
            "\nRemuneração total: "+gerenteCarlosDaniel.RemuneracaoTotal(gerenteCarlosDaniel.Salario));

            Console.WriteLine("\nSacar R$100,00 da conta do Jonatan.");
            contaDoJonatan.Sacar(100);
            Console.WriteLine("O saldo da conta do Jonatan é: "+ contaDoJonatan.Saldo);

            Console.WriteLine("\nDepositar R$380,00 na conta do Mateus.");
            contaDoMateus.Depositar(380);
            Console.WriteLine("O saldo da conta do Mateus é: "+ contaDoMateus.Saldo);

            Console.WriteLine("\nTransferir R$500,00 da conta do Jonatan para a conta da Virginia.");
            contaDoJonatan.Transferir(500, contaDaVirginiaLeticiaAfonso);
            Console.WriteLine("O saldo da conta do Jonatan é: "+ contaDoJonatan.Saldo);
            Console.WriteLine("O saldo da conta da Virginia é: "+ contaDaVirginiaLeticiaAfonso.Saldo);

            Console.WriteLine("\nO número de contas criadas é: "+ContaCorrente.TotaldeContasCriadas);
        }
    }
}