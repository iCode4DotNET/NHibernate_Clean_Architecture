using Domain.Concrete.Base;

namespace Domain.Concrete.Schema.HR;

public class Order : BaseEntity
{

    public Order()
    {
            
    }


    /// <summary>
    /// کلید فنی
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// کد یا شماره سفارش که به ازای بیزینس خاصی باید مقدار بعدی آن بدست بیاد
    /// </summary>
    public int Code { get; set; }

    public DateTime OrderDate { get; set; }

    public override bool IsEntityValid()
    {
        throw new NotImplementedException();
    }


    public override string ToString()
    {
        return base.ToString();
    }
}