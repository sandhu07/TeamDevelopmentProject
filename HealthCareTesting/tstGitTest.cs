using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;

namespace HealthCareTesting
{
    [TestClass]
    public class tstGitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsAppointment AnAppointment = clsAppointment();
            Assert.IsNotNull(AnAppointment);
        }
    }
}
