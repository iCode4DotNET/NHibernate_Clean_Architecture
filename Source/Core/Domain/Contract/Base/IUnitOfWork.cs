using Domain.Contract.Schema.HR;

namespace Domain.Contract.Base;

public interface IUnitOfWork : IDisposable
{
    void Commit();
    void RollBack();
    IRoleRepository RoleRepository { get; }
    IPersonRepository PersonRepository { get; }
}
