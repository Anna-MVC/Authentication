using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RESTFull.Controllers
{
    [RoutePrefix("myapi/Values")]
    public class ValuesController : ApiController
    {
        // GET api/values
        [Route("hello/{count:int}")]
        [HttpGet]
        //GET api/values/hello
        public IHttpActionResult Get1(int count)
        {
            //NotFound();
            //Created(location, content);
            //return BadRequest();
            //BadRequest("custom message");
            //BadRequest(ModelState);
            //throw new Exception();
            return Ok(new string[] { "value1", "value2" });
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
