public class Aluno{
    
    
    
    private string nome;
    private int idade;
    private double nota;

    public string Nome    {
        get { return nome; }
        set        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("O nome não pode ser vazio.");

            nome = value;
        }
    }

    public int Idade    {
        get { return idade; }
        set        {
            if (value < 0 || value > 100)
                throw new ArgumentException("A idade deve estar entre 0 e 100.");

            idade = value;
        }
    }

    public double Nota    {
        get { return nota; }
        set        {
            if (value < 0 || value > 10)
                throw new ArgumentException("A nota deve estar entre 0 e 10.");
            nota = value;
        }
    }

    public Aluno(string nome, int idade, double nota)
    {
        Nome = nome;
        Idade = idade;
        Nota = nota;
    }
    
    public override string ToString()
    {
        return $"Aluno: {Nome} | Idade: {Idade} | Nota: {Nota:F1}";
    }
}