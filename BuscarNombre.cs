using System;

class BuscarNombre
{
    static void Main()
    {
        string[] nombres = new string[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Ingresa el nombre {i + 1}: ");
            nombres[i] = Console.ReadLine();
        }

        Console.Write("\nIngresa el nombre que deseas buscar: ");
        string buscar = Console.ReadLine();

       
        bool encontrado = false;
        for (int i = 0; i < 5; i++)
        {
            if (nombres[i].Equals(buscar, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"\nEl nombre '{buscar}' se encuentra en la posición {i}.");
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine($"\nEl nombre '{buscar}' no se encuentra en la lista.");
        }
    }
}
