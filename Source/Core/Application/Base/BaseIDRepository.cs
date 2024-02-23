using NHibernate;
using Application.Contract.Base;
using Domain.Concrete.Base;
using ViewModels.Schema.HR;

namespace Application.Base;


// class MehranClass : BaseIDRepository<T, TViewModel>


public abstract class BaseIDRepository<T, TViewModel> : BaseRepository<T, TViewModel>,
                                                        IBaseIDRepository<T, TViewModel> where T : BaseEntity
                                                                                         where TViewModel : IBaseViewModel
{
    protected BaseIDRepository(ISession session) : base(session)
    {
    }

    public T GetByID(int id)
    {
        return _session.Get<T>(id);
    }
}