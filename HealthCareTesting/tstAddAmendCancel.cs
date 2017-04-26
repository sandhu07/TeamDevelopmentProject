using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;

namespace HealthCareTesting
{
    [TestClass]
    public class tstAddAmendCancel
    {
        public DateTime DateAdded { get; private set; }

        [TestMethod]
        public void AppointmentInstantOk()
        {
            //create an instance of class
            clsAppointment ACompany = new clsAppointment();
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class
            clsAppointment ABooking = new clsAppointment();
             string TestData = "01/01/0000";
            //assign a value to the variable
            ABooking.DateAdded = DateAdded;
            //test date added
            Assert.AreEqual(ABooking.DateAdded, TestData);
        }

        [TestMethod]
        public void EmailPropertyMax()
        {
            //create an instance of class
            clsAppointment ABooking = new clsAppointment();
            string Email;
            //assign a value to the variable
            Email = "p13225578@myemail.dmu.ac.uk";
            ABooking.Email = Email;

            Assert.AreEqual(ABooking.Email, Email);
        }
    }
}