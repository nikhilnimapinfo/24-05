using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
   // [Authorize]
    public class ValuesController : ApiController
    {
        static List<string> Strings = new List<string>()
        {
         "value 0","value 1","value 2"
        };

        //GET api/values

        public IEnumerable<string> Get()
        {
            return Strings;

        }

       // GET api/values/5
        public string Get(int id)
        {
            
                return Strings[id];
           
        }

        // POST api/values
       // [HttpPost]
        //[Route()]
        public void Post([FromBody]string value)
        {
            Strings.Add(value);

        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            Strings[id] = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            Strings.RemoveAt(id);
        }
    }
}
