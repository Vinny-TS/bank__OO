using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente gerenteMax = new Gerente()
            {
                Nome = "Max",
                CPF = "378.159.442-11",
                Salario = 5000,
                NumeroDeAgencias = 4,
            };

            Vendedor vendedorLewis = new Vendedor()
            {
                Nome = "Lewis",
                CPF = "142.570.068-45",
                Salario = 2000,
                NumeroClientesAtendidos = 3,
            };

            Vendedor vendedorValtteri = new Vendedor()
            {
                Nome = "Valtteri",
                CPF = "075.112.258-77",
                Salario = 2000,
                NumeroClientesAtendidos = 6,
            };

            Vendedor vendedorKimi = new Vendedor()
            {
                Nome = "Kimi",
                CPF = "033.007.077-04",
                Salario = 2000,
                NumeroClientesAtendidos = 5,
            };

            vendedorValtteri.Bonificacao = vendedorValtteri.Salario;
            vendedorLewis.Bonificacao = vendedorLewis.Salario;
            vendedorKimi.Bonificacao = vendedorKimi.Salario;
            gerenteMax.Bonificacao = gerenteMax.Salario;

            ContaCorrente contaDoViniciusTelleseSilva = new ContaCorrente("Vinícius Telles e Silva", 45, 2500, vendedorValtteri);
            contaDoViniciusTelleseSilva.Conta = 333;
            ContaCorrente contaDoNorris = new ContaCorrente("Norris", 04, 3000, vendedorKimi);
            contaDoNorris.Conta = 123;
            ContaCorrente contaDoGeorge = new ContaCorrente("George", 63, 1500, vendedorLewis);
            contaDoGeorge.Conta = 332;

            Console.WriteLine("\nBonificação Lewis: " + vendedorLewis.Bonificacao +
            "\nBonificação Kimi: " + vendedorKimi.Bonificacao + 
            "\nBonificação Valtteri: " + vendedorValtteri.Bonificacao +
            "\nBonificação Max: " + gerenteMax.Bonificacao +
            "\nRemuneração total Lewis: " + vendedorLewis.RemuneracaoTotal(vendedorLewis.Salario, vendedorLewis.Bonificacao) +
            "\nRemuneração total Valtteri: " + vendedorValtteri.RemuneracaoTotal(vendedorValtteri.Salario, vendedorValtteri.Bonificacao) + 
            "\nRemuneração total Kimi: " + vendedorKimi.RemuneracaoTotal(vendedorKimi.Salario, vendedorKimi.Bonificacao) +
            "\nRemuneração total Max: " + gerenteMax.RemuneracaoTotal(gerenteMax.Salario, gerenteMax.Bonificacao) +
            "\nDias de férias Lewis: " + vendedorLewis.CalcularFerias() +
            "\nDias de férias Valtteri: " + vendedorValtteri.CalcularFerias() +
            "\nDias de férias Kimi: " + vendedorKimi.CalcularFerias() +
            "\nDias de férias Max: " + gerenteMax.CalcularFerias());

            Console.WriteLine("\nConta 1: " + contaDoViniciusTelleseSilva.Titular +
            "\nConta 2: " + contaDoGeorge.Titular + 
            "\nConta 3: " + contaDoNorris.Titular);

            Console.WriteLine("\nO número de contas criadas é: " + ContaCorrente.TotaldeContasCriadas);

        }
    }
}