using System;
using System.Diagnostics;
using System.Security.Principal;

namespace SecurityPipeline
{
    internal class Helper
    {
        public static void Write(string stage, IPrincipal principal)
        {
            Debug.WriteLine("---------- " + stage + " ------------");
            if (principal == null || principal.Identity == null || !principal.Identity.IsAuthenticated)
            {
                Debug.WriteLine("anonymous user");
            }
            else
            {
                Debug.WriteLine("User: " + principal.Identity.Name);
            }

            Debug.WriteLine("\n");
        }
    }
}