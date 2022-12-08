using EmployeeGrapQL.GraphQL.Query;
using GraphQL.Types;
using System.Xml.Linq;

namespace EmployeeGrapQL.GraphQL.GraphQLRoots
{
    public class RootQuery : ObjectGraphType
    {
        public RootQuery()
        {
            Name = "RootQuery";
            Field<EmployeeQuery>("employees", resolve: context => new { });
            Field<DepartmentQuery>("departments", resolve: context => new { });
        }
    }
}
