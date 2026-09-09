public class Player
{
    private string nome;
    private int nivel;
    private int vida;

    public string Nome
    {
        get { return nome; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("O nome não pode estar vazio.");

            nome = value;
        }
    }

    public int Nivel
    {
        get { return nivel; }
        set
        {
            if (value < 1)
                throw new ArgumentException("O nível deve ser maior que 0.");

            nivel = value;
        }
    }

    public int Vida
    {
        get { return vida; }
        set
        {
            if (value < 0 || value > 100)
                throw new ArgumentException("A vida deve estar entre 0 e 100.");

            vida = value;
        }
    }

    public Player(string nome, int nivel, int vida)
    {
        Nome = nome;
        Nivel = nivel;
        Vida = vida;
    }

    public void Atacar()
    {
        Console.WriteLine($"{Nome} atacou o inimigo!");
    }

    public void Defender()
    {
        Console.WriteLine($"{Nome} se defendeu!");
    }

    public void SubirNivel()
    {
        Nivel = Nivel + 1;
        Console.WriteLine($"{Nome} subiu de nível | nível atual: {Nivel}!");
    }

    public override string ToString()
    {
        return $"Player: {Nome} | Nível: {Nivel} | Vida: {Vida}";
    }
}
