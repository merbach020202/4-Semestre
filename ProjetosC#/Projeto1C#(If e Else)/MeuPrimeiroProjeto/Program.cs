Console.WriteLine("Informe a nota do aluno: ");
double nota = Convert.ToDouble(Console.ReadLine());

if (nota > 7)
{
    Console.WriteLine("Aprovado");
}
else if (nota >= 5)
{
    Console.WriteLine("Recuperação");
}
else
{
    Console.WriteLine("Reprovado");
}

//Implementar um programa que receba a nota de um aluno, e imprima se ele está aprovado, reprovado, ou em recuperação