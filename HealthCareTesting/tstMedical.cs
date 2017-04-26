using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;

namespace HealthCareTesting
{
    [TestClass]
    public class tstMedical
    {
        [TestMethod]
        public void MedicalInstantiationOk()
        {
            //create an instance of the class
            clsMedical AMedical = new clsMedical();
        }
    }
}
