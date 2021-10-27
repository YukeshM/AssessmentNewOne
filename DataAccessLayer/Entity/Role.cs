using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entity
{
    public partial class Role
    {
        public Role()
        {
            UserTbls = new HashSet<UserTbl>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<UserTbl> UserTbls { get; set; }
    }
}
