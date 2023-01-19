using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace ProjetGestionTaches.Models
{
    class Annuaire
    {
        readonly public GestionTachesContext context;
        public Annuaire(GestionTachesContext c)
        {
            context = c;
        }
        public GestionTachesContext GetContext() { return context; }
        public Utilisateur AddUtilisateur(String un, String n, String p)
        {
            Utilisateur newUser = new Utilisateur()
            {
                UserName = un, Nom = n, Prenom = p
            };
            context.Annuaire.Add(newUser);
            context.SaveChanges(); return newUser;
        }
        public Utilisateur GetUtilisateur(int id) 
        { 
            return context.Annuaire.Find(id);
        }
        public bool deleteUser(int id)
        {
            Utilisateur u = context.Annuaire.Find(id);
            if(u==null)
                return false;
            else
            {
                context.Annuaire.Remove(u);
                context.SaveChanges();
                return true;
            }
          
        }
        public void modifier(int id)
        {
            Utilisateur u = context.Annuaire.Find(id);
            Console.WriteLine(" Veuillez saisir 1 pour modifier le username, 2 pour le prenom,3 pour le nom et 0 pour tous les champs");
            int choix = int.Parse(Console.ReadLine());
            switch (choix)
            {
                case 0:
                    
                        Console.WriteLine(" Username" );
                        u.UserName =Console.ReadLine();
                        Console.WriteLine(" Prenom");
                        u.Prenom = Console.ReadLine();
                        Console.WriteLine(" Nom");
                        u.Nom = Console.ReadLine();
                    break;
                    
                case 1:
                    
                        Console.WriteLine(" Username");
                        u.UserName = Console.ReadLine();
                     break;
                    
                case 2:
                    
                        Console.WriteLine(" Prenom");
                    u.Prenom = Console.ReadLine();
                     break;

                case 3:
                    
                        Console.WriteLine(" Nom");
                        u.Nom = Console.ReadLine();
                     break;
                    
                default:
                    Console.WriteLine(" Choix non valide");
                    break;
                    

            }
            if(choix==0 || choix==1 || choix==2 || choix==3)
            {
                context.Attach(u).State = EntityState.Modified;
                context.SaveChanges();
            }

        }
    }
}