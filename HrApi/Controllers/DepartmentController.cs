using HrApi.Model;
using HrApi.Serves;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HrApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        IDepartemntInterFace departemnt;
        public DepartmentController(IDepartemntInterFace departemntInter) 
        {
            departemnt = departemntInter;
        }

        [HttpPost]
        public void insert(DeptDto deptDto) 
        {
            departemnt.insert(deptDto);
        }

        [HttpGet]
        public List<DeptDto> getDeot()
        {
            return departemnt.getDept();
        }
    }
}
