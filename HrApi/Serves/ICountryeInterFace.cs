using HrApi.Model;

namespace HrApi.Serves
{
    public interface ICountryeInterFace
    {
        public void insert(CountryDto countryDto);

        List<CountryDto> getCountry();


    }
}
