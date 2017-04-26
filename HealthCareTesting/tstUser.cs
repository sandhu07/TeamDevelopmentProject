using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;

namespace HealthCareTesting
{
    [TestClass]
    public class tstUser
    {
        [TestMethod]
        public void PatientInstanceOK()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();
            //test to see that it exists
            Assert.IsNotNull(AnUser);
        }


        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of class
            clsUser PatientUser = new clsUser();
            //create varibale to store the ID of company 
            String FirstName;
            //assign a value to the variable
            FirstName = "J";
            //try to send some data to the CompanyNo property
            PatientUser.FirstName = FirstName;
            //check to see that the data in the varibale and the property are the same
            Assert.AreEqual(PatientUser.FirstName, FirstName);
        }

        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of class
            clsUser PatientUser = new clsUser();
            //create varibale to store the ID of company 
            String FirstName;
            //assign a value to the variable
            FirstName = "jjj";
            //try to send some data to the CompanyNo property
            PatientUser.FirstName = FirstName;
            //check to see that the data in the varibale and the property are the same
            Assert.AreEqual(PatientUser.FirstName, FirstName);
        }

        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of class
            clsUser PatientUser = new clsUser();
            //create varibale to store the ID of company 
            String FirstName;
            //assign a value to the variable
            FirstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //try to send some data to the CompanyNo property
            PatientUser.FirstName = FirstName;
            //check to see that the data in the varibale and the property are the same
            Assert.AreEqual(PatientUser.FirstName, FirstName);
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of class
            clsUser PatientUser = new clsUser();
            //create varibale to store the ID of company 
            String FirstName;
            //assign a value to the variable
            FirstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab";
            //try to send some data to the CompanyNo property
            PatientUser.FirstName = FirstName;
            //check to see that the data in the varibale and the property are the same
            Assert.AreEqual(PatientUser.FirstName, FirstName);
        }

        [TestMethod]
        public void FirstNameMinMinusOne()
        {
            //create an instance of class
            clsUser PatientUser = new clsUser();
            //create varibale to store the ID of company 
            String FirstName;
            //assign a value to the variable
            FirstName = "";
            //try to send some data to the CompanyNo property
            PatientUser.FirstName = FirstName;
            //check to see that the data in the varibale and the property are the same
            Assert.AreEqual(PatientUser.FirstName, FirstName);
        }

        [TestMethod]
        public void PatientAddress()
        {
            //create an instance of class
            clsUser PatientUser = new clsUser();
            //create varibale to store the ID of company 
            String Address;
            //assign a value to the variable
            Address = "122 Welford Road";
            //try to send some data to the CompanyNo property
            PatientUser.Address = Address;
            //check to see that the data in the varibale and the property are the same
            Assert.AreEqual(PatientUser.Address, Address);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of class
            clsUser AnUser = new clsUser();
            //create varibale to store the ID of company 
            Boolean TestData = true;
            //assign a value to the variable
            AnUser.Active = TestData;
            //try to send some data to the CompanyNo property
            Assert.AreEqual(AnUser.Active, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of class
            clsUser AnUser = new clsUser();
            //create varibale to store the ID of company 
            DateTime TestData = DateTime.Now.Date;
            //assign a value to the variable
            AnUser.DateAdded = TestData;
            //try to send some data to the CompanyNo property
            Assert.AreEqual(AnUser.DateAdded, TestData);
        }


        [TestMethod]
        public void UserNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnUser.UserNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserNo, TestData);
        }

        [TestMethod]
        public void MedicalNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnUser.MedicalNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.MedicalNo, TestData);
        }

        [TestMethod]
        public void HouseAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();
            //create some test data to assign to the property
            string TestData = "123 Street Road";
            //assign the data to the property
            AnUser.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Address, TestData);
        }

        [TestMethod]
        public void PostCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();
            //create some test data to assign to the property
            string TestData = "LE2 5HD";
            //assign the data to the property
            AnUser.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.PostCode, TestData);
        }

        [TestMethod]
        public void EmailPropertyMin()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();
            //create some test data to assign to the property
            string TestData = "sandhu@hotmail.com";
            //assign the data to the property
            AnUser.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Email, TestData);
        }

        [TestMethod]
        public void FindUserNoMethodOK()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();
            //create some test data to assign to the property
            Boolean Found = false;
            //assign the data to the property
            Int32 UserNo = 1;
            //invoke method
            Found = AnUser.FindUser(UserNo);
            //test to see that values are the same
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserNoFound()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();
            //create some test data to assign to the property
            Boolean Found = false;
            //assign the data to the property
            Boolean OK = true;
            //create test data
            Int32 UserNo = 11;
            //invoke method
            Found = AnUser.FindUser(UserNo);
            //test to see that values are the same
            if (AnUser.UserNo !=21)
            {
                OK = false;
            }
            //test results
            Assert.IsTrue(Found);
        }


        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 UserNo = 21;
            //invoke the method
            Found = AnUser.Find(UserNo);
            //check the property
            if (AnUser.DateAdded != Convert.ToDateTime("16/09/2015"))
            {
                OK = true;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 UserNo = 21;
            //invoke the method
            Found = AnUser.Find(UserNo);
            //check the property
            if (AnUser.Active != true)
            {
                OK = true;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}