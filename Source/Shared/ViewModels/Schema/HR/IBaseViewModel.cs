namespace ViewModels.Schema.HR;

public interface IBaseViewModel
{
    //https://www.ag-grid.com/

    // grid js , ...
    // SetColumnsForGrid ( size , type ( text , dropdown , date ), readonly  , visible )

    // id for front

    /// <summary>
    /// جهت استفاده در گرید جاوا اسکریپتی
    /// </summary>
    public int Id { get; set; }

}
