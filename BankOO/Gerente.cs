public class Gerente : Funcionario{
    public int NumeroDeAgencias {get;set;}

    public override double Bonificacao {
        get{
            return _bonificacao;
        }
        set{
            _bonificacao += value * 0.08;
        } 
    }

    public override int CalcularFerias(){
        int dias_ferias = 20 + NumeroDeAgencias* 2;
        return dias_ferias;
    }
}