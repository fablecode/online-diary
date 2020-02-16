using System.Collections.Generic;
using GraphQL.Types;
using onlinediary.application.GraphQl.Queries;

namespace onlinediary.application.GraphQl
{
    public partial class OnlineDiaryQuery : ObjectGraphType
    {
        public OnlineDiaryQuery(IEnumerable<IFieldTypeBuilder> fieldTypeObjectGraphTypes)
        {
            Name = "Online Diary";
            Description = "Online Diary queries";

            foreach (var fieldTypeObjectGraphType in fieldTypeObjectGraphTypes)
                fieldTypeObjectGraphType.Register(this);
        }
    }
}