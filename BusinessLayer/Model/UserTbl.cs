using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Model
{
    public partial class UserTbl
    {
        public UserTbl()
        {
            Events = new HashSet<Event>();
        }

        public int Id
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public DateTime Dob
        {
            get; set;
        }
        public string PhoneNo
        {
            get; set;
        }
        public string City
        {
            get; set;
        }
        public int? RoleId
        {
            get; set;
        }

        public virtual Role Role
        {
            get; set;
        }
        public virtual ICollection<Event> Events
        {
            get; set;
        }
    }
}
