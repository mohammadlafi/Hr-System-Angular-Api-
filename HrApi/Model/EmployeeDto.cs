using HrApi.Data;
using System.ComponentModel.DataAnnotations.Schema;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace HrApi.Model
{
    [AutoMap(typeof(Employee), ReverseMap = true)]
    public class EmployeeDto
    {
        public int id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Phone { get; set; }
        public DateTime Bod { get; set; }
        public int country_id { get; set; }
        public int city_id { get; set; }
        public int Dept_id { get; set; }

        public CountryDto? country { get; set; }

        public DeptDto? departemnt { get; set; }
           
        public CityDto? city { get; set; }

        public IFormFile ?FormPic { get; set; }

        public string ?ImageName { get; set; }
    }
}
