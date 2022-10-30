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
    public class BusService : IBusService
    {
        private readonly AppDbContext _context;
        public BusService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Bus>> GetBusAsync()
        {
            var buses = await _context.Buses.ToListAsync();
            if (buses == null) return null;
            return buses;
        }



        public async Task<List<Bus>> GetBusByColorAsync(string colorName)
        {
            var buses = await _context.Buses.Where(o => o.colorName == colorName).ToListAsync();
            if (buses == null) return null;
            return buses;
        }

        public async Task<Bus> GetOneBusByIdAsync(int carID)
        {
            var bus = await _context.Buses.FindAsync(carID);
            if (bus == null) return null;
            return bus;
        }
    }
}
