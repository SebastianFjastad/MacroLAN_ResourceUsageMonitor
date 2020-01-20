using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace MLReporting
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/Css").IncludeDirectory("~/Content/", "*.css", searchSubdirectories: true));

            bundles.Add(new ScriptBundle("~/Scripts/JQueryBundle").Include(
                "~/Scripts/jquery-1.10.2.js",
                "~/Scripts/bootstrap.js"
                ));
        }
    }
}