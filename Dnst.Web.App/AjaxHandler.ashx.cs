using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace Dnst.Web.App
{
    /// <summary>
    /// Summary description for AjaxHandler
    /// </summary>
    public class AjaxHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.Write("<h1>Hello from base handler</h1>");

            //context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
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