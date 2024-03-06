using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculerNombreFichier
{ /// <summary>
/// Composite = Repertoire or "files"
/// </summary>
    internal class Composite : IFile
    {
        public string Nom { get; set; }
        public List<IFile> ListeDeFichier { get; set; } = new List<IFile>();    

  
        public Composite(string nom) 
        {
            Nom = nom;
        }

        public double CalculerTaille()
        {
            double resultat = 0;

            foreach (IFile file in ListeDeFichier) 
            {
                resultat += file.CalculerTaille();
            }
            return resultat;
        }

        public int CalculerNbFichier()
        {
            return ListeDeFichier.Count;
        }

        public void Add(IFile a) 
        {
            ListeDeFichier.Add(a);
        }
        public void Remove(IFile a)
        {
            ListeDeFichier.Remove(a);
        }
        /// <summary>
        /// besoin dexplication 
        /// </summary>
        public void GetChildren()
        {
            try
            {
                string[] files = Directory.GetFiles(Nom); // Get all files in the directory

                foreach (string file in files)
                {
                    Console.WriteLine(file); // Display file path (you can do anything with it here)
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching files: " + ex.Message);
            }
        }
    }

}
    


}
