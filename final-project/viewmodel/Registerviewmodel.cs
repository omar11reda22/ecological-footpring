using final_project.Models;

namespace final_project.viewmodel
{
    public class Registerviewmodel
    {
        public IEnumerable<Country> countries { get; set; }
        public IEnumerable<City> cities { get; set; }
        public IEnumerable<Governorate> governorates { get; set; }
    }
}
