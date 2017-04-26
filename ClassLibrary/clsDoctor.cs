using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    public class clsDoctor
    {
        public string DoctorSurname { get; set; }
        public int GPDoctorNo { get; set; }

        public bool ValidDoctor(string doctorID, string doctorName)
        {
            return true;
        }
    }

    public class clsGPCompany
    {
        public List<clsGPCompany> AllCompanies { get; set; }
        public string Company { get; set; }
        public int CompanyNo { get; set; }
        public int Count { get; set; }

        public bool Valid(string someCompany)
        {
            //booleanflag to indicate ok
            Boolean OK = true;
            //if the name of the company is blank
            if (someCompany == "")
            {
                //flag error
                OK = false;
            }
            //if name of the company is more than 50 characters
            if (someCompany.Length > 50)
            {
                //flag error
                OK = false;
            }
            return OK;
        }
    }
}


