using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace OnlineShop.Infrastructure
{
    public class AppConfig
    {

        private static string _imagesFolderRelative = ConfigurationManager.AppSettings["ImagesFolder"];
        public static string ImagesFolderRelative
        {
            get
            {
                return _imagesFolderRelative;
            }
        }


    }
}