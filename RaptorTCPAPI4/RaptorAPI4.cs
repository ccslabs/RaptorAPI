using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RaptorTCPAPI4
{
    
    public class RaptorAPI4 : IRaptorAPI4
    {
        // Simple test to see if the server is online
        public bool Hello()
        {
            return true;
        }
    }
}
