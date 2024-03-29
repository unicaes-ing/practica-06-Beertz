﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica__Núm._6.Ejercicios
{
    //Alberto Galdámez | 07-09-2019
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            //Proceso
            Console.Write("Escriba el ancho de la figura: ");
            decimal anchoMain = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Escriba el alto de de la Figura: ");
            decimal altoMain = Convert.ToDecimal(Console.ReadLine());
            Console.Write("\nEliga la figura con cual se hará la grafica " +
            "(Deje en blanco para usar la figura premeditada): ");
            string figura = Console.ReadLine();
            Console.WriteLine("\n---Escriba las coordenadas para mostrar su figura en ellas (Escriba 0 para dejar las coordenadas de predeterminadas): ");
            Console.Write("X: ");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y: ");
            int Y = Convert.ToInt32(Console.ReadLine());

            if (X == 0 && Y == 0)
            {

                if (figura == "")
                {
                    Console.WriteLine("\n---Su Figura-----\n");
                    for (int cuentaLineas = 1; cuentaLineas <= altoMain; cuentaLineas++)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
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
                        
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Dibujar(anchoMain, figura));
                    }
                    Console.ReadKey();
                }

            }
            
            if(X > 0 && Y >0)
            {
                if (figura == "")
                {
                    Console.WriteLine("\n---Su Figura-----\n");
                    for (int cuentaLineas = 1; cuentaLineas <= altoMain; cuentaLineas++)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(X, Y);
                        Console.ForegroundColor = ConsoleColor.Red;
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
                        Console.Clear();
                        Console.SetCursorPosition(X, Y);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Dibujar(anchoMain, figura));
                    }
                    Console.ReadKey();
                }
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
