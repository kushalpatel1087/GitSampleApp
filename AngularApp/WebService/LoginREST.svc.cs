using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AngularApp.WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "LoginREST" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select LoginREST.svc or LoginREST.svc.cs at the Solution Explorer and start debugging.
    public class LoginREST : ILoginREST
    {
        public string DoWork()
        {
            return "REST Service";
        }

        public string CheckUser(string UserName, string PassWord) {
            if (UserName == "admin" && PassWord == "admin") {
                return "sucess";
            }
            return "fail";
        }
    }
}
