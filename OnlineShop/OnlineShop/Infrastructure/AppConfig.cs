using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace OnlineShop.Infrastructure
{
    public class AppConfig
    {

        private static string _imagesFolder = ConfigurationManager.AppSettings["ImagesFolder"];
        public static string ImagesFolder
        {
            get
            {
                return _imagesFolder;
            }
        }


    }
}