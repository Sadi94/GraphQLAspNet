using EmployeeGrapQL.Model;

namespace EmployeeGrapQL
{
    public class EmployeeSkill
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }
      
    }
}
