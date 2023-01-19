using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjetGestionTaches.Models
{
    internal class Registre
    {
         readonly public GestionTachesContext context;
        public Registre(GestionTachesContext c)
        {
            context = c;
        }
        public GestionTachesContext GetContext() { return context; }
        public ElementRegistre AddRegistre(String nomClasse, String description, string id)
        {
            ElementRegistre newRegistre = new ElementRegistre()
            {
                NomClasseExecutable = nomClasse, Description = description,ID=id,
            };
            context.Registre.Add(newRegistre);
            context.SaveChanges(); return newRegistre;
        }
        public ElementRegistre GetRegistreWindows(string id) 
        { 
            return context.Registre.Find(id);
        }
        public bool deleteRegistre(string id)
        {   
            ElementRegistre u= context.Registre.Find(id);
            if(u==null)
                return false;
            else
            {
                context.Registre.Remove(u);
                context.SaveChanges();
                return true;
            }
          
        }
        public void modifier(string id)
        {
            ElementRegistre u = context.Registre.Find(id);
            Console.WriteLine(" Veuillez saisir 1 pour modifier le nom de la classe, 2 pour la description, 0 pour tous les champs");
            int choix = int.Parse(Console.ReadLine());
            switch (choix)
            {
                case 0:
                    
                        Console.WriteLine(" Nom CLasse Excecutable" );
                        u.NomClasseExecutable =Console.ReadLine();
                        Console.WriteLine(" Description");
                        u.Description = Console.ReadLine();
                    break;
                    
                case 1:
                    
                        Console.WriteLine(" Nom CLasse Excecutable");
                        u.NomClasseExecutable = Console.ReadLine();
                     break;
                    
                case 2:
                    
                        Console.WriteLine(" Description");
                    u.Description = Console.ReadLine();
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
