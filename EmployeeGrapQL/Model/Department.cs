namespace EmployeeGrapQL.Model
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public virtual Employee Employee { get; set; }
        public int EmployeeId { get; set; }
    }
}
