using DataAccessLayer.Entity;
using DataAccessLayer.ViewModel;
using System.Collections.Generic;

namespace DataAccessLayer.Interface
{
    public interface ICrudDAL
    {
        void Create(AdminViewModel model);

        AdminViewModel Get(int id);

        IEnumerable<AdminViewModel> GetAll();

        void Edit(AdminViewModel model);

        void Delete(int id);

    }
}
