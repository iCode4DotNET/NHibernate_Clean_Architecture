using Domain.Contract.Base;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace BootCampManagement.EndPoint.MVCApp.Controllers;

public class PersonController(IUnitOfWork unitOfWork) : Controller
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public JsonResult Index()
    {
        var list = _unitOfWork.PersonRepository.GetAll();

        JsonSerializerOptions options = new()
        {
            ReferenceHandler = ReferenceHandler.IgnoreCycles,
            WriteIndented = true,
        };

        return Json(list,options);
    }

    public JsonResult Index2()
    {
        var list = _unitOfWork.PersonRepository.GetViewModels();
        return Json(list);
    }
}
