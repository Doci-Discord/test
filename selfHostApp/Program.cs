using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;

namespace SelfHostApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // آدرس و پورت اجرای سرور
            string baseAddress = "http://localhost:9000/";

            // اجرای SelfHost با Startup
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                Console.WriteLine($"Server running on {baseAddress}");
                Console.WriteLine("Press Enter to exit...");
                Console.ReadLine();
            }
        }
    }
}
