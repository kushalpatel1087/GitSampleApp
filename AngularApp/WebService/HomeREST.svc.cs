using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AngularApp.WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HomeREST" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select HomeREST.svc or HomeREST.svc.cs at the Solution Explorer and start debugging.
    public class HomeREST : IHomeREST
    {
        public void DoWork()
        {
        }

        public List<Template> fillTemplate() {
            Template obj = new Template();
            string template = "Custom Template";
            obj.FillTemplate(template);
            List<Template> templatelist = new List<Template>();
            templatelist.Add(obj);

            obj = new Template();
            template = "Budget Template";
            obj.FillTemplate(template);
            templatelist.Add(obj);

            obj = new Template();
            template = "Simple Template";
            obj.FillTemplate(template);
            templatelist.Add(obj);

           return templatelist;      
        }
    }

    public class Template
    {
        public string TemplateName;
        public void FillTemplate(string templatename) {
            TemplateName = templatename;
        }
    }
}
