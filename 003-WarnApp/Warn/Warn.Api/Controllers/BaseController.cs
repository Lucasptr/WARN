using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace Warn.Api.Controllers
{
    public class BaseController : ApiController
    {
        public HttpResponseMessage _responseMessage;

        public BaseController()
        {
            _responseMessage = new HttpResponseMessage();
        }
        public Task<HttpResponseMessage> CreateResponse(HttpStatusCode code, object result)
        {
            _responseMessage = Request.CreateResponse(code, result);

            return Task.FromResult<HttpResponseMessage>(_responseMessage);
        }
    }
}