using NHibernate;
using Domain.Concrete.Base;
using ViewModels.Schema.HR;
using Application.Contract.Base;


namespace Application.Base;

public abstract class BaseCodeRepository<T, TViewModel> : BaseRepository<T, TViewModel>,
                                                          IBaseCodeRepository<T, TViewModel> where T : BaseEntity
                                                                                           where TViewModel : IBaseViewModel
{
    protected BaseCodeRepository(ISession session) : base(session)
    {
    }

    public T GetByCode(byte code)
    {
        return _session.Get<T>(code);
    }

    /// <summary>
    /// max + 1
    /// </summary>
    public abstract byte GetNextValue();

}