using HrApi.Model;
using HrApi.Serves;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HrApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IEmployeeInterFace employeeInterFace;
        public EmployeeController(IEmployeeInterFace _empInter) 
        {
            employeeInterFace = _empInter;
        }

        [HttpPost]
        public  void insert(EmployeeDto employeeDto) 
        {
            employeeInterFace.insert(employeeDto);
        }

    

        [HttpGet]

        public List<EmployeeDto> getUserBySearch(string FName) 
        {
            return employeeInterFace.getUserBySearch(FName);
        }

        [HttpDelete]    
        public void Delete(int id) 
        {
            employeeInterFace.DeleteEmp(id);
        }

        [HttpGet]
        [Route("getEmp")]
        public EmployeeDto getEmployee(int id) 
        {
            return employeeInterFace.getEmpById(id);   
        }
        [HttpPut]
        public void EditEmp(EmployeeDto employeeDto) 
        {
            employeeInterFace.EditEmp(employeeDto);
        }

    }
}
