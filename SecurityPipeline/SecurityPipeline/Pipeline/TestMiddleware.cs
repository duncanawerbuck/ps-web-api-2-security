using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.Owin;

namespace SecurityPipeline.Pipeline
{
    public class TestMiddleware
    {
        private Func<IDictionary<string, object>, Task> _next;

        public TestMiddleware(Func<IDictionary<string, object>, Task> next )
        {
            _next = next;
        }

        public async Task Invoke(IDictionary<string, object> env)
        {
            var context = new OwinContext(env);

            context.Request.User = new GenericPrincipal(new GenericIdentity("dude"), new string[] {});

            Helper.Write("Middleware", context.Request.User);

            await _next(env);
        }
    }
}