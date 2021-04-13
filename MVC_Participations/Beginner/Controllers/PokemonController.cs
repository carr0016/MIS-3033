using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Beginner.Controllers
{
    public class PokemonController : Controller
    {
        // GET: Pokemon
        public ActionResult Index()
        {
            RandomChuckJokeAPI joke;

            using (var client = new HttpClient())
            {
                var json = client.GetStringAsync("https://api.chucknorris.io/jokes/random").Result;

                joke = JsonConvert.DeserializeObject<RandomChuckJokeAPI>(json);
            }
            return View();
        }
    }
}