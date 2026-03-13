using Microsoft.AspNetCore.Mvc;

using BowlingMission10.data;
using BowlingMission10.data;
using Microsoft.AspNetCore.Mvc;

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
    public IEnumerable<Bowler> Get()
    {
        var bowlerList = _bowlerContext.Bowlers.ToList();
        return bowlerList;
    }
}
