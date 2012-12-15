using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealServer.Service.Interface;
using RealLicenseLibraryWCF;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace RealService.Service.Plugin
{
    public class AuthenticationSvcADOImpl : IAuthenticationSvc
    {
        public Boolean AuthenticateLicense(RealLicenseWCF obj)
        {
            string sel = "SELECT * FROM License WHERE License_No = '"+ obj.LicenseNumber+"'";

            SqlCommand cmd = new SqlCommand(sel, new SqlConnection(this.getConnectionString()));

            cmd.Connection.Open();

            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            while (dr.Read())
            {
                obj.LicenseNumber = dr.GetString(0);
                obj.Expiry = dr.GetDateTime(1);
                if (DateTime.Now > obj.Expiry)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        private string getConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["LicenseConnectionString"].ConnectionString;
        }
    }
}
