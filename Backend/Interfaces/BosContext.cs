using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Interfaces
{
    public interface BosContext
    {

        /*
         * Should be some reference to identity server
        */
        public String GetAuthenticatedUserPrinepal();

        public String GetRequestId();

        public String GetCorrelationId();

        public String GetClientApplication();

    }
}
