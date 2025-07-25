using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace selfHostApp.Controllers
{
    [RoutePrefix("api/values")]
    public class ValuesController : ApiController
    {
        static List<string> data = new List<string> { "value1", "value2", "value3" };

        // GET api/values
        [HttpGet, Route("")]
        public IHttpActionResult Get()
        {
            // اینجا یک JSON به صورت key:value برمی‌گردانیم
            var result = new Dictionary<string, object>
            {
                { "status", "success" },
                { "count", data.Count },
                { "values", data }
            };

            return Ok(result);
        }

        // GET api/values/1
        [HttpGet, Route("{id:int}")]
        public IHttpActionResult Get(int id)
        {
            if (id < 0 || id >= data.Count)
                return NotFound();

            var result = new Dictionary<string, object>
            {
                { "status", "success" },
                { "value", data[id] }
            };

            return Ok(result);
        }
    }
}
