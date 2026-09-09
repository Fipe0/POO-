public class Celular{
    
    
    private string marca;
    private string modelo;
    private int bateria;

    public string Marca
    {
        get { return marca; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("A marca não pode estar vazia.");

            marca = value;
        }
    }

    public string Modelo
    {
        get { return modelo; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("O modelo não pode estar vazio.");

            modelo = value;
        }
    }

    public int Bateria
    {
        get { return bateria; }
        set
        {
            if (value < 0 || value > 100)
                throw new ArgumentException("A bateria deve estar entre 0 e 100.");

            bateria = value;
        }
    }

    public Celular(string marca, string modelo, int bateria)
    {
        Marca = marca;
        Modelo = modelo;
        Bateria = bateria;
    }

    public void Ligar()
    {
        if (Bateria > 0)
            Console.WriteLine($"{Marca} {Modelo} foi ligado.");
        else
            Console.WriteLine("Não é possível ligar. Bateria descarregada.");
    }

    public void Desligar()
    {
        Console.WriteLine($"{Marca} {Modelo} foi desligado.");
    }

    public void Carregar()
    {
        Bateria = 100;
        Console.WriteLine($"{Marca} {Modelo} foi carregado. Bateria: {Bateria}%");
    }

    public override string ToString()
    {
        return $"Celular: {Marca} | Modelo: {Modelo} | Bateria: {Bateria}%";
    }
}
``
