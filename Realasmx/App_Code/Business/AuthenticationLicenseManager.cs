using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealServer.Service.Interface;
using RealService.Exceptions;
using RealLicenseLibraryWCF;

namespace RealServer.Business
{
    public class AuthenticationLicenseManager : BusinessManager
    {
        public Boolean AuthenticateLicense(RealLicenseWCF obj)
        {
            try
            {
                IAuthenticationSvc svc = (IAuthenticationSvc)this.getService(typeof(IAuthenticationSvc).Name);
                return svc.AuthenticateLicense(obj);
            }
            catch (ServiceLoadException ex)
            {
                throw ex;
            }
        }
    }
}
