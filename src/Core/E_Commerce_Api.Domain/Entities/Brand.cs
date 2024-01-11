using E_Commerce_Api.Domain.Common;

namespace E_Commerce_Api.Domain.Entities
{
    public class Brand:EntityBase
    {
        public Brand()
        {
            
        }
        public Brand(string name)
        {
            Name = name;
        }
        public  string Name { get; set; }

    }

}
