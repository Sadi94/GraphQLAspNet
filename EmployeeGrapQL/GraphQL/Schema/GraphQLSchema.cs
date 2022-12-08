using EmployeeGrapQL.GraphQL.GraphQLRoots;
using GraphQL.Types;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace EmployeeGrapQL.GraphQL
{
    public class GraphQLSchema : Schema
    {
        public GraphQLSchema(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<RootQuery>();
            Mutation = serviceProvider.GetRequiredService<RootMutation>();
        }
    }
}
