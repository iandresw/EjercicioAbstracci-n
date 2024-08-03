using EjercicioAbstracción;

Console.WriteLine("Ejercicio Abstraccion!");
Calculadora calculadora = new Calculadora();
Console.WriteLine("Ingrese el Primer Numero:");
calculadora.Num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el Segundo Numero:");
calculadora.Num2 = double.Parse(Console.ReadLine());
calculadora.Imprimir();