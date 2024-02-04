using HrApi.Model;

namespace HrApi.Serves
{
    public interface IEmployeeInterFace
    {
        void insert(EmployeeDto employeeDto);

        List<EmployeeDto> getUserBySearch(string FName);

        void DeleteEmp(int id);

        EmployeeDto getEmpById(int id);

        void EditEmp(EmployeeDto employeeDto);
    }
}
