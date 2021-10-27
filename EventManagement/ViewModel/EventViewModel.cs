using EventManagement.Models;
using System;

namespace EventManagement.ViewModel
{
    public class EventViewModel
    {
        public int Id
        {
            get; set;
        }
        public int? UserId
        {
            get; set;
        }
        public int? EventTypeId
        {
            get; set;
        }
        public string Title
        {
            get; set;
        }
        public string Description
        {
            get; set;
        }
        public string Address
        {
            get; set;
        }
        public string City
        {
            get; set;
        }
        public string Owner
        {
            get; set;
        }
        public DateTime StartDateTime
        {
            get; set;
        }
        public DateTime EndDateTime
        {
            get; set;
        }
        public DateTime CreatedAt
        {
            get; set;
        }

        public virtual EventTypeViewModel EventType
        {
            get; set;
        }
        public virtual UserTbl User
        {
            get; set;
        }
    }
}
