﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace AirplaneAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{origin}/{destin}",
                defaults: new
                {
                    origin = RouteParameter.Optional,
                    destin = RouteParameter.Optional
                }
            );
        }
    }
}
