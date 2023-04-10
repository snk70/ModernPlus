using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Connectionst
/// </summary>
public class Connectionst
{
    //public static string ConnectionString_Main = "server=localhost;User Id=root;database=modernpl_apps";
    public static string ConnectionString_Main = System.Configuration.ConfigurationManager.ConnectionStrings["ModernPlusConnectionString"].ConnectionString;

}