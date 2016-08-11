using System.Web.Optimization;

namespace Sigma
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/layout/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/layout/bootstrap.min.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/global").Include(
                      "~/Content/CSS/plugins/font-awesome.css",
                      "~/Content/CSS/plugins/simple-line-icons.css",
                      "~/Content/CSS/plugins/bootstrap.min.css",
                      "~/Content/CSS/plugins/uniform.default.css"));

            bundles.Add(new StyleBundle("~/Content/BootstrapSwitch").Include(
                      "~/Content/CSS/plugins/bootstrap-switch.min.css"));

            bundles.Add(new StyleBundle("~/Content/theme").Include(
                      "~/Content/CSS/components.css",
                      "~/Content/CSS/plugins.css",
                      "~/Content/CSS/admin/layout.css",
                      "~/Content/CSS/admin/default.css",
                      "~/Content/CSS/admin/custom.css"));

            bundles.Add(new StyleBundle("~/Scripts/assets").Include(
                      "~/Scripts/layout/bootstrap-hover-dropdown.min.js",
                      "~/Scripts/layout/jquery.slimscroll.min.js",
                      "~/Scripts/layout/jquery.blockui.min.js",
                      "~/Scripts/layout/jquery.cokie.min.js",
                      "~/Scripts/layout/jquery.uniform.min.js"));

            bundles.Add(new StyleBundle("~/Scripts/bootstrapswitch").Include(
                      "~/Scripts/layout/bootstrap-switch.min.js"));

            bundles.Add(new StyleBundle("~/Scripts/flot").Include(
                      "~/Scripts/flot/jquery.flot.js",
                      "~/Scripts/flot/jquery.flot.resize.js",
                      "~/Scripts/flot/jquery.flot.categories.js"));

            bundles.Add(new StyleBundle("~/Scripts/metronic").Include(
                      "~/Scripts/metronic.js"));

            bundles.Add(new StyleBundle("~/Scripts/layout").Include(
                      "~/Scripts/layout/layout.js"));

            bundles.Add(new StyleBundle("~/Scripts/sidebar").Include(
                      "~/Scripts/layout/quick-sidebar.js"));

            bundles.Add(new StyleBundle("~/Scripts/demo").Include(
                      "~/Scripts/demo/demo.js"));

            bundles.Add(new StyleBundle("~/Content/datepicker").Include(
                      "~/Content/CSS/datepicker/datepicker3.css"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                      "~/Scripts/angular.js",
                      "~/Scripts/angular-route.js"));
        }
    }
}
