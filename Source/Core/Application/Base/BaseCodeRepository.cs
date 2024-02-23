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


    public byte GetNextVal()
    {
        byte result = 0;

        NextValAttribute? att = (NextValAttribute?)Attribute.GetCustomAttribute(typeof(T), typeof(NextValAttribute)) ??
            throw new Exception("The sequence attribute was not found.");

        var select = $"SELECT MAX(Code) FROM {att.Schema}.{att.Table}";

        var res = _session.CreateSQLQuery(select).List();

        var maxCode = res[0];

        if (maxCode is not null)
            result = (byte)((byte)maxCode + 1);
        else result = 1;

        return result;
        
    }

}