using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using Domain.Concrete.Schema.HR;
using Domain.Contract.Base;

namespace BootCampManagement.EndPoint.MVCApp.Controllers
{
    public class RoleController(IUnitOfWork unitOfWork) : Controller
    {
        private readonly IUnitOfWork _unitOfWork = unitOfWork;

        public JsonResult Index()
        {
            var roles = _unitOfWork.RoleRepository.GetAll();

            JsonSerializerOptions options = new()
            {
                ReferenceHandler = ReferenceHandler.IgnoreCycles,
                WriteIndented = true,
            };

            return Json(roles, options);
        }

        public JsonResult Index2()
        {
            var roles = _unitOfWork.RoleRepository.GetViewModels();
            return Json(roles);
        }

        public JsonResult Get(byte id)
        {
            var role = _unitOfWork.RoleRepository.GetByCode(id);

            JsonSerializerOptions options = new()
            {
                ReferenceHandler = ReferenceHandler.IgnoreCycles,
                WriteIndented = true,
            };

            return Json(role, options);
        }

        public JsonResult GetPeople(byte id)
        {
            var role = _unitOfWork.RoleRepository.GetByCode(id);

            if (role is null)
            {
                return Json(BadRequest("شناسه مورد نظر معتبر نمیباشد"));
            }

            JsonSerializerOptions options = new()
            {
                ReferenceHandler = ReferenceHandler.IgnoreCycles,
                WriteIndented = true,
            };

            return Json(role.PersonList, options);
        }

        public IActionResult Create()
        {
            var role1 = new Role
            {
                Code = 3,
                Title = "Admin101"
            };

            var role2 = new Role
            {
                Code = 4,
                Title = "User201"
            };


            _unitOfWork.RoleRepository.Insert(role1);
            _unitOfWork.RoleRepository.Insert(role2);

            _unitOfWork.Commit();


            return Ok();
        }
    }
}