using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warn.ApplicationService;
using Warn.Data.Context;
using Warn.Data.Repository;
using Warn.Domain.Interfaces.Repository;
using Warn.Domain.Interfaces.Service;

namespace Warn.CrossCutting
{
    public class DependencyRegister
    {
        public static void Register(UnityContainer container)
        {
            container.RegisterType<WarnContext, WarnContext>(new HierarchicalLifetimeManager());
            //Repositories
            container.RegisterType<IUserRepository, UserRepository>(new HierarchicalLifetimeManager());

            //Services
            container.RegisterType<IUserService, UserService>(new HierarchicalLifetimeManager());
        }
    }
}
