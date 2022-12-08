using GraphQL.Types;

namespace EmployeeGrapQL.GraphQL.Type
{
    public class EmployeeSkillsType : ObjectGraphType<EmployeeSkill>
    {
        public EmployeeSkillsType()
        {
            Field(es => es.Name);
        }
    }
}
