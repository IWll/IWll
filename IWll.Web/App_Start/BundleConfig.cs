using System.Web.Optimization;

namespace IWll.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css")
                .Include("~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/AngularApp")
                .IncludeDirectory("~/Scripts/Controllers", "*.js")
                .Include("~/Scripts/app.js"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
