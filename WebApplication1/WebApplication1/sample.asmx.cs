using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;
using System.Web.Script.Serialization;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for sample
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class sample : System.Web.Services.WebService
    {

        [WebMethod]
        [ScriptMethod(ResponseFormat =ResponseFormat.Json)]
        public string GetPersonData(string name, string email)
        {
            return "You have submitted data with Name: " + name + " and Email: " + email;
        }
    
    }
}
