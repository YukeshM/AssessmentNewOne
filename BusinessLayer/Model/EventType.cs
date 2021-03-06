using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Model
{
    public partial class EventType
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
