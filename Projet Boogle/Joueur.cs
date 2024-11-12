using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Boogle
{
    internal class Joueur
    {
        private string nom;
        private int score;
        private string[] mots;

        public Joueur(string nom1, int score1, string[] mots1)
        {
            this.nom = nom1;
            this.score = score1;
            this.mots = mots1;
        }

        public bool Contain(string mot)
        {
            bool b = false;
            for (int i = 0; i < mots.Length; i++)
            {
                if (mot == mots[i]) { b = true; break; }
            }
            return b;
        }

        public void Add_Mot(string mot)
        {

        }
    }
}
