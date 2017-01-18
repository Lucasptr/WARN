using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Warn.Data.Repository;
using Warn.Domain.Entities;
using Warn.Domain.Interfaces.Repository;
using Warn.Domain.Interfaces.Service;

namespace Warn.Api.Security
{
    public class SimpleAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        IUserService _userService;

        public SimpleAuthorizationServerProvider(IUserService userService)
        {
            _userService = userService;
        }

        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            try
            {
            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });

            var user = _userService.Authenticate(context.UserName, context.Password);
            if (user == null)
            {
                context.SetError("invalid_grant", "O login ou senha estão incorretos.");
                return;
            }

            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            identity.AddClaim(new Claim("sub", context.UserName));
            identity.AddClaim(new Claim(ClaimTypes.Role, user.Profile.Name));

            context.Validated(identity);
            }
            catch
            {
                context.SetError("invalid_request", "A requisição está incorreta.");
            }
        }
    }
}