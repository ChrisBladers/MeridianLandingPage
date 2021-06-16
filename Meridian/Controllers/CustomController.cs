using System.Web.Mvc;
using System.Web.Routing;

namespace Meridian.Controllers
{
    public class CustomController : Controller
    {
        //public CustomController() { }

        protected string IPAdress { get; set; }
        protected string UserAgent { get; set; }
        protected bool DebugMode { get; set; }

        protected override void Initialize(RequestContext context)
        {
            IPAdress = GetIPAddress(context);
            UserAgent = context.HttpContext.Request.UserAgent;
            DebugMode = (context.HttpContext.Application.Get("_inDebug") != null) ? true : false;
        }

        private string GetIPAddress(RequestContext context)
        {
            string szRemoteAddr = context.HttpContext.Request.UserHostAddress;
            string szXForwardFor = context.HttpContext.Request.ServerVariables["X_FORWARDED_FOR"];
            string szIP = "";

            if(szXForwardFor == null)
            {
                szIP = szRemoteAddr;
            }

            return szIP;
        }
    }
}