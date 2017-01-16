using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warn.Domain.Entities;
using Warn.SharedKernel.Validation;

namespace Warn.Domain.Scopes
{
    public static class UserScopes
    {
        public static bool RegisterUserScopeIsValid(this User user)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertNotEmpty(user.Login, "O login é obrigatório"),
                AssertionConcern.AssertNotEmpty(user.Password, "A senha é obrigatória"),
                AssertionConcern.AssertNotEmpty(user.Name, "O nome é obrigatório"),
                AssertionConcern.AssertNotEmpty(user.Email, "O email é obrigatório"),
                AssertionConcern.AssertNotNull(user.Phone, "O telefone é obrigatório")
            );
        }
    }
}
