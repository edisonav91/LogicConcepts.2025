﻿do
{
    Console.Write("Ingrese numero o presiones ctrl c para salir: ");
    var numberString = Console.ReadLine();
    var numberInt = 0;
    if(int.TryParse(numberString, out numberInt))
    {
        if (numberInt % 2 == 0)
        {
            Console.WriteLine($"El numero {numberInt} es par: ");

        }
        else
        {
            Console.WriteLine($"El numero {numberInt} es impar: ");
        }
    }
    else
    {
        Console.WriteLine($"Lo que ingresaste: {numberString} no es un numero entero.");
    }
} while (true);


