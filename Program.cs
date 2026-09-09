Animal cachorro = new Animal("Martelo", 5, "Cachorro");
Animal hamster = new Animal("Jorge", 5, "Hamster");

cachorro.Comer();
cachorro.Dormir();
cachorro.Som();

Console.WriteLine(cachorro);


hamster.Comer();
hamster.Dormir();
hamster.Som();

Console.WriteLine(hamster);



Celular pessoal = new Celular("Samsung", "Galaxy S24", 50);
Celular corporativo = new Celular("Motorola", "Edge 50 Pro", 75);

Console.WriteLine(pessoal);

pessoal.Ligar();
pessoal.Carregar();
pessoal.Desligar();


Console.WriteLine(corporativo);

corporativo.Ligar();
corporativo.Carregar();
corporativo.Desligar();



Player jogador1 = new Player("Filipe", 1, 100);
Player jogador2 = new Player("Josefa", 1, 100);

jogador1.Atacar();
jogador1.Defender();
jogador1.SubirNivel();

Console.WriteLine(jogador1);

jogador2.Atacar();
jogador2.Defender();
jogador2.SubirNivel();

Console.WriteLine(jogador2);
