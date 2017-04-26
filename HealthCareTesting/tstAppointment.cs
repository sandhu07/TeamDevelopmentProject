using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;

namespace HealthCareTesting
{
    /// <summary>
    /// Summary description for tstAppointment
    /// </summary>
    [TestClass]
    public class tstAppointment
    {
        public tstAppointment()
        {
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void AppointmentInstanceOK()
        {
            clsAppointment NewPage = new clsAppointment();
            Assert.IsNotNull(NewPage);
        }

        [TestMethod]
        public void BookingNoMax()
        {
            clsAppointment NewPage = new clsAppointment();
            Int32 BookingDate;
            BookingDate = 123;
            NewPage.DateCount = BookingDate;
            Assert.AreEqual(BookingDate, NewPage.DateCount);
        }

        [TestMethod]
        public void DateAdded_ExtremeMin()
        {
            clsAppointment NewPage = new clsAppointment();
            string UserPostCode;
            string UserDate;
            Boolean AllOk = false;
            UserPostCode = "";
            UserDate = "12/12/2016";
            NewPage.Valid(UserPostCode, UserDate);
            Assert.IsFalse(AllOk);
        }

        [TestMethod]
        //used to test the current validation of the appointment method
        public void ValidAppointmentName()
        {
            //create an instance of the class
            clsAppointment ACounty = new clsAppointment();
            ACounty.Valid("Leicester");
        }

        [TestMethod]
        //used to test the current validation of the appointment method
        public void CountyMinLessOne()
        {
            //create an instance of the class
            clsAppointment UserCounty = new clsAppointment();
            //create a variable to record the results executed by the validation test
            Boolean OK;
            //test the validation method with a blank string
            OK = UserCounty.Valid("");
            //return the outcome which should be false
            Assert.IsFalse(OK);
        }

        [TestMethod]
        //used to test the current validation of the appointment method
        public void FindAppointmentMethodOK()
        {
            //create an instance of the class
            clsAppointment AMedical = new clsAppointment();
              //create an instance of the class
              clsAppointment AnAppointment = new clsAppointment();
            //create a variable to record the results executed by the validation test
              Boolean Found = true;
            //test the validation method with a blank string
             Int32 AppointmentNo = 1;
            //return the outcome which should be false
            Found = AnAppointment.Find(AppointmentNo);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        //used to test the current validation of the appointment method
        public void DateAddedMinLessOne()
        {
            //create an instance of the class
            clsMedical AMedical = new clsMedical();
            //create an instance of the class
             clsAppointment AnAppointment = new clsAppointment();
            //create a variable to record the results executed by the validation test
              Boolean OK = false;
            //test the validation method with a blank string
              string AppointmentName = "Some Appointment";
            //return the outcome which should be false
              DateTime TestDate;
              TestDate = DateTime.Now.Date;
            //convert time variable
              TestDate = TestDate.AddDays(-1);
            //invoke method
              OK = AnAppointment.Valid(AppointmentName);
            //test to see correct
             Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsAppointment AnAppointment = new clsAppointment();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string AppointmentNo = "1";
            string PatientName = "some name";
            string AppointmentName = "Check Up";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            OK = AnAppointment.Valid(AppointmentNo, PatientName, AppointmentName, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsAppointment AnAppointment = new clsAppointment();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string AppointmentNo = "1";
            string PatientName = "some name";
            string AppointmentName = "Check Up";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            OK = AnAppointment.Valid(AppointmentNo, PatientName, AppointmentName, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsAppointment AnAppointment = new clsAppointment();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string AppointmentNo = "1";
            string PatientName = "some name";
            string AppointmentName = "Check Up";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            OK = AnAppointment.Valid(AppointmentNo, PatientName, AppointmentName, DateAdded);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

    }
}
