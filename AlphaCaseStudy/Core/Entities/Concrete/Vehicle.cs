using CaseStudy.Entities.Abstract;


namespace CaseStudy.Entities.Concrete
{
    public class Vehicle : IEntity
    {
        public int Id { get; set; } 
        public string colorName { get; set; }
    }
}
