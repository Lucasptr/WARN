using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using Warn.Api.Models;
using Warn.SharedKernel;
using Warn.SharedKernel.Events;

namespace Warn.Api.Controllers
{
    public class BaseController : ApiController
    {
        public IHandler<DomainNotification> Notifications;
        public HttpResponseMessage ResponseMessage;

        public BaseController()
        {
            Notifications = DomainEvent.Container.GetService<IHandler<DomainNotification>>();
            ResponseMessage = new HttpResponseMessage();
        }
        public Task<HttpResponseMessage> CreateResponse(HttpStatusCode code, object result)
        {
            var jsonResult = new JsonResult<object>();
            jsonResult.Src = result;

            if (Notifications.HasNotifications())
            {
                jsonResult.Errors = Notifications.Notify();
                ResponseMessage = Request.CreateResponse(HttpStatusCode.BadRequest, jsonResult);
                // Request.CreateResponse(HttpStatusCode.BadRequest, new { errors = Notifications.Notify() });
            }
            else
                ResponseMessage = Request.CreateResponse(code, result);

            Notifications.Dispose();
            return Task.FromResult<HttpResponseMessage>(ResponseMessage);
        }
    }
}