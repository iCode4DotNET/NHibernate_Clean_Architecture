using Domain.Concrete.Base;
using ViewModels.Schema.HR;

namespace Application.Contract.Base;

public interface IBaseCodeRepository<T, TViewModel> : IBaseRepository<T,TViewModel> where T : BaseEntity 
                                                                                     where TViewModel : IBaseViewModel
{
    T GetByCode(byte code);


}
