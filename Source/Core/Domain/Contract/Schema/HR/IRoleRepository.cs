using Domain.Concrete.Schema.HR;
using Domain.Contract.Base;
using ViewModels.Schema.HR;

namespace Domain.Contract.Schema.HR;

public interface IRoleRepository : IBaseRepository<Role>
{
    List<RoleViewModel> GetRoleViewModels();
}