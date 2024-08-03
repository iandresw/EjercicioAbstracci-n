using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstracción
{
    internal class Calculadora : Matematicas
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }

        public override double Divicion()
        {
            return Num1 / Num2;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"Suma: {Suma()}");
            Console.WriteLine($"La Resta: {Resta()}");
            Console.WriteLine($"La Multiplicacion: {Multiplicacion()}");
            Console.WriteLine($"La Divicion: {Divicion()}");
        }

        public override double Multiplicacion()
        {
            return Num1 * Num2;
        }

        public override double Resta()
        {
            return (Num1 - Num2);
        }

        public override double Suma()
        {
            return Num1 + Num2;
        }
    }
}

