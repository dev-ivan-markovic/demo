using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Project_Beer.App_Start
{
    public class BundleConfig
    {
        public const string SCRIPTS_GLOBAL = "~/bundles/scripts";

        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle(SCRIPTS_GLOBAL).Include
                (
                    "~/Scripts/jquery/*.js",
                    "~/Scripts/angular/angular.js",
                    "~/Scripts/angular/angular-sanitize.js",
                    "~/Scripts/angular/angular-route.js",
                    "~/Scripts/angular/angular-animate.js"
                )
                .IncludeDirectory("~/Scripts/app", "*.js")
                .IncludeDirectory("~/Scripts/app/Controllers", "*.js")
                .IncludeDirectory("~/Scripts/app/Factories", "*.js"));

            bundles.Add(new StyleBundle("~/Content/css").IncludeDirectory("~/Content/css","*.css"));
        }
    }
}