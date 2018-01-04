using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace System.Web.Http.Results
{
    public class AcceptedResult : IHttpActionResult
    {
        private readonly HttpRequestMessage request;

        public AcceptedResult(HttpRequestMessage request)
        {
            this.request = request;
        }

        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            var response = request.CreateResponse(HttpStatusCode.Accepted);
            return Task.FromResult(response);
        }
    }

}