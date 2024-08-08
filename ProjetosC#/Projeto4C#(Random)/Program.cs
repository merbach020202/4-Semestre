// Crie um programa que gere um número aleatório entre 1 e dez. O Usuário deve tentar adivinhar esse número. 
//O programa deve continuar pedindo um palpite até que o usuário acerte o número. Ao final, mostre quantas tentativas foram necessárias

int cont = 0;

// Número aleatório gerado
Random RandNum = new Random();
int scretNum = RandNum.Next(1, 11);


Console.WriteLine("Um número aleatório de 1 a 10 foi gerado, Tente adivinhá-lo!");
int RightNum = Convert.ToInt16(Console.ReadLine());


while (scretNum != RightNum)
{
    if (RightNum == scretNum)
    {
        Console.Clear();
        Console.WriteLine("\nCorreto!");
        Console.WriteLine($"\nNúmero de tentativas: {cont}");
        cont++;
    }

    else
    {
        Console.WriteLine($"\nIncorreto!, Tente adivinhar outro número");
        cont++;
    }
}
