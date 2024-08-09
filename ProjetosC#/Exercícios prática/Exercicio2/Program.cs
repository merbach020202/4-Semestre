string[] nomes = Console.ReadLine();


for (int i = 1; i < nomes.Length; i++)
{
    Console.WriteLine($"\nDigite o {i}º nome: ");
    string[] Nomes = new string[5];
    string NomeStr = Console.ReadLine();


    Console.WriteLine($"\n{Nomes}");
}

Console.WriteLine($"\nOs nomes digitados serão mostrados em ordem alfabética:");

Console.WriteLine($"{Nomes}");


int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}


