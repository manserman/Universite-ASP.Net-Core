using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetGestionTaches.Models
{ class Utilisateur 
    { 
        public int ID { get; set; } 
        [Required] 
        public String UserName { get; set; } 
        public String Nom { get; set; }
        public String Prenom { get; set; }
        public override string ToString() 
        { return ID + " : " + UserName + " ( " + Nom + " , " + Prenom + " )";
        }
        public static bool operator ==(Utilisateur utilisateur1, Utilisateur utilisateur2)
        {
            return (utilisateur1.UserName == utilisateur2.UserName);
        }
        public static bool operator !=(Utilisateur utilisateur1, Utilisateur utilisateur2)
        {
            return (utilisateur1.UserName != utilisateur2.UserName);
        }

    }
}