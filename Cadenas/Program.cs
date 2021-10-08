using System;
using System.Collections.Generic;
using System.Text;

namespace Cadenas
{
    class Program
    {
        static void Main(string[] args)
        {

            string cadena;

            Console.WriteLine("Escriba una frase: ");
            cadena = Console.ReadLine();

            char[] separador = { ' ', ',' };
            string[] palabras = cadena.Split(separador);
            int i;
            for (i = 0; i < palabras.Length; i++) 
            {

                Console.WriteLine("palabra {0}={1}  ",(i+1), palabras[i]);
            }
            Console.ReadKey();
        }
        
        

    }
			



	
    
}
