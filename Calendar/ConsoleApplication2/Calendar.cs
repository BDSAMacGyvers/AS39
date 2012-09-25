using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventSpace;

namespace Domain
{
    class Calendar
    {
        private User ID { get;set; }  

        private HashSet<Event> events;

        private HashSet<User> viewedBy;

        private HashSet<Invitation> invitations;

        public void CreateEvent() { }

        public void DeleteEvent() { }

        public Event GetEvent(int id) { throw new NotImplementedException(); }

        public void Respond() { }

    }
}
