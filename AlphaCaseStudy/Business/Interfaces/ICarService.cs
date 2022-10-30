
using CaseStudy.Entities.Concrete;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface ICarService
    {
        Task<List<Car>> GetCarAsync();
        Task<Car> GetCarByIdAsync(int carID);
        Task<List<Car>> GetCarByColorAsync(string colorName);
        Task  DeleteCarAsync(int carID);
        Task<Car> SwitchTheHeadlightsByIdAsync(int carID);

    }
}
