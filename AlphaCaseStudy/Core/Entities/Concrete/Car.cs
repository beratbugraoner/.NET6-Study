using CaseStudy.Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace CaseStudy.Entities.Concrete
{
    public class Car : Vehicle, IHeadlight, IWheels
    {
       
        public int Wheels { get ; set ; }
        public bool headlight { get; set; }
    }
}
