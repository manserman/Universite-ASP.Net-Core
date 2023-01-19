using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGestionTaches.Models
{ 
    internal class GestionnaireTaches
    {
        public Dictionary<int, Tache> dico { get; set; }
        public GestionnaireTaches()
        {
            dico= new Dictionary<int, Tache>();
        }
        public Tache AjouterTache(Utilisateur p, ElementRegistre e) {
            Random random = new Random();
            int PID = random.Next(50);
            while(dico.ContainsKey(PID))
                {
                PID = random.Next(50);

            }
            Tache tachee= new Tache(PID, p, e);
            dico.Add(PID, tachee);
            tachee.start();
            return tachee;

        }
        public Tache GetTache(int PID) {
            Tache tache;
            if (dico.TryGetValue(PID, out tache))
                { return tache; }
            else return null;
           }
        public int NbTaches() {
            return dico.Count;
        }

      
    }
}
