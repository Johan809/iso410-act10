using System;

class Program
{
    static void Main()
    {
        RentaMensual();
    }

    static void RentaAnual()
    {
        // Obtener la renta del usuario
        Console.Write("Ingrese su renta anual: ");
        if (double.TryParse(Console.ReadLine(), out double rentaAnual))
        {
            // Calcular el impuesto según la escala
            double impuesto = CalcularImpuestoSobreRenta(rentaAnual);

            // Mostrar el resultado
            Console.WriteLine($"El impuesto sobre la renta es: RD${impuesto:N2}");
        }
        else
        {
            Console.WriteLine("Ingrese un valor válido para la renta.");
        }
        Console.ReadLine();
    }

    static void RentaMensual()
    {
        // Obtener la renta mensual del usuario
        Console.Write("Ingrese su renta mensual: ");
        if (double.TryParse(Console.ReadLine(), out double rentaMensual))
        {
            // Calcular el impuesto según la escala
            double rentaAnual = rentaMensual * 12;
            double impuesto = CalcularImpuestoSobreRenta(rentaAnual);

            // Mostrar el resultado
            Console.WriteLine($"El impuesto sobre la renta MENSUAL es: RD${impuesto / 12:N2}");
            Console.WriteLine($"El impuesto sobre la renta ANUAL es: RD${impuesto:N2}");
        }
        else
        {
            Console.WriteLine("Ingrese un valor válido para la renta mensual.");
        }
        Console.ReadLine();
    }

    static double CalcularImpuestoSobreRenta(double renta)
    {
        double impuesto;

        if (renta <= 416220.00)
        {
            // Exento
            impuesto = 0;
        }
        else if (renta <= 624329.00)
        {
            // 15% del excedente de RD$416,220.01
            impuesto = (renta - 416220.01) * 0.15;
        }
        else if (renta <= 867123.00)
        {
            // RD$31,216.00 más el 20% del excedente de RD$624,329.01
            impuesto = 31216.00 + (renta - 624329.01) * 0.20;
        }
        else
        {
            // RD$79,776.00 más el 25% del excedente de RD$867,123.01
            impuesto = 79776.00 + (renta - 867123.01) * 0.25;
        }

        return impuesto;
    }
}
