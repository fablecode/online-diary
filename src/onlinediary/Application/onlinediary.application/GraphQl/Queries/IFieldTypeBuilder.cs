using GraphQL.Types;

namespace onlinediary.application.GraphQl.Queries
{
    public interface IFieldTypeBuilder
    {
        void Register(ObjectGraphType objectGraphType);
    }
}