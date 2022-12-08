using EmployeeGrapQL.Model;
using GraphQL.Types;

namespace EmployeeGrapQL.GraphQL.InputTypes
{
    public class EmployeeSalaryInputType : InputObjectGraphType<EmployeeSalary>
    {
        public EmployeeSalaryInputType()
        {
            Field(a => a.Salary);
        }
    }
}
