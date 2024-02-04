using AutoMapper;
using HrApi.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace HrApi.Model
{

    [AutoMap(typeof(City), ReverseMap = true)]
    public class CityDto
    {
        public int id { get; set; }

        public string Name { get; set; }
        public int country_id { get; set; }
  
    }
}
