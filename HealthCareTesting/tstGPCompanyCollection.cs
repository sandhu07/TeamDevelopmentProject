using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;
using System.Collections.Generic;

namespace HealthCareTesting
{
    [TestClass]
    public class tstGPCompanyCollection
    {
        [TestMethod]
        public void GPCompanyCollectionInstanceOK()
        {
            //create an instance of theclass
            clsGPCompanyCollection AllCompanies = new clsGPCompanyCollection();
            //test to see it exists
            Assert.IsNotNull(AllCompanies);
        }

        [TestMethod]
        public void CompanyPropertyOK()
        {
            //create an instance of the class
            clsMedical AMedical = new clsMedical();
            //   //create instance of the class
            //   clsGPCompanyCollection AllCompanies = new clsGPCompanyCollection();
            //   //creaye some test
            //  Int32 SomeCount = 1;
            //  //assign to property
            //  AllCompanies.Count = SomeCount;
            //test the class
            //  Assert.AreEqual(AllCompanies.Count, SomeCount);
        }

        [TestMethod]
        public void AllCompaniesOK()
        {
            //create instance of the class
            clsGPCompanyCollection Companies = new clsGPCompanyCollection();
            //create some test
            List<clsGPCompany> TestList = new List<clsGPCompany>();
            //add an item
            clsGPCompany TestItem = new clsGPCompany();
            //set properties
            TestItem.CompanyNo = 1;
            TestItem.Company = "Leicester Surgery";
            //add item to the test list
            TestList.Add(TestItem);            
            //assign to property
            Companies.AllCompanies = TestList;
            //test the class
            Assert.AreEqual(Companies.AllCompanies, TestList);
        }


        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class
            clsMedical AMedical = new clsMedical();
            //create instance of the class
            //   clsGPCompanyCollection AllCompanies = new clsGPCompanyCollection();
            //creaye some test
            //  Int32 SomeCount = 2;
            //assign to property
            //  AllCompanies.Count = SomeCount;
            //test the class
            // Assert.AreEqual(AllCompanies.Count, SomeCount);
        }

    }
}

