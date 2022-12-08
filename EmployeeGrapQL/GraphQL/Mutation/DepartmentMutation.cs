using EmployeeGrapQL.GenericRepo.Interface;
using EmployeeGrapQL.GraphQL.InputTypes;
using EmployeeGrapQL.GraphQL.Type;
using EmployeeGrapQL.Model;
using GraphQL;
using GraphQL.Types;

namespace EmployeeGrapQL.GraphQL.Mutation
{
    public class DepartmentMutation : ObjectGraphType
    {
        private readonly IGenericRepo<Department> _department;

        public DepartmentMutation(IGenericRepo<Department> department)
        {
            _department = department;

            FieldAsync<DepartmentType>("CreateDepartment", "create a department",
            arguments: new QueryArguments(new QueryArgument<NonNullGraphType<DepartmentInputType>> { Name = "department" }),

            resolve: async context =>
            {
                var department = context.GetArgument<Department>("department");
                await _department.AddItem(department);
                return department;
            });
        }
    }
}
