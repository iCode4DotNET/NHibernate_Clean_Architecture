using Domain.Concrete.Base;
using Domain.Contract.Base;
using NH = NHibernate;
using ViewModels.Schema.HR;

namespace Application.Base;

public abstract class BaseRepository<T, TViewModel> : IBaseRepository<T, TViewModel> where T : BaseEntity
                                                                                      where TViewModel : IBaseViewModel
{
    protected readonly NH.ISession _session;

    public BaseRepository(NH.ISession session)
    {
        _session = session;
    }

    public void Delete(T entity)
    {
        _session.Delete(entity);
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

    public abstract bool IsValid(T entity);
    public abstract TViewModel ToViewModel(T entity);
    public abstract T ToEntity(TViewModel model);
    public abstract List<TViewModel> GetViewModels();

}