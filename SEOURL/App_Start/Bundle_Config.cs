using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace SEOURL.App_Start
{
    public class Bundle_Config
    {
        /*Nuget Web-Optimization eklentisinin eklenmesi gerekli*/
        /*Çalışması için Global.asax'ta da tanımlaması yapılmalıdır*/
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/css/all").Include("~/Content/bootstrap.min.css", "~/Content/Site.css"));

            /*CDN kullanımını aktif hale getirmek için*/
            /*CDN kullanırsak diğerleri kullanılamaz hale gelir*/

            bundles.UseCdn = true;
            string jQueryCDN="https://dsaajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js";

            bundles.Add(new ScriptBundle("~/js/layout",jQueryCDN).Include("~/Scripts/bootstrap.min.js", "~/Scripts/modernizr-{version}.js", "~/Scripts/jquery-[version}.min.js"));

            /*Optimizasyonu açmak için kullanılır yukarıdaki bundle yapılarını sıkıştırıp sayfa yüklenme hızını arttırır*/
            BundleTable.EnableOptimizations = true;
        }
    }
}