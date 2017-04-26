using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;

namespace HealthCareTesting
{
    [TestClass]
    public class tstGPCompany
    {
        [TestMethod]
        public void GPCompanyInstanceOK()
        {
            //create instance of the class
            clsGPCompany ACompany = new clsGPCompany();
            //test the class
            Assert.IsNotNull(ACompany);
        }
        [TestMethod]
        public void CompanyPropertyOK()
        {
            //create instance of the class
            clsGPCompany ACompany = new clsGPCompany();
            //creaye some test
            string SomeCompany = "Leicester Surgery";
            //assign to property
            ACompany.Company = SomeCompany;
            //test the class
            Assert.AreEqual(ACompany.Company, SomeCompany);
        }
        [TestMethod]
        public void CompanyNoPropertyOK()
        {
            //create instance of the class
            clsGPCompany ACompany = new clsGPCompany();
            //creaye some test
            Int32 CompanyNo = 1;
            //assign to property
            ACompany.CompanyNo = CompanyNo;
            //test the class
            Assert.AreEqual(ACompany.CompanyNo, CompanyNo);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create instance of the class
            clsGPCompany ACompany = new clsGPCompany();
            //creaye some test
            Boolean OK = false;
            //assign to property
            string SomeCompany = "Leicester Surgery";
            //test the class
            OK = ACompany.Valid(SomeCompany);
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CompanyMinLessOne()
        {
            //create instance of the class
            clsGPCompany ACompany = new clsGPCompany();
            //creaye some test
            Boolean OK = false;
            //assign to property
            string SomeCompany = "";
            //test the class
            OK = ACompany.Valid(SomeCompany);
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void CompanyMinBoundary()
        {
            //create instance of the class
            clsGPCompany ACompany = new clsGPCompany();
            //creaye some test
            Boolean OK = false;
            //assign to property
            string SomeCompany = "a";
            //test the class
            OK = ACompany.Valid(SomeCompany);
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CompanyMaxLessOne()
        {
            //create instance of the class
            clsGPCompany ACompany = new clsGPCompany();
            //creaye some test
            Boolean OK = false;
            //assign to property
            string SomeCompany = "uwiqkazxopdjsheudjshdnciwosldjcmsndhdhsocnkscndkd";
            //test the class
            OK = ACompany.Valid(SomeCompany);
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CompanyMaxPlusOne()
        {
            //create instance of the class
            clsGPCompany ACompany = new clsGPCompany();
            //creaye some test
            Boolean OK = false;
            //assign to property
            string SomeCompany = "uwiqkaxophhuhuhudjsheudjshdneciwosldjcmsndhdhsocnkscndkd";
            //test the class
            OK = ACompany.Valid(SomeCompany);
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CompanyExtremeMax()
        {
            //create instance of the class
            clsGPCompany ACompany = new clsGPCompany();
            //creaye some test
            Boolean OK = false;
            //assign to property
            string SomeCompany = "";
            //test the class
            SomeCompany = SomeCompany.PadRight(500, 'a');
            OK = ACompany.Valid(SomeCompany);
            Assert.IsFalse(OK);
        }


    }
}
