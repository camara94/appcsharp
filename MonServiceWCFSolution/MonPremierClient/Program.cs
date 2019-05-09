using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonPremierClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new ServiceReference1.Service1Client();
            String input = "";
            do
            {
                Console.WriteLine("Quel est le nom de l'objet dont vous voulez le prix : ");
                input = Console.ReadLine();
                if (input !="quit")
                    Console.WriteLine("Le prix de " + input + " est " + client.GetPrice(input) + " euro");
            } while (input != "quit");
            Console.ReadLine();
            client.Close();
           
        }
    }
}
