using EventManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagement.ViewModel
{
    public class UserViewModel
    {
        public UserViewModel()
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
