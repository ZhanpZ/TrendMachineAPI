using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrendMachineAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace TrendMachineAPI.Controllers
{
    [Route("api/[controller]")]
    //[Route("api/[controller/[action]")]
    [ApiController]
    public class GameInfoController : ControllerBase
    {
        /*
        private static List<GameInfo> gameinfos = new List<GameInfo>
            {
                new GameInfo {
                    Id = 1,
                    Name = "Witcher 3",
                    FirstName = "Witcher",
                    LastName = "3"
                },
                new GameInfo {
                    Id = 2,
                    Name = "Elden Ring",
                    FirstName = "Elden",
                    LastName = "Ring"
                }
            };
        */

        private readonly TrendMachineDBContext _context;

        public GameInfoController(TrendMachineDBContext context)
        {
            _context = context;
        }
        
        /*
        //GET: api/GameInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GameInfo>>> GetGames()
        {
            return await _context.gametrend.ToListAsync();
        }
        */

        //Model
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GameInfo>>> GetGames()
        {
            var gif = await _context.gametrend.ToListAsync();
            return Ok(new GameTrendResponse
            { 
                StatusCode = "200",
                Description = "GET Success",
                gametrend = gif
                }
                );
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<GameInfo>> Get(int id)
        {
            var gameinfo = await _context.gametrend.FindAsync(id);


            //if (gameinfo == null)
            //    return BadRequest("not found.");


            if (gameinfo == null)
                {
                return BadRequest(new GameTrendResponse
                {
                    StatusCode = "400",
                    Description = "Invalid GameTrend Item",
                });
            }

            return Ok(new GameTrendResponse
            {
                StatusCode = "200",
                Description = "GET by  Success",
                GameInfo = gameinfo
            }
            );
        }


        [HttpPost]
        public async Task<ActionResult<List<GameInfo>>> AddGame(GameInfo gameinfo)
        {
            if (gameinfo == null)
            {
                return BadRequest(new GameTrendResponse
                {
                    StatusCode = "400",
                    Description = "Invalid GameTrend object",
                });
            }


            //_context.gametrend.Add(gameinfo);
            //await _context.SaveChangesAsync();

            //return Ok(await _context.gametrend.ToListAsync());

            var gif = await _context.AddAsync(gameinfo);
            await _context.SaveChangesAsync();
            return Ok(new GameTrendResponse
            {
                StatusCode = "200", 
                Description = "Success Post",
                GameInfo = gif.Entity
            }
                );
        }

        /*
        [HttpPut("{id}")]
        public async Task<ActionResult<List<GameInfo>>> UpdateGame(GameInfo request)
        {
            var dbgameinfo = await _context.gametrend.FindAsync(request.id);
            if (dbgameinfo == null)
                return BadRequest("not found.");

            dbgameinfo.Name = request.Name;
            dbgameinfo.Peak_Num = request.Peak_Num;
            dbgameinfo.Net_Income = request.Net_Income;
            
            await _context.SaveChangesAsync();

            return Ok(await _context.gametrend.ToListAsync());
        }
        */

        [HttpDelete("{id}")]
        public async Task<ActionResult<GameInfo>> Delete(int id)
        {
            var dbgameinfo = await _context.gametrend.FindAsync(id);
            //if (dbgameinfo == null)
            //    return BadRequest("not found.");

            if (dbgameinfo == null)
            {
                return BadRequest(new GameTrendResponse
                {
                    StatusCode = "400",
                    Description = "Invalid GameTrend Item Delete by id",
                });
            }


            _context.gametrend.Remove(dbgameinfo);
            await _context.SaveChangesAsync();

            //return Ok(await _context.gametrend.ToListAsync());
            return Ok(new GameTrendResponse
            {
                StatusCode = "200",
                Description = "Successful deleted item"
            }) ;
        }
        

    }
}
