using Domain.Contract.Base;
using Microsoft.AspNetCore.Mvc;

namespace BootCampManagement.EndPoint.MVCApp.Controllers;

public class CompanyController(IUnitOfWork unitOfWork) : Controller
{

    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    /*
    public JsonResult Index()
    {
        var list = _unitOfWork.CompanyRepository.GetAll();
        return Json(list);
    }
    */
}