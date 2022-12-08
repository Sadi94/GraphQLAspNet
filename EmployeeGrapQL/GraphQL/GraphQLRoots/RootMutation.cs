using EmployeeGrapQL.GraphQL.Mutation;
using GraphQL.Types;
using System.Xml.Linq;

namespace EmployeeGrapQL.GraphQL.GraphQLRoots
{
    public class RootMutation : ObjectGraphType
    {
        public RootMutation()
        {
            Name = "RootMutation";
            Field<EmployeeMutation>("employees", resolve: context => new { });
            Field<DepartmentMutation>("departments", resolve: context => new { });
        }

    }
}
