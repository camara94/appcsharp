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
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.MaMethode();
            a.Entier = 9;
            Console.WriteLine(a.Entier);
            Console.ReadLine();

        }
    }
}
