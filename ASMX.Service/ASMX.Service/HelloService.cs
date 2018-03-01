using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ASMX.Service
{
    public class HelloService : System.Web.Services
    {
        [WebMethod]
        public string Hello(DateTime dateBegin, DateTime dateEnd)
        {
            return "Hello";
        }
    }

}