using System.Collections.Generic;

namespace EventManagement.Models
{
    public class Role
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
