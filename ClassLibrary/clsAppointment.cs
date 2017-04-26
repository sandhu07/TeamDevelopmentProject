using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Class_Library
{
    public class clsAppointment
    {
        private Int32 MedicalID;
        private Int32 mAppointmentNo;
        public DateTime mDateAdded;
        public string mAppointmentName;
        private Int32 mUserNo;

        public DateTime DateAdded
        {
            get
            {
                //return the private data
                return mDateAdded;
            }
            set
            {
                //set the private data
                mDateAdded = value;
            }
        }

        public int AppointmentNo
        {
            get
            {
                //return the private data
                return mAppointmentNo;
            }
            set
            {
                //set the value of the private data member
                mAppointmentNo = value;
            }
        }

        public int UserNo
        {
            get
            {
                //return the private data
                return mUserNo;
            }
            set
            {
                //set the private data
                mUserNo = value;
            }
        }

        public string AppointmentName
        {
            get
            {
                //return the private data
                return mAppointmentName;
            }
            set
            {
                //set the private data
                mAppointmentName = value;
            }
        }

        public string Email { get; set; }
        public int DateCount { get; set; }

        public bool Valid(string userPostCode, string userDate)
        {
            DateTime TempDate;
            Boolean OK = true;
            try
            {
                TempDate = Convert.ToDateTime(userDate);
                if (TempDate < DateTime.Now.Date.AddDays(-1))
                {
                    OK = false;
                }
            }
            catch
            { }
            return OK;
        }

        public bool Find(int AppointmentNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@AppointmentNo", AppointmentNo);
            //execute the stored procedure
            DB.Execute("sproc_tblAppointment_FilterByAAppointmentNo");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mAppointmentNo = Convert.ToInt32(DB.DataTable.Rows[0]["AppointmentNo"]);
                mAppointmentName = Convert.ToString(DB.DataTable.Rows[0]["AppointmentName"]);
                mUserNo = Convert.ToInt32(DB.DataTable.Rows[0]["UserNo"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public Boolean Valid(string County)
        {
            //record any errors found in the county name 
            Boolean OK = true;
            //test the outcome to see if the county has zero characters
            if (County.Length == 0)
            {
                //set the return value ok to false
                OK = false;
            }
            //return the results of all the tests provided
            return OK;
        }

        public bool Valid(string appointmentNo, string patientName, string AppointmentName, string dateAdded)
        {
            //create a boolean variable to flag error
            Boolean OK = true;
            //create variables to store
            DateTime DateTemp;
            //if appointment no is blank
            {
                OK = false;
            }
            if (appointmentNo.Length > 6)
            {
                OK = false;
            }
            //copy date added value to datetemp variable
            DateTemp = Convert.ToDateTime(dateAdded);
            //check date is less than todays date
            if (DateTemp < DateTime.Now.Date)
            {
                OK = false;
            }
            //check to see if the date is greater than today's date
            if (DateTemp > DateTime.Now.Date)
            {
                //set the flag OK to false
                OK = false;
            }
            return OK;

        }
    }

    public class clsAppointment
    {
    }
}