using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Domain;

namespace EventSpace
{
    /// <summary>
    /// Class representing an event in the calendar system
    /// </summary>
    public class Event
    {
        /// <summary>
        /// Unique ID for this event
        /// </summary>
        public int id { get; set; }
        
        /// <summary>
        /// Title of this event 
        /// </summary>
        public string title { get; set; }
        
        /// <summary>
        /// Description for this event
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// Location of the event
        /// </summary>
        public latLng location;

        /// <summary>
        /// Start time of the event
        /// </summary>
        public DateTime start { get; set; }

        /// <summary>
        /// End time of the event
        /// </summary>
        public DateTime end { get; set; }

        /// <summary>
        /// All messages posted to this event
        /// </summary>
        public string[] messages;

        /// <summary>
        /// A list of users who are invited to the event
        /// </summary>
        public User[] userList;

        /// <summary>
        /// Constructor
        /// </summary>
        public Event() 
        { 
        }

        /// <summary>
        /// Immutable struct representing a latitude longitude
        /// </summary>
        public struct latLng
        {
            private readonly double latitude;
            private readonly double longitude;

            public double lat { get { return latitude; } }
            public double lng { get { return longitude; } }

            public latLng(double latitude, double longitude)
            {
                this.latitude = latitude;
                this.longitude = longitude;
            }

            public string toString()
            {
                return string.Format("{0},{1}", latitude, longitude);
            }
        }

        /// <summary>
        /// Method used for sending invitations to the registered users
        /// It should only send to those who have not yet received an invitation
        /// </summary>
        public void sendInvitations()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Method to send invitation to all users who have received an invitation,
        /// but have yet to reply
        /// </summary>
        public void resendInvitations()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Method to add a user to the 
        /// </summary>
        /// <param name="user">The user to add</param>
        public void addUser(User user)
        {
            throw new NotImplementedException();
        }

    }
}
