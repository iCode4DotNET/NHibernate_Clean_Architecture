using Application.Contract.Base;
using Domain.Concrete.Schema.HR;
using ViewModels.Schema.HR;

namespace Application.Contract.Schema.HR;

public interface IRoleRepository : IBaseCodeRepository<Role,RoleViewModel>
{
   
}
