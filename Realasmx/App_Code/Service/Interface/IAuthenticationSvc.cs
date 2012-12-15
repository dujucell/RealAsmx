using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealLicenseLibraryWCF;

namespace RealServer.Service.Interface
{
    interface IAuthenticationSvc : IService
    {
        Boolean AuthenticateLicense(RealLicenseWCF obj);
    }
}
