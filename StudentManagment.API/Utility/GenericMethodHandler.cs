using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentManagment.API.Utility
{
    public class GenericMethodHandler

    {
        public static string GetConnectionString()
        {
            return System.Configuration.ConfigurationManager.AppSettings["ConStr"];
        }
    }
}