using CaseStudy.Entities.Concrete;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Interfaces
{
    public interface IBusService
    {
        Task<List<Bus>> GetBusAsync();
        Task<Bus> GetOneBusByIdAsync(int carID);
        Task<List<Bus>> GetBusByColorAsync(string colorName);
    }
}
