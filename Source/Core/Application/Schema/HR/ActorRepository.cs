using NHibernate;
using Application.Base;
using Domain.Concrete.Schema.HR;
using Domain.Contract.Schema.HR;
namespace Application.Schema.HR;

public class ActorRepository : BaseRepository<Actor>, IActorRepository
{
    public ActorRepository(ISession session) : base(session)
    {
    }
}
