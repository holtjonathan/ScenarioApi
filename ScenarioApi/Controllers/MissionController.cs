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
    [Route("api/mission")]
    [ApiController]
    public class MissionController : ControllerBase
    {
        private readonly ScenarioContext _context;

        public MissionController(ScenarioContext context)
        {
            _context = context;
        }

        // GET: api/Mission/5
        [HttpGet("{scenarioId}")]
        public async Task<ActionResult<List<MissionReturn>>> GetMissions(int scenarioId)
        {
            var allMissionData = await (from m in _context.Missions
                                  join mt in _context.MissionTypes on m.TypeId equals mt.MissionTypeId
                                  join r in _context.Rewards on m.RewardId equals r.RewardId
                                  join tu in _context.TribeUpgrades on m.TribeUpgradeId equals tu.TribeUpgradeId into tuJoin
                                  from tuData in tuJoin.DefaultIfEmpty()
                                  join u in _context.Upgrades on tuData.UpgradeId equals u.UpgradeId into uJoin
                                  from uData in uJoin.DefaultIfEmpty()

                                  where m.ScenarioId == scenarioId
                                  select new MissionReturn
                                  {
                                      MissionId = m.MissionId,
                                      MissionName = m.MissionName,
                                      MissionDescription = m.Description,
                                      MissionTypeName = mt.Name,
                                      RewardDescription = r.Description,
                                      UpgradeName = uData.Name,
                                      UpgradeDescription = uData.Description
                                  }).ToListAsync();

            if (allMissionData == null)
                return NotFound();

            return allMissionData;
        }
    }
}
