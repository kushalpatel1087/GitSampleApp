using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AngularApp.WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IHomeREST" in both code and config file together.
    [ServiceContract]
    public interface IHomeREST
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "fillTemplate/")]
        List<Template> fillTemplate();
    }
}
