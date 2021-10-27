using System;
using System.Collections.Generic;

namespace EventManagement.Models
{
    public class UserTbl
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
