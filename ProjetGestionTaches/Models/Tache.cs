using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ProjetGestionTaches.Models
{
    internal class Tache
    {
        public int PID { get; set; }
        Utilisateur Propriétaire { get; set; }
        ElementRegistre Entry { get; set; }
        public Tache()
        {
            PID = 0;
            Propriétaire = new Utilisateur();
            Entry=new ElementRegistre();

        }
        public Tache(int pid, Utilisateur prop, ElementRegistre registre)
        {
            PID = pid;
            Propriétaire = prop;
            Entry = registre;

        }
        public void start()
        {
            Word word ;
            Edge edge;
            String nomClasse = Entry.NomClasseExecutable;
            
            // Récupération d’un tableau avec tous les types de l’application
            Type[] lesTypes = Assembly.GetCallingAssembly().GetTypes();
            foreach (Type t in lesTypes)
            {
                if (nomClasse == t.Name)
                {
                    if(nomClasse=="Edge")
                    {

                        edge= (Edge)Activator.CreateInstance(t);
                        edge.PID = PID;
                        new Thread(new ThreadStart(edge.EdgeExe)).Start();
                        
                    }
                    else if (nomClasse == "Word")
                    {
                        word=(Word)Activator.CreateInstance(t);
                        word.PID = PID;
                        new Thread(new ThreadStart(word.WinWordExe)).Start();


                    }

                }
            }


        }
      
    }
}
