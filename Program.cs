Animal cachorro = new Animal("Martelo", 5, "Cachorro");

cachorro.Comer();
cachorro.Dormir();
cachorro.Som();


Console.WriteLine(cachorro);



Celular celular = new Celular("Samsung", "Galaxy S24", 50);

Console.WriteLine(celular);

celular.Ligar();
celular.Carregar();
celular.Desligar();


ContaBancaria conta1 = new ContaBancaria("Carlos", 1001, 1500.00);
ContaBancaria conta2 = new ContaBancaria("Marcos", 1002, 2500.00);

Console.WriteLine("\n" + conta1);
Console.WriteLine(conta2);

conta1.Saldo = 2000.00;
Console.WriteLine("\nDepois de alterar o saldo:");
Console.WriteLine(conta1);
