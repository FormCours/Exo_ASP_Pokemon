using Exo_ASP_MVC.Models;
using Exo_ASP_MVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exo_ASP_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           List<Pokemon> pokemons = PokemonData.GetPokemonList();

            return View(pokemons);
        }

        public ActionResult Detail(int id)
        {
            Pokemon pokemon = PokemonData.GetPokemon(id);

            if(pokemon == null)
            {
                return HttpNotFound();
            }

            return View(pokemon);
        }

        [HttpPost]
        public ActionResult Detail(int id, Commentaire commentaire)
        {
            PokemonData.AddComment(id, commentaire);

            return RedirectToAction(nameof(Detail), new { id = id });
        }
    }
}