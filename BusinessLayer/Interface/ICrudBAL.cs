
using DataAccessLayer.Entity;
using DataAccessLayer.ViewModel;
//using BusinessLayer.Model;
using System.Collections.Generic;

namespace BusinessLayer.Interface
{
    public interface ICrudBAL
    {
        void Create(AdminViewModel model);

        AdminViewModel Get(int id);

        IEnumerable<AdminViewModel> GetAll();

        void Edit(AdminViewModel model);

        void Delete(int id);
    }
}
