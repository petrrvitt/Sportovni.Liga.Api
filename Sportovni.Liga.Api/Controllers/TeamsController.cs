using Microsoft.AspNetCore.Mvc;
using Sportovni.Liga.Api.Entities;

namespace Sportovni.Liga.Api.Controllers
{
    [ApiController]
    [Route("api/teams")]
    public class TeamsController : ControllerBase
    {
        private static readonly List<Team> _teams = new List<Team>
        {
            new Team {Id = 0, Name = "Florbal Hradec Králové"},
            new Team {Id = 1, Name = "FBC Dobruška"},
            new Team {Id = 2, Name = "FbK Kostelc nad Orlicí"}
        };

        [HttpGet]
        public ActionResult<List<Team>> GetAll()
        {
            return Ok(_teams);
        }

        [HttpGet("{id}")]
        public ActionResult<Team> GetById(int id)
        {
            foreach (var a in _teams)
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
