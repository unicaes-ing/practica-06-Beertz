using System;

namespace Práctica_Núm4.Ejerccicios
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba el ancho de la figura: ");
            decimal anchoMain = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Escriba el alto de de la Figura: ");
            decimal altoMain = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Eliga la figura con cual se hará la grafica " +
                "\n(Deje en blanco para usar la figura premeditada): ");
            string figura = Console.ReadLine();

            if (figura == "")
            {
                Console.WriteLine("\n---Su Figura-----\n");
                for (int cuentaLineas = 1; cuentaLineas <= altoMain; cuentaLineas++)
                {

                    Console.WriteLine(Dibujar(anchoMain));
                }
                Console.ReadKey();
            }
            else
            {
                //Se le otorgan las variables
                Console.WriteLine("\n---Su Figura-----\n");
                for (int cuentaLineas = 1; cuentaLineas <= altoMain; cuentaLineas++)
                {
                    Console.WriteLine(Dibujar(anchoMain, figura));

                }
                Console.ReadKey();
            }
        }

        public static string Dibujar(decimal figura)
        {
            string ancho = "";
            for (int i = 1; i <= figura; i++)
            {
                ancho = ancho + "*";
            }

            return ancho;
        }

        public static string Dibujar(decimal figura, string elegirFigura)
        {
            string ancho = elegirFigura;
            for (int i = 1; i <= figura; i++)
            {
                ancho = ancho + elegirFigura;

            }

            return ancho;
        }
    }
}

