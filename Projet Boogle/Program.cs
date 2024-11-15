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
            try
            {
                string path = @"C:\Users\basti\Documents\A2\Algo\Projet Boogle\Lettres.txt";
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine("L'erreur suivante s'est produite : " + e.Message);
            }

            
            Console.ReadLine();
        }
    }
}
