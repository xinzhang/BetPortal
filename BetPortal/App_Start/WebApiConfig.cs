using BetPortal.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace BetPortal
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
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

        public static void LoadInitData()
        {
            IDataLoader dataLoader = new DataLoader();
            BetRespository.Customers = dataLoader.LoadCustomerFromRest();
            BetRespository.Bets = dataLoader.LoadBetsFromRest();
            BetRespository.Races = dataLoader.LoadRacesFromRest();

        }
    }
}
