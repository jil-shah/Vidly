﻿using System.Web;
using System.Web.Optimization;

namespace Vidly
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new Bundle("~/bundles/lib").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/scripts/bootbox.js",
                        "~/Scripts/bootstrap.js",
                        "~/scripts/datatables/jquery.datatables.js",
                        "~/scripts/datatables/datatables.bootstrap4.js"
                        ));

            bundles.Add(new Bundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new Bundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new Bundle("~/Content/css").Include(
                      "~/Content/bootstrap-lumen.css",
                      "~/content/datatables/css/datatables.bootstrap4.css",
                      "~/Content/site.css"));
        }
    }
}
