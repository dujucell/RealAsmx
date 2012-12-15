using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealService.Exceptions
{
        public class ServiceLoadException : Exception
        {
            public ServiceLoadException(String message)
                : base(message)
            {
            }
        }
}
