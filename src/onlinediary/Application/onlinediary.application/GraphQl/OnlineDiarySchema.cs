using GraphQL;
using GraphQL.Types;

namespace onlinediary.application.GraphQl
{
    public class OnlineDiarySchema : Schema
    {
        public OnlineDiarySchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<OnlineDiaryQuery>();
        }
    }
}