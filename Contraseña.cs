using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jueves190123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Adivinar la contraseña
            int pass, cont, intentos=2023;
            pass = 2023;
            cont = 0;
            while (cont <=3 ) 
            {
                Console.WriteLine("Digite la contraseña");
                pass=int.Parse(Console.ReadLine());
                if (pass == intentos)
                {
                    Console.WriteLine("La contraseña es correcta");
                    break;
                }
                else 
                { 
                    Console.WriteLine("Contraseña incorrecta.");
                    cont++;
                }
                if (cont==3) 
                {
                    Console.WriteLine("Ha superado el numero de intentos!!");
                    
                }
            }

            Console.ReadKey();
        }
    }
}
