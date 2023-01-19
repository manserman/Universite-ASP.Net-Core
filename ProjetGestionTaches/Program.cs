using System;
using ProjetGestionTaches.Models;
namespace ProjetGestionTaches
{
    class Program
    {
        static void Main(string[] args)
        {
            GestionTachesContext context = new GestionTachesContext();
            Annuaire annuaire = new Annuaire(context);
            Registre registre = new Registre(context);
            String rep = "o";
            String userName, nom, prenom;
          
            System.Console.WriteLine("Liste des utilisateurs"); 
            foreach (Utilisateur u in context.Annuaire) 
            { 
                System.Console.WriteLine(u.ID + " : " + u.UserName + ", " + u.Nom + ", " + u.Prenom);
            }
            foreach (ElementRegistre u in context.Registre)
            {
                System.Console.WriteLine(u.ID + " : " + u.NomClasseExecutable + ", " + u.Description );
            }
           
            // Initialisation du modèle
            Annuaire AnnuaireUtilisateurs = new Annuaire(context);
            Registre BaseRegistres = new Registre(context);
            GestionnaireTaches GestionnaireTaches = new GestionnaireTaches();
            

            Utilisateur user;
            ElementRegistre entry;
            int num = 1;
            user = AnnuaireUtilisateurs.GetUtilisateur(1);
            entry = BaseRegistres.GetRegistreWindows(num.ToString());
            Tache tache = GestionnaireTaches.AjouterTache(user, entry);
            user = AnnuaireUtilisateurs.GetUtilisateur(2);
            num = 2;
            entry = BaseRegistres.GetRegistreWindows(num.ToString());
             tache = GestionnaireTaches.AjouterTache(user, entry);
           
            user = AnnuaireUtilisateurs.GetUtilisateur(3);
            num = 1;
            entry = BaseRegistres.GetRegistreWindows(num.ToString());
            tache = GestionnaireTaches.AjouterTache(user, entry);
           

           
            Console.ReadKey();
            
        }
    }
}