using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealServer.Service;

namespace RealServer.Business
{
    public abstract class BusinessManager
    {
        protected IService getService(String name)
        {
            return (Factory.getInstance()).getService(name);
        }
    }
}
