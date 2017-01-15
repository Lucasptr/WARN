using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Warn.Api.Models;
using Warn.Domain.Entities;
using Warn.Domain.Interfaces.Service;

namespace Warn.Api.Controllers
{
    [RoutePrefix("api/v1")]
    public class UserController : BaseController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("user")]
        [Authorize(Roles = "Transmissor")]
        public Task<HttpResponseMessage> GetUser(string login)
        {
            var result = new JsonResult<User>();
            result.Src = _userService.GetUser(login);

            return CreateResponse(HttpStatusCode.OK, result);
        }
    }
}