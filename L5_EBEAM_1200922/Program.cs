// See https://aka.ms/new-console-template for more information
int numeroEntero;

Console.WriteLine("Ejercicio 1");
Console.WriteLine("Ingresar un Numero Entero");

numeroEntero = Convert.ToInt32(Console.ReadLine());

if (numeroEntero > 0)
{
    Console.WriteLine("El Numero Es Positivo");
}
else if (numeroEntero < 0)
{
    Console.WriteLine(" El Numero Es Negativo ");

}

else if (numeroEntero == 0)
{
    Console.WriteLine("Cero");
}

Console.WriteLine(numeroEntero);    