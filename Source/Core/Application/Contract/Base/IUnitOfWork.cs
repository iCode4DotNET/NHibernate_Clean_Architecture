
using Application.Contract.Schema.HR;

namespace Application.Contract.Base;

public interface IUnitOfWork : IDisposable
{
    void Commit();
    void RollBack();
    IRoleRepository RoleRepository { get; }
    IPersonRepository PersonRepository { get; }
    IShiftRepository ShiftRepository { get; }
}