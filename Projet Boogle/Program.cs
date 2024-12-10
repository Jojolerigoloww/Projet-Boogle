using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Boogle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionnaire francais = new Dictionnaire("FR");
            francais.lecture();
            Console.ReadLine();
        }
    }
}
