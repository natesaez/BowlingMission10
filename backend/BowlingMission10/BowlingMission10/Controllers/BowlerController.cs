using BowlingMission10.data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BowlingMission10.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BowlersController : ControllerBase
{
    private BowlersDbContext _bowlerContext;

    public BowlersController(BowlersDbContext temp)
    {
        _bowlerContext = temp;
    }

    [HttpGet(Name = "GetBowlers")]
    public IActionResult Get()
    {
        var bowlerList = _bowlerContext.Bowlers
            .Include(b => b.Team)
            .Where(b => b.Team != null &&
                        (b.Team.TeamName == "Marlins" || b.Team.TeamName == "Sharks"))
            .Select(b => new
            {
                b.BowlerId,
                b.BowlerFirstName,
                b.BowlerMiddleInit,
                b.BowlerLastName,
                TeamName = b.Team!.TeamName,
                b.BowlerAddress,
                b.BowlerCity,
                b.BowlerState,
                b.BowlerZip,
                b.BowlerPhoneNumber
            })
            .ToList();

        return Ok(bowlerList);
    }
}