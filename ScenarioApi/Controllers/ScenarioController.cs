﻿using ScenarioApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScenarioApi.Controllers
{
    [Route("api/scenario")]
    [ApiController]
    public class ScenarioController : ControllerBase
    {
        private readonly ScenarioContext _context;
        public ScenarioController(ScenarioContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Scenarios>>> GetScenarios()
        {
            var test = (from s in _context.Scenarios
                        select new
                        {
                            s.ScenarioId,
                            s.Name,
                            s.Slug,
                            s.Description
                        });

            return Ok(test);
            //return await _context.Scenarios.ToListAsync();
        }

    }
}