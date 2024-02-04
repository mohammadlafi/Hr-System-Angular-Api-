using AutoMapper;
using HrApi.Data;

namespace HrApi.Model
{

    [AutoMap(typeof(Departemnt), ReverseMap = true)]
    public class DeptDto
    {
        public int id { get; set; }

        public string Name { get; set; }

    }
}
