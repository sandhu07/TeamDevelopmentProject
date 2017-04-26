using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;

namespace HealthCareTesting
{
    [TestClass]
    public class tstDoctor
    {
        [TestMethod]
        public void DoctorNoLessOne()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DoctorID = "1";
            string DoctorName = "some name";
            //invoke the method
            OK = ADoctor.ValidDoctor(DoctorID, DoctorName);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DoctorNoMin()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DoctorID = "1";
            string DoctorName = "some Doctor";
            //invoke the method
            OK = ADoctor.ValidDoctor(DoctorID, DoctorName);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DoctorNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DoctorID = "11";
            string DoctorName = "some Doctor";
            //invoke the method
            OK = ADoctor.ValidDoctor(DoctorID, DoctorName);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void DoctorNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DoctorID = "1111111";
            string DoctorName = "some Doctor";
            //invoke the method
            OK = ADoctor.ValidDoctor(DoctorID, DoctorName);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DoctorNoMax()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DoctorID = "11111111";
            string DoctorName = "some Doctor";
            //invoke the method
            OK = ADoctor.ValidDoctor(DoctorID, DoctorName);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DoctorNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DoctorID = "111111111";
            string DoctorName = "some Doctor";
            //invoke the method
            OK = ADoctor.ValidDoctor(DoctorID, DoctorName);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void DoctorNoMid()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string DoctorID = "11111";
            string DoctorName = "some Doctor";
            //invoke the method
            OK = ADoctor.ValidDoctor(DoctorID, DoctorName);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }
}
