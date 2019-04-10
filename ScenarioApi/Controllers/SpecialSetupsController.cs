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
    [Route("api/specialsetup")]
    [ApiController]
    public class SpecialSetupsController : ControllerBase
    {
        private readonly ScenarioContext _context;

        public SpecialSetupsController(ScenarioContext context)
        {
            _context = context;
        }

        // GET: api/SpecialSetups
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SpecialSetups>>> GetSpecialSetups()
        {
            return await _context.SpecialSetups.ToListAsync();
        }


        [HttpGet("{scenarioId}")]
        public async Task<ActionResult<IEnumerable<Scenarios>>> GetSpecialSetup(int scenarioId)
        {
            var test = (from sr in _context.SpecialSetups
                        where sr.ScenarioId == scenarioId
                        select sr);

            return Ok(test);
            //return await _context.Scenarios.ToListAsync();
        }
    }
}
