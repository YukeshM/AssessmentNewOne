using BusinessLayer.Interface;
using DataAccessLayer.Entity;
using DataAccessLayer.ViewModel;
//using BusinessLayer.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EventManagement.Controllers
{
    public class EntryController : Controller
    {
        private readonly ICrudBAL _crudBAL;
        public EntryController(ICrudBAL crudBAL)
        {
            this._crudBAL = crudBAL;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(AdminViewModel model)
        {
            
                _crudBAL.Create(model);
                return RedirectToAction("GetAll", "Entry");
               
        }

        [HttpGet]
        public IActionResult Get(int id)
        {

            if (id != 0)
            {
                var singleEventDetail = _crudBAL.Get(id);
                return View(singleEventDetail);
            }
            return View();
            
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<AdminViewModel> Events = _crudBAL.GetAll();
            return View(Events);
        }

        //[HttpGet]
        //public IActionResult Edit(int id)
        //{
        //    if (id != 0)
        //    {
        //        var singleEventDetail = _crudBAL.Get(id);
        //        return View(singleEventDetail);
        //    }
        //    return View();
        //}

        [HttpGet]
        public IActionResult Edit(AdminViewModel model)
        {           
                _crudBAL.Edit(model);
                return RedirectToAction("GetAll", "Entry");          
        }

        public IActionResult Delete(AdminViewModel model)
        {         
                _crudBAL.Delete(model);
                return RedirectToAction("GetAll", "Entry");           
        }
    }
}
