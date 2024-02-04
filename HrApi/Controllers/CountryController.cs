using HrApi.Data;
using HrApi.Model;
using HrApi.Serves;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HrApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    
    public class CountryController : ControllerBase
    {

        ICountryeInterFace country;
        public CountryController(ICountryeInterFace _country) 
        { 
            country= _country;  
        }

        [HttpPost]
        public void insert(CountryDto countryDto)
        {
            country.insert(countryDto);
        }


        [HttpGet]
        public List<CountryDto> getCountry() 
        {
            return country.getCountry();
        }

    }
}
