using NHibernate;
using Domain.Concrete.Base;
using Domain.Contract.Base;
using ViewModels.Schema.HR;

namespace Application.Base;

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