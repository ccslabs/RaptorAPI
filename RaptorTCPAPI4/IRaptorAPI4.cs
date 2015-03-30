using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RaptorTCPAPI4
{
   
    [ServiceContract]
    public interface IRaptorAPI4
    {
        bool Hello();       // Simply returns true if called. Quick test to see if the service is online

       
    }

    
}
