using AutoMapper;
using HrApi.Data;
using HrApi.Model;

namespace HrApi.Serves
{
    public class DepartemntServes:IDepartemntInterFace
    {
        HrContext context;
        IMapper mapper;
       public DepartemntServes(HrContext _context,IMapper _mapper) 
       {
            context = _context; 
            mapper = _mapper;
       }

        public void insert(DeptDto deptDto) 
        {
            Departemnt departemnt = new Departemnt();
            departemnt.Name=deptDto.Name;
            context.departemnts.Add(departemnt);
            context.SaveChanges();
        }

        public List<DeptDto> getDept() 
        {

            List<Departemnt> listDept = context.departemnts.ToList();

            List<DeptDto> deptDtos = mapper.Map<List<DeptDto>>(listDept);

            return deptDtos;
        }
    }
}
