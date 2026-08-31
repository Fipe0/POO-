public class Produto{
    
    
    
    private string nome;
    private double preco;
    private int estoque;

    public string Nome    {
        get { return nome; }
        set        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("O nome não pode ser vazio.");

            nome = value;
        }
    }

    public double Preco    {
        get { return preco; }
        set        {
            if (value < 0)
                throw new ArgumentException("O preço não pode ser negativo.");

            preco = value;
        }
    }

    public int Estoque    {
        get { return estoque; }
        set        {
            if (value < 0)
                throw new ArgumentException("O estoque não pode ser negativo.");

            estoque = value;
        }
    }

    public Produto(string nome, double preco, int estoque)
    {
        Nome = nome;
        Preco = preco;
        Estoque = estoque;
    }

    public override string ToString()
    {
        return $"Produto: {Nome} | Preço: R$ {Preco:F2} | Estoque: {Estoque}";
    }
}