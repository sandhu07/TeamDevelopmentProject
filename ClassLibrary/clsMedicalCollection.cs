using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    public class clsMedicalCollection
    {
        clsMedical aMedical = new clsMedical();
        const int recordNotAdded = -1;


        public int AddMedical(clsMedical Medical)
        {
            int primaryKey = recordNotAdded;
            clsDataConnection MyLogin = new clsDataConnection();
            MyLogin.AddParameter("Medication", Medical.Medication);
            MyLogin.AddParameter("TravelInsurance", Medical.TravelInsurance);
            MyLogin.AddParameter("GPName", Medical.GPName);
            MyLogin.AddParameter("LastGPVisit", Medical.LastGPVisit);

            try
            {
                primaryKey = MyLogin.Execute("sproc_tblMedical_Register");
            }
            catch (Exception ex)
            {

            }
            return primaryKey;
        }
    }
}
