using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exo_ASP_MVC.Models
{
    public class Pokemon
    {
        public int Id { get; set; }

        public int Numero { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }

        public List<Commentaire> Commentaires { get; set; }


        public Pokemon()
        {
            Commentaires = new List<Commentaire>();
        }

        public Pokemon(int id, int numero, string nom, string description)
            :this()
        {
            this.Id = id;
            this.Numero = numero;
            this.Nom = nom;
            this.Description = description;
        }
    }
}