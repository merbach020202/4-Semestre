//Implementar um programa que solicite ao usuário um número, e imprima a  tabuada desse número

Console.WriteLine("Digite um número de 1 a 10: ");
float numero = Convert.ToInt16(Console.ReadLine());

Console.Clear();

for (int i = 1; i <= 10; i++)
{
    float tabuada = numero * i;
    Console.WriteLine(tabuada);
}
