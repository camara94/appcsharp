using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonjourDotNet
{
    class Program
    {
        static void MaMethode(ref int entier, string chaine)
        {
            Console.WriteLine(entier);

            Console.WriteLine(chaine);

            entier = 10;

            chaine = "10";

            Console.WriteLine(entier);

            Console.WriteLine(chaine);
        }

        static void Main(string[] args)
        {
            var mavariable = 51;

            var message = mavariable == 42 ? "Test réussi" : "Test Echoué";

            MaMethode(ref mavariable, message);

            Console.WriteLine(message);

            Console.WriteLine(mavariable);

            Console.ReadLine();
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }


            var j = 42;
            switch (j)
            {
                case 51:
                    {
                        Console.WriteLine("Il s'agissait de 51 !");
                        break;
                    }
                case 10:
                    {
                        Console.WriteLine("Il s'agissait de 10 !");
                        break;
                    }
                case 42:
                    {
                        Console.WriteLine("Il s'agissait de 42 !");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Autre valeur");
                        break;
                    }
            }

            Console.ReadLine();
        }


    }

}
