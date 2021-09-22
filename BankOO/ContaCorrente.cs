public class ContaCorrente{
    public string Titular { get; set; }
    public int Agencia { get; set; }
    public int Conta { get; set; }
    private double _saldo;
    public double Saldo { get{
        return this._saldo;
    }
    set{
        if(value >= 0){
            this._saldo = value;
        }
     } 
    }

    public ContaCorrente() {}
    public ContaCorrente(string contacorrente_titular, int contacorrente_agencia, int contacorrente_conta, double contacorrente_saldo)
    { 
        Titular = contacorrente_titular;
        Agencia = contacorrente_agencia;
        Conta = contacorrente_conta;
        Saldo = contacorrente_saldo;
    }

    public bool Sacar (double valor){
        if(this.Saldo < valor){
            return false;
        }
        else{
            this.Saldo -= valor;
            return true;
        }
    }

    public void Depositar(double valor){
        this.Saldo += valor;
    }

    public bool Transferir(double valor, ContaCorrente contaDestino){
        if(this.Saldo < valor){
            return false;
        }
        else{
            this.Sacar(valor);
            contaDestino.Depositar(valor);
            return true;
        }
    }

    public double ConsultaSaldo(){
        return this.Saldo;
    }
}