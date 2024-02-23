using Application.Contract.Base;
using Domain.Concrete.Schema.HR;
using Microsoft.AspNetCore.Mvc;
using ViewModels.Schema.HR;

namespace BootCampManagement.EndPoint.MVCApp.Controllers;

//public class ShiftController(IUnitOfWork unitOfWork) : Controller
//{
//    private readonly IUnitOfWork _unitOfWork = unitOfWork;


//    public IActionResult Create()
//    {
//        var shift = new Shift
//        {
//            Code = _unitOfWork.ShiftRepository.GetNextVal(),
//            Title = "شیفت صبح",
//            Start = "10:30",
//            End = "15:30",
//        };

//        _unitOfWork.ShiftRepository.Insert(shift);  
//        _unitOfWork.Commit();

//        return Ok();
//    }
//}




public class ShiftController : CrudController<ShiftViewModel>
{
    public ShiftController(IUnitOfWork uow) : base(uow)
    {
    }

    [HttpGet]
    public override IActionResult Index()
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public override IActionResult Create([FromBody] ShiftViewModel model)
    {
       _uow.ShiftRepository.Insert(model);
        return Ok();
    }

    [HttpPost]
    public override IActionResult Delete([FromBody] ShiftViewModel model)
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public override IActionResult Edit([FromBody] ShiftViewModel model)
    {
        throw new NotImplementedException();
    }

}