//Ejercicio 5 Taller Word Lógica de Programación: Dados los catetos de un triángulo rectángulo, calcular su hipotenusa.

public class CalcularHipotenusa
{
    static void Main(string[] args)
    {

        //Declaración de variables
        double cateto1, cateto2, hipotenusa;

        //Pedir datos de entrada al usuario
        Console.Write("¿Cuánto mide el cateto 1? (Si es un decimal, escríbalo utilizando coma(,) ): ");
        cateto1 = double.Parse(Console.ReadLine());

        Console.Write("¿Cuánto mide el cateto 2? (Si es un decimal, escríbalo utilizando coma(,) ): ");
        cateto2 = Convert.ToDouble(Console.ReadLine());

        //Cálculos
        hipotenusa = Math.Sqrt((Math.Pow(cateto1, 2)) + (Math.Pow(cateto2, 2)));

        //Datos de salida
        Console.Write("\n");
        Console.Write("La hipotenusa mide: " + hipotenusa);
        Console.Write("\n");

    }
}


