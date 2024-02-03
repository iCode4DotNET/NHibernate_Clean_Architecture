using NHibernate;
using Application.Base;
using Domain.Concrete.Schema.HR;
using Domain.Contract.Schema.HR;

namespace Application.Schema.HR;

public class RoleRepository : BaseRepository<Role>, IRoleRepository
{
    public RoleRepository(ISession session) : base(session)
    {
    }
}