using System;

namespace Práctica__Núm._6.Ejercicios
{
    class Ejercicio3
    {
        //Alberto Galdámez | 09-09-2019
        static void Main(string[] args)
        {
            Console.Write("Escriba la base: ");
            int basePrincipal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escriba el Exponente de la base: {0}^", basePrincipal);
            int exponente = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Exponente(basePrincipal, exponente));

            Console.ReadKey();
        }

        public static string Exponente(int basePrincipal, int exponentee)
        {
            int final = exponentee;
            string respuestaFinal = "";
            int proceso = 0;
            for(int inicio = 0; inicio <= final; inicio++)
            {

                proceso = basePrincipal * basePrincipal;


            }

            respuestaFinal = "Su respuesta es: " + proceso;
            return respuestaFinal;

        }


    }
}
