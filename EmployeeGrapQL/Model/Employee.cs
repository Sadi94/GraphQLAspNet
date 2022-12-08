using System.ComponentModel.DataAnnotations;

namespace EmployeeGrapQL.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }

        public virtual Department department { get; set; }
        public virtual EmployeeSalary EmployeeSalary { get; set; }
        public virtual IEnumerable<EmployeeSkill> EmployeeSkill { get; set; }

    }
}
