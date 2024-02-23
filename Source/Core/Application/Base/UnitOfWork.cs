using Application.Contract.Base;
using Application.Contract.Schema.HR;
using Application.Schema.HR;
using NHibernate;

namespace Application.Base;

public class UnitOfWork : IUnitOfWork
{

    private readonly ISessionFactory _sessionFactory;

    private readonly ITransaction _transaction;

    private readonly ISession _session;

    public UnitOfWork(ISessionFactory sessionFactory)
    {
        _sessionFactory = sessionFactory;

        _session = _sessionFactory.OpenSession();

        _transaction = _session.BeginTransaction();
    }

    private IRoleRepository _roleRepository = null!;
    private IPersonRepository _personRepository = null!;
    private IShiftRepository _shiftRepository = null!;



    public IPersonRepository PersonRepository
    {
        get
        {
            _personRepository ??= new PersonRepository(_session);
            return _personRepository;
        }
    }

    public IRoleRepository RoleRepository
    {
        get
        {
            _roleRepository ??= new RoleRepository(_session);
            return _roleRepository;
        }
    }

    public IShiftRepository ShiftRepository
    {
        get
        {
            _shiftRepository ??= new ShiftRepository(_session);
            return _shiftRepository;
        }
    }

    public void Commit()
    {
        if (!_transaction.IsActive)
        {
            throw new InvalidOperationException("No active transation");
        }

        _transaction.Commit();
    }

    public void Dispose()
    {
        if (_session.IsOpen)
        {
            _session.Close();
        }
    }

    public void RollBack()
    {
        if (_transaction.IsActive)
        {
            _transaction.Rollback();
        }
    }
}