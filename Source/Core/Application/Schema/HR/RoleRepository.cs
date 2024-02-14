using NHibernate;
using Application.Base;
using Domain.Concrete.Schema.HR;
using Domain.Contract.Schema.HR;
using ViewModels.Schema.HR;

namespace Application.Schema.HR;

public class RoleRepository : BaseRepository<Role>, IRoleRepository
{
    public RoleRepository(ISession session) : base(session)
    {
    }

    public List<RoleViewModel> GetRoleViewModels()
    {
        var result = _session.Query<Role>().ToList();

        var res2 = result.Select(x => new RoleViewModel
         {
             Code = x.Code,
             Title = x.Title,
         }).ToList();

        return res2;
    }
}