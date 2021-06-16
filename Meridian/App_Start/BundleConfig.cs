using System.Web;
using System.Web.Optimization;

namespace Meridian
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new Bundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.js"));

            bundles.Add(new Bundle("~/bundles/angular").Include(
                "~/Scripts/angular.js",
                "~/Scripts/angular-route.js",
                "~/Scripts/angular-resource.js",
                "~/Scripts/angular-aria.js",
                "~/Scripts/angular-animate.js",
                "~/Scripts/angular-messages.js",
                "~/Scripts/angular-material.js",
                "~/Scripts/angular-cookies.js",
                "~/Scripts/angular-sanitize.js"
                ));

            bundles.Add(new StyleBundle("~/Content/css").IncludeDirectory(
                "~/Content",
                "*.css",
                true));

            bundles.Add(new StyleBundle("~/app/css").IncludeDirectory(
                "~/app",
                "*.style.css",
                true));

            bundles.Add(new Bundle("~/bundles/app").Include("~/app/app.js")
                .IncludeDirectory("~/app/","*.js", true));


            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));
        }
    }
}
