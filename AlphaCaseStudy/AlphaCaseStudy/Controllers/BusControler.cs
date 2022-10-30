using Business.Interfaces;
using CaseStudy.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CaseStudy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusController : ControllerBase
    {
        private readonly IBusService _busService;
        public BusController(IBusService busService)
        {
            _busService = busService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Bus>>> GetBuses()
        {
            var buses = await _busService.GetBusAsync();
            if (buses == null) return NotFound();
            return Ok(buses);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Bus>> GetBusById(int id)
        {
            var bus = await _busService.GetOneBusByIdAsync(id);
            if (bus == null) return NotFound();
            return Ok(bus);
        }
        [HttpGet("colorName")]
        public async Task<ActionResult<List<Bus>>> GetBusByColor(string colorName)
        {
            var bus = await _busService.GetBusByColorAsync(colorName);
            if (bus.Count == 0) return NotFound();
            return Ok(bus);
        }
    }
}
