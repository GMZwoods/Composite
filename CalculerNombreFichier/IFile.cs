using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculerNombreFichier
{
    internal interface IFile
    {
         double CalculerTaille();
         int CalculerNbFichier();
    }
}
