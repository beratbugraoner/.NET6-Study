
using CaseStudy.Entities.Concrete;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IBoatService
    {
        Task<List<Boat>> GetBoatAsync();
        Task<Boat> GetOneBoatByIdAsync(int carID);
        Task<List<Boat>> GetBoatByColorAsync(string colorName);
    }
}
