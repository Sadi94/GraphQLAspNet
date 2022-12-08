using GraphQL.Types;

namespace EmployeeGrapQL.GraphQL.InputTypes
{
    public class EmployeeSkillsInputType : InputObjectGraphType<EmployeeSkill>
    {
        public EmployeeSkillsInputType()
        {
            Field(a => a.Name);
        }
    }
}
