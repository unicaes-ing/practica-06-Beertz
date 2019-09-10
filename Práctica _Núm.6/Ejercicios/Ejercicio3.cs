using System;

namespace Práctica__Núm._6.Ejercicios
{
    class Ejercicio3
    {
        //Alberto Galdámez | 09-09-2019
        static void Main(string[] args)
        {
            Console.Write("[Escriba el numero base]: ");
            int numBase = Convert.ToInt32(Console.ReadLine());
            Console.Write("[Escriba el exponente del numero base]: {0}^", numBase);
            int numExponente = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(DevolverR(numBase, numExponente));

            Console.ReadKey();
        }

        public static string DevolverR(int numBase, int numExponente)
        {
            string resultado = "";
            double resultadoFinal = Math.Pow(numBase, numBase);
            resultado = "Su resultado es: " + resultadoFinal;
            return resultado;
        }
    }
}
