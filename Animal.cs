public class Animal
{
    private string nome;
    private int idade;
    private string especie;

    public string Nome
    {
        get { return nome; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("O nome não pode ser vazio.");

            nome = value;
        }
    }

    public int Idade
    {
        get { return idade; }
        set
        {
            if (value < 0 || value > 100)
                throw new ArgumentException("A idade deve estar entre 0 e 100.");

            idade = value;
        }
    }

    public string Especie
    {
        get { return especie; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("A espécie não pode estar vazia.");

            especie = value;
        }
    }

    public Animal(string nome, int idade, string especie)
    {
        Nome = nome;
        Idade = idade;
        Especie = especie;
    }


    public void Comer()
    {
        Console.WriteLine($"{Nome} está comendo.");
    }

    public void Dormir()
    {
        Console.WriteLine($"{Nome} está dormindo.");
    }

    public void Som()
    {
        Console.WriteLine($"{Nome} emitiu um som.");
    }

    public override string ToString()
    {
        return $"Animal: {Nome} | Idade: {Idade} | Espécie: {Especie}";
    }
}
