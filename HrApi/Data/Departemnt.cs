namespace HrApi.Data
{
    public class Departemnt
    {
        public int id { get; set; }

        public string  Name { get; set; }

        public virtual List<Employee> employees { get; set; }
    }
}
