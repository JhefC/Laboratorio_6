using System;

class Programa
{
    // Variable global para el límite
    static int LIMITE_GLOBAL = 80;

    static void MostrarEncabezado()
    {
        Console.WriteLine("==== SISTEMA INDUSTRIAL ====");
    }

    // Primer método adicional: Valida que no sea negativa
    static bool ValidarTemperatura(double temp)
    {
        if (temp < 0)
        {
            Console.WriteLine("Error: valor inválido");
            return false;
        }
        return true;
    }

    // Segundo método adicional: Devuelve el estado directamente como texto
    static string EvaluarTemperatura(double temp)
    {
        if (temp > LIMITE_GLOBAL)
            return "ALERTA";
        return "NORMAL";
    }

    static void Main()
    {
        MostrarEncabezado();
        Console.Write("Ingrese temperatura: ");
        
        // Usamos TryParse para evitar que el programa se cierre si ingresan letras
        if (double.TryParse(Console.ReadLine(), out double temp))
        {
            // Primero validamos si el rango es correcto (no negativo)
            if (ValidarTemperatura(temp))
            {
                // Si es válido, evaluamos y mostramos el resultado
                string resultado = EvaluarTemperatura(temp);
                Console.WriteLine("Estado: " + resultado);
            }
        }
        else
        {
            Console.WriteLine("Error: Debe ingresar un número válido.");
        }
    }
}