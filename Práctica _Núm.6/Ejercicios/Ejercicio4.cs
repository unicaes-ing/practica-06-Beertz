using System;


namespace Práctica__Núm._6.Ejercicios
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
        paso1:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----{Conversor de Decimal a Binario}----");
            Console.Write("Escriba el numero que se convertirá: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal numeroEntrada))
            {
                Console.WriteLine(Binario(numeroEntrada));
                Console.ReadKey();


            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Dato invalido");
                Console.ReadKey();
                goto paso1;
            }

        }

        public static string Binario(decimal numeroEntrada)
        {
            string cadena = "";
            if(numeroEntrada %2 == 0)
            {
                cadena = cadena + "0";

            }
            else
            {

                cadena = cadena + "0";
            }
            return cadena;
        }
    }
}
