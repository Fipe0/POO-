
class Program
{
    static void Main()
    {
        
        Aluno aluno1 = new Aluno("Filipe", 15, 8.5);
        Aluno aluno2 = new Aluno("João", 16, 7.0);
        Console.WriteLine(aluno1);
        Console.WriteLine(aluno2);
        aluno1.Nota = 9.5;
        Console.WriteLine("\nDepois de alterar a nota:");
        Console.WriteLine(aluno1);



        Produto produto1 = new Produto("Teclado", 850.00, 10);
        Produto produto2 = new Produto("Mouse", 120.00, 25);

        Console.WriteLine("\n" + produto1);
        Console.WriteLine(produto2);

        produto1.Preco = 900.00;
        produto2.Estoque = 30;

        Console.WriteLine("\nDepois das alterações:");
        Console.WriteLine(produto1);
        Console.WriteLine(produto2);



        ContaBancaria conta1 = new ContaBancaria("Carlos", 1001, 1500.00);
        ContaBancaria conta2 = new ContaBancaria("Marcos", 1002, 2500.00);

        Console.WriteLine("\n" + conta1);
        Console.WriteLine(conta2);

        conta1.Saldo = 2000.00;
        Console.WriteLine("\nDepois de alterar o saldo:");
        Console.WriteLine(conta1);
    }
}