using Business.Interfaces;
using CaseStudy.Entities.Concrete;

using Microsoft.AspNetCore.Mvc;

namespace CaseStudy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoatController : ControllerBase
    {
        private readonly IBoatService _boatService;
        public BoatController(IBoatService boatService)
        {
            _boatService = boatService;
        }

        [HttpGet]
       public async Task<ActionResult<List<Boat>>> GetBoats()
        {
            var boats = await _boatService.GetBoatAsync();
            if (boats == null) return NotFound();
            return Ok(boats);

        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Boat>> GetBoatById(int id)
        {
            var boat = await _boatService.GetOneBoatByIdAsync(id);
            if (boat == null) return NotFound();
            return Ok(boat);
        }
        [HttpGet("colorname")]
        public async Task<ActionResult<List<Boat>>> GetBoatByColor(string colorName)
        {
            var boat = await _boatService.GetBoatByColorAsync(colorName);
            if (boat == null) return NotFound();
            return Ok(boat);
        }
    }
}
