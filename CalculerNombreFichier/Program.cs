

using CalculerNombreFichier;

namespace PatronConceptComposite 
{
    internal class program 
    {
        public static void main(String[] args) 
        {
            // 2e branche
            Leaf f3 = new Leaf("Dossier 3", 2);
            Leaf f4 = new Leaf("Dossier 4", 2);

            Composite c111 = new Composite("Répertoire 3");
            c111.Add(f3); c111.Add(f4);

            Leaf f5 = new Leaf("Dossier 5", 2);
            Leaf f6 = new Leaf("Dossier 6", 2);
            Leaf f7 = new Leaf("Dossier 7", 2);
            // 2e branche
            Composite c112 = new Composite("repertoire 4");
            c112.Add(f5); c112.Add(f6);

            // 1re branche
            Composite c110 = new Composite("Répertoire 1");            
            c110.Add(f7); c110.Add(c112); c110.Add(c111);

            Leaf f8 = new Leaf("Dossier 8", 2);
            Leaf f9 = new Leaf("Dossier 9", 2);
            Leaf f10 = new Leaf("Dossier 10", 2);

            // 1re branche
            Composite c113 = new Composite("Répertoire 5");
            Composite c114 = new Composite("Répertoire 6");
            Composite c109 = new Composite("Répertoire 2");

            c113.Add(f8);
            c114.Add(f9); c114.Add(f10);
            c109.Add(c113); c113.Add(c114);
            
            //Racine
            Composite C = new Composite("C:");
            Leaf f1 = new Leaf("Dossier 1", 2);
            Leaf f2 = new Leaf("Dossier 2", 2);
            C.Add(f1); C.Add(f2);
            C.Add(c109); C.Add(c110);
        }


    }

}







