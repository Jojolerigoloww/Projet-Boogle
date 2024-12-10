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
            List<string> dictionnaire = new List<string>();
            string path = "";
            if (langue == "FR") { path = @"MotsPossiblesFR.txt"; }
            else if (langue == "EN") { path = @"MotsPossiblesEN.txt"; }
            else { return null; }
            using (StreamReader sr = new StreamReader(path))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    char[] charsToTrim = { ' ' };
                    string[] words = line.Split();
                    foreach (string word in words) 
                    { 
                        dictionnaire.Add(word.TrimEnd(charsToTrim));
                        Console.WriteLine(word);
                    }          
                }
            }
            return dictionnaire;
        }
        
        //denjneiuvnriuv

        /*public string toString()
        {
            List<string> description = new List<string>();
            description = Dictionnaire.lecture();
        }*/

    }
}
