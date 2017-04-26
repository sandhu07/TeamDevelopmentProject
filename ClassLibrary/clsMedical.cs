using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    public class clsMedical
    {
        //private data members for the class
        private Int32 medicalID;
        private Int32 userNo;
        private Int32 loginNo;
        private string gpName;
        private string lastGPVisit;
        private string medication;
        private string travelinsurance;

        clsDataConnection myDB = new clsDataConnection();

        public Int32 LoginNo
        {
            get
            {
                return loginNo;
            }
            set
            {
                loginNo = value;
            }
        }

        public Int32 UserNo
        {
            get
            {
                return userNo;
            }
            set
            {
                userNo = value;
            }
        }

        public Int32 MedicalID
        {
            get
            {
                return medicalID;
            }
            set
            {
                medicalID = value;
            }
        }

        public string GPName
        {
            get { return gpName; }
            set { gpName = value; }
        }

        public string LastGPVisit
        {
            get { return lastGPVisit; }
            set { lastGPVisit = value; }
        }

        public string Medication
        {
            get { return medication; }
            set { medication = value; }
        }

        public string TravelInsurance
        {
            get { return travelinsurance; }
            set { travelinsurance = value; }
        }
    }
}
