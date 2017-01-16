using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warn.Data
{
    public interface IUnityOfWork : IDisposable
    {
        void Commit();
    }
}
