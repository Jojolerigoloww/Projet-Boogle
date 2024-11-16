using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Boogle
{
    internal class Dictionnaire
    {
        private string langue;

        public Dictionnaire(string langue1)
        {
            this.langue = langue1;
        }

        public List<string> lecture()
        {
            List<string> list = new List<string>();
            string path = "";
            if (langue == "FR") { path = @"C:\Users\basti\Documents\A2\Algo\Projet Boogle\MotsPossiblesFR.txt"; }
            else if (langue == "EN") { path = @"C:\Users\basti\Documents\A2\Algo\Projet Boogle\MotsPossiblesEN.txt"; }
            else { return null; }
            using (StreamReader sr = new StreamReader(path))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    char[] charsToTrim = { ' ' };
                    string[] words = line.Split();
                    foreach (string word in words)
                        list.Add(word.TrimEnd(charsToTrim));
                }

            }
            foreach (string word in list) {Console.WriteLine(word); }
            return list;
        }
        
    }
}
