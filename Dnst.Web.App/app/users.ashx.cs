using Dnst.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace Dnst.Web.App.app
{
    public class users : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            using (UserRepository repository = new UserRepository("dnst"))
            {
                var users = repository.GetAllUsers();

                JavaScriptSerializer jsr = new JavaScriptSerializer();
                string json = jsr.Serialize(users);

                context.Response.ContentType = "application/json";
                context.Response.Write(json);
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}