using GraphQL.Types;
using onlinediary.core.Models.Db;

namespace onlinediary.application.GraphQl.Types
{
    public class DiaryEventType : ObjectGraphType<DiaryEvent>
    {
        public DiaryEventType()
        {
            Field(t => t.Id);
            Field(t => t.Name);
            Field(t => t.Description);
            Field(t => t.EventDate);
            Field(t => t.EventDuration);
        }
    }
}