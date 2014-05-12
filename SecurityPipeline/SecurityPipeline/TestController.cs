using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using SecurityPipeline.Pipeline;

namespace SecurityPipeline
{
    [TestAuthenticationFilter]
    [TestAuthorizationFilter]
    public class TestController : ApiController
    {
        public IHttpActionResult Get()
        {
            Helper.Write("Controller", User);

            return Ok();
        }
    }
}