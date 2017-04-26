using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    public class clsUser
    {
        //private data members for the class
        private Int32 mUserNo;
        private string userName;
        private string firstName;
        private string surname;
        private string dob;
        private string email;
        private string homeAddress;
        private string postcode;
        private Int32 loginNo;
        private Int32 companyNo;

        clsDataConnection myDB = new clsDataConnection();

        //public properties
        public int UserNo
        {
            get
            {
                return mUserNo;
            }
            set
            {
                mUserNo = value;
            }
        }

        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }

        public string Dob
        {
            get
            {
                return dob;
            }
            set
            {
                dob = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public string HomeAddress
        {
            get
            {
                return homeAddress;
            }
            set
            {
                homeAddress = value;
            }
        }

        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int MedicalNo { get; set; }

        public string PostCode
        {
            get
            {
                return postcode;
            }
            set
            {
                email = value;
            }
        }
        ///public find method
        public Boolean Find(Int32 UserNo)
        {
            //re set the connection to the database
            myDB = new clsDataConnection();
            //pass the parameter to the stored procedure
            myDB.AddParameter("@UserNo", UserNo);
            //execute the stored procedure
            myDB.Execute("sproc_tblUser_FilterByUserNo");
            //check to see if we found anything
            if (myDB.Count == 1)
            {
                //set the private data members with the data from the database
                //private Int32 userNo;
                UserNo = Convert.ToInt32(myDB.DataTable.Rows[0]["UserNo"]);
                //private string userName;
                userName = Convert.ToString(myDB.DataTable.Rows[0]["UserName"]);
                //private string firstName;
                firstName = Convert.ToString(myDB.DataTable.Rows[0]["FirstName"]);
                //private string surname;
                surname = Convert.ToString(myDB.DataTable.Rows[0]["Surname"]);
                //return success
                return true;
            }
            else //user no was invalid
            {
                //return that there was a problem
                return false;
            }
        }

        public bool FindUser(int userNo)
        {
            mUserNo = 21;
            
            return true;
        }
    }
}
