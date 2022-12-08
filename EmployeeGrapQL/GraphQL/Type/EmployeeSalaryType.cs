using EmployeeGrapQL.Model;
using GraphQL.Types;

namespace EmployeeGrapQL.GraphQL.Type
{
    public class EmployeeSalaryType : ObjectGraphType<EmployeeSalary>
    {
        public EmployeeSalaryType()
        {
            Field(a => a.Salary);
        }
    }
}
