using Domain.Concrete.Schema.HR;

namespace ViewModels.Schema.HR;

public class OrderViewModel : IBaseViewModel
{

    public OrderViewModel()
    {

    }


    #region [ Implicit Convert / Cast ]

    public static implicit operator Order(OrderViewModel model)
    {
        return new Order
        {
            Code = model.OrderNumber,
            OrderDate = model.OrderDate,
            ID = model.Id
        };
    }

    public static implicit operator OrderViewModel(Order entity)
    {
        return new OrderViewModel
        {
            Id = entity.ID,
            OrderDate = entity.OrderDate,
            OrderNumber = entity.Code
        };
    }

    #endregion

    public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public int RowIndex { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    /// <summary>
    /// کد یا شماره سفارش که به ازای بیزینس خاصی باید مقدار بعدی آن بدست بیاد
    /// </summary>
    public int OrderNumber { get; set; }

    public DateTime OrderDate { get; set; }


    public override string ToString()
    {
        return base.ToString();
    }
}