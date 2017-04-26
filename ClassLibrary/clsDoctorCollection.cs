using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    public class clsDoctorCollection : clsDBCollection
    {
        public object AllDoctors;
        public object ThisDoctor;
        private List<clsDoctor> mAllGP = new List<clsDoctor>();
        public List<clsDoctor> AllGP
        {
            //getter sends data to requesting code
            get
            {
                //return the private data mamber
                return mAllGP;
            }
            //setter accepts data from other objects
            set
            {
                //assign the incoming value to the private data member
                mAllGP = value;
            }
        }

        public void FilterByCompanyName(string GPName)
        {
            //initialise the DBConnection
            DBCon = new clsDataConnection();
            //add the parameter data used by the stored procedure
            DBCon.AddParameter("CompanyName", GPName);
            //execute the stored procedure to delete the address
            DBCon.Execute("sproc_tblGPCompany_FilterByCompanyName");
        }
    }

    public class clsGPCompanyCollection
    {
        public List<clsGPCompany> mAllCompanies
        {
            get
            {
                //return value
                return mAllCompanies;
            }
            set
            {
                //asign value
                mAllCompanies = value;
            }
        }
        public int Count
        {
            get
            {
                //return private data member
                return mAllCompanies.Count;
            }
            set
            {

            }
        }

        public List<clsGPCompany> AllCompanies { get; set; }
    }
}
