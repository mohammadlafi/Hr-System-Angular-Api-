using System.ComponentModel.DataAnnotations.Schema;

namespace HrApi.Data
{
    public class Employee
    {
        public int id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Phone { get; set; }
        public DateTime Bod { get; set; }
        public virtual Country country { get; set; }

        [ForeignKey("country")]
        public int country_id { get; set; }
        public virtual City city { get; set; }

        [ForeignKey("city")]
        public int city_id { get; set; }
        public virtual Departemnt departemnt  { get; set;}

        [ForeignKey("departemnt")]
        public int Dept_id { get; set; }

        public string ? ImageName { get; set; }

    }
}
