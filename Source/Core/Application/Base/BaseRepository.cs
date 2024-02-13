using NH = NHibernate;
using Domain.Concrete.Base;
using Domain.Contract.Base;

namespace Application.Base;

public abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
{
    private readonly NH.ISession _session;

    public BaseRepository(NH.ISession session)
    {
        _session = session;
    }

    public void Delete(T entity)
    {
        _session.Delete(entity);
    }

    public T Get(int id)
    {
        return _session.Get<T>(id);
    }

    public T Get(byte id)
    {
        return _session.Get<T>(id);
    }

    public IQueryable<T> GetAll()
    {
        return _session.Query<T>();
    }

    public void Insert(T entity)
    {
        _session.Save(entity);
    }

    public void Update(T entity)
    {
        _session.Update(entity);
    }
}
