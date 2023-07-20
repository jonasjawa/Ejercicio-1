// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio 1");

int numero, i, correcto;

//Pedimos el numero
Console.Write("Introduce un número entero positivo: ");
numero = Convert.ToInt32(Console.ReadLine());

//Lo mostramos
Console.WriteLine("Números primos: ");

//Comprobamos que sea positivo
if (numero <= 0)
{
    Console.WriteLine("No es positivo");
}
else
{
    //Recorremos el numero comprobando cuales son primos
    for (i = 2; i <= numero; i++)
    {
        correcto = Primo(i);

        if (correcto == 1)
        {
            //Lo mostramos
            Console.WriteLine(i);
        }
    }
}

Console.ReadKey();


/***
 * Comprueba primos
 * ***/
static int Primo(int numero)
{
    int j, contador = 0;

    //Recorremos el numero dividiendolo
    for (j = 1; j <= numero; j++)
    {
        if (numero % j == 0)
        {
            contador++;
        }
    }
    // si el numero solo tiene 2 divisores (1 y él mismo), es un número primo
    if (contador == 2)
    {
        return 1;
    }
    else
    {
        return 0;
    }
}


