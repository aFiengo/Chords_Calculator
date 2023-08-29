using ChordsCalculator.Logic.Managers;
using ChordsCalculator.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChordsCalculator.App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChordController : ControllerBase
    {
        private readonly ChordManager _chordManager;

        public ChordController()
        {
            _chordManager = new ChordManager();
        }

        [HttpGet]
        public ActionResult<Chord> GetChord(string root, string type)
        {
            var chord = _chordManager.CalculateChord(root, type);
            if (chord == null)
            {
                return BadRequest("Invalid root or type");
            }
            return Ok(chord);
        }
    }
}
