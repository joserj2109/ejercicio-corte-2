using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolanro2
{
    class Program
    {
        static void Main(string[] args)
        {
            string enlace = "";
            double estatura = 0.0;
            int edad = 0;
            int decision = 0;


            Console.WriteLine("¡hola! bienvenido/a");

            Console.WriteLine("¿Me podrias indicar tu edad? por favor. ");

            enlace = Console.ReadLine();

            edad = Convert.ToInt32(enlace);

            if (edad<18)
            { Console.WriteLine("Como eres menor de edad necesitas un representante para poder entrar. ¿Esta ahora tu representante contigo?");
                Console.WriteLine("Si es: NO:1 ---- SI:2");
               enlace = Console.ReadLine();
                decision = Convert.ToInt32(enlace);
                if (decision== 1)
                {
                    Console.WriteLine("Lo siento, no puedes entrar al parque hasta que vuelva tu representante.");
                      Console.ReadKey()
                        ;
                       }
                
                else
                { Console.WriteLine("¡Perfecto, bienvenido/a!"); }

            }
            else
            { Console.WriteLine("¡Perfecto, bienvenido/a!"); }
            Console.WriteLine("Por favor, indicame tu estatura en metros.");
            enlace = Console.ReadLine();
            estatura = Convert.ToDouble(enlace);


            if (estatura<160)

                { Console.WriteLine("Puedes entrar a las siguientes 4 atracciones: 1) Carrusel --- 2)Vuelta a la luna --- 3)Carritos chocones --- 4) Tirolina"); }
            else
            { Console.WriteLine("Puedes entrar a las siguientes 6 atracciones:1) Carrusel --- 2)Vuelta a la luna --- 3)Carritos chocones --- 4) Tirolina --- 5)Montaña rusa--- 6)El barco de la perdicion"); }
            Console.WriteLine("¡Que tengas un bien dia y disfrutes!");

            Console.ReadKey();



        }
    }
}
