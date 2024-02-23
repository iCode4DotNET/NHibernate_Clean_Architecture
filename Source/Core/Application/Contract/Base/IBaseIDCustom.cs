using ViewModels.Schema.HR;

namespace Application.Contract.Base;

/// <summary>
/// متد های مربوط به موجودیت های خاص با کلید اصلی آیدی
/// </summary>
/// <typeparam name="TViewModel">کلاس ویو مدل مرتبط با کلاس موجودیت</typeparam>
public interface IBaseIDCustom<TViewModel> where TViewModel : IBaseViewModel
{
    /// <summary>
    /// دریافت مقدار بعدی با شرایط خاص . مثل داشتن کلید خارجی
    /// </summary>
    /// <param name="model">آبجکت ویومدل</param>
    long GetNextVal(TViewModel model);
}
