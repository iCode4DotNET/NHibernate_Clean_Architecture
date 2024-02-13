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
    private IActorRepository _actorRepository = null!;
    private ICompanyRepository _companyRepository = null!;


    public IPersonRepository PersonRepository
    {
        get
        {
            _personRepository ??= new PersonRepository(_session);
            return _personRepository;
        }
    }

    public IActorRepository ActorRepository
    {
        get
        {
            _actorRepository ??= new ActorRepository(_session);
            return _actorRepository;
        }
    }

    public ICompanyRepository CompanyRepository
    {
        get
        {
            _companyRepository ??= new CompanyRepository(_session);
            return _companyRepository;
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