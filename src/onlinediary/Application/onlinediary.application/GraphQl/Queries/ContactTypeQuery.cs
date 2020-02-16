using GraphQL.Types;
using onlinediary.application.GraphQl.Types;
using onlinediary.domain.Repository;

namespace onlinediary.application.GraphQl.Queries
{
    public class ContactTypeQuery : IFieldTypeBuilder
    {
        private readonly IContactRepository _contactRepository;

        public ContactTypeQuery(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public void Register(ObjectGraphType objectGraphType)
        {
            objectGraphType.Field<ListGraphType<ContactType>>
            (
                "contacts",
                "Return all contacts",
                resolve: context => _contactRepository.GetAll()
            );

            objectGraphType.Field<ContactType>
            (
                "contact",
                "Get contact by id",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>>{ Name = "id"}),
                resolve: context =>
                {
                    var id = context.GetArgument<long>("id");
                    return _contactRepository.GetById(id);
                }
            );
        }
    }
}