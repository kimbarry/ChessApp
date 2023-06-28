using ChessClubApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChessClubApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChessClassesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<ChessClassDto>> GetAllChessClasses()
        {
            return Ok(ChessClassDataStore.Current.Classes);
        }

        [HttpGet("{id}")]
        public ActionResult<ChessClassDto> GetChessClassById(int id)
        {
            var chessClassToReturn = ChessClassDataStore.Current.Classes.FirstOrDefault(c => c.Id == id);

            if (chessClassToReturn == null)
            {
                return NotFound();
            }
            return Ok(chessClassToReturn);
        }
    }
    
}
