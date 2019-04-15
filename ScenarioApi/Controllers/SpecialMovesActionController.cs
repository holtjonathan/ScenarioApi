using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScenarioApi.Models;

namespace ScenarioApi.Controllers
{
    [Route("api/specialmoveaction")]
    [ApiController]
    public class SpecialMovesActionController : ControllerBase
    {
        private readonly ScenarioContext _context;

        public SpecialMovesActionController(ScenarioContext context)
        {
            _context = context;
        }

        // GET: api/SpecialMovesAction/5
        [HttpGet("{scenarioId}")]
        public async Task<ActionResult<SpecialMovesActions>> GetSpecialMovesActions(int scenarioId)
        {
            var test = (from sr in _context.SpecialMovesActions
                        where sr.ScenarioId == scenarioId
                        select sr);

            return Ok(test);
        }
    }
}
