using Domain.Concrete.Base;

namespace Domain.Contract.Base;


/// <summary>
/// متد های جنرال
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IBaseRepository<T> where T : BaseEntity
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
    ///   واکشی همه اطلاعات
    /// </summary>
    /// <returns></returns>
    IQueryable<T> GetAll();

    /// <summary>
    /// واکشی رکورد مورد نظر
    /// </summary>
    /// <param name="id">شناسه جدول</param>
    /// <returns></returns>
    T Get(int id);

}