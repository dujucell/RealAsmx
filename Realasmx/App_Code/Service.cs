﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using RealLicenseLibraryWCF;
using RealServer.Business;
using RealServer.Service;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    public Boolean AuthenticateLicense(RealLicenseWCF obj)
    {
        AuthenticationLicenseManager mgr = new AuthenticationLicenseManager();
        return mgr.AuthenticateLicense(obj);
    }
}
