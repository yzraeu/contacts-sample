using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;

namespace ContactsSample.API.Infrastructure.Extensions
{
    public static class ControllerExtensions
    {
        public static IHttpActionResult Accepted(this ApiController apiController)
        {
            return new AcceptedResult(apiController.Request);
        }
    }
}