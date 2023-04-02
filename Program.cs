Console.WriteLine("**/-- Exercício de Nome Completo --/**");
Console.WriteLine();
string nome, sobrenome;

Console.WriteLine("Digite seu nome");
nome = Console.ReadLine()!;
Console.WriteLine();

Console.WriteLine("Digite seu Sobrenome");
sobrenome = Console.ReadLine()!;
Console.WriteLine();

Console.WriteLine($"Nome Completo :.. {nome} {sobrenome}\n");

Console.WriteLine($"Nome de catálogo :.. {sobrenome.ToUpper()}, {nome}\n");

//Consegui fazer esse exercio sem olhar nada na correção. 