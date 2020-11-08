using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace LoginCompleto.Controllers
{
    [Authorize]
    public class DefaultController : ApiController
    {
        // GET: api/Default
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Default/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Default
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Default/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Default/5
        public void Delete(int id)
        {
        }
    }
}
