using Microsoft.AspNetCore.Mvc;
using Sportovni.Liga.Api.Entities;

namespace Sportovni.Liga.Api.Controllers
{
    [ApiController]
    [Route("api/players")]
    public class PlayersController : ControllerBase
    {
        private static readonly List<Player> _players = new List<Player>
        {
            new Player {Id = 0, Name = "Adam Hála", JerseyNumber = 42},
            new Player {Id = 1, Name = "Vít Veverka", JerseyNumber = 67},
            new Player {Id = 2, Name = "Ivo Vykydal", JerseyNumber = 69}
        };

        [HttpGet]
        public ActionResult<List<Player>> GetAll()
        {
            return Ok(_players);
        }

        [HttpGet("{id}")]
        public ActionResult<Player> GetById(int id)
        {
            foreach (var a in _players)
            {
                if (a.Id == id)
                {
                    return Ok(a); // povedlo se najít, vrátím 200
                }
            }
            return NotFound();
        }
    }
}