using Exo_ASP_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exo_ASP_MVC.Services
{
    public static class PokemonData
    {

        private static List<Pokemon> pokemons = new List<Pokemon>()
        {
            new Pokemon(1, 1, "Bulbizarre", "Il y a une graine sur son dos depuis sa naissance. Elle grossit un peu chaque jour."),
            new Pokemon(2, 25, "Pikachu", "Plus la puissance électrique de Pikachu est élevée, plus les poches de ses joues sont extensibles."),
            new Pokemon(3, 725, "Flamiaou", "Laissez ce Pokémon respirer ou il se renfermera sur lui-même. Même s'il devient affectueux, allez-y doucement avec les caresses.")
        };

        public static List<Pokemon> GetPokemonList()
        {
            return pokemons;
        }

        public static Pokemon GetPokemon(int id)
        {
            return pokemons.SingleOrDefault(p => p.Id == id);
        }

        public static void AddComment(int id, Commentaire commentaire)
        {
            commentaire.Date = DateTime.Now;
            pokemons.Single(p => p.Id == id).Commentaires.Add(commentaire);
        }
    }
}