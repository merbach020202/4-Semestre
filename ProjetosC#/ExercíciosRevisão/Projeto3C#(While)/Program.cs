//Calcular a soma dos números pares de 1 a 100

int cont = 0;
float valorFinal = 0f;

Console.WriteLine("Cálculo da soma dos números pares de 1 a 100:");

while (cont <= 100)
{
    if (cont % 2 == 0)
    {
        valorFinal += cont;
    }    
    cont++;
}

Console.WriteLine(valorFinal);