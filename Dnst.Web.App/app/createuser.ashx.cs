using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dnst.Web.App.app
{
    /// <summary>
    /// Summary description for createuser
    /// </summary>
    public class createuser : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
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