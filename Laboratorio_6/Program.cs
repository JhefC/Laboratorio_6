using System;

class Programa
{
    // Variable global para el límite
    static double LIMITE_GLOBAL = 80;

    static void Main()
    {
        MostrarEncabezado();

        double temp = Ingresar();

        if (Validar(temp))
        {
            // Evaluación usando el límite global (80)
            string estadoGlobal = Evaluar(temp);
            Console.WriteLine("--- Evaluación con Límite Global (80) ---");
            Mostrar(estadoGlobal);

            // Evaluación usando el nuevo método con un límite personalizado (ejemplo: 100)
            int limitePersonalizado = 100;
            string estadoPersonalizado = Evaluar(temp, limitePersonalizado);
            Console.WriteLine($"--- Evaluación con Límite Personalizado ({limitePersonalizado}) ---");
            Mostrar(estadoPersonalizado);
        }
    }

    // --- MÉTODOS ---

    static void MostrarEncabezado()
    {
        Console.WriteLine("==== SISTEMA INDUSTRIAL DE MONITOREO ====");
    }

    static double Ingresar()
    {
        Console.Write("Ingrese temperatura: ");
        if (double.TryParse(Console.ReadLine(), out double temperatura))
        {
            return temperatura;
        }
        return -1;
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

    // Versión 1: Usa la variable global
    static string Evaluar(double temp)
    {
        if (temp > LIMITE_GLOBAL) 
            return "ALERTA";
        else 
            return "NORMAL";
    }

    // Versión 2: NUEVO MÉTODO (Sobrecarga que recibe un límite específico)
    static string Evaluar(double temp, int limite)
    {
        if (temp > limite)
            return "ALERTA";
        return "NORMAL";
    }

    static void Mostrar(string resultado)
    {
        Console.WriteLine("Estado actual: " + resultado);
    }
}