using Domain.Concrete.Base;
using ViewModels.Schema.HR;

namespace Application.Contract.Base;


public interface IBaseRepository<T, TViewModel> where T : BaseEntity
                                                where TViewModel : IBaseViewModel
{
    /// <summary>
    /// افزودن موجودیت
    /// </summary>
    void Insert(T entity);


    /// <summary>
    /// آپدیت موجودیت
    /// </summary>
    void Update(T entity);

    /// <summary>
    /// حذف موجودیت
    /// </summary>
    void Delete(T entity);

    /// <summary>
    ///  بر اساس موجودیت اصلی واکشی همه اطلاعات
    /// </summary>
    /// <returns></returns>
    IQueryable<T> GetAll();

    public abstract List<TViewModel> GetViewModels();
    public abstract TViewModel ToViewModel(T entity);
    public abstract T ToEntity(TViewModel model);

}