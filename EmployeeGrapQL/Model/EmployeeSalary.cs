namespace EmployeeGrapQL.Model
{
    public class EmployeeSalary
    {
        public int Id { get; set; }
        public int Salary { get; set; }

        public virtual Employee Employee { get; set; }
        public int EmployeeId { get; set; }

    }
}
