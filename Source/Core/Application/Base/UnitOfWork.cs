using NHibernate;
using Domain.Contract.Base;
using Domain.Contract.Schema.HR;
using Application.Schema.HR;

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