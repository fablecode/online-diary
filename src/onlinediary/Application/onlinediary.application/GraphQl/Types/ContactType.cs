using GraphQL.Types;
using onlinediary.core.Models.Db;

namespace onlinediary.application.GraphQl.Types
{
    public class ContactType : ObjectGraphType<Contact>
    {
        public ContactType()
        {
            Field(t => t.Id);
            Field(t => t.FirstName);
            Field(t => t.LastName);
            Field(t => t.Telephone);
            Field(t => t.MobilePhone);
            Field(t => t.Email);
            Field(t => t.AddressLine1);
            Field(t => t.City);
            Field(t => t.State);
            Field(t => t.PostalCode);
        }
    }
}