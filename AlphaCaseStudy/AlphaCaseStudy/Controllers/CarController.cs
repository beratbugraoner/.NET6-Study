using Business.Interfaces;
using Business.Services;
using CaseStudy.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CaseStudy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;
        public CarController(ICarService carService)
        {
            _carService = carService;
        }
        [HttpGet]
        public async Task<ActionResult<List<Car>>> GetCars()
        {
            var cars = await _carService.GetCarAsync();
            if (cars == null) return NotFound();
            return Ok(cars);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Car>> GetCarById(int id)
        {
            var car = await _carService.GetCarByIdAsync(id);
            if (car == null) return NotFound();
            return Ok(car);
        }
        [HttpGet("colorName")]
        public async Task<ActionResult<List<Car>>> GetCarByColor(string colorName)
        {
            var car = await _carService.GetCarByColorAsync(colorName);
            if (car.Count == 0) return NotFound();
            return Ok(car);
        }
        [HttpPost("changeHeadlightsByID")]
        public async Task<ActionResult<Car>> ChangeHeadlightsByCarId(int id)
        {
            var car = await _carService.SwitchTheHeadlightsByIdAsync(id);
            if (car == null) return NotFound();
            return Ok(car);
        }
        [HttpDelete]
        public async Task<ActionResult<Car>> DeleteCarById(int id)
        {
            await _carService.DeleteCarAsync(id);
            return Ok();
        }
    }
}
