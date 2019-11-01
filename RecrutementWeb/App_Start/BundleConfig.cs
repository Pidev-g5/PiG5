using System.Web;
using System.Web.Optimization;

namespace RecrutementWeb
{
    public class BundleConfig
    {
        // Pour plus d'informations sur le regroupement, visitez https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilisez la version de développement de Modernizr pour le développement et l'apprentissage. Puis, une fois
            // prêt pour la production, utilisez l'outil de génération à l'adresse https://modernizr.com pour sélectionner uniquement les tests dont vous avez besoin.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            #region Template Design

            bundles.Add(new ScriptBundle("~/template/js").Include(
                        "~/Scripts/jquery-3.3.1.js",
                        "~/Scripts/jquery-migrate-3.0.0.min.js",
                        "~/Scripts/popper.min.js",
                        "~/Scripts/bootstrap.min.js",
                        "~/Scripts/jquery.mmenu.all.js",
                        "~/Scripts/ace-responsive-menu.js",
                        "~/Scripts/bootstrap-select.min.js",
                        "~/Scripts/snackbar.min.js",
                        "~/Scripts/simplebar.js",
                        "~/Scripts/parallax.js",
                        "~/Scripts/scrollto.js",
                        "~/Scripts/jquery-scrolltofixed-min.js",
                        "~/Scripts/jquery.counterup.js",
                        "~/Scripts/wow.min.js",
                        "~/Scripts/progressbar.js",
                        "~/Scripts/slider.js",
                        "~/Scripts/timepicker.js",
                        "~/Scripts/script.js",
                        "~/Scripts/googlemaps1.js"));

            bundles.Add(new StyleBundle("~/template/css").Include(
                      "~/Content/css/bootstrap.min.css",
                      "~/Content/css/bootstrap.min.css.map",
                      "~/Content/css/bootstrap.css.map",
                      "~/Content/css/bootstrap.css",
                      "~/Content/css/bootstrap-theme.css",
                      "~/Content/css/bootstrap-theme.css.map",
                      "~/Content/css/bootstrap-theme.min.css.map",
                      "~/Content/css/menu.css",
                      "~/Content/css/style.css",
                      "~/Content/css/site.css",
                      "~/Content/css/responsive.css",
                      "~/Content/css/flaticon.css",
                      "~/Content/css/map-css/maps.css",
                      "~/Content/css/map-css/searcher.css",
                      "~/Content/css/map-css/info-box.css",
                      "~/Content/css/map-css/jquery-finddo.css"));

           

            #endregion
        }
    }
}
