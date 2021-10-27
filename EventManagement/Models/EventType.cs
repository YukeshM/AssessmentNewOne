using System.Collections.Generic;

namespace EventManagement.Models
{
    public class EventType
    {
        public EventType()
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

        public virtual ICollection<Event> Events
        {
            get; set;
        }
    }
}
