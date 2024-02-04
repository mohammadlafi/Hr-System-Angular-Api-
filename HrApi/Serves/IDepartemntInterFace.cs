using HrApi.Model;

namespace HrApi.Serves
{
    public interface IDepartemntInterFace
    {

        void insert(DeptDto deptDto);

        List<DeptDto> getDept();

    }
}
