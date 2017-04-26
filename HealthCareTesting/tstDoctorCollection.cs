using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;

namespace HealthCareTesting
{
    [TestClass]
    public class tstDoctorCollection
    {

        [TestMethod]
        public void GPDoctorNo()
        {
            //create an instance of class
            clsDoctor ADoctor = new clsDoctor();
            //create varibale to store the ID of company 
            Int32 GPDoctorNo;
            //assign a value to the variable
            GPDoctorNo = 123;
            //try to send some data to the GP Doctor No property
            ADoctor.GPDoctorNo = GPDoctorNo;
            Assert.AreEqual(ADoctor.GPDoctorNo, GPDoctorNo);
        }

        [TestMethod]
        public void DoctorSurnameMax()
        {
            //create an instance of class
            clsDoctor AName = new clsDoctor();
            //create varibale to store the gp doctors lastname
            string DoctorSurname;
            //assign a value to the variable
            DoctorSurname = "Richards";
            //send data to the gp doctors last name to store
            AName.DoctorSurname = DoctorSurname;
            //check to see that the data in the varibale and the property are the same
            Assert.AreEqual(AName.DoctorSurname, DoctorSurname);
        } 
    }
    
}
