using System.Web.Http;
using WebActivatorEx;
using Swashbuckle.Application;
using System;
using OnlineTrainTicketReservation;


[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace WebAppTrainTicket.App_Start
{
    public class SwaggerrConfigg
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerrConfigg).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", "WebAppTrainTicket");
                })
                .EnableSwaggerUi();
        }
    }
}