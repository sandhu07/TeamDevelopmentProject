using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;

namespace HealthCareTesting
{
    [TestClass]
    public class tstLogin
    {

        [TestMethod]
        public void LoginNoMin()
        {
            //create an instance of class
            clsLogin ALogin = new clsLogin();
            //create varibale to store the ID of the user
            Int32 LoginNo;
            //assign a value to the variable
            LoginNo = 999;
            //try to send some data to the user login No property
            ALogin.LoginNo = LoginNo;
            Assert.AreEqual(ALogin.LoginNo, LoginNo);
        }

        [TestMethod]
        public void LoginNoMid()
        {
            //create an instance of class
            clsLogin ALogin = new clsLogin();
            //create varibale to store the ID of the user
            Int32 LoginNo;
            //assign a value to the variable
            LoginNo = 99999;
            //try to send some data to the user login No property
            ALogin.LoginNo = LoginNo;
            Assert.AreEqual(ALogin.LoginNo, LoginNo);
        }

        [TestMethod]
        public void LoginNoMax()
        {
            //create an instance of class
            clsLogin ALogin = new clsLogin();
            //create varibale to store the ID of the user
            Int32 LoginNo;
            //assign a value to the variable
            LoginNo = 999999999;
            //try to send some data to the user login No property
            ALogin.LoginNo = LoginNo;
            Assert.AreEqual(ALogin.LoginNo, LoginNo);
        }

        public void LoginNoMaxPlus1()
        {
            //create an instance of class
            clsLogin ALogin = new clsLogin();
            //create varibale to store the ID of the user
            Int32 LoginNo;
            //assign a value to the variable
            LoginNo = 999999998;
            //try to send some data to the user login No property
            ALogin.LoginNo = LoginNo;
            Assert.AreEqual(ALogin.LoginNo, LoginNo);
        }

        public void LoginMinMinusOne()
        {
            //create an instance of class
            clsLogin ALogin = new clsLogin();
            //create varibale to store the ID of the user
            Int32 LoginNo;
            //assign a value to the variable
            LoginNo = 9;
            //try to send some data to the user login No property
            ALogin.LoginNo = LoginNo;
            Assert.AreEqual(ALogin.LoginNo, LoginNo);
        }

        [TestMethod]
        public void UsernameMax()
        {
            //create an instance of class
            clsLogin ALogin = new clsLogin();
            //create varibale to store the username of a patient
            string Username;
            //assign a value to the variable
            Username = "jacob123";
            //execute the above procedure to send data
            ALogin.Username = Username;
            Assert.AreEqual(ALogin.Username, Username);
        }

        [TestMethod]
        public void UsernameMin()
        {
            //create an instance of class
            clsLogin ALogin = new clsLogin();
            //create varibale to store the username of a patient
            string Username;
            //assign a value to the variable
            Username = "j";
            //execute the above procedure to send data
            ALogin.Username = Username;
            Assert.AreEqual(ALogin.Username, Username);
        }

        [TestMethod]
        public void UsernameMaxPlus1()
        {
            //create an instance of class
            clsLogin ALogin = new clsLogin();
            //create varibale to store the username of a patient
            string Username;
            //assign a value to the variable
            Username = "jacob123fjdkfkdjdkfjdkfdkjkfd";
            //execute the above procedure to send data
            ALogin.Username = Username;
            Assert.AreEqual(ALogin.Username, Username);
        }

        [TestMethod]
        public void UsernameMinMinus1()
        {
            //create an instance of class
            clsLogin ALogin = new clsLogin();
            //create varibale to store the username of a patient
            string Username;
            //assign a value to the variable
            Username = "";
            //execute the above procedure to send data
            ALogin.Username = Username;
            Assert.AreEqual(ALogin.Username, Username);
        }

        [TestMethod]
        public void UsernameMid()
        {
            //create an instance of class
            clsLogin ALogin = new clsLogin();
            //create varibale to store the username of a patient
            string Username;
            //assign a value to the variable
            Username = "jacob";
            //execute the above procedure to send data
            ALogin.Username = Username;
            Assert.AreEqual(ALogin.Username, Username);
        }

        [TestMethod]
        public void Password_Max1toExtremeMax()
        {
            //create an instance of the class
            clsLogin ALogin = new clsLogin();
            //create an instance of class
            //  clsLogin ALogin = new clsLogin();
            //create varibale to store the password of patient
            //  Boolean _OK;
            // string SomeText = "";
            //assign a value to the variable
            // _OK = ALogin.ValidateTest(SomeText, "password938");
            // SomeText.PadLeft(51);
            //  Assert.IsFalse(_OK);
        }
    }
}