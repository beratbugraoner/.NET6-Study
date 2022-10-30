using Business.Interfaces;
using CaseStudy.Data;
using CaseStudy.Entities.Concrete;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class CarService : ICarService
    {
        private readonly AppDbContext _context;
        public CarService(AppDbContext context)
        {
            _context = context;
        }
        public async Task DeleteCarAsync(int carID)
        {
            var deleteCar = await _context.Cars.FindAsync(carID);
            if (deleteCar != null)
            {
                _context.Remove(deleteCar);
                await _context.SaveChangesAsync();
            }
           
        }

        public async Task<List<Car>> GetCarAsync()
        {
            var cars = await _context.Cars.ToListAsync();
            if (cars == null) return null;
            return cars;
        }

      
        public async Task<Car> GetCarByIdAsync(int carID)
        {
            var car = await _context.Cars.FindAsync(carID);
            if (car == null) return null;
            return car;
        }

        public async Task<List<Car>> GetCarByColorAsync(string colorName)
        {
            var car = await _context.Cars.Where(o => o.colorName == colorName).ToListAsync();
            if (car == null) return null;
            return car;
        }

        public async Task<Car> SwitchTheHeadlightsByIdAsync(int carID)
        {
            var car = await _context.Cars.FindAsync(carID);
            if (car == null) return null;
            car.headlight = !car.headlight;
            _context.Update(car);
            await _context.SaveChangesAsync();
            return car;

        }
    }
}
