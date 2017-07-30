using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Infrastructure
{
    public static class UrlHelpers
    {
        public static string CategoriesLogoPath(this UrlHelper helper, string nameCategoriesLogo)
        {
            var ImagesFolder = AppConfig.ImagesFolder;
            var path = Path.Combine(ImagesFolder, nameCategoriesLogo);
            var absolutePath = helper.Content(path);

            return absolutePath;
        }
    }
}