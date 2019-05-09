using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class A
{
    private int entier = 10;

    public int Entier
    {
        get
        {
            return this.entier;
        }

        set
        {
            if (value > 0)
                this.entier = value;
        }
    }
    public void MaMethode()
    {
        Console.WriteLine("Je viends de ma methode!");
    }
}

namespace CsharpPOO
{
    class A
    {
        int entier;

        public int Entier
        {
            get { return entier; }
            set { entier = value; }
        }

        public void FoisDeux(int entier2)
        {
            entier2 += entier2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var a = new A();
            a.Entier = 1;

            for (int i = 0; i <= 5; i++)
            {
                a.FoisDeux(a.Entier);
            }

            Console.WriteLine(a.Entier);
            Console.ReadLine();
        }
    }
}
  
