using Domain.Concrete.Base;
using ViewModels.Schema.HR;

namespace Domain.Contract.Base;

public interface IBaseIDRepository<T, TViewModel> : IBaseRepository<T, TViewModel> where T : BaseEntity
                                                                                    where TViewModel : IBaseViewModel
{
    T GetByID(int id);
}