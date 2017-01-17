using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Warn.Api.Models;
using Warn.Domain.Commands.UserCommands;
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
            var user = _userService.GetUser(login);

            return CreateResponse(HttpStatusCode.OK, user);
        }

        [HttpPost]
        [Route("user")]
        [Authorize(Roles = "Transmissor")]
        public Task<HttpResponseMessage> Post([FromBody]dynamic body)
        {
            var command = new RegisterUserCommand(
                login: (string)body.login,
                password: (string)body.password,
                name: (string)body.name,
                email: (string)body.email,
                phone: (int?)body.phone,
                profile: (int?)body.profile

            );

            var user = _userService.Register(command);

            return CreateResponse(HttpStatusCode.Created, user);
        }
    }
}