using Application.Contract.Base;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ViewModels.Schema.HR;

namespace BootCampManagement.EndPoint.MVCApp.Controllers;


/// <summary>
/// ادامه دارد....
/// </summary>
public class BaseController : Controller
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        base.OnActionExecuting(context);
    }

    public override void OnActionExecuted(ActionExecutedContext context)
    {
        base.OnActionExecuted(context);
    }
}



public abstract class CrudController<TViewModel>(IUnitOfWork uow) : BaseController where TViewModel : IBaseViewModel
{
    protected readonly IUnitOfWork _uow = uow;

    [HttpGet]
    public abstract IActionResult Index();

    [HttpPost]
    public abstract IActionResult Create([FromBody] TViewModel model);

    [HttpPost]
    public abstract IActionResult Edit([FromBody] TViewModel model);

    [HttpPost]
    public abstract IActionResult Delete([FromBody] TViewModel model);
}
