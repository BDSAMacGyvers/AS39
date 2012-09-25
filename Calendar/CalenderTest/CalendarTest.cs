using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

namespace CalenderTest
{
    [TestClass]
    public class CalendarTest
    {
        Calendar cal;
        [TestInitialize]
        public void initialize()
        {
             cal = new Calendar();
        }

        [TestMethod]
        public void TestCreateEvent()
        {
            cal.CreateEvent();
        }

        [TestMethod]
        public void TestDeleteEvent()
        {
            var eventId = 22;
            cal.DeleteEvent(eventId);
        }

        [TestMethod]
        public void TestGetEvent()
        {
            var eventId = 22;
            cal.GetEvent(eventId);
        }

        [TestMethod]
        public void TestRespond()
        {

        }
    }
}
