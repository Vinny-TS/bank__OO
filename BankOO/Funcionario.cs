public class Funcionario{
    public string Nome { get; set; }
    public string CPF { get; set; }
    public string Cargo { get; set; }
    public double Salario { get; set; }
    public double Comissao { get; set; }
    private double _bonificacao;
    public double Bonificacao { 
        get{
            return _bonificacao;
        } 
        set{
            if(this.Cargo == "Vendedor"){
                _bonificacao += value * 0.02;
            }
            if(this.Cargo == "Diretor"){
                _bonificacao += value * 0.08;
            }  
        } 
    }

    public Funcionario(string funcionario_nome, string funcionario_cpf, string funcionario_cargo, double funcionario_salario, double funcionario_bonificacao)
    { 
        Nome = funcionario_nome;
        CPF = funcionario_cpf;
        Cargo = funcionario_cargo;
        Salario = funcionario_salario;
        Bonificacao = funcionario_bonificacao;
    }
}