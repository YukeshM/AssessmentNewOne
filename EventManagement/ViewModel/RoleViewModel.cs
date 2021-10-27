using EventManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagement.ViewModel
{
    public class RoleViewModel
    {
        public RoleViewModel()
        {
            UserTbls = new HashSet<UserTbl>();
        }

        public int Id
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }

        public virtual ICollection<UserTbl> UserTbls
        {
            get; set;
        }
    }
}
