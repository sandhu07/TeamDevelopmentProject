using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    public class clsLoginCollection
    {
        clsLogin aLogin = new clsLogin();
        clsDataConnection dBConnection;

        const int recordNotAdded = -1;

        public clsLogin ALogin
        {
            get
            {
                return aLogin;
            }
            set
            {
                aLogin = value;
            }
        }

        public int AddLogin(clsLogin login)
        {
            int primaryKey = recordNotAdded;
            clsDataConnection MyLogin = new clsDataConnection();
            MyLogin.AddParameter("Username", login.Username);
            MyLogin.AddParameter("Password", login.Password);
            MyLogin.AddParameter("EmailAddress", login.EmailAddress);
            try
            {
                primaryKey = MyLogin.Execute("sproc_tblLogin_Register");
            }
            catch (Exception ex)
            {

            }
            return primaryKey;
        }

        public void ChangePassword(clsLogin aLogin)
        {
            clsDataConnection NewPassword = new clsDataConnection();
            NewPassword.AddParameter("@LoginNo", aLogin.LoginNo);
            NewPassword.AddParameter("@Username", aLogin.Username);
            NewPassword.AddParameter("Password", aLogin.Password);
            NewPassword.AddParameter("EmailAddress", aLogin.EmailAddress);
            NewPassword.Execute("sproc_tblLogin_UpdatePassword");
        }
    }
}
