using Business.Interfaces;
using CaseStudy.Data;
using CaseStudy.Entities.Concrete;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class BoatService : IBoatService
    {
        private readonly AppDbContext _context;
        public BoatService(AppDbContext context)
        {
            _context = context;
        }


        public async Task<List<Boat>> GetBoatAsync()
        {
            var boats = await _context.Boats.ToListAsync();
            if (boats == null) return null;
            return boats;
 
        }

        public async Task<List<Boat>> GetBoatByColorAsync(string colorName)
        {
            var boat = await _context.Boats.Where(o => o.colorName == colorName).ToListAsync();
            if (boat.Count == 0) return null;
            return boat;
        }

        public async Task<Boat> GetOneBoatByIdAsync(int carID)
        {
            var boat = await _context.Boats.FindAsync(carID);
            if (boat == null) return null ;
            return boat;
        }
    }
}
