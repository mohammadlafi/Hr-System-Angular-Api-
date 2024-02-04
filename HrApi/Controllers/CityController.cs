using HrApi.Model;
using HrApi.Serves;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HrApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        ICityInterFac city;
        public CityController(ICityInterFac _city) 
        {
            city = _city;
        }

        [HttpPost]
        public void insert(CityDto cityDto) 
        {
            city.inser(cityDto);    
        }

        [HttpGet]
    
        public List<CityDto> getCityD() 
        {
            return city.getCityDto();   
        }

        
        [HttpGet]
        [Route("getCity")]
        public List<CityDto> getCityBySearch(int country_id)
        {
            return city.getCityByChose(country_id);
        }
    }
}
