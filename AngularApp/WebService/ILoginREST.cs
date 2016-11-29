using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AngularApp.WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ILoginREST" in both code and config file together.
    [ServiceContract]
    public interface ILoginREST
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Xml, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "DoWork/")]
        string DoWork();

        [OperationContract]
        [WebInvoke(Method ="GET", ResponseFormat =WebMessageFormat.Json,BodyStyle = WebMessageBodyStyle.Bare,UriTemplate ="ValidateUser/{UserName}/{PassWord}")]
        string CheckUser(string UserName, string PassWord);
    }
}
