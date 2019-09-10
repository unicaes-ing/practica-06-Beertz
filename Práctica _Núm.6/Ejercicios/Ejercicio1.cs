using System;

namespace Práctica__Núm._6
{
    //Alberto Galdámez | 06-09-2019
    class Ejercicio1
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba el numero de la tabla de multiplicar a generar: ");
            int numTabla = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---Color de Tabla----");
            Console.WriteLine("[1] Rojo");
            Console.WriteLine("[2] Azul"); 
            Console.WriteLine("[3] Verde");
            Console.WriteLine("[4] Amarillo");
            Console.Write("Elija el color de la tabla (Presione solo [Enter] para elegir el color pre-establecido: ");
            if (int.TryParse(Console.ReadLine(), out int numColor))
            {
                Console.Clear();
                Console.WriteLine(DevolverTabla(numTabla, numColor));
                Console.ReadKey();

            }
            else
            {
                Console.Clear();
                Console.WriteLine(DevolverTabla(numTabla));
                Console.ReadKey();

            }

        }

        static string DevolverTabla(int numeroTabla)
        {
            string tablaFinal = "";
            int num1 = 0;
            int num2 = numeroTabla;
            int final = 0;

            for (int inicio = 1; inicio <= 10; inicio++)
            {
                num1 = num1 + 1;
                final = num1 * num2;
                Console.WriteLine("{0} * {1} = {2}", num2, num1, final);
            }
            return tablaFinal;
        }



        static string DevolverTabla(int numeroTabla, int Color)
        {
            string tablaFinal = "";
            int num1 = 0;
            int num2 = numeroTabla;
            int final = 0;

            //Selecciona color.
            switch (Color)
            {
                case 1:

                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                case 2:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;

                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;

                case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;

            }


            for (int inicio = 1; inicio <= 10; inicio++)
            {
                num1 = num1 + 1;
                final = num1 * num2;
                Console.WriteLine("{0} * {1} = {2}", num2, num1, final);
            }
            return tablaFinal;
        }
    }
}
