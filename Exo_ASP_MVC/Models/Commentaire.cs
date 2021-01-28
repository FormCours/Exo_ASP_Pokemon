using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exo_ASP_MVC.Models
{
    public class Commentaire
    {
        public string Auteur { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
    }
}