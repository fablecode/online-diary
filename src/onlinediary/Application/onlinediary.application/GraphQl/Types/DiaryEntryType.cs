using GraphQL.Types;
using onlinediary.core.Models.Db;

namespace onlinediary.application.GraphQl.Types
{
    public class DiaryEntryType : ObjectGraphType<DiaryEntry>
    {
        public DiaryEntryType()
        {
            Field(t => t.Id);
            Field(t => t.EntryDate);
            Field(t => t.Title);
            Field(t => t.Text);
            Field(t => t.DateChanged);
        }
    }
}