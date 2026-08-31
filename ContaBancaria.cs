public class ContaBancaria{
    
    
    
    private string titular;
    private int numero;
    private double saldo;

    public string Titular    {
        get { return titular; }
        set        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("O titular não pode ser vazio.");

            titular = value;
        }
    }

    public int Numero    {
        get { return numero; }
        set        {
            if (value <= 0)
                throw new ArgumentException("O número da conta deve ser maior que zero.");
            numero = value;
        }
    }

    public double Saldo    {
        get { return saldo; }
        set        {
            if (value < 0)
                throw new ArgumentException("O saldo não pode ser negativo.");
            saldo = value;
        }
    }
    public ContaBancaria(string titular, int numero, double saldo)
    {
        Titular = titular;
        Numero = numero;
        Saldo = saldo;
    }

    public override string ToString()
    {
        return $"Titular: {Titular} | Conta: {Numero} | Saldo: R$ {Saldo:F2}";
    }
}