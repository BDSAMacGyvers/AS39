using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventSpace;

namespace Domain
{
    public class Calendar
    {
        private User ID { get;set; }  

        private HashSet<Event> events;

        private HashSet<User> viewedBy;

        public HashSet<Invitation> Invitations;

        public Calendar()
        {
        }

        public bool CreateEvent() {throw new NotImplementedException(); return true; }

        public void DeleteEvent(int eventId) { throw new NotImplementedException(); }
        
        public Event GetEvent(int id) { throw new NotImplementedException(); }

        public Event GetEvent(int id)
        {
            throw new NotImplementedException();
            //return new Event(); 
        }

        public void Respond() { throw new NotImplementedException(); }

    }
}
