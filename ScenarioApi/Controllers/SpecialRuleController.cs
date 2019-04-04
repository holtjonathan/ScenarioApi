using ScenarioApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScenarioApi.Controllers
{
    [Route("api/specialrule")]
    [ApiController]
    public class SpecialRulesController : ControllerBase
    {
        private readonly ScenarioContext _context;
        public SpecialRulesController(ScenarioContext context)
        {
            _context = context;
        }

        [HttpGet()]
        public async Task<ActionResult<IEnumerable<Scenarios>>> GetSpecialRules()
        {
            var test = (from sr in _context.SpecialRules
                        select sr);

            return Ok(test);
            //return await _context.Scenarios.ToListAsync();
        }
    }
}
