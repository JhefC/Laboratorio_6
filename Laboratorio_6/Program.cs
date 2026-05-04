using System;

class Programa
{
    // Variable global para el límite (usamos static para que sea accesible)
    static double LIMITE_GLOBAL = 80;

    static void Main()
    {
        MostrarEncabezado();

        // 1. Ingresar
        double temp = Ingresar();

        // 2. Validar
        if (Validar(temp))
        {
            // 3. Evaluar
            string estado = Evaluar(temp);

            // 4. Mostrar
            Mostrar(estado);
        }
    }

    // --- MÉTODOS UNIFICADOS ---

    static void MostrarEncabezado()
    {
        Console.WriteLine("==== SISTEMA INDUSTRIAL DE MONITOREO ====");
    }

    static double Ingresar()
    {
        Console.Write("Ingrese temperatura: ");
        // Usamos TryParse para que el programa no falle si escriben letras
        if (double.TryParse(Console.ReadLine(), out double temperatura))
        {
            return temperatura;
        }
        return -1; // Retornamos un valor que falle en la validación
    }

    static bool Validar(double temp)
    {
        if (temp < 0)
        {
            Console.WriteLine("Error: Temperatura inválida (no puede ser menor a 0)");
            return false;
        }
        return true;
    }

    static string Evaluar(double temp)
    {
        if (temp > LIMITE_GLOBAL) 
            return "ALERTA";
        else 
            return "NORMAL";
    }

    static void Mostrar(string resultado)
    {
        Console.WriteLine("Estado actual: " + resultado);
    }
}