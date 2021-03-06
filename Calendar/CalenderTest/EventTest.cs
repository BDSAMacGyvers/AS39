﻿using EventSpace;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Domain;

namespace CalenderTest
{
    
    
    /// <summary>
    ///This is a test class for EventTest and is intended
    ///to contain all EventTest Unit Tests
    ///</summary>
    [TestClass()]
    public class EventTest
    {
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Event Constructor
        ///</summary>
        [TestMethod()]
        public void EventConstructorTest()
        {
            Event target = new Event();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for addUser
        ///</summary>
        [TestMethod()]
        public void addUserTest()
        {

            Event target = new Event(); // TODO: Initialize to an appropriate value
            User user = new User(); // TODO: Initialize to an appropriate value
            
            // Initially empty
            Assert.AreEqual(0,target.userList.Length); 
            
            // Add one
            target.addUser(user);

            // Now +1
            Assert.AreEqual(1, target.userList.Length);

            // The inserted user now exists
            Assert.IsTrue(target.userList[1].Equals(user));

            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for sendInvitations
        ///</summary>
        [TestMethod()]
        public void sendInvitationsTest()
        {
            Event target = new Event();
            User user = new User();

            target.addUser(user);

            target.sendInvitations();

            Assert.IsTrue(user.Calendar.Invitations.Contains(target.getInvitation()));

        }

        /// <summary>
        ///A test for resendInvitations
        ///</summary>
        [TestMethod()]
        public void resendInvitationsTest()
        {
            Event target = new Event(); // TODO: Initialize to an appropriate value
            target.resendInvitations();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
