using HrApi.Model;

namespace HrApi.Serves
{
    public interface ICityInterFac
    {

        void inser(CityDto cityDto);

        List<CityDto> getCityDto();
        List<CityDto> getCityByChose(int country_id);

    }
}
