using Domain.Concrete.Base;
using ViewModels.Schema.HR;

namespace Domain.Contract.Base;

public interface IBaseCodeRepository<T, TViewModel> : IBaseRepository<T, TViewModel> where T : BaseEntity
                                                                                     where TViewModel : IBaseViewModel
{
    T GetByCode(byte code);
}