using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using RealLicenseLibraryWCF;
using RealServer.Business;

/// <summary>
/// Summary description for RealService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class RealAsmx : System.Web.Services.WebService {

    public RealAsmx () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public Boolean AuthenticateLicense(RealLicenseWCF obj)
    {
        AuthenticationLicenseManager mgr = new AuthenticationLicenseManager();
        return mgr.AuthenticateLicense(obj);
    }
    
}
