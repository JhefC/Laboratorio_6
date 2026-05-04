using System;

class Programa
{
    static int LIMITE_GLOBAL = 80;

    static void MostrarEncabezado()
    {
        Console.WriteLine("==== SISTEMA INDUSTRIAL ====");
    }

    static bool EvaluarTemperatura(double temp)
    {
        if (temp > LIMITE_GLOBAL)
            return true;
        return false;
    }

    static void Main()
    {
        MostrarEncabezado();
        Console.Write("Ingrese temperatura: ");
        double temp = double.Parse(Console.ReadLine());

        if (EvaluarTemperatura(temp))
            Console.WriteLine("ALERTA");
        else
            Console.WriteLine("NORMAL");
    }
}