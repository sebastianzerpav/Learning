// Ejercicio 1: Pedir 2 números por pantalla y realizar operaciones aritméticas

// Nombre de clase
public class CalculadoraBasica
{

    static void Main(string[] args)
    {
        
        //Declaración de variables (datos de entrada)
        double num1, num2;
        double numSuma, numResta, numProducto, numCociente;

        //Entrada de datos
        Console.Write("Escriba el primer número (si hay decimales, utilice comas y no puntos): ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Escriba el segundo número (si hay decimales, utilice comas y no puntos): ");
        num2 = Convert.ToDouble(Console.ReadLine());

        //Proceso con datos de datos
        numSuma = num1 + num2;
        numResta = num1 - num2;
        numProducto = num1 * num2;
        numCociente = num1 / num2;

        //Datos de salida e impresión
        Console.WriteLine("La suma es: " + numSuma);
        Console.WriteLine("La resta es: " + numResta);
        Console.WriteLine("El producto es: " + numProducto);
        Console.WriteLine("El cociente es: " + numCociente);

    }
    
}

