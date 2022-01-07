using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBeautifulAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBeautifulAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        [HttpGet]
        public List<Player> Get(string country, string name)
        {
            List<Player> players = new List<Player>()
            {
                new Player() { Name = "Robert", Id = 1, Country = "Sweden", Score = 24 },
                new Player() { Name = "Winston", Id = 2, Country = "Germany", Score = -1 },
                new Player() { Name = "Leonard", Id = 3, Country = "Russia", Score = 100 }
            };

            if (!string.IsNullOrWhiteSpace(country))
            {
                players = players.Where(p => p.Country == country).ToList();
            }

            if (!string.IsNullOrWhiteSpace(name))
            {
                players = players.Where(p => p.Name == name).ToList();
            }

            return players;
        }
    }
}
