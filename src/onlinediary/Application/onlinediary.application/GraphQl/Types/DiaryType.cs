using GraphQL.Types;
using onlinediary.core.Models.Db;

namespace onlinediary.application.GraphQl.Types
{
    public class DiaryType : ObjectGraphType<Diary>
    {
        public DiaryType()
        {
            Field(t => t.Id);
            Field(t => t.Username);
            Field(t => t.FirstName);
            Field(t => t.LastName);
        }
    }
}