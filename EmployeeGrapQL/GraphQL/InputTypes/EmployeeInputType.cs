using EmployeeGrapQL.Model;
using GraphQL.Types;

namespace EmployeeGrapQL.GraphQL.InputTypes
{
    public class EmployeeInputType : InputObjectGraphType<Employee>
    {
        public EmployeeInputType()
        {
            Field(a => a.FirstName, true);
            Field(a => a.LastName, true);
            Field(a => a.Email, true);
        }

    }
}
