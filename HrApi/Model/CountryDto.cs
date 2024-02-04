using AutoMapper;
using HrApi.Data;
using System.ComponentModel.DataAnnotations;

namespace HrApi.Model
{
    [AutoMap(typeof(Country), ReverseMap = true)]
    public class CountryDto
    {
        public int id { get; set; }

        [Required]
        public string Name { get; set; }
      
    }
}
