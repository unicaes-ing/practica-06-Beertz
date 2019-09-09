using System;


namespace Práctica__Núm._6.Ejercicios
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba un numero decimal: ");
            decimal enterNumero = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Su respuesta: ");
            Console.Write(Cadena(enterNumero));
            Console.ReadKey();
        }

        public static string Cadena(decimal numeroBase)
        {
            string cadenaCompletada = "";
            {

                if (numeroBase % 2 == 0)
                {
                    cadenaCompletada = cadenaCompletada + "0";

                }
                else
                {
                    cadenaCompletada = cadenaCompletada + "1";
                }
                
                return cadenaCompletada;
            }
        }
    }
}
