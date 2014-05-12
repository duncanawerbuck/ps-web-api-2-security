using System;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Filters;

namespace SecurityPipeline.Pipeline
{
    public class TestAuthenticationFilterAttribute : Attribute, IAuthenticationFilter
    {
        public async Task AuthenticateAsync(HttpAuthenticationContext context, CancellationToken cancellationToken)
        {
            Helper.Write("AuthenticationFilter", context.ActionContext.RequestContext.Principal);
        }

        public async Task ChallengeAsync(HttpAuthenticationChallengeContext context, CancellationToken cancellationToken)
        {
            // Do nothing.
        }
        
        public bool AllowMultiple { get { return false; } }
    }
}