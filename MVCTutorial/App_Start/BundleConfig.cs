using System.Web;
using System.Web.Optimization;

namespace MVCTutorial
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/Libraries").Include(
                "~/Scripts/libs/jquery/jquery-{version}.js",
                "~/Scripts/libs/bootstrap/bootstrap.js",
                "~/Scripts/libs/knockout/knockout-{version}.js",
                "~/Scripts/libs/knockout/knockout.validation.js",
                "~/Scripts/libs/kendo/kendo.all.min.js",
                "~/Scripts/libs/kendo/kendo.aspnetmvc.min.js",
                "~/Scripts/libs/knockout-kendo/knockout-kendo.js",
                "~/Scripts/libs/require/require.js",
                "~/Scripts/libs/modernizr/modernizr-{version}.js"));

            bundles.Add(new ScriptBundle("~/Scripts/Application").Include(
               "~/Scripts/app.js",
               "~/Scripts/utils.js",
               "~/Scripts/bindingHandlers.js",
               "~/Scripts/_references.js"));

            bundles.Add(new ScriptBundle("~/Scripts/Application").Include(
                "~/Scripts/app.js",
                "~/Scripts/utils.js",
                "~/Scripts/bindingHandlers.js",
                "~/Scripts/_references.js"));

            bundles.Add(new StyleBundle("~/Content/Css").Include(
                "~/Content/bootstrap/bootstrap.min.css",
                "~/Content/bootstrap/bootstrap-theme.min.css",
                "~/Content/kendo/kendo.common-bootstrap.min.css",
                "~/Content/kendo/kendo.bootstrap.min.css",
                "~/Content/Style.css"));

        }
    }
}
