using AutoMapper;
using HrApi.Data;
using HrApi.Model;
using Microsoft.EntityFrameworkCore;

namespace HrApi.Serves
{
    public class EmployeeServes : IEmployeeInterFace
    {
        HrContext context;
        IMapper mapper;
        public EmployeeServes(HrContext _context, IMapper _mapper)
        {
            context = _context;
            mapper = _mapper;
        }

        public void insert(EmployeeDto employeeDto)
        {
            Employee employee = mapper.Map<Employee>(employeeDto);

            context.employees.Add(employee);

            context.SaveChanges();
        }

        public List<EmployeeDto> getUserBySearch(string FName)
        {

            List<Employee> listEmployee = context.employees.Where(e => e.FName == FName).ToList();

            List<EmployeeDto> listEmployeeDto = mapper.Map<List<EmployeeDto>>(listEmployee);

            return listEmployeeDto;
        }

        public void DeleteEmp(int id)



        {
            var emp = context.employees.Find(id);
            context.employees.Remove(emp);
            context.SaveChanges();
        }

        public EmployeeDto getEmpById(int id) 
        {
            Employee emp= context.employees.Where(e => e.id == id).FirstOrDefault();

            EmployeeDto empDto = mapper.Map < EmployeeDto>(emp);

            return empDto;
        }
        public void EditEmp(EmployeeDto employeeDto) 
        {
            Employee emp = mapper.Map<Employee>(employeeDto);

            context.employees.Attach(emp);

            context.Entry(emp).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            
            context.SaveChanges();  
        }
    }
}
