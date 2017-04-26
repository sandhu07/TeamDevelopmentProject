using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    public class clsAppointmentCollection
    {
        List<clsAppointment> mAppoinmentList = new List<clsAppointment>();
        clsAppointment mThisAppointment = new clsAppointment();
        public object AllBookings;

        public clsAppointmentCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblAppointment_SelectAll");
            PopulateArray(DB);
        }

        void PopulateArray (clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mAppoinmentList = new List<clsAppointment>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsAppointment AnAppointment = new clsAppointment();
                //read in the fields from the current record
                AnAppointment.AppointmentNo = Convert.ToInt32(DB.DataTable.Rows[Index]["AddressNo"]);
                AnAppointment.UserNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CountyNo"]);
                AnAppointment.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AnAppointment.AppointmentName = Convert.ToString(DB.DataTable.Rows[Index]["Street"]);
                //add the record to the private data mamber
                mAppoinmentList.Add(AnAppointment);
                //point at the next record
                Index++;
            }

        }

        public List<clsAppointment> AppointmentList
        {
            get
            {
                //return the private data
                return mAppoinmentList;
            }
            set
            {
                //set the private data
               mAppoinmentList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mAppoinmentList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        //public property for ThisAddress
        public clsAppointment ThisAppointment
        {
            get
            {
                //return the private data
                return mThisAppointment;
            }
            set
            {
                //set the private data
                mThisAppointment = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of thisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@UserNo", mThisAppointment.UserNo);
            DB.AddParameter("@AppointmentName", mThisAppointment.AppointmentName);
            DB.AddParameter("@DateAdded", mThisAppointment.DateAdded);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblAppointment_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@AppointmentNo", mThisAppointment.AppointmentNo);
            //execute the stored procedure
            DB.Execute("sproc_tblAppointment_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of thisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@AppointmentNo", mThisAppointment.AppointmentNo);
            DB.AddParameter("@AppointmentName", mThisAppointment.AppointmentName);
            DB.AddParameter("@UserNo", mThisAppointment.UserNo);
            DB.AddParameter("@DateAdded", mThisAppointment.DateAdded);
            //execute the stored procedure
            DB.Execute("sproc_tblAppointment_Update");
        }

        public void FilterByAppointmentName(string AppointmentName)
        {
            //filters the records based on a full or partial post code
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the PostCode parameter to the database
            DB.AddParameter("@AppointmentName", AppointmentName);
            //execute the stored procedure
            DB.Execute("sproc_tblAppointment_FilterByAppointmentName");
            //populate the array list with the data table
            PopulateArray(DB);
        }
    }
}
