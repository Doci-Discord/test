using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Owin;
using System.Web.Http;

namespace SelfHostApp
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            // پیکربندی Web API
            HttpConfiguration config = new HttpConfiguration();

            // فعال‌سازی Attribute Routing
            config.MapHttpAttributeRoutes();

            // مسیر پیش‌فرض در صورت استفاده از Route سنتی
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Formatters.XmlFormatter.SupportedMediaTypes.Clear();

            // استفاده از Web API
            appBuilder.UseWebApi(config);
        }
    }
}
