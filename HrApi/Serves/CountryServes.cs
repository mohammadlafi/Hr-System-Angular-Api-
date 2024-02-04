using HrApi.Data;
using HrApi.Model;

namespace HrApi.Serves
{
    public class CountryServes:ICountryeInterFace
    {
        HrContext context;
        public CountryServes(HrContext _context) 
        { 
        context=_context;
        }  

        public void insert(CountryDto countryDto) 
        {
            Country country = new Country();

            country.Name = countryDto.Name;
            

            context.countries.Add(country);
            context.SaveChanges();
        
        }

        public List<CountryDto> getCountry() 
        {
            List<Country> listCountry = context.countries.ToList();

            List<CountryDto> listCountryD=new List<CountryDto>();

            foreach(var item in listCountry) 
            {
                CountryDto countryDto = new CountryDto();

                countryDto.Name = item.Name;
                countryDto.id = item.id;

                listCountryD.Add(countryDto);
            }

            return listCountryD;

        }

    }
}
   