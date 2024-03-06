using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculerNombreFichier
{
    internal class Leaf : IFile
    {
        public string Nom { get; set; }
        public double Taille { get; set; }

        public Leaf(string nom, double taille) 
        {
            Nom = nom;
            Taille = taille;
        }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
        public override string ToString()
        {
            return base.ToString();
        }

        public double CalculerTaille()
        {
            return Taille;
        }

        public int CalculerNbFichier()
        {
            return 1;
        }
    }
}
