using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Model
{
    public partial class Role
    {
        public Role()
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
