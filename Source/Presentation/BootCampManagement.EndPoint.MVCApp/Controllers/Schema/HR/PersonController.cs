using Application.Contract.Base;
using Domain.Concrete.Schema.HR;
using Microsoft.AspNetCore.Mvc;
using NHibernate;
using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;
using NH = NHibernate;

namespace BootCampManagement.EndPoint.MVCApp.Controllers;

public class PersonController(IUnitOfWork unitOfWork , NH.ISession session) : Controller
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    protected readonly NH.ISession _session = session;

    public JsonResult Index()
    {
        var list = _unitOfWork.PersonRepository.GetAll();

        JsonSerializerOptions options = new()
        {
            ReferenceHandler = ReferenceHandler.IgnoreCycles,
            WriteIndented = true,
        };

        return Json(list, options);
    }

    public JsonResult Index2()
    {
        var list = _unitOfWork.PersonRepository.GetViewModels();
        return Json(list);
    }

    public JsonResult Index3()
    {
        var list = _session.Query<VW_AllActor>().ToList();  
        return Json(list);
    }













    public JsonResult Index4()
    {
        IQuery query = _session.GetNamedQuery("usp_actor_selectAll");

        IList<VW_AllActor> actors = query.List<VW_AllActor>();

        return Json(actors);
    }




    public JsonResult Index5()
    {
        IQuery query = _session.GetNamedQuery("usp_actor_selectByDate");

        query.SetDateTime("DateFrom", new DateTime(2000,1,1));
        query.SetDateTime("DateTo", new DateTime(2024, 1, 1));

        IList<VW_AllActor> actors = query.List<VW_AllActor>();
        return Json(actors);
    }



    public JsonResult Index6()
    {
        var cmd = "EXEC dbo.usp_actor_selectByDate @DateFrom = '2024-02-21', @DateTo = '2024-02-21'";
        IQuery query = _session.CreateSQLQuery(cmd);
        var actors = query.List();
        return Json(actors);
    }  
}

