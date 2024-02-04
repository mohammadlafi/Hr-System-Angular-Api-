using AutoMapper;
using HrApi.Data;
using HrApi.Model;

namespace HrApi.Serves
{
    public class CityServes : ICityInterFac
    {
        IMapper mapper;
        HrContext context;
        public CityServes(HrContext _context, IMapper _mapper)
        {
            context = _context;
            mapper = _mapper;
        }

        public void inser(CityDto cityDto)
        {
            City city = new City();

            city.Name = cityDto.Name;
            city.country_id = cityDto.country_id;

            context.cities.Add(city);
            context.SaveChanges();
        }

        public List<CityDto> getCityDto()
        {
            List<City> listcity = context.cities.ToList();

            List<CityDto> cityDto = mapper.Map<List<CityDto>>(listcity);

            return cityDto;
        }

        public List<CityDto> getCityByChose(int country_id)
        {
            List<City> searchbycity = context.cities.Where(c => c.country_id == country_id).ToList();

            List<CityDto> listDto = mapper.Map<List<CityDto>>(searchbycity);

            return listDto;
            
        }

    }
}
