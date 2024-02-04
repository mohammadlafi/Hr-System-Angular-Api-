using System.ComponentModel.DataAnnotations.Schema;

namespace HrApi.Data
{
    
    public class City
    {
        public int id { get; set; }

        public string Name { get; set; }
        
        public virtual Country country { get; set; }

        [ForeignKey("country")]
        public int country_id { get; set; }
        public virtual List<Employee> employees { get; set; }
    }
}
