using NHibernate;
using Application.Base;
using Domain.Concrete.Schema.HR;
using Domain.Contract.Schema.HR;
namespace Application.Schema.HR;


public class PersonRepository : BaseRepository<Person>, IPersonRepository
{
    public PersonRepository(ISession session) : base(session)
    {
    }
}