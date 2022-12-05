/*
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrendMachineAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace TrendMachineAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameInfosssController : ControllerBase
    {
        private readonly TrendMachineDBContext _context;

        public GameInfosssController(TrendMachineDBContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<List<GameInfosss>>> AddGameInfo(GameInfosss gameinfo)
        {
            _context.gameinfos.Add(gameinfo);
            await _context.SaveChangesAsync();

            return Ok(await _context.gameinfos.ToListAsync());
        }

    }
}
*/