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


        public AdminViewModel Get(int id)
        {
            try
            {
                var singleEventDetail = new AdminViewModel();
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


        public void Delete(int id)
        {
            try
            {
                _crudDAL.Delete(id);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
