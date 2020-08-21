using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace BundlingMinificationExample
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/scriptbundle1").Include("~/Scripts/JavaScript1.js", "~/Scripts/JavaScript2.js", "~/Scripts/JavaScript3.js", "~/Scripts/JavaScript4.js", "~/Scripts/" +
                "JavaScript5.js"));
            bundles.Add(new ScriptBundle("~/bundles/scriptbundle2").Include("~/Scripts/JavaScript6.js", "~/Scripts/JavaScript7.js", "~/Scripts/JavaScript8.js", "~/Scripts/JavaScript9.js", "~/Scripts/" +
                "JavaScript10.js"));
            bundles.Add(new StyleBundle("~/bundles/stylebundle1").Include("~/Styles/StylesSheet1.css", "~/Styles/StylesSheet2.css", "~/Styles/StylesSheet3.css", "~/Styles/StylesSheet4.css", "~/Styles/" +
                "StylesSheet5.css"));
            bundles.Add(new StyleBundle("~/bundles/stylebundle2").Include("~/Styles/StylesSheet6.css", "~/Styles/StylesSheet7.css", "~/Styles/StylesSheet8.css", "~/Styles/StylesSheet9.css", "~/Styles/" +
                "StylesSheet10.css"));
            BundleTable.EnableOptimizations = true;
        }
    }
}