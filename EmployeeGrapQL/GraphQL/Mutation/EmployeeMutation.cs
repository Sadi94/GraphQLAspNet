using EmployeeGrapQL.GenericRepo;
using EmployeeGrapQL.GenericRepo.Interface;
using EmployeeGrapQL.GraphQL.InputTypes;
using EmployeeGrapQL.GraphQL.Type;
using EmployeeGrapQL.Model;
using GraphQL;
using GraphQL.Types;

namespace EmployeeGrapQL.GraphQL.Mutation
{
    public class EmployeeMutation : ObjectGraphType
    {
        private readonly IGenericRepo<Employee> _employee;

        public EmployeeMutation(IGenericRepo<Employee> employee)
        {
            _employee = employee;
            FieldAsync<EmployeeType>(
            "CreateEmployee", "Create an employee",
            arguments: new QueryArguments(
            new QueryArgument<NonNullGraphType<EmployeeInputType>> { Name = "employee" }),

            resolve: async context =>
            {
                var employee = context.GetArgument<Employee>("employee");
                await _employee.AddItem(employee);
                return employee;
            });
        }
    }
}
