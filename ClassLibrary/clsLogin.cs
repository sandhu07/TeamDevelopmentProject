using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    public class clsLogin
    {
        public int ActiveUser;

        private Int32 loginNo;
        private string username;
        private string password;
        private Int32 userRoleId;
        private string emailAddress;
        private bool admin;
        // public clsDataConnection myDB;

        clsDataConnection myDB = new clsDataConnection();
        clsDBCollection DB = new clsDBCollection();


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

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public Int32 UserRoleId
        {
            get { return userRoleId; }
            set { userRoleId = value; }
        }

        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }



        public bool Admin
        {
            get
            {
                return admin;
            }
            set
            {
                admin = value;
            }
        }

        public Boolean Find(Int32 LoginNo)
        {
            clsDataConnection myDB = new clsDataConnection();
            //initialise the myDB
            myDB = new clsDataConnection();
            //add the loginid parameter
            myDB.AddParameter("LoginNo", LoginNo);
            //execute the query
            myDB.Execute("sproc_tblLogin_GetUser");
            //if the record was found
            if (myDB.Count == 1)
            {
                //gets the login id
                loginNo = Convert.ToInt32(myDB.DataTable.Rows[0]["LoginNo"]);
                //gets the username
                username = Convert.ToString(myDB.DataTable.Rows[0]["Username"]);
                //gets the password
                password = Convert.ToString(myDB.DataTable.Rows[0]["Password"]);
                //gets the password
                emailAddress = Convert.ToString(myDB.DataTable.Rows[0]["EmailAddress"]);
                // gets the user role ID
                //UserRoleId = Convert.ToInt32(myDB.DataTable.Rows[0]["UserRoleId"]);
                //return success
                return true;
            }
            else
            {
                //return failure
                return false;
            }
        }

        public Boolean GetLoginNo(string Username, string Password)
        {
            clsDataConnection myDB = new clsDataConnection();
            //re set the connection to the database
            myDB = new clsDataConnection();
            //pass the parameter to the stored procedure
            myDB.AddParameter("@Username", Username);
            myDB.AddParameter("@Password", Password);
            //execute the stored procedure
            myDB.Execute("sproc_tblLogin_GetLoginNo");
            //check to see if we found anything
            if (myDB.Count == 1)
            {
                //set the private data members with the data from the database
                //private Int32 LoginNo;
                loginNo = Convert.ToInt32(myDB.DataTable.Rows[0]["LoginNo"]);
                return true;
            }
            else
            {
                return false; //error
            }
        }

        public Boolean FilterbyUsername(string Username)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Username", Username);
            DB.Execute("sproc_tblLogin_GetPassword");
            if (DB.Count == 1)
            {
                loginNo = Convert.ToInt32(DB.DataTable.Rows[0]["LoginNo"]);
                //private string Email;
                emailAddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                //private string Pass;
                password = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                //private string Username;
                username = Convert.ToString(DB.DataTable.Rows[0]["Username"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean Login(string Password, string Username)
        {
            //Checks username and password for match
            bool _OK = false;
            //check username
            _OK = this.FilterbyUsername(Username);
            if (_OK == true)
            {
                //check password over username
                if (Password == password)
                {
                    _OK = true;
                    this.GetLoginNo(Username, Password);
                }
                //return false if username and password is incorrect
                else
                {
                    _OK = false;
                }

            }
            return _OK;
        }

        public bool AddUser()
        {
            //register new user
            if (this.Find(LoginNo) == false)
            {
                //try and catch
                try
                {
                    //add parameters for register
                    myDB.AddParameter("@LoginNo", loginNo);
                    myDB.AddParameter("@EmailAddress", emailAddress);
                    myDB.AddParameter("@Password", password);
                    myDB.AddParameter("@Username", username);
                    //execute stored procedure
                    myDB.Execute("sproc_tblLogin_Register");
                    return true;
                    //ececute sproc for register
                }
                catch
                //return catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        public string Valid(string EmailAddress,
                    string Password,
                    string UserName)
        ///this function accepts 5 parameters for validation
        ///the function returns a string containing any error message
        ///if no errors found then a blank string is returned
        {

            //var to store the error message
            string ErrMsg = "";
            //check the min length of the EMail
            if (EmailAddress.Length == 0)
            {
                //set the error messsage
                ErrMsg = ErrMsg + "Email Address is blank. ";
            }
            if (EmailAddress.Length < 5)
            {
                //set the error messsage
                ErrMsg = ErrMsg + "Email Address is too small. ";
            }
            if (EmailAddress.Length > 50)
            {
                //set the error messsage
                ErrMsg = ErrMsg + "Email Address is too big. ";
            }

            //check the min length of the street
            if (Password.Length == 0)
            {
                //set the error messsage
                ErrMsg = ErrMsg + "Password is blank. ";
            }
            if (Password.Length < (6))
            {
                ErrMsg = ErrMsg + "Password is too small. ";
            }
            if (Password.Length > (50))
            {
                ErrMsg = ErrMsg + "Password is too big. ";
            }
            if (UserName.Length == 0)
            {
                //set the error messsage
                ErrMsg = ErrMsg + "Username is blank. ";
            }
            if (UserName.Length > 50)
            {
                //set the error messsage
                ErrMsg = ErrMsg + "Username is too long. ";
            }
            if (UserName.Length < (5))
            {
                ErrMsg = ErrMsg + "Username is too small. ";
            }
            //is username correct?
            if (UserName != username)
            {
                ErrMsg = ErrMsg + "Username is incorrect";
            }
            //check if password is correct
            if (Password != password)
            {
                ErrMsg = ErrMsg + "Password is incorrect";
            }
            //if there were no errors
            if (ErrMsg == "")
            {
                //return a blank string
                return "";
            }
            else//otherwise
            {
                //return the errors string value
                return "There were the following errors : " + ErrMsg;
            }
        }

        public string Validate(string Password,
              string UserName)
        ///this function accepts 5 parameters for validation
        ///the function returns a string containing any error message
        ///if no errors found then a blank string is returned
        {
            //var to store the error message
            string ErrMsg = "";
            //check the min length of the Password
            if (Password.Length == 0)
            {
                //set the error messsage
                ErrMsg = ErrMsg + "Password is blank. ";
            }
            //username must not be blank
            if (UserName.Length == 0)
            {
                //set the error messsage
                ErrMsg = ErrMsg + "Username is blank. ";
            }
            //Username must be more than 5 characters long
            if (UserName.Length < (5))
            {
                ErrMsg = ErrMsg + "Username is too small. ";
            }
            //username must be less than 50 or equal to characters
            if (UserName.Length > (50))
            {
                ErrMsg = ErrMsg + "Username is too big. ";
            }
            //check if username is correct
            if (UserName != username)
            {
                ErrMsg = ErrMsg + "Username is incorrect. ";
            }
            //check if password is correct
            if (Password != password)
            {
                ErrMsg = ErrMsg + "Password is incorrect. ";
            }
            //password must be 6 more more characters
            if (Password.Length < (6))
            {
                ErrMsg = ErrMsg + "Password is too small. ";
            }
            //password must be less than or equal to 50
            if (Password.Length > (50))
            {
                ErrMsg = ErrMsg + "Password is too big. ";
            }
            //if there were no errors
            if (ErrMsg == "")
            {
                //return a blank string
                return "";
            }
            else//otherwise
            {
                //return the errors string value
                return "There were the following errors : " + ErrMsg;
            }
        }

        public Boolean ValidateTest(string Password,
             string UserName)
        ///this function accepts 5 parameters for validation
        ///the function returns a string containing any error message
        ///if no errors found then a blank string is returned
        {
            Boolean OK = true;
            //var to store the error message
            //check the min length of the Password
            if (Password.Length == 0)
            {
                //set the error messsage
                OK = false;
            }
            if (UserName.Length == 0)
            {
                //set the error messsage
                OK = false;
            }
            if (UserName.Length < (5))
            {
                OK = false;
            }
            if (UserName.Length > (50))
            {
                OK = false;
            }
            //check if username is correct
            if (UserName != username)
            {
                OK = false;
            }
            //check if password is correct
            if (Password != password)
            {
                OK = false;
            }
            if (Password.Length < (6))
            {
                OK = false;
            }
            if (Password.Length > (50))
            {
                OK = false;
            }
            //if there were no errors
            //return a blank string
            return OK;
        }

    }

}
