using Microsoft.AspNetCore.Mvc;
using Sportovni.Liga.Api.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sportovni.Liga.Api.Controllers
{
    [ApiController]
    [Route("api/players")]
    public class MatchesController : ControllerBase
    {
        private static readonly List<Match> _matches = new List<Match>
        {
            new Match {Id = 0, Date = DateTime.ParseExact("11.9.2026", "dd.MM.yyyy", null), Round = 1},
            new Match {Id = 0, Date = DateTime.ParseExact("24.9.2026", "dd.MM.yyyy", null), Round = 3},
            new Match {Id = 0, Date = DateTime.ParseExact("19.10.2026", "dd.MM.yyyy", null), Round = 7},
        };

        [HttpGet]
        public ActionResult<List<Match>> GetAll()
        {
            return Ok(_matches);
        }

        [HttpGet("{id}")]
        public ActionResult<Match> GetById(int id)
        {
            foreach (var a in _matches)
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