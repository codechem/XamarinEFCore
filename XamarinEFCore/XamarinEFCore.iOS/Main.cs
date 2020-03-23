using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using UIKit;
[assembly: Preserve(typeof(System.Linq.Queryable), AllMembers = true)]
[assembly: Preserve(typeof(System.DateTime), AllMembers = true)]
[assembly: Preserve(typeof(System.Linq.Enumerable), AllMembers = true)]
[assembly: Preserve(typeof(System.Linq.IQueryable), AllMembers = true)]
namespace XamarinEFCore.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");
        }
    }
}