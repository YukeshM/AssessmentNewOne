using BusinessLayer.Interface;
//using BusinessLayer.Model;
using DataAccessLayer.Entity;
using DataAccessLayer.Interface;
using DataAccessLayer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.Method
{
    public class CrudBAL : ICrudBAL
    {
        private readonly ICrudDAL _crudDAL;
        public CrudBAL(ICrudDAL crudBAL)
        {
            this._crudDAL = crudBAL;
        }

        public void Create(AdminViewModel model)
        {
            try
            {
                _crudDAL.Create(model);
            }
            catch (Exception)
            {

                throw;
            }
        }


        public Event Get(int id)
        {
            try
            {
                var singleEventDetail = new Event();
                return singleEventDetail = _crudDAL.Get(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<AdminViewModel> GetAll()
        {
            try
            {
                var eventList = new List<AdminViewModel>();
                return eventList = _crudDAL.GetAll().ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Edit(AdminViewModel model)
        {
            try
            {
                _crudDAL.Edit(model);
            }
            catch (Exception)
            {

                throw;
            }
        }


        public void Delete(AdminViewModel model)
        {
            try
            {
                _crudDAL.Delete(model);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
