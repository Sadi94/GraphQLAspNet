using EmployeeGrapQL.Model;
using GraphQL.Types;

namespace EmployeeGrapQL.GraphQL.Type
{
    public class EmployeeType : ObjectGraphType<Employee>
    {
        public EmployeeType()
        {
            Field(a => a.FirstName);
            Field(a => a.LastName);
            Field(a => a.Email);

            Field(a => a.department, true, typeof(DepartmentType))
           .Resolve(a => a.Source.department);
        }
    }
}
