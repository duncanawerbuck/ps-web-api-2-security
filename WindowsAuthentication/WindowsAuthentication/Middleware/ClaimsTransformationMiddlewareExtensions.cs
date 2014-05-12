﻿/*
 * Copyright (c) Dominick Baier, Brock Allen.  All rights reserved.
 * see license.txt
 */

using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Owin;

namespace WindowsAuthentication.Middleware
{
    public static class ClaimsTransformationMiddlewareExtensions
    {
        public static IAppBuilder UseClaimsTransformation(this IAppBuilder app, Func<ClaimsPrincipal, Task<ClaimsPrincipal>> transformation)
        {
            return app.UseClaimsTransformation(new ClaimsTransformationOptions
                {
                    ClaimsTransformation = transformation
                });
        }

        public static IAppBuilder UseClaimsTransformation(this IAppBuilder app, ClaimsTransformationOptions options)
        {
            if (options == null)
            {
                throw new ArgumentNullException("options");
            }

            app.Use(typeof(ClaimsTransformationMiddleware), options);
            return app;
        }
    }
}