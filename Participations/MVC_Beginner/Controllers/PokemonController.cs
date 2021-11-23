using MVC_Beginner.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace MVC_Beginner.Controllers
{
    public class PokemonController : Controller
    {
        // GET: Pokemon
        public ActionResult Index()
        {
            PokemonApi allpokemon;

            using (var client = new HttpClient())
            {
                var json = client.GetStringAsync("https://pokeapi.co/api/v2/pokemon?offset=0&limit=1100").Result;
                allpokemon = JsonConvert.DeserializeObject<PokemonApi>(json);
            }


            return View(allpokemon.results);
        }
        public ActionResult Info(string id)
        {
            Pokemoninfo info;

            using (var client = new HttpClient())
            {
                var json = client.GetStringAsync($"https://pokeapi.co/api/v2/pokemon/{id}").Result;
                info = JsonConvert.DeserializeObject<Pokemoninfo>(json);
            }


            return View(info);


        }
    }
}