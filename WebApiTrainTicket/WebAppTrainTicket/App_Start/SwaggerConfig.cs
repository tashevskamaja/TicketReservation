using System.Web.Http;
using WebActivatorEx;
using Swashbuckle.Application;
using System;
using OnlineTrainTicketReservation;
using WebAppTrainTicket.App_Start;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace WebAppTrainTicket.App_Start
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", "WebAppTrainTicket");
                })
                .EnableSwaggerUi();
        }
    }
}